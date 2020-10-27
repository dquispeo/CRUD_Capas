using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CRUDSemana06
{
    /// <summary>
    /// Lógica de interacción para ManProducto.xaml
    /// </summary>
    public partial class ManProducto : Window
    {
        public int ID { get; set; }
        public ManProducto(int Id)
        {
            InitializeComponent();
            ID = Id;
            if (ID > 0)
            {
                BProducto bProducto = new BProducto();
                List<Producto> productos = new List<Producto>();
                productos = bProducto.Listar(ID);
                if (productos.Count > 0)
                {
                    lblID.Content = productos[0].IdProducto.ToString();
                    txtNombre.Text = productos[0].NombreProducto;
                    txtIdProveedor.Text = productos[0].IdProveedor.ToString();
                    txtIdCategoria.Text = productos[0].IdCategoria.ToString();
                    txtCantidadProUnidad.Text = productos[0].CantidadPorUnidad;
                    txtPrecioUnidad.Text = productos[0].PrecioUnidad.ToString();
                    txtUnidadesExistentes.Text = productos[0].UnidadesExistentes.ToString();
                    txtUnidadesPedidas.Text = productos[0].UnidadesPedidas.ToString();
                    txtNivelNuevoPedido.Text = productos[0].NivelNuevoPedido.ToString();
                    txtSuspendido.IsChecked = productos[0].Suspendido;
                    txtCategoriaProducto.Text = productos[0].CategoriaProducto;
                }
            }
        }
        private void BtnGrabar_Click(object sender, RoutedEventArgs e)
        {
            BProducto Bproducto = null;
            bool result = true;
            try
            {
                //0: Listar todas las categorias
                Bproducto = new BProducto();
                if (ID > 0)
                    result = Bproducto.Actualizar(new Producto { 
                        IdProducto = ID, 
                        NombreProducto = txtNombre.Text,
                        IdProveedor = Convert.ToInt32(txtIdProveedor.Text),
                        IdCategoria = Convert.ToInt32(txtIdCategoria.Text),
                        CantidadPorUnidad = txtCantidadProUnidad.Text,
                        PrecioUnidad = Convert.ToInt32(txtPrecioUnidad.Text),
                        UnidadesExistentes = Convert.ToInt32(txtUnidadesExistentes.Text),
                        UnidadesPedidas = Convert.ToInt32(txtUnidadesPedidas.Text),
                        NivelNuevoPedido = Convert.ToInt32(txtNivelNuevoPedido.Text),
                        Suspendido = Convert.ToBoolean(txtSuspendido),
                        CategoriaProducto = txtCategoriaProducto.Text 
                    });
                else
                    result = Bproducto.Insertar(new Producto {
                        NombreProducto = txtNombre.Text,
                        IdProveedor = Convert.ToInt32(txtIdProveedor.Text),
                        IdCategoria = Convert.ToInt32(txtIdCategoria.Text),
                        CantidadPorUnidad = txtCantidadProUnidad.Text,
                        PrecioUnidad = Convert.ToInt32(txtPrecioUnidad.Text),
                        UnidadesExistentes = Convert.ToInt32(txtUnidadesExistentes.Text),
                        UnidadesPedidas = Convert.ToInt32(txtUnidadesPedidas.Text),
                        NivelNuevoPedido = Convert.ToInt32(txtNivelNuevoPedido.Text),
                        Suspendido = Convert.ToBoolean(txtSuspendido),
                        CategoriaProducto = txtCategoriaProducto.Text
                    });
                if (!result)
                    MessageBox.Show("Comunicarse con el administrador");

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el administrador");
            }
            finally
            {
                Bproducto = null;
            }
        }
        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            BProducto Bproducto = null;
            bool result = true;
            try
            {
                //0: Listar todas las categorias
                Bproducto = new BProducto();
                if (ID > 0)
                    result = Bproducto.Eliminar(ID);

                if (!result)
                    MessageBox.Show("Comunicarse con el administrador");

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el administrador");
            }
            finally
            {
                Bproducto = null;
            }
        }
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}