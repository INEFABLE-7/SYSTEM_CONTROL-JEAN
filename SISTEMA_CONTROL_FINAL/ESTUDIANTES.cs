using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_CONTROL_FINAL
{
    public partial class ESTUDIANTES : Form
    {
        public ESTUDIANTES()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=JEAN;Initial Catalog=SYSTEMJEAN;Integrated Security=True");
        string sentencias, mensaje;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentencia = "UPDATE ESTUDIANTESJEAN SET ESTUDIANTE = '" + txtestudiante.Text + "', carrera = '" + txtmatricula.Text + "' WHERE matricula = '" + txtmatricula.Text + "'";
            string mensaje = "Los datos fueron actualizados correctamente";

        }

        private void ESTUDIANTES_Load(object sender, EventArgs e)
        {

        }

        // Método para mostrar datos en un DataGridView
        public void Mostrar()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USUARIOSJEAN", conexion);
            DataSet ds = new DataSet();

            try
            {
                conexion.Open();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                // Manejar excepciones de SQL Server aquí
            }
            finally
            {
                conexion.Close();
            }
        }

        // Método para ejecutar consultas SQL
        public void EjecutarSql(string sql, string msg)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=JEAN;Initial Catalog=SYSTEMJEAN;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
