using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Scrieti un program care implementeaza cifrul lui Cezar.
// Cifrul lui Cezar inlocuieste fiecare litera din textul clar cu a treia litera care urmeaza in alfabet. 
// Criptare: "+3"      Decriptare: "-3"
// Obs. orice alt caracter diferit de litera ramane nemodificat. 
// Se vor implementa operatiile de criptare/decriptare/criptanaliza.

namespace Cezar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(text);
            
            string enc = CaesarCypher.Encrypt(text);
            Console.WriteLine(enc);

            string dec = CaesarCypher.Decrypt(enc);
            Console.WriteLine(dec);
        }
    }
}