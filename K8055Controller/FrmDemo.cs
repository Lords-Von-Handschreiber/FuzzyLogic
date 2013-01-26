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

        private void butGetOutsideTemperature_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tc.GetOutsideTemperature().ToString());
        }

        private void butGetInsideTemperature_Click(object sender, EventArgs e)
        {
             MessageBox.Show(tc.GetInsideTemperature().ToString());
        }

        private void butGetIsOneHeaterOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tc.GetIsOneHeaterOn().ToString());
        }

        private void butGetAreBothHeatersOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tc.GetAreBothHeatersOn().ToString());
        }

        private void butSetOneHeaterOn_Click(object sender, EventArgs e)
        {
            tc.SetOneHeaterOn(1);
        }

        private void butSetBothHeatersOn_Click(object sender, EventArgs e)
        {
            tc.SetBothHeatersOn(1);
        }
    }
}
