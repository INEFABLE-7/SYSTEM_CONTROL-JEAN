using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTROL_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private int N = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            N = N + 1;
            progressBar1.Value = N;
            label1.Text = N.ToString();

            if (N == 100)
            {
                timer1.Stop();
                this.Hide();

                login loginForm = new login();
                loginForm.Show();



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
