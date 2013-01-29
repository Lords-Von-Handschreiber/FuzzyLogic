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

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmDemo" /> class.
        /// </summary>
        public FrmDemo()
        {
            InitializeComponent();

            Application.ApplicationExit += delegate { tc.SetNoHeaterOn(0.0); };
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void timer1_Tick(object sender, EventArgs e)
        {
            var result = fle.PerformFuzzyCalculation();
            toolStripStatusLabel1.Text = "Inside Temp: " + Math.Round(tc.GetInsideTemperature(), 1) + "°C";
            toolStripStatusLabel2.Text = "Outside Temp: " + tc.GetOutsideTemperature() + "°C";
            toolStripStatusLabel3.Text = "Fuzzy Result: " + Math.Round(result, 2) + "%";
        }

        /// <summary>
        /// Handles the Click event of the butisAvaiable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butisAvaiable_Click(object sender, EventArgs e)
        {
            tc.IsAvaiable();
        }

        /// <summary>
        /// Handles the Load event of the FrmDemo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmDemo_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the butGetOutsideTemperature control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butGetOutsideTemperature_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tc.GetOutsideTemperature().ToString());
        }

        /// <summary>
        /// Handles the Click event of the butGetInsideTemperature control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butGetInsideTemperature_Click(object sender, EventArgs e)
        {
             MessageBox.Show(tc.GetInsideTemperature().ToString());
        }

        /// <summary>
        /// Handles the Click event of the butGetIsOneHeaterOn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butGetIsOneHeaterOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tc.GetIsOneHeaterOn().ToString());
        }

        /// <summary>
        /// Handles the Click event of the butGetAreBothHeatersOn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butGetAreBothHeatersOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tc.GetAreBothHeatersOn().ToString());
        }

        /// <summary>
        /// Handles the Click event of the butSetOneHeaterOn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butSetOneHeaterOn_Click(object sender, EventArgs e)
        {
            tc.SetOneHeaterOn(1);
        }

        /// <summary>
        /// Handles the Click event of the butSetBothHeatersOn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void butSetBothHeatersOn_Click(object sender, EventArgs e)
        {
            tc.SetBothHeatersOn(1);
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            tc.SetNoHeaterOn(1);
        }

        private void btnHeating_Click(object sender, EventArgs e)
        {
            //FuzzyLogicEntry entry = new FuzzyLogicEntry(tc);
            //double result = entry.PerformFuzzyCalculation();
            //MessageBox.Show(result.ToString());
            MessageBox.Show(fle.PerformFuzzyCalculation().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnTimer.Text = "Toggle Timer " + (timer1.Enabled ? "Off" : "On");

        }
    }
}
