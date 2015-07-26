using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using deltaKinematics;

namespace DeltaCalibrationTool
{
    public partial class frmMain : Form
    {
        private void InitValues()
        {
            cboDefaults.Items.Add("Rostock MAX v2");
            cboDefaults.Text = "Choose Printer";
            txtAccuracy.Text = "";
            txtDiagRod.Text = "";
            txtHorizRadius.Text = "";
            txtMeasurementInversion.Text = "";
            txtOffsetX.Text = "";
            txtOffsetY.Text = "";
            txtOffsetZ.Text = "";
            txtRotA.Text = "";
            txtRotB.Text = "";
            txtRotC.Text = "";
            txtTowerX.Text = "";
            txtTowerXOpp.Text = "";
            txtTowerY.Text = "";
            txtTowerYOpp.Text = "";
            txtTowerZ.Text = "";
            txtTowerZOpp.Text = "";
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitValues();

        }

        private void btnCalibrate_Click(object sender, EventArgs e)
        {
            classCalibrate cal = new classCalibrate();


        }
    }
}
