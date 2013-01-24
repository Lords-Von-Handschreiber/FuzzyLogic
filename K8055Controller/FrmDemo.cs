using FuzzyLogicImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K8055Controller
{
    public partial class FrmDemo : Form
    {
        
        private TemperatureController tc = new TemperatureController();

        private FuzzyLogicEntry fle = new FuzzyLogicEntry(new TemperatureController());

        public FrmDemo()
        {
            InitializeComponent();
            // timer1.Tick += timer1_Tick; //tBX
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            fle.PerformFuzzyCalculation();
        }

        private void butisAvaiable_Click(object sender, EventArgs e)
        {
            tc.IsAvaiable();
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
