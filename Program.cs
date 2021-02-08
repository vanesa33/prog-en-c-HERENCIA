using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseHija Valida = new ClaseHija();

            Valida.saludar();
            Valida.despedirse();
            Console.ReadKey();
        }
    }
}
