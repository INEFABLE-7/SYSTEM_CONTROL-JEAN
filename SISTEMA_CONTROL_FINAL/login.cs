using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SISTEMA_CONTROL_FINAL
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JEAN;Initial Catalog=SYSTEMJEAN;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataReader dr;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOSJEAN WHERE USUARIO='" + textBox1.Text + "' AND Clave='" + textBox2.Text + "'", conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Bienvenido a nuestro sistema escolar");
                    this.Hide();
                    menu fmenu = new menu();
                    fmenu.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o clave incorrectos");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

