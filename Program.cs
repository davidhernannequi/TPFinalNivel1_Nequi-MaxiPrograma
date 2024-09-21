using System;

namespace TPFinal_Nequi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maxPar = 0, menorPrimo = 0, contImp = 0;
            bool banPar = false, banPrimo = false;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0){
                if (n % 2 == 0){
                    if (!banPar){
                        maxPar = n;
                        banPar = true;
                    }
                    else if (n > maxPar)
                        maxPar = n;    
                }
                else
                    contImp++;

                if (n > 0 && primo(n)){
                    if (!banPrimo){
                        menorPrimo = n;
                        banPrimo = true;
                    }
                    else if (n < menorPrimo)
                        menorPrimo = n;
                }
                
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Hay " + contImp + " numeros impares.");
            Console.WriteLine("El maximo par es: " + maxPar);
            Console.WriteLine("El menor primo es: " + menorPrimo);
        }   

        static bool primo(int nro) {
            int cont = 0;
            for (int i = 1; i <= nro; i++)
            {
                if (nro % i == 0)
                    cont++;
            }

            if (cont == 2)
                return true;
            else
                return false;     
        }
    }
}
