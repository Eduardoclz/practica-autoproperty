using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1uno = new Class1();
            class1uno.Nombre = "eduardo castro ";
            class1uno.Direccion = "por ahi ";
            class1uno.CorreoElectronico = "eduardoclx@gmail.com ";
            class1uno.TelefonoCasa = "6622045320 ";
            class1uno.TelefonoCelular = "4443493849 ";
            Console.WriteLine("Nombre " + class1uno.Nombre);
            Console.WriteLine("Direccion " + class1uno.Direccion);
            Console.WriteLine("Celular " + class1uno.TelefonoCelular);
            Console.WriteLine("Casa " + class1uno.TelefonoCasa);
            Console.WriteLine("Correo " + class1uno.CorreoElectronico);
            Console.ReadLine();


        }
    }
}
