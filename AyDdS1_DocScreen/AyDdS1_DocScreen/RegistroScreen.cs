using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyDdS1_DocScreen
{
    class RegistroScreen
    {
        //atributos
        public string nombreArchivo, path;
        public string nombre, descripcion;

        //constructor
        public RegistroScreen()
        {
            nombreArchivo = "";
            path = "";
            nombre = "";
            descripcion = "";
        }
        public RegistroScreen(string nombreArchivo, string path)
        {
            //inicializa variables
            this.nombreArchivo = nombreArchivo;
            this.path = path;
            nombre = "";
            this.descripcion = "";
        }
        
        public RegistroScreen(string nombreArchivo, string path, string nombre, string descripcion)
        {
            //inicializa variables
            this.nombreArchivo = nombreArchivo;
            this.path = path;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

    }
}
