﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio; //agregar
using dominio;//agregar

namespace TPFinal
{
    public partial class FormularioPrincipal : Form
    {
        //Creamos una lista para ir mostrando las imagenes.
        private List<Articulo> listaArticulo;

        //creamos un constructor de btnModificar
        /*public btnModificar()
        {
            InitializeComponent();
        }*/

        public FormularioPrincipal()
        {
            InitializeComponent();
            pcboxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            // Establece la posición de inicio en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }
        //Metodo para cargar la lista cuando abrimos la app
        //y actualizar cuando hacemos una modificacion
        private void cargar()
        {
            //Instanciamos la clase y llamamos a nuestro metodo listar.
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                // Formatear el precio en la lista de artículos
                foreach (var articulo in listaArticulo)
                {
                    articulo.Precio = Math.Round(articulo.Precio, 2);

                }
                dgvTablaArticulos.DataSource = listaArticulo;
                ocultarColumna();
                cargarImagen(listaArticulo[0].ImagenUrl);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para ocultar la columna en la vista.
        private void ocultarColumna()
        {
            dgvTablaArticulos.Columns["ImagenUrl"].Visible = false;
            dgvTablaArticulos.Columns["Id"].Visible = false;
        }

        //Metodo para cargar una imagen y en caso de no cargar la imagen que muestre la del catch
        private void cargarImagen(string imagen)
        {
            try
            {
                pcboxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pcboxImagen.Load("https://i0.wp.com/casagres.com.ar/wp-content/uploads/2022/09/placeholder.png?ssl=1");

            }
        }
        //Mostramos la imagen seleccionada
        private void dgvTablaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //Validamos para evitar romper la busqueda por filtro cuando borramos lo que escribimos.
            if(dgvTablaArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        //Eventoo Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog(); //para que no me deje salir de la ventana hasta terminar de cargar o oprimir salir.
            cargar();
           
        }

        //Evento modificar, selecionamos el Articulo y modificamos.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos que la tabla esté con un articulo seleccionado sino mostramos el msj
                if(dgvTablaArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;

                    frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                    modificar.ShowDialog();
                    cargar();

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona el artículo que deseas modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Evento eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                //Validamos que la tabla tenga un articulo seleccionado.
                if(dgvTablaArticulos.CurrentRow != null)
                {
                     DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas Eliminar el artículo?", "Advertencia!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                     //Validamos la accion por si el usuario nos responde no.
                     if(dialogResult == DialogResult.Yes)
                     {
                         seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;
                         articulo.eliminar(seleccionado.Id);
                            cargar(); //para que vuelva a actualizar la tabla despues de eliminar
                     }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona el artículo que deseas Eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        //Evento del txtFiltrar para un filtro rapido a medida que vayamos escribiendo
        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                string filtro = txtFiltrar.Text;
                if (filtro != "")
                {
                    listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listaArticulo;
                }

                dgvTablaArticulos.DataSource = null;
                dgvTablaArticulos.DataSource = listaFiltrada;
                ocultarColumna();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos que la tabla esté con un articulo seleccionado
                if(dgvTablaArticulos.CurrentRow != null)
                { 
                    Articulo seleccionado = (Articulo)dgvTablaArticulos.CurrentRow.DataBoundItem;

                    frmVerDetalle detalle = new frmVerDetalle(seleccionado);
                    detalle.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Por favor, Selecciona el artículo que deseas ver dellado!" ,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
