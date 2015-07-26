using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaCalibrationTool
{
    public partial class frmMain : Form
    {
        private void InitValues()
        {
            cboDefaults.Items.Add("Rostock MAX v2");
            cboDefaults.Text = "Choose Printer";
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitValues();

        }
    }
}
