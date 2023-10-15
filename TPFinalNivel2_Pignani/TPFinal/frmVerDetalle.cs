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

namespace TPFinal
{
    public partial class frmVerDetalle : Form
    {
        //Declaramos una variable para poder usarla en varios lados
        private Articulo articulo = null;
        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            pcboxDetalle.SizeMode = PictureBoxSizeMode.Zoom;
            // Establece la posición de inicio en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Vamos a pre insribir los datos del articulo seleccionado
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            

            try
            {
                //LLamamos al metodo listar de la clase MarcaNegocio y CategoriaNegocio para que nos traiga los elementos y los muestre en el desplegable y nos sirva para luego
                //poder pre inscrirlos cuando vayamos a modificar.
                cboxMarca.DataSource = marca.listar();
                cboxMarca.ValueMember = "Id"; //clave
                cboxMarca.DisplayMember = "Descripcion"; //valor
                cboxCategoria.DataSource = categoria.listar();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";

                //txtDetalleCodigo.Text = articulo.Codigo;
                txtDetalleNombre.Text = articulo.Nombre;
                //txtDetalleUrl.Text = articulo.ImagenUrl;
                cargarImagen(articulo.ImagenUrl);
                cboxMarca.SelectedValue = articulo.Marca.Id;
                cboxCategoria.SelectedValue = articulo.Categoria.Id;
                txtRichDescripcion.Text = articulo.Descripcion;
                txtDetallePrecio.Text = articulo.Precio.ToString();
                
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Metodo para cargar una imagen y en caso de no cargar la imagen que muestre la del catch
        private void cargarImagen(string imagen)
        {
            try
            {
                pcboxDetalle.Load(imagen);
            }
            catch (Exception)
            {
                pcboxDetalle.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
