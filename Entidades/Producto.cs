using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //modificador "public" de la clase producto
    public class Producto
    {
        #region Atributos
        private int Codigo;
        private string Descripcion;
        private int Stock;
        #endregion

        #region Propiedades
        public int pcodigo
        {
            set { Codigo = value; }
            get { return Codigo; }
        }
        public string pdescripcion
        {
            set { Descripcion = value; }
            get { return Descripcion; }

        }
        public int pstock
        {
            get { return Stock; }   
        }
        #endregion
        #region Constructores
        //constructores (2 inicialmente)
        public Producto()
        {
            //por defecto
        }
        public Producto(int Cod, string Desc)//recibe los parametros
        {
            Codigo = Cod;
            Descripcion = Desc;
            Stock = 0;

        }
        #endregion
        #region Metodos
        //metodo
        public void Ingreso (int cant)
        {
            Stock = Stock + cant;
        }
        public void Salida (int cant)
        {
            Stock = Stock - cant;

        }
        #endregion
    }
}
