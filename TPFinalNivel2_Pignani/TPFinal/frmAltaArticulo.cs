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

        //Si tocamos el btnAceptar, lee este constructor
        public frmAltaArticulo()
        {
            InitializeComponent();
            pcboxAltaArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            // Establece la posición de inicio en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Si tocamos el btnModificar, lee este constructor
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            pcboxAltaArticulo.SizeMode = PictureBoxSizeMode.Zoom;
            // Establece la posición de inicio en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Articulo";
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
                if (articulo == null) //Si el usuario oprime agregar y el articulo es == null, significa que tenemos que crear un nuevo articulo.(sino, lo que hace es modificar)
                    articulo = new Articulo(); //instanciamos la clase para crear el articulo.

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                //capturamos lo que viene en el comboBox
                articulo.Marca = (Marca)cmboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmboxCategoria.SelectedItem;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                //Validamos los metodos agregar o modificar
                //Si vos tenes un (id != 0) significa que estamos modificando, porque ya existe.
                //Si el (id == 0) significa que no existe, entonces agregamos el articulo.
                if(articulo.Id != 0)
                {
                    nuevo.modificar(articulo);
                    DialogResult dialogResultModificar = MessageBox.Show("Artículo Modificado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    nuevo.agregar(articulo);
                    DialogResult dialogResultAgrefar = MessageBox.Show("Artículo Agregado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
                //LLamamos al metodo listar de la clase MarcaNegocio y CategoriaNegocio para que nos traiga los elementos y los muestre en el desplegable y nos sirva para luego
                //poder pre inscrirlos cuando vayamos a modificar.
                cmboxMarca.DataSource = marcaNegocio.listar();
                cmboxMarca.ValueMember = "Id"; //clave
                cmboxMarca.DisplayMember = "Descripcion"; //valor
                cmboxCategoria.DataSource = categoriaNegocio.listar();
                cmboxCategoria.ValueMember = "Id"; //clave
                cmboxCategoria.DisplayMember = "Descripcion"; //valor

                //Validamos si el usuario oprimio btnCargar o btnModificar
                if(articulo != null)//si es diferente de null, significa que vamos a modificar, entonces pre inscribimos los datos del articulo seleccionado.
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cmboxMarca.SelectedValue = articulo.Marca.Id; //Con esto pre inscribimos los valores dentro del combobox
                    cmboxCategoria.SelectedValue = articulo.Categoria.Id; //que seria, reutilizando los valores clave-valor
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl); //usamos el metodo ya creado anteriormente, para que nos lea la url apenas abre la ventana
                    txtPrecio.Text = articulo.Precio.ToString();
                }
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
