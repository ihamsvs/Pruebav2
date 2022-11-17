using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionV2
{
    class DiccionarioProductos
    {
        private Dictionary<int, string> diccionarioP = new Dictionary<int, string>();

        public void AgregarProducto(int key, string nombre)
        {
            diccionarioP.Add(key, nombre);
        }


        public void MostrarProductos(int key)
        {
            string nombre = "";
            Console.WriteLine("\n --------------------- \n");
            Console.WriteLine("Buscando un producto con la key " + key);

            if(diccionarioP.TryGetValue(key, out nombre))
            {
                Console.WriteLine("Nombre "+ nombre)
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No existe esa key en la base de datos");
            }
            



        }

    }
}
