using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class ProductoA : Producto
    {
        #region Variables
        private short _diametro;
        private Material _material;
        #endregion

        #region Propiedades
        public short Diametro
        {
            get
            {
                return this._diametro;
            }
            set
            {
                this._diametro = value;
            }
        }

        public Material Material
        {
            get
            {
                return this._material;
            }
            set
            {
                this._material = value;
            }
        }

        #endregion

        #region Constructores
        public ProductoA() : base()
        { }

        public ProductoA(string descripcion, short diametro, Material material) : base(descripcion)
        {
            this._diametro = diametro;
            this._material = material;
        }
        #endregion

        #region Métodos
        public override string Mostrar()
        {
            StringBuilder miProdA = new StringBuilder();
            miProdA.AppendFormat(base.Mostrar() + "Tipo: {0}, Diametro: {0}, Material: {0}", "A", this._diametro, this._material);
            return miProdA.ToString();
        }

        private bool Validar(int valorAValidar)
        {
            if (this._diametro <= valorAValidar)
            {
                return true;
            }
            return false;
        }

        public bool ValidarMaterial(Material material)
        {
            bool materialValido = false;
            string mensajeExcepcion = string.Format("No se puede fabricar una pieza de {0} y diametro de {1} centímetros.",this._material,this._diametro);
            switch (material)
            {
                case Material.Plastico:
                    materialValido = true;
                    break;
                case Material.Aluminio:
                    materialValido = Validar(10);
                    break;
                case Material.Caucho:
                    materialValido = Validar(15);
                    break;
                default:
                    break;
            }
            if (!materialValido)
            {
                throw new MaterialException(mensajeExcepcion);
            }
            return materialValido;
        }
        #endregion
    }
}
