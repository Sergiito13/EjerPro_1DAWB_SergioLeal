using System;
namespace TienditaPOSTAPOCALIPTICA
{
    class Program
    {
        public static void Main(string[] args)
        {
            // EJER REPASO - TIENDITAPOSTAPOCALIPTICA
            // Declaramos las variables

            Estructuras.UsuariosTienda[] UsuariosShop = Funciones.LlenarUsuariosTienda();

            Estructuras.ProductosTienda[] ProductosShop = Funciones.ProductosDeLaTiendaPOSTAPOCALIPTICA();

            Menu.MenuOpciones();
        }
    }

    class Estructuras
    {
        public struct ProductosTienda
        {
            public string NombreProducto;
            public decimal PrecioProducto;
            public int StockProducto;
        }

        public struct UsuariosTienda
        {
            public string NombreUsuario;
            public int EdadUsuario;
            public decimal SaldoUsuario;
        }
        public struct Pedidos
        {
            public string UsuarioPedido;
            public int CantidadProductos;
            public decimal PrecioTotalCompra;
        }
    }
}
