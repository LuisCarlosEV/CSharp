using System;
using System.Linq;
using Programando.CSharp.Demos.Model;

namespace Programando.CSharp.Demos
{
    public class Program
    {
        static void SentenciasControl2()
        {   
            int[] nums;
            int[] nums2 = new int [5];
            int[] nums3 = new int [5] {1, 5, 4, 74, -10};
            int[] nums4 = new int[] {1, 5, 4, 74, -10};


            int[] numeros = {10, 95, -2, -32, 118};
            string [] frutas = {"naranja", "limon","pomelo", "lima"};

            for(int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine($"Posicion: {i} --> {frutas[i]}");
            }

            foreach(var fruta in frutas)
            {
                Console.WriteLine($"{frutas}");
            }
        }

            public static void Main(string[] args)
        {   
            var reserva3 = new Reserva();    

            switch (respuesta.ToUpper())
            {
                case "si":
                    reserva3.fumador = true;
                    respuesta = "si";
                    break;
                case "no":
                    reserva3.fumador = false;
                    respuesta = "no";
                    break;
                default:
                    Console.WriteLine ("Escriba si/no");
                    reserva3.fumador = false;
                    break;                    
            }

            Console.WriteLine ("Es fumador? si/no");
            string respuesta = Console.ReadLine();
                       
            switch (respuesta.ToUpper())
            {
                case "si":
                    reserva3.fumador = true;
                    respuesta = "si";
                    break;
                case "no":
                    reserva3.fumador = false;
                    respuesta = "no";
                    break;
                default:
                    Console.WriteLine ("Escriba si/no");
                    reserva3.fumador = false;
                    break;                    
            }

            Console.Clear();
            //mostrar ID reserva y nombre
            //mostrar utilizando IF/ELSE tipo de habitacion en texto
            //mostar utilizando switch si es fumador







           
        }
    }

}