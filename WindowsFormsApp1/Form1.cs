using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Articulos> listArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            listArticulos = negocio.Listar();
            dgvArticulos.DataSource = listArticulos;
            cargarImagen(listArticulos[0].URLimagen);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.URLimagen);
            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://www.pngkey.com/png/detail/233-2332677_image-500580-placeholder-transparent.png");
            }
        }
    }
}
