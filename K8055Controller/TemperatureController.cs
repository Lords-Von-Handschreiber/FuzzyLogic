﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyCore;
using System.Runtime.InteropServices;


namespace K8055Controller
{
    class TemperatureController : ITemperatureController
    {
        private SimpleLogger sl = new SimpleLogger();

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


        public bool isAvaiable()
        {
            int cardAddr = 3; //SK5 + SK6 aktiviert
            int h = OpenDevice(cardAddr);
            if(h==3){
                sl.log("Boerdli connected");
                return true;
            }else{
                sl.log("Boerdli not connected");
                return false;
            }
            
        }

        public double GetOutsideTemperature()
        {
            throw new NotImplementedException();
        }

        public double GetInsideTemperature()
        {
            throw new NotImplementedException();
        }

        public bool GetIsOneHeaterOn()
        {
            throw new NotImplementedException();
        }

        public bool GetAreBothHeatersOn()
        {
            throw new NotImplementedException();
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
