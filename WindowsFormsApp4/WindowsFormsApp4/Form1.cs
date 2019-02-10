using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private string before_TotalPrice;
        private string before_Ninzu;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_click(object sender, EventArgs e)
        {

            int sumPrice = int.Parse(txtTotalPrice.Text);
            int Ninzu = int.Parse(txtNinzu.Text);

            txtWari.Text = (sumPrice / Ninzu).ToString();
           
        }


        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            if (int.TryParse(txtTotalPrice.Text, out i) == false && (txtTotalPrice.Text != ""))
            {

                txtTotalPrice.Text = before_TotalPrice;
            }

            before_TotalPrice = txtTotalPrice.Text;

            btnaction();

        }

        private void btnaction()
        {
            if (txtTotalPrice.Text != "" && txtNinzu.Text != "")
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtNinzu_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            if (int.TryParse(txtNinzu.Text, out i) == false && (txtNinzu.Text != ""))
            {

                txtNinzu.Text = before_Ninzu;
            }

            before_Ninzu = txtNinzu.Text;

            btnaction();
        }
    }
}
