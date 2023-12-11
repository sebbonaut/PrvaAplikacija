using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvaAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int brKlikova = 0;
        private void gumbKlikni_Click(object sender, EventArgs e)
        {
            ++brKlikova;
            labelaPoruka.Text = "Broj klikova na gumb: "
                + brKlikova;
            if (brKlikova == 10)
                gumbKlikni.Click -= gumbKlikni_Click;
        }
    }
}
