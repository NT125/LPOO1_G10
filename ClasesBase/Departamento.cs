using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Departamento
    {
        private int depto_Codigo;
        public int Depto_Codigo
        {
            get { return depto_Codigo; }
            set { depto_Codigo = value; }
        }

        private string edif_Nombre;
        public string Edif_Nombre
        {
            get { return edif_Nombre; }
            set { edif_Nombre = value; }
        }

        private string dpto_Tipo;
        public string Dpto_Tipo
        {
            get { return dpto_Tipo; }
            set { dpto_Tipo = value; }
        }


        private int dpto_Numero;
        public int Dpto_Numero
        {
            get { return dpto_Numero; }
            set { dpto_Numero = value; }
        }


        private int dpto_Piso;
        public int Dpto_Piso
        {
            get { return dpto_Piso; }
            set { dpto_Piso = value; }
        }


        private int dpto_Ambientes;
        public int Dpto_Ambientes
        {
            get { return dpto_Ambientes; }
            set { dpto_Ambientes = value; }
        }


        private int dpto_Dormitorios;
        public int Dpto_Dormitorios
        {
            get { return dpto_Dormitorios; }
            set { dpto_Dormitorios = value; }
        }

        
        private int dpto_Baños;
        public int Dpto_Baños
        {
            get { return dpto_Baños; }
            set { dpto_Baños = value; }
        }



        private string dpto_Disposicion;
        public string Dpto_Disposicion
        {
            get { return dpto_Disposicion; }
            set { dpto_Disposicion = value; }
        }

    }
}
