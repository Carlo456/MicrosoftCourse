using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftCourse
{
    public class Prueba
    {
        Prueba()
        {
            int id = 20;
            string nombre = "Carlo";
        }
        public void GetMessage()
        {
            Console.WriteLine("Hola, soy un metodo de la clase prueba");
        }
        protected void GetMessage2()
        {
            Console.WriteLine("Hola, soy un metodo protegido de laz clase prueba");
        }
        private void GetMessage3()
        {
            Console.WriteLine("Hola, soy un metodo privado de laz clase prueba");
        }

    }
}
