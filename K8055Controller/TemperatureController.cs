﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyCore;
using System.Runtime.InteropServices;
using System.Xml;


namespace K8055Controller
{
    class TemperatureController : ITemperatureController
    {
        int Data1, Data2;
        private SimpleLogger sl = new SimpleLogger();

        private bool boerdliConnected = false;
        private bool heaterOneOn = false;
        private bool heaterTwoOn = false;

        [DllImport("k8055d.dll")]
        public static extern int OpenDevice(int CardAddress);

        [DllImport("k8055d.dll")]
        public static extern void CloseDevice();

        [DllImport("k8055d.dll")]
        public static extern int ReadAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void ReadAllAnalog(ref int Data1, ref int Data2);

        [DllImport("k8055d.dll")]
        public static extern void OutputAnalogChannel(int Channel, int Data);

        [DllImport("k8055d.dll")]
        public static extern void OutputAllAnalog(int Data1, int Data2);

        [DllImport("k8055d.dll")]
        public static extern void ClearAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void SetAllAnalog();

        [DllImport("k8055d.dll")]
        public static extern void ClearAllAnalog();

        [DllImport("k8055d.dll")]
        public static extern void SetAnalogChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void WriteAllDigital(int Data);

        [DllImport("k8055d.dll")]
        public static extern void ClearDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void ClearAllDigital();

        [DllImport("k8055d.dll")]
        public static extern void SetDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern void SetAllDigital();

        [DllImport("k8055d.dll")]
        public static extern bool ReadDigitalChannel(int Channel);

        [DllImport("k8055d.dll")]
        public static extern int ReadAllDigital();

        [DllImport("k8055d.dll")]
        public static extern int ReadCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        public static extern void ResetCounter(int CounterNr);

        [DllImport("k8055d.dll")]
        public static extern void SetCounterDebounceTime(int CounterNr, int DebounceTime);

        [DllImport("k8055d.dll")]
        public static extern int Version();

        [DllImport("k8055d.dll")]
        public static extern int SearchDevices();

        [DllImport("k8055d.dll")]
        public static extern int SetCurrentDevice(int lngCardAddress);


       
        private bool connector()
        {
            if (boerdliConnected)
            {
                return true;
            }
            else
            {
                return IsAvaiable();
            }
        }

        public bool IsAvaiable()
        {
            boerdliConnected = false;
            try
            {
                int cardAddr = 0; //SK5 + SK6 aktiviert
                int h = OpenDevice(cardAddr);
                if (h == 0)
                {
                    sl.log("Boerdli connected");
                    boerdliConnected = true;
                    return true;
                }else{
                   sl.log("Boerdli not connected");
                }
              
            }
            catch (Exception e)
            {
                sl.log(e.ToString());
            }
            
            return false;
        }

        public double GetOutsideTemperature()
        {
            //WetterID von Zürich
            String woeid = "784794";
            XmlDocument doc = new XmlDocument();
            try
            {
                //Wetterdaten von Yahoo-Abfragen für Zürich
                doc.Load("http://weather.yahooapis.com/forecastrss?w="+woeid+"&u=c");
                XmlNodeList nodes = doc.GetElementsByTagName("yweather:condition");
                return double.Parse(nodes[0].Attributes["temp"].Value.ToString());
            }
            catch (Exception e)
            {
                sl.log(e.ToString());
            }
           
            return -999;
        }

        public double GetInsideTemperature()
        {
            if (connector())
            {
                //Beide Analoge Eingänge messen
                ReadAllAnalog(ref Data1,ref Data2);
                //Gemessene Voltzahl in Temperatur umwandeln
                double temp = ((101 * (Data2 / 1024)) - 23);
                return temp;
            }
            return -999;
        }

        public bool GetIsOneHeaterOn()
        {
            return heaterOneOn;
        }

        public bool GetAreBothHeatersOn()
        {
            if (heaterOneOn && heaterTwoOn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetOneHeaterOn(double intensity)
        {
            throw new NotImplementedException();
        }

        public void SetBothHeatersOn(double intensity)
        {
            throw new NotImplementedException();
        }
        
        public void SetNoHeaterOn(double intensity)
        {
            throw new NotImplementedException();
        }
    }
}
