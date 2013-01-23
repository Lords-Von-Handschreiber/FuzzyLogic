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
        
        private TemperatureController tc;

        

        public FrmDemo()
        {
            InitializeComponent();
            tc = new TemperatureController();
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
