using System;
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



        /// <summary>
        /// Connectors this instance.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Is the temperature controller avaiable
        /// </summary>
        /// <returns>
        /// Returns true if all components are connected correctly
        /// </returns>
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

        /// <summary>
        /// Provide outside temperature in degree celsius
        /// </summary>
        /// <returns>
        /// outside temperature
        /// </returns>
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

        /// <summary>
        /// Provide inside temperature in degree celsius
        /// </summary>
        /// <returns>
        /// inside temperature
        /// </returns>
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

        /// <summary>
        /// Get if one heater is on
        /// </summary>
        /// <returns>
        /// true if exactly one heater is on
        /// </returns>
        public bool GetIsOneHeaterOn()
        {
            return heaterOneOn;
        }

        /// <summary>
        /// Get if both heaters are on
        /// </summary>
        /// <returns>
        /// true if exactly two heaters are on
        /// </returns>
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

        /// <summary>
        /// Set exactly one heater on
        /// </summary>
        /// <param name="intensity"></param>
        public void SetOneHeaterOn(double intensity)
        {
            if (connector())
            {
                OutputAnalogChannel(1, 255);
                OutputAnalogChannel(2, 0);
            }
        }

        /// <summary>
        /// Set both heater on
        /// </summary>
        /// <param name="intensity"></param>
        public void SetBothHeatersOn(double intensity)
        {
            if (connector())
            {
                OutputAnalogChannel(1, 255);
                OutputAnalogChannel(2, 255);
            }
        }

        /// <summary>
        /// Disable both heaters
        /// </summary>
        /// <param name="intensity"></param>
        public void SetNoHeaterOn(double intensity)
        {
            if (connector())
            {
                OutputAnalogChannel(1, 0);
                OutputAnalogChannel(2, 0);
            }
        }
    }
}
