using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Edificio
    {
        private int edifCodigo;
        private string edif_Nombre;
        private string edif_Direccion;
        private string edif_Administrador;
        private string edif_Telefono;
        
        

        public int EdifCodigo
        {
            get { return EdifCodigo; }
            set { EdifCodigo = value; }
        }

        public string Edif_Nombre
        {
            get { return Edif_Nombre; }
            set { Edif_Nombre = value; }
        }

        public string Edif_Direccion
        {
            get { return Edif_Direccion; }
            set { Edif_Direccion = value; }
        }

        public string Edif_Administrador
        {
            get { return Edif_Administrador; }
            set { Edif_Administrador = value; }
        }

        public string Edif_Telefono
        {
            get { return Edif_Telefono; }
            set { Edif_Telefono = value; }
        }
        
    }
}
