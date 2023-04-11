using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ContadordePalabras
{
    class cuentaPalabras
    {
        static void Main(string[] args)
        {
            string text = "Un texto que tiene palabras.";
            int n=0;
            text = Regex.Replace(text, @"\s+", " ").Trim();
            var words = text.Split(' ');
            n= words.Length;

            Console.WriteLine("Nùmero de palabras: " + n);
            Console.ReadKey();
        }
         
    }
}
