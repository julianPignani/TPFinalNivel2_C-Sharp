using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace TPFinal
{
    public partial class frmAltaArticulo : Form
    {
        //Instanciamos la clase Articulo
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            pcboxAltaArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            // Establece la posición de inicio en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevo = new ArticuloNegocio();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;

                //capturamos lo que viene en el comboBox
                articulo.Marca = (Marca)cmboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmboxCategoria.SelectedItem;

                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                nuevo.agregar(articulo);
                MessageBox.Show("Artículo Agregado");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Metodo desde el load, para trabajar con los cmbox desde la DB
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            //Instanciamos las clases
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                //LLamamos al metodo listar de la clase MarcaNegocio y CategoriaNegocio para que nos traiga los elementos y los muestre en el desplegable.
                cmboxMarca.DataSource = marcaNegocio.listar();
                cmboxMarca.ValueMember = "Id";
                cmboxMarca.DisplayMember = "Descripcion";
                cmboxCategoria.DataSource = categoriaNegocio.listar();
                cmboxCategoria.ValueMember = "Id";
                cmboxCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Evento para traer la url y mostrarla en el pictureBox
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        //Metodo para cargar una imagen y en caso de no cargar la imagen que muestre la del catch
        private void cargarImagen(string imagen)
        {
            try
            {
                pcboxAltaArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pcboxAltaArticulo.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
