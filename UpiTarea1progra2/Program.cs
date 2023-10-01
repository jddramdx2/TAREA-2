using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpiTarea1progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio1();
                        break;
                    case 2: Ejercicio2();
                        break;
                    case 3: Ejercicio3();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion!=4);// mientras que la opcion sea diferente de 4
        }
        public static void Ejercicio1()  // metodo 1
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Cual es el precio de la camisa");
            precio = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite la cantidad");
            cantidad=int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"total a pagar: {cantidad*precio}");
            }else if (cantidad > 1 && cantidad <=6) 
            {
                total = (cantidad * precio) * 0.15f;
                total = (cantidad * precio);
                Console.WriteLine($"total a pagar: {total} con descuento de 15%");
            }else if (cantidad >=6)
            {
                total = (cantidad * precio) * 0.2f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"total a pagar: {total} con descuento de 20%");

            }
        }
        public static void Ejercicio2()  //metodo 2
        {
            {
                // Leer datos del estudiante
                Console.Write("Ingrese el carnet del estudiante:");
                string carnet = Console.ReadLine();

                Console.Write("Ingrese el nombre del estudiante:");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la nota del Quiz numero 1:");
                double quiz1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota del Quiz numero 2:");
                double quiz2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota del Quiz numero 3:");
                double quiz3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota de la Tarea numero 1:");
                double tarea1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota de la Tarea numero 2:");
                double tarea2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota de la Tarea numero 3:");
                double tarea3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota del Examen numero 1:");
                double examen1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota del Examen numero 2:");
                double examen2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la nota del Examen numero 3:");
                double examen3 = Convert.ToDouble(Console.ReadLine());

                // calculando los porcecentajes obtnenidos en una variable y formula de una vez
                double porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
                double porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.30;
                double porcentajeExamenes = (examen1 + examen2 + examen3) / 3 * 0.45;

                // Meter todos los promedios en una sola variable que se lllma promedio Final
                double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

                // Determinar la condición del estudiante
                string condicion = "";
                if (promedioFinal >= 70)
                {
                    condicion = "Aprobado";
                }
                else if (promedioFinal >= 50 && promedioFinal < 70)
                {
                    condicion = "Aplazado";
                }
                else
                {
                    condicion = "Reprobado";
                }

                // Imprimir todos los datos obtenidos
                //Por ejemplo, si porcentajeQuices tiene un valor de 0.4567, la expresión porcentajeQuices.ToString("P2")
                //dará como resultado la cadena "45.67%", que es el valor formateado como un porcentaje con dos decimales.

                //Este formato es útil cuando se necesita mostrar valores numéricos como porcentajes en la salida de un programa o aplicación de C# de una manera legible y estandarizada.
                Console.WriteLine("Carnet: " + carnet);
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices.ToString("P2"));
                Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas.ToString("P2"));
                Console.WriteLine("Porcentaje de Examenes: " + porcentajeExamenes.ToString("P2"));
                Console.WriteLine("Promedio Final: " + promedioFinal.ToString("P2"));
                Console.WriteLine("Condición: " + condicion);
            }
        }
        public static void Ejercicio3()  //metodo 3
        {
            {
        // Solicitar la cantidad de artículos al usuario
        Console.Write("Ingrese la cantidad de artículos: ");
        int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

        // Definir los precios por producto
        double precioPorProducto;

        // Determinar el precio por producto según la cantidad
        if (cantidadArticulos <= 10)
        {
            precioPorProducto = 20.0;
        }
        else
        {
            precioPorProducto = 15.0;
        }

        // Calcular el precio total
        double precioTotal = cantidadArticulos * precioPorProducto;

        // Mostrar resultados
        Console.WriteLine("Precio por producto: $" + precioPorProducto);
        Console.WriteLine("Precio total: " + precioTotal+ "COLONES " );   // BUSCAR COMO METER EL ESPACIO ENTRE LA CANT Y LOS COLONES
    }
        }
    }
}
// else sirve para algunos casos pero no todos solo en el caso de un cuestinario ocupo que evalue todo