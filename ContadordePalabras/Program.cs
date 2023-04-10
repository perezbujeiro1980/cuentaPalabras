using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContadordePalabras
{
    class Program
    {        static void Main(string[] args)
        {

            //string oracion = ".";
             //string oracion = "El sol sale por el este y se esconde por el oeste.";
            string oracion = "hola amigo, ¿qué tal?";

            int palabras=0;
            int contador = 0;

            if (oracion.Length < 1) {
                Console.Write("vacío");               
            }
            
            else {
                foreach (var item in oracion)
                {
                    if (item != ' ')
                    {
                        contador++;
                    }

                    if (item == ' ' && contador >0)
                    {
                        palabras++;
                        contador = 0;
                    }                  
                }
                if (contador > 0)
                    palabras++;
            }
            Console.Write("la oración posee {0} palabras", palabras);              
            Console.ReadKey();  
        }         
         
    }       
}
