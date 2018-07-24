using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {
        #region Variables
        private short _alto;
        private short _ancho;
        private short _largo;
        #endregion

        #region Propiedades
        public short Alto
        {
            get
            {
                return this._alto;
            }
        }

        public short Ancho
        {
            get
            {
                return this._ancho;
            }
        }

        public short Largo
        {
            get
            {
                return this._largo;
            }
        }


        #endregion

        #region Constructores
        public ProductoB():base()
        { }

        public ProductoB(string descripcion, short largo, short alto, short ancho):base(descripcion)
        {
            this._largo = largo;
            this._alto = alto;
            this._ancho = ancho;
        }
        #endregion

        #region Métodos
        public override string Mostrar()
        {
            var _volumen = CalcularVolumen();
            StringBuilder miProdB = new StringBuilder();
            miProdB.AppendFormat(base.Mostrar(), "Tipo: {0}, Ancho: {1}, Alto: {2}, Largo: {3}, Volumen: {4}", "B", this._ancho, this._alto, this._largo, _volumen);
            return miProdB.ToString();
        }

        public int CalcularVolumen()
        {
            int volumenCalculado;
            volumenCalculado = this._ancho * this._alto * this._largo;
            return volumenCalculado;
        }
        #endregion
    }
}
