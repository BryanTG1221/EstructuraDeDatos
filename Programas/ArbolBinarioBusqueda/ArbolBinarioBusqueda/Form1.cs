using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Edad", "Edad ");
            dataGridView1.Columns.Add("Puesto", "Puesto");
            dataGridView1.Columns.Add("Home Office", "Home Office");
            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            rdbPreOrden.Checked = true;
        }

        ClaseRoja ObjetoInteligente;
        ClaseABB<ClaseRoja> ArbolBianario = new ClaseABB<ClaseRoja>();
        static ClaseABB<ClaseRoja> ClaseABB = new ClaseABB<ClaseRoja>();
        
        public void GenerarStringRandom()
        {
            Random rnd = new Random();
            char[] letras = "ABCDEFGHIJKLMNOPQRSTUVXYZ0123456789".ToCharArray();
            string PalabraRandom = "";
            for (int i = 0; i < 10; i++)
            {
                PalabraRandom += letras[rnd.Next(0, 35)].ToString();
            }
            txtInt.Text = PalabraRandom;
        }
        public int GenerarIntRandom()
        {
            Random rnd = new Random();
            int NumeroUnoDos = Convert.ToInt32(rnd.Next(1, 80));
            return NumeroUnoDos;
        }

        public void AgregarNodoAlData()
        {
            dataGridView1.Rows.Clear();
            foreach (ClaseRoja Persona in ArbolBianario.RecorrerPreOrden())
            {
                dataGridView1.Rows.Add(Persona.Edad, Persona.Puesto, Persona.HomeOffice, Persona.Hora);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ObjetoInteligente = new ClaseRoja();
            ObjetoInteligente.Edad = GenerarIntRandom();
            ObjetoInteligente.Puesto = comboBox1.Text;
            ObjetoInteligente.Hora = Convert.ToDateTime(dtmHora.Text);
            if (chkHomeOffice.Checked)
            {
                ObjetoInteligente.HomeOffice = true;
            }
            else
            {
                ObjetoInteligente.HomeOffice = false;
            }
            ArbolBianario.InsertarNodo(ObjetoInteligente);
            AgregarNodoAlData();
            txtInt.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtInt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtmHora.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (chkHomeOffice.Checked)
            {
                chkHomeOffice.Checked = true;
            }
            else
            {
                chkHomeOffice.Checked = false;
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (rdbPreOrden.Checked)
            {
               ArbolBianario.RecorrerPreOrden();
            }else 
            {
                if (rdbInOrden.Checked)
                {
                    ArbolBianario.RecorrerInOrden();
                }
                else if (rdbPostOrden.Checked)
                {
                    ArbolBianario.RecorrerPostOrden();
                }else
                {
                    MessageBox.Show("No selecciono su recorrido");
                }
            }
        }

        private void rdbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (ClaseRoja Persona in ArbolBianario.RecorrerPreOrden())
            {
                dataGridView1.Rows.Add(Persona.Edad, Persona.Puesto, Persona.HomeOffice, Persona.Hora);
            }
        }

        private void rdbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (ClaseRoja Persona in ArbolBianario.RecorrerInOrden())
            {
                dataGridView1.Rows.Add(Persona.Edad, Persona.Puesto, Persona.HomeOffice, Persona.Hora);
            }
        }

        private void rdbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (ClaseRoja Persona in ArbolBianario.RecorrerPostOrden())
            {
                dataGridView1.Rows.Add(Persona.Edad, Persona.Puesto, Persona.HomeOffice, Persona.Hora);
            }
        }

        private void btnBuscarNodo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Usted Busco: " + ArbolBianario.Buscar(ObjetoInteligente));
        }

        private void btnGenerarNodos_Click(object sender, EventArgs e)
        {
                Random rnd = new Random();
                ObjetoInteligente = new ClaseRoja();
                string[] Puesto = new string[] { "Jefe", "Operador", "Surpevisor","Pasante" };
                string TipoP = ""; TipoP += Puesto[rnd.Next(0, 3)].ToString();
                comboBox1.Text = TipoP;
                dtmHora.Text = Convert.ToString(RandomDay());
                GenerarStringRandom();
                if (GenerarIntRandom() == 1)
                {
                    chkHomeOffice.Checked = true;
                }
                else if(GenerarIntRandom() == 2)
                {
                    chkHomeOffice.Checked = false;
                }

                ObjetoInteligente.Edad = GenerarIntRandom();
                ObjetoInteligente.Puesto = comboBox1.Text;
                ObjetoInteligente.Hora = Convert.ToDateTime(dtmHora.Text);
                if (chkHomeOffice.Checked)
                {
                    ObjetoInteligente.HomeOffice = true;
                }
                else
                {
                    ObjetoInteligente.HomeOffice = false;
                }
            try
            {
                ArbolBianario.InsertarNodo(ObjetoInteligente);
                AgregarNodoAlData();
                txtInt.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("E R R O R \nNo se permiten DUPLICADOS");
            }
        }
        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            ObjetoInteligente.Edad = GenerarIntRandom();
            ObjetoInteligente.Puesto = comboBox1.Text;
            ObjetoInteligente.Hora = Convert.ToDateTime(dtmHora.Text);
            if (chkHomeOffice.Checked)
            {
                ObjetoInteligente.HomeOffice = true;
            }
            else
            {
                ObjetoInteligente.HomeOffice = false;
            }
            ArbolBianario.Eliminar(ObjetoInteligente);
            AgregarNodoAlData();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            if (ArbolBianario.Vacio == false)
            {
                DibujarFigura();
            }
            else
            {
                MessageBox.Show("Arbol BInario de Busqueda Vacio", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DibujarFigura()
        {
            string resultado = CrearArchivoDot();
            InvocaDibuja();
            MessageBox.Show("Codigo para generar el archivos FIGURA.jpg con la imagen:\n\n" + resultado + "\n\nEjecutar mediante: DOT -TJPG -0 \\Figura", "CREACION DEL ARCHIVO EN LENGUAJE DOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CrearNuevFormaConFigura();
        }

        private string CrearArchivoDot()
        {
            string Resultado = "";
            ArbolBianario.CrearArchivoDot(ref Resultado);

            System.IO.StreamWriter AliasArchivos = new System.IO.StreamWriter("\\Datos\\Figura.dot");
            AliasArchivos.WriteLine(Resultado);
            AliasArchivos.Close();
            return (Resultado);
        }

        private void InvocaDibuja()
        {
            System.Diagnostics.Process.Start("c:Datos\\DIBUJAR.bat");
        }

        private void CrearNuevFormaConFigura()
        {
            Form frmNuevaVentana = new Form();
            frmNuevaVentana.Width = 1000;
            frmNuevaVentana.Height = 600;
            frmNuevaVentana.AutoScroll = true;
            frmNuevaVentana.Text = "F I G U R A";
            frmNuevaVentana.StartPosition = FormStartPosition.CenterScreen;
            frmNuevaVentana.Show();

            PictureBox picABB = new PictureBox();
            picABB.Parent = frmNuevaVentana;
            picABB.Width = 990;
            picABB.Height = 565;
            picABB.SizeMode = PictureBoxSizeMode.Zoom;
            System.IO.FileStream AliasFigura;

            try
            {
                AliasFigura = new System.IO.FileStream("c:\\Datos\\Figura.png", System.IO.FileMode.Open, System.IO.FileAccess.Read);
            }
            catch (Exception x)
            {

                MessageBox.Show("No se pudo abrir el archivo \\FIGURA.jpg", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmNuevaVentana.Close();
                return;
            }

            try
            {
                picABB.Image = System.Drawing.Bitmap.FromStream(AliasFigura);
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo cargar la imagen del archivo \\FIGURA.jpg", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AliasFigura.Close();
                frmNuevaVentana.Close();
                return;
            }
            AliasFigura.Close();
            picABB.Refresh();
        } 
    }
}
