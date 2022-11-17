using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionV2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declaracion de variables y obejtos
            bool exit = false;
            DiccionarioProductos p = new DiccionarioProductos();
            #endregion

            while (!exit)
            {
                Console.WriteLine("-------------- Bienvenido a Trueque --------------");
                Console.WriteLine("1 - ¿ Desea intercambiar un articulo ? ");
                Console.WriteLine("2 - ¿ Buscar un producto en la bodega ?");
                Console.WriteLine("3 - ¿ Agregar un producto a la bodega ?");
                Console.WriteLine("4 - Mostrar productos en bodega");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Intercambiar producto");
                        break;
                    case 2:
                        Console.WriteLine("Nombre del producto");
                        break;
                    case 3:
                        Console.WriteLine("Que producto desea agregar");
                        Console.WriteLine("Ingrese la llave del producto"); 
                        int key = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del producto");
                        string nombre = Console.ReadLine();
                        p.AgregarProducto(key, nombre);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese la key del producto");
                        int key = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n ----- Mostrando productos en bodega ----- \n ");
                        p.MostrarProductos(key);



                }
            
            
            
            
                Console.ReadKey();
            }   
        }
    }
