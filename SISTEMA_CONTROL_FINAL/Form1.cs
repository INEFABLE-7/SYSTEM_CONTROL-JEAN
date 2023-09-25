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
        Dim N As INTEGER = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            N = N + 1;

        }
    }
}
