using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AyDdS1_DocScreen
{
    [TestFixture]
    public class PruebasUnitarias
    {

        PantallaPrincipal programa;

        public PruebasUnitarias(PantallaPrincipal programa)
        {

            this.programa = programa;
        }

        [Test]
        public void verificarPantallazos()
        {
            
            int cantidad = 10;
            int intervalo = 1000;
            int retardo = 2000;

            programa.iniciar(cantidad, intervalo, retardo);
            //verificamos si existen la cantidad de  capturas que solicitamos
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ejecutando for");
                Assert.IsTrue(System.IO.File.Exists(programa.getListaScreens().ElementAt(i).getPath() + programa.getListaScreens().ElementAt(i).nombreArchivo), "Existen el archivo " + programa.getListaScreens().ElementAt(i) + programa.getListaScreens().ElementAt(i).nombreArchivo);
            }
            
        }

    }
}
