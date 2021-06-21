﻿using System;

namespace UD5E5
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Introduce un numero";
            int numero = Convert.ToInt32(texto);
            String binario = decimalBinario(numero);
            Console.WriteLine("El numero " + numero + " en binario es " + binario);
        }
        public static String decimalBinario(int numero)
        {
            String binario = "";
            String digito;
            for (int i = numero; i > 0; i /= 2)
            {
                if (i % 2 == 1)
                {
                    digito = "1";
                }
                else
                {
                    digito = "0";
                }
                
                binario = digito + binario;
            }
            return binario;
            
        }
    }
}
