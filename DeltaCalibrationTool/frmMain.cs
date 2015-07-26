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

        #region Field by field input validation

        private void txtAccuracy_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtAccuracy.Text, out workValue)) {
                errProvider.SetError(txtAccuracy, "The Accuracy value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.accuracy = workValue;
                e.Cancel = false;
            }
        }

        private void txtMeasurementInversion_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtMeasurementInversion.Text, out workValue)) {
                errProvider.SetError(txtMeasurementInversion, "The Measurement Inversion value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.measInver = workValue;
                e.Cancel = false;
            }
        }
       

        private void txtDiagRod_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtDiagRod.Text, out workValue)) {
                errProvider.SetError(txtDiagRod, "The Diagonal Rod value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.diagonalRod = workValue;
                e.Cancel = false;
            }
        }

        private void txtHorizRadius_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtHorizRadius.Text, out workValue)) {
                errProvider.SetError(txtHorizRadius, "The Horizontal Radius value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.HRad = workValue;
                e.Cancel = false;
            }
        }

        private void txtOffsetX_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtOffsetX.Text, out workValue)) {
                errProvider.SetError(txtOffsetX, "The X Tower Offset value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.offsetX = workValue;
                e.Cancel = false;
            }
        }

        private void txtOffsetY_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtOffsetY.Text, out workValue)) {
                errProvider.SetError(txtOffsetY, "The Y Tower Offset value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.offsetY = workValue;
                e.Cancel = false;
            }
        }

        private void txtOffsetZ_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtOffsetZ.Text, out workValue)) {
                errProvider.SetError(txtOffsetZ, "The Z Tower Offset value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.offsetZ = workValue;
                e.Cancel = false;
            }
        }

        private void txtRotA_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtRotA.Text, out workValue)) {
                errProvider.SetError(txtRotA, "The A Alpha Rotation value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.A = workValue;
                e.Cancel = false;
            }
        }

        private void txtRotB_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtRotB.Text, out workValue)) {
                errProvider.SetError(txtRotB, "The B Alpha Rotation value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.B = workValue;
                e.Cancel = false;
            }
        }

        private void txtRotC_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtRotC.Text, out workValue)) {
                errProvider.SetError(txtRotC, "The C Alpha Rotation value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.C = workValue;
                e.Cancel = false;
            }
        }

        private void txtTowerX_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtTowerX.Text, out workValue)) {
                errProvider.SetError(txtTowerX, "The X Tower Height value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.X = workValue;
                e.Cancel = false;
            }
        }

        private void txtTowerXOpp_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtTowerXOpp.Text, out workValue)) {
                errProvider.SetError(txtTowerXOpp, "The X Opposite Tower Height value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.XOpp = workValue;
                e.Cancel = false;
            }
        }

        private void txtTowerY_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtTowerY.Text, out workValue)) {
                errProvider.SetError(txtTowerY, "The Y Tower Height value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.Y = workValue;
                e.Cancel = false;
            }
        }

        private void txtTowerYOpp_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtTowerYOpp.Text, out workValue)) {
                errProvider.SetError(txtTowerYOpp, "The X Opposite Tower Height value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.YOpp = workValue;
                e.Cancel = false;
            }
        }

        private void txtTowerZ_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtTowerZ.Text, out workValue)) {
                errProvider.SetError(txtTowerZ, "The Z Tower Height value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.Z = workValue;
                e.Cancel = false;
            }
        }

        private void txtTowerZOpp_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtTowerZOpp.Text, out workValue)) {
                errProvider.SetError(txtTowerZOpp, "The Z Opposite Tower Height value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.ZOpp = workValue;
                e.Cancel = false;
            }
        }

        private void txtStepsPerMM_Validating(object sender, CancelEventArgs e) {
            double workValue = 0.0;
            if (!Double.TryParse(txtStepsPerMM.Text, out workValue)) {
                errProvider.SetError(txtStepsPerMM, "The Z Steps per MM value must be numeric!");
                e.Cancel = true; // keeps the user from leaving the field.
            } else {
                errProvider.Clear();
                cal.stepsPerMM = workValue; // should this be getSteps instead?
                e.Cancel = false;
            }
        }
        #endregion  // individual input field validating.
    }
}

