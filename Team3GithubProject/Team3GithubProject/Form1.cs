using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3GithubProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            float F = float.Parse( txtFah.Text );
            float C = (F - 32) * 5.0f / 9.0f;
            txtCel.Text = C.ToString();
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            float C = float.Parse( txtCel.Text );
            float F = (C * 9f / 5f) + 32;
            txtFah.Text = F.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFah.Text = "0.0";
            txtCel.Text = "0.0";
        }

        private void AM4Chnge_Click(object sender, EventArgs e)
        {

        }
    }
}
