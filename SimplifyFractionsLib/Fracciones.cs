using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraccionesLib
{
    public class Fracciones
    {
        
        public string Simplificar (string fraccion)
        {
            string[] frac = fraccion.Split('/');
            int numerador=0, denominador = 0;
            
            if(frac.Length > 0 && frac.Length == 2)
            {
                if ((numerador > denominador) && (numerador % denominador == 0))
                {
                   fraccion = (numerador / denominador).ToString(); 
                }
                
                int[] factoresPrimosN = getFactoresPrimos(Int32.Parse(frac[0]));
                int[] factoresPrimosD = getFactoresPrimos(Int32.Parse(frac[1]));
                eliminarFactoresRepetidos(factoresPrimosN, factoresPrimosD);
                string fracSimplificada = getFraccionSimplificada(factoresPrimosN, factoresPrimosD);
            }
            return fraccion;
        }
        private void eliminarFactoresRepetidos(int[] factoresN, int[] factoresD) {
            factoresN = factoresN.Except(factoresN.Intersect(factoresD)).ToArray();
            factoresD = factoresD.Except(factoresD.Intersect(factoresN)).ToArray();
        }

        private string getFraccionSimplificada(int[] factoresN, int[] factoresD)
        {
            string fraccionSimplificada = String.Empty;

            /*To Do*/
            return fraccionSimplificada;
        }
        private int[] getFactoresPrimos(int numero)
        {
            int[] listPrimos = { };
            int j = 0;
            int i = 2;
            /*Tomo 2 como semilla*/
            while(numero > i)
            {
                if (numero % i == 0) /*Es divisible*/
                {
                    listPrimos[j] = i;
                    j++;
                    numero = numero / i; /*Obtengo el cociente para ver si es divisible en primo*/
                }
                else /*Chequeo si el numero es Primo, sino incremento al próximo primo*/
                {
                    if (esPrimo(numero)) /*si es primo lo agrego al listado y se lo asigno al divisor*/
                    {
                        listPrimos[j] = numero;
                        i = numero;
                    }
                    else /*busco el proximo primo*/
                    {
                       i = getProximoPrimo(i);
                    }
                }
            }
            return listPrimos;
        }
        private bool esPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(numero));

            for (int i = 3; i <= boundary; i += 2)
                if (numero % i == 0)
                    return false;

            return true;
        }
        private int getProximoPrimo(int numero)
        {
            int i = (numero==2 ? numero+= 1: numero);
            for (; !esPrimo(i); i++) ;
            return i;
        }
    }
}
