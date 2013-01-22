using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8055Controller
{
    class SimpleLogger
    {
        public SimpleLogger(){
            
        }

        public void log(String logtxt)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\temperaturController.txt", true))
            {
                file.WriteLine("logtxt");
            }
        }
    }
}
