using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Principal;
using System.Xml.Linq;
using System;
using Microsoft.VisualBasic;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------FUNCTIONS
            // Stampare array
            void StampaArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    PrintPointInArray();
                }
                Console.Write("...");
                Console.Write("]");
            }
            // Stampa virgola tra gli elementi
            void PrintPointInArray()
            {
                Console.Write(", ");
            }
            // Calcola Esponenziale
            int Exponents(int number)
            {
                number = number * number;
                return number;
            }
            // Crea nuovo array ed eleva gli elementi al quadrato
            int[] ExponentsNewArray(int[] array)
            {
                int[] squaredArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    squaredArray[i] = Exponents(array[i]);
                }
                return squaredArray;
            }
            // Somma elementi in array
            int SommaElementiArray(int[] array)
            {
                int sum = 0;
                foreach(int number in array)
                {
                    sum += number;
                }
                return sum;
            }
            /* Esercizio di oggi: **csharp - functions * *
               nome repo: **csharp - functions * *
               In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter 
               fare operazioni complesse nei vostri programma principale.

               Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
               -**void StampaArray(int[] array) * *: che preso un array di numeri interi, 
                stampa a video il contenuto dell’array in questa forma 
                “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
            */
            {
                int[] numeri = { 2, 6, 7, 5, 3, 9 };
                StampaArray(numeri);
            }
            /*
               - **int Quadrato(int numero) * *: che vi restituisca il quadrato del numero passato come parametro.
            */
            {
                Console.WriteLine("Scegli un numero");
                int choiceNumber = Convert.ToInt32(Console.ReadLine());
                int result = Exponents(choiceNumber);
                Console.WriteLine($"Il valore scelto, {choiceNumber}, il suo esponente {result}");
            }
            /*
               -**int[] ElevaArrayAlQuadrato(int[] array) * *: che preso un array di numeri interi, restituisca un nuovo array 
                con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, 
                e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci(vedi slide)
            */
            {
                int[] myArrayNumber = { 2, 6, 7, 5, 3, 9 };
                int[] squaredArray = ExponentsNewArray(myArrayNumber);

                Console.Write("Array originale:");
                StampaArray(myArrayNumber);

                Console.Write("Array con elementi elevati al quadrato:");
                StampaArray(squaredArray);
            }
            /*
               -**int sommaElementiArray(int[] array) * *: che preso un array di numeri interi, restituisca la somma totale di tutti 
                gli elementi dell’array.
            */
            {
                int[] myArray = { 2, 6, 7, 5, 3, 9 };
                int sum = SommaElementiArray(myArray);
                Console.WriteLine($"La somma del mio array è {sum}");
            }
            /*

                Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri[2, 6, 7, 5, 3, 9] 
                già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
               -Stampare l’array di numeri fornito a video
               -Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al 
                quadrato(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente 
                l’array originale e verificare che sia rimasto[2, 6, 7, 5, 3, 9])
               -Stampare la somma di tutti i numeri
               -Stampare la somma di tutti i numeri elevati al quadrati
               ** BONUS:**Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono 
               *lavorare con array di numeri interi** di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi 
               *array di 5 elementi, sia di 6, di 7, di... e così via.
               A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che 
               questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente 
               dall’utente.
           */
        }
    }
}
