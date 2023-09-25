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
            string sentencia = "INSERT INTO ESTUDIANTEJEAN (matricula, ESTUDIANTE, carrera) VALUES ('" + txtmatricula.Text + "', '" + txtestudiante.Text + "', '" + txtcarrera.Text + "')";
            string mensaje = "Los datos fueron insertados correctamente";
            EjecutarSql(sentencia, mensaje);
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
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sentencia = "UPDATE ESTUDIANTEJEAN SET estudiante = '" + txtestudiante.Text + "', carrera = '" + txtcarrera.Text + "' WHERE matricula = '" + txtmatricula.Text + "'";
            string mensaje = "Datos actualizados correctamente";
            EjecutarSql(sentencia, mensaje);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarEstudianteJEAN();
        }

        // Método para eliminar datos de la tabla ESTUDIANTEJEAN
        public void EliminarEstudianteJEAN()
        {
            string matricula = txtmatricula.Text;

            if (string.IsNullOrEmpty(matricula))
            {
                MessageBox.Show("Por favor, ingrese la matrícula para eliminar.");
                return;
            }

            string sentencia = "DELETE FROM ESTUDIANTEJEAN WHERE matricula = '" + matricula + "'";
            string mensaje = "Los datos fueron eliminados correctamente";

            EjecutarSql(sentencia, mensaje);
            // Limpiar los campos después de eliminar
            txtmatricula.Clear();
            txtestudiante.Clear();
            txtcarrera.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarDatosEstudianteJEAN();
        }

        // Método para mostrar datos de la tabla ESTUDIANTEJEAN en el DataGridView
        public void MostrarDatosEstudianteJEAN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ESTUDIANTEJEAN", conexion);
            DataSet ds = new DataSet();

            try
            {
                conexion.Open();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






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
