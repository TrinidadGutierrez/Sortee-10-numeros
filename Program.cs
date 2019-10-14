using System;

namespace Sortee_10_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Random ObjetoRandom = new Random();
            int numero = 0;

            for (int i = 0; i < 10; i++) /*A la variable i (que empieza en 0),
                                          va a ir incrementando de a 1 hasta llegar a 10 
                                          (Repetira  el proceso de abajo 10 veces)*/
            {
                numero += ObjetoRandom.Next(1000);  // acumulo numeros al azar diez veces y se van sumando
            }
            Console.WriteLine("El promedio de los diez numeros sorteados es:  " + (numero / 10));/* los numeros sumados
                                                                  (Resultado final "numero", 
                                                                  lo divide por 10 para sacar promedio.*/
        }
    }
}