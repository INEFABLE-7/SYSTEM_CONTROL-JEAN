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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ESTUDIANTES formEstudiantes = new ESTUDIANTES();
            formEstudiantes.Show();

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
