using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramación
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        private void  button1_Click(object sender, EventArgs e)
        {
            Producto NuevoProducto;
            NuevoProducto = new Producto( int.Parse(txtCod.Text), txtDescripcion.Text);
            lbl_Cod.Text = NuevoProducto.pcodigo.ToString();
            lbl_Desc.Text = NuevoProducto.pdescripcion.ToString();
            lbl_StockActual.Text = "Hay " + NuevoProducto.pstock.ToString() + " unidades";
            MessageBox.Show("Producto instanciado");
        }
    }
}
