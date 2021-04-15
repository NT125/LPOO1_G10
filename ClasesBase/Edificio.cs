using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Edificio
    {
        private int edifCodigo;

        public int EdifCodigo
        {
            get { return edifCodigo; }
            set { edifCodigo = value; }
        }
        private string edifNombre;

        public string EdifNombre
        {
            get { return edifNombre; }
            set { edifNombre = value; }
        }
        private string edifDireccion;

        public string EdifDireccion
        {
            get { return edifDireccion; }
            set { edifDireccion = value; }
        }
        private string edifAdministrador;

        public string EdifAdministrador
        {
            get { return edifAdministrador; }
            set { edifAdministrador = value; }
        }
        private string edifTelefono;

        public string EdifTelefono
        {
            get { return edifTelefono; }
            set { edifTelefono = value; }
        }
   
        
    }
}
