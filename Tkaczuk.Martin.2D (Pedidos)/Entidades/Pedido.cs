using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Pedido
    {
        #region Variables
        private List<Producto> _productos;
        #endregion

        #region Propiedades
        public List<Producto> Productos
        {
            get
            {
                return this._productos;
            }
            set
            {
                this._productos = value;
            }
        }
        #endregion

        #region Métodos
        public static Pedido operator +(Pedido unPedido, Producto unProducto)
        {
            int cantMaxima = 5;
            string mensajeExcepcion = string.Format("El pedido ya cuenta con la cantidad máxima de productos");

            if (unPedido._productos.Count() < cantMaxima)
            {
                unPedido._productos.Add(unProducto);
            }
            else
            {
                throw new CantidadMaximaProductos(mensajeExcepcion);
            }
            return unPedido;
        }

        public void FabricarPedido()
        {
            foreach (var miProd in _productos)
            {
                Thread.Sleep(1000);
                miProd.Elaborar();
            }
        }
        #endregion
    }
}
