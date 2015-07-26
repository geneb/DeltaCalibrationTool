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

namespace DeltaCalibrationTool {
    public partial class frmMain : Form {
        classCalibrate cal = new classCalibrate();

        private void InitValues() {
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

        public frmMain() {
            InitializeComponent();
            this.btnQuit.CausesValidation = false;  // allows user to exit if invalid data is on the form.
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitValues();

        }

        private void btnCalibrate_Click(object sender, EventArgs e) {

            ValidateInput();


        }

        private void ValidateInput() {
            throw new NotImplementedException();
        }

        private void btnQuit_Click(object sender, EventArgs e) {
            Application.Exit();

        }

        private void txtAccuracy_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtAccuracy.Text, out workValue)) {
                errProvider.SetError(this.txtAccuracy, "Accuracy value must be numeric!");
                e.Cancel = false;
            } else {
                errProvider.Clear();
                cal.accuracy = workValue;
            }
        }
    }
}
