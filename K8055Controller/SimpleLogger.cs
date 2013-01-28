using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K8055Controller
{
    class SimpleLogger
    {
        /// <summary>
        /// Logs the specified logtxt.
        /// </summary>
        /// <param name="logtxt">The logtxt.</param>
        public void log(string logtxt)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\temperaturController.txt", true))
            {

                file.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + logtxt);
            }
        }
    }
}
