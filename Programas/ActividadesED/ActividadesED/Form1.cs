﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadesED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        ListaOrdenadaSimple<GrupoMusical> nuevaListaGrupo = new ListaOrdenadaSimple<GrupoMusical>();
        GrupoMusical GrupoMusicalOBJ;
        public void AgregarGrupo()
        {
            foreach (GrupoMusical item in nuevaListaGrupo)
            {
                dataGridView1.Rows.Add(item.NombreGrupo, item.PrecioHora, item.CantidadIntegrantes, item.NombreDueño, item.Genero, item.Clasificacion, item.ConversionEstado, item.FechaFundacion,item.LogoGrupo);
                
            }
        }

            char ClasificacionChar;
        public char Clasificacion()
        {
            if (rdbClasificacionA.Checked) { ClasificacionChar = 'A'; }else if (rdbClasificacionB.Checked) { ClasificacionChar = 'B'; }else { MessageBox.Show("Seleccione una clasificacion."); }
            return ClasificacionChar;
        }

        public void ClearAll()
        {
            txtCantidadIntegrantes.Clear();
            txtMonetizacionHora.Clear();
            txtNombreAgrupacion.Clear();
            txtNombreDueño.Clear();
        }

        public bool Estado()
        {
            if (chk.Checked)
            {
                GrupoMusicalOBJ.ConversionEstado = "SI";
                return true;
            }
            GrupoMusicalOBJ.ConversionEstado = "NO";
            return false;
        }

        public void BuscarObjeto()
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GrupoMusicalOBJ = new GrupoMusical();
            GrupoMusicalOBJ.NombreGrupo = txtNombreAgrupacion.Text;
            GrupoMusicalOBJ.PrecioHora = Convert.ToDouble(txtMonetizacionHora.Text);
            GrupoMusicalOBJ.CantidadIntegrantes = Convert.ToInt32(txtCantidadIntegrantes.Text);
            GrupoMusicalOBJ.NombreDueño = txtNombreDueño.Text;
            GrupoMusicalOBJ.Genero = cbo.Text;
            GrupoMusicalOBJ.Estado = Estado();
            GrupoMusicalOBJ.Clasificacion = Clasificacion();
            GrupoMusicalOBJ.FechaFundacion = dtpFundacion.Text;
            nuevaListaGrupo.AgregarNodo(GrupoMusicalOBJ);

            dataGridView1.Rows.Clear();
            AgregarGrupo();
            ClearAll();
        }

        private void btnExaminarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ObtenerImagen = new OpenFileDialog();
            ObtenerImagen.InitialDirectory = "C:\\";
            ObtenerImagen.Filter = "Archivos de Imagen (*jpg)(*jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (.gif)|*.gif";
            if (ObtenerImagen.ShowDialog() == DialogResult.OK)
            {
                GrupoMusicalOBJ.LogoGrupo = ObtenerImagen.FileName;
                pic.ImageLocation = ObtenerImagen.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            nuevaListaGrupo.EliminarNodo();
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Grupo Eliminado \n " + GrupoMusicalOBJ.NombreGrupo);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GrupoMusical grupoMusical = new GrupoMusical();
            grupoMusical.NombreGrupo = txtNombreAgrupacion.Text;
            grupoMusical.PrecioHora = Convert.ToDouble(txtMonetizacionHora.Text);
            grupoMusical.CantidadIntegrantes = Convert.ToInt32(txtCantidadIntegrantes.Text);
            grupoMusical.NombreDueño = txtNombreDueño.Text;
            grupoMusical.Genero = cbo.Text;
            grupoMusical.Estado = Estado();
            grupoMusical.Clasificacion = Clasificacion();
            grupoMusical.FechaFundacion = dtpFundacion.Text;
            nuevaListaGrupo.BuscarNodo(grupoMusical);
            MessageBox.Show("Grupo encontrado: \n" + grupoMusical.NombreGrupo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GrupoMusicalOBJ = new GrupoMusical();
            GrupoMusicalOBJ.NombreGrupo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            GrupoMusicalOBJ.PrecioHora = Convert.ToDouble(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            GrupoMusicalOBJ.CantidadIntegrantes = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            GrupoMusicalOBJ.NombreDueño = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            GrupoMusicalOBJ.Genero = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string EstadoAux = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            GrupoMusicalOBJ.Clasificacion = Convert.ToChar(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            if (EstadoAux == "NO")
            {
                GrupoMusicalOBJ.Estado = false;
                GrupoMusicalOBJ.ConversionEstado = "NO";
            }
            else
            {
                GrupoMusicalOBJ.Estado = true;
                GrupoMusicalOBJ.ConversionEstado = "SI";
            }
            GrupoMusicalOBJ.FechaFundacion = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtNombreAgrupacion.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMonetizacionHora.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCantidadIntegrantes.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNombreDueño.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
                chk.Checked = true;
            }
            else
            {
                chk.Checked = false;
            }
            dtpFundacion.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            nuevaListaGrupo.Vaciar();
            dataGridView1.Rows.Clear();


        }
    }
}
