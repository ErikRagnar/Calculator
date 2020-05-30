using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionCalculator
{
    public partial class DimensionCalculator : Form
    {

        private string CurrentAction;
        private decimal oldValue;
        private decimal nowValue;

        public DimensionCalculator()
        {
            InitializeComponent();
        }
        #region Button actions

        /// <summary>
        ///calculator buttons that is displayed will proform the functions that is indecated and proform the need requirements 
        /// </summary>
        /// <param btnOne="1"></param>
        public void btnOne_Click(object sender, EventArgs e)
        {
            AddingInNumbers("1");
        }

        public void btnTwo_Click(object sender, EventArgs e)
        {
            AddingInNumbers("2");
        }
        public void btnThree_Click(object sender, EventArgs e)
        {
            AddingInNumbers("3");
        }
        public void btnFour_Click(object sender, EventArgs e)
        {
            AddingInNumbers("4");
        }
        public void btnFive_Click(object sender, EventArgs e)
        {
            AddingInNumbers("5");
        }
        public void btnSix_Click(object sender, EventArgs e)
        {
            AddingInNumbers("6");
        }
        public void btnSeven_Click(object sender, EventArgs e)
        {
            AddingInNumbers("7");
        }
        public void btnEight_Click(object sender, EventArgs e)
        {
            AddingInNumbers("8");
        }
        public void btnNine_Click(object sender, EventArgs e)
        {
            AddingInNumbers("9");
        }
        public void btnZero_Click(object sender, EventArgs e)
        {
            AddingInNumbers("0");
        }

        public void AddingInNumbers(string Value)
        {
            txtInformation.Text = txtInformation.Text + Value;
        }
        #endregion

        #region Calculations

        ///numbers that is inputed

        ///these are the symbols used in the input
        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            nowValue = decimal.Parse(txtInformation.Text);
            txtInformation.Text = oldValue.ToString();
            try
            {
                switch (CurrentAction)
                {
                    case "/":
                        CurrentAction = "/";
                        break;
                    case "*":
                        CurrentAction = "*";
                        break;
                    case "-":
                        CurrentAction = "-";
                        break;
                    case "+":
                        CurrentAction = "+";
                        break;
                }
            }
            catch (OverflowException fa)
            {
                MessageBox.Show(fa.Message);
            }
            catch (DivideByZeroException fa)
            {
                MessageBox.Show(fa.Message);
            }
            catch (Exception fa)
            {
                MessageBox.Show(fa.Message);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            CurrentAction = "-";
            oldValue = decimal.Parse(txtInformation.Text);
            txtInformation.Clear();
            txtInformation.Focus();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CurrentAction = "+";
            oldValue = decimal.Parse(txtInformation.Text);
            txtInformation.Clear();
            txtInformation.Focus();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            CurrentAction = "*";
            oldValue = decimal.Parse(txtInformation.Text);
            txtInformation.Clear();
            txtInformation.Focus();
        }

        private void btnDevid_Click(object sender, EventArgs e)
        {
            CurrentAction = "/";
            oldValue = decimal.Parse(txtInformation.Text);
            txtInformation.Clear();
            txtInformation.Focus();
        }

        private void txtInformation_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            oldValue = 0;
            nowValue = 0;
            txtInformation.Text = null;
            CurrentAction = null;
        }
        ///symbols end

        #endregion
    }
}
