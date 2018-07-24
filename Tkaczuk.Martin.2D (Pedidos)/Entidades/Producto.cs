using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Enumerado Material
    public enum Material { Plastico, Aluminio, Caucho }
    #endregion

    public abstract class Producto
    {
        #region Delegado + Evento
        public delegate void ProductoTerminado(object sender, EventArgs e);
        public event ProductoTerminado InformarProductoTerminado;
        #endregion

        #region Variables
        private string _descripcion;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }
        #endregion

        #region Constructores
        public Producto ()
        { }
        public Producto(string descripcion)
        {
            this._descripcion = descripcion;
        }
        #endregion

        #region Métodos
        public virtual string Mostrar()
        {
            StringBuilder miProd = new StringBuilder();
            miProd.AppendFormat("Descripcion: {0}", this._descripcion);
            return miProd.ToString();
        }

        public void Elaborar()
        {
            ProductoDAO miProdDAO = new ProductoDAO();
            ProductoA miProdA = new ProductoA();
            ProductoB miProdB = new ProductoB();
            
            if (this.GetType() == typeof(ProductoA))
            {
                miProdA = (ProductoA)this;
                miProdDAO.GuardarProducto(miProdA);

                InformarProductoTerminado.Invoke(miProdA, new EventArgs());
            }
            else
            {
                miProdB = (ProductoB)this;
                miProdDAO.GuardarProducto(miProdB);

                InformarProductoTerminado.Invoke(miProdB, new EventArgs());
            }
        }
        #endregion
    }
}
