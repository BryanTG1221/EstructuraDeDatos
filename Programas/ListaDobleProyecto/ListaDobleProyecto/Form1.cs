using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbClasificacionA.Select();
            dataGridView1.Columns.Add("Nombre", "Nombre Grupo");
            dataGridView1.Columns.Add("Nombre", "Salario por Hora");
            dataGridView1.Columns.Add("Sueldo", "Integrantes");
            dataGridView1.Columns.Add("Nombre Dueno", "Nombre dueño");
            dataGridView1.Columns.Add("Genero", "Genero");
            dataGridView1.Columns.Add("Clasificacion", "Clasificacion");
            dataGridView1.Columns.Add("Activo", "Activo");
            dataGridView1.Columns.Add("Fundacion", "Fundacion");
            dataGridView1.Columns.Add("Ruta de Logo", "Ruta de Logo");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
        }
        ClaseListaDoble<objeto> ListaDoble = new ClaseListaDoble<objeto>();
        objeto GrupoMusical;
        public void AgregarGrupo()
        {
            foreach (objeto item in ListaDoble.HaciaAdelante)
            {
                dataGridView1.Rows.Add(item.NombreGrupo, item.PrecioHora, item.CantidadIntegrantes, item.NombreDueño, item.Genero, item.Clasificacion, item.ConversionEstado, item.FechaFundacion, item.LogoGrupo);

            }
        }
        public bool Estado()
        {
            if (chkEstado.Checked)
            {
                GrupoMusical.ConversionEstado = "SI";
                return true;
            }
            GrupoMusical.ConversionEstado = "NO";
            return false;
        }

        char ClasificacionChar;
        public char Clasificacion()
        {
            if (rdbClasificacionA.Checked) { ClasificacionChar = 'A'; } else if (rdbClasificacionB.Checked) { ClasificacionChar = 'B'; } else { MessageBox.Show("Seleccione una clasificacion."); }
            return ClasificacionChar;
        }

        public void AgregarImagen()
        {
            OpenFileDialog ObtenerImagen = new OpenFileDialog();
            ObtenerImagen.InitialDirectory = "C:\\";
            ObtenerImagen.Filter = "Archivos de Imagen (*jpg)(*jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (.gif)|*.gif";
            if (ObtenerImagen.ShowDialog() == DialogResult.OK)
            {
                GrupoMusical.LogoGrupo = ObtenerImagen.FileName;
                picbImagen.ImageLocation = ObtenerImagen.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GrupoMusical = new objeto();
            if (txtNombreAgrupacion.Text == "")
            {
                MessageBox.Show("No ingreso el nombre de su Grupo Musical");
                ClearAll();
            }
            else { GrupoMusical.NombreGrupo = txtNombreAgrupacion.Text; }
            if (txtMonetizacion.Text == "")
            {
                MessageBox.Show("No ingreso el pago por hora");
                ClearAll();
            }else { GrupoMusical.PrecioHora = Convert.ToDouble(txtMonetizacion.Text); }
            if (txtNumeroDeIntegrantes.Text == "")
            {
                MessageBox.Show("No ingreso cuantas personas conforman su Agrupacion");
                ClearAll();
            }else { GrupoMusical.CantidadIntegrantes = Convert.ToInt32(txtNumeroDeIntegrantes.Text); }
            if (txtNombreDueño.Text == "")
            {
                MessageBox.Show("No ingreso el nombre del dueño de la Agrupacion");
                ClearAll();
            }else { GrupoMusical.NombreDueño = txtNombreDueño.Text; }
            if (cbxGenero.Text == "")
            {
                MessageBox.Show("No ingreso el genero del Grupo");
                ClearAll();
            }else { GrupoMusical.Genero = cbxGenero.Text; }
            GrupoMusical.Estado = Estado();
            GrupoMusical.Clasificacion = Clasificacion();
            GrupoMusical.FechaFundacion = dateTimePicker1.Text;
            if (txtNombreAgrupacion.Text != "" && txtMonetizacion.Text != "" && txtNombreDueño.Text != "" && txtNumeroDeIntegrantes.Text != "" && cbxGenero.Text != "")
            {
                
                ListaDoble.AgregarNodo(GrupoMusical);
                dataGridView1.Rows.Clear();
                AgregarImagen();
                AgregarGrupo();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Ingrese los datos nuevamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListaDoble.EliminarNodo(GrupoMusical);
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            dataGridView1.Rows.Clear();
            AgregarGrupo();
            MessageBox.Show("Grupo Eliminado\n" + GrupoMusical.NombreGrupo);
            ClearAll();
        }

        public void EliminarNodo()
        {
            
            ListaDoble.EliminarNodo(GrupoMusical);
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index); 
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GrupoMusical = new objeto();
            GrupoMusical.NombreGrupo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            GrupoMusical.PrecioHora = Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            GrupoMusical.CantidadIntegrantes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            GrupoMusical.NombreDueño = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            GrupoMusical.Genero = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string EstadoAux = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            GrupoMusical.Clasificacion = Convert.ToChar(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            if (EstadoAux == "NO")
            {
                GrupoMusical.Estado = false;
                GrupoMusical.ConversionEstado = "NO";
            }
            else
            {
                GrupoMusical.Estado = true;
                GrupoMusical.ConversionEstado = "SI";
            }
            GrupoMusical.FechaFundacion = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtNombreAgrupacion.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMonetizacion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNumeroDeIntegrantes.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNombreDueño.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbxGenero.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "A")
            {
                rdbClasificacionA.Select();
            }
            else
            {
                rdbClasificacionB.Select();
            }
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "SI")
            {
                chkEstado.Checked = true;
            }
            else
            {
                chkEstado.Checked = false;
            }
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() != "")
            {
               picbImagen.Image = System.Drawing.Image.FromFile(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                GrupoMusical.LogoGrupo = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDoble.Vaciar();
            dataGridView1.Rows.Clear();
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GrupoMusical = new objeto();
            GrupoMusical.NombreGrupo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            GrupoMusical.PrecioHora = Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            GrupoMusical.CantidadIntegrantes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            GrupoMusical.NombreDueño = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            GrupoMusical.Genero = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            GrupoMusical.Clasificacion = Convert.ToChar(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            string EstadoAux = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (EstadoAux == "NO")
            {
                GrupoMusical.Estado = false;
                GrupoMusical.ConversionEstado = "NO";
            }
            else
            {
                GrupoMusical.Estado = true;
                GrupoMusical.ConversionEstado = "SI";
            }
            GrupoMusical.FechaFundacion = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            MessageBox.Show("Encontramos su Grupo Musical:\n" + ListaDoble.Buscar(GrupoMusical) );
        }

        public void ClearAll()
        {
            txtNombreDueño.Clear();
            txtNumeroDeIntegrantes.Clear();
            txtNombreAgrupacion.Clear();
            txtMonetizacion.Clear();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
