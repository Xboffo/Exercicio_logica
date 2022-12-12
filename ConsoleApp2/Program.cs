using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n,soma=0;
            int[] vet1;
            int[] vet2;
            

            Console.WriteLine("Digite o tamanho do seu array ");
            n = int.Parse(Console.ReadLine());
            vet1 = new int[n];
            vet2 = new int[n];
            

            //Numeros aleatorios
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet1[i] = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet2[i] = vet1[i];
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet1[j] > vet1[j + 1])
                    {
                        int trocaNumero = vet1[j];
                        vet1[j] = vet1[j + 1];
                        vet1[j + 1] = trocaNumero;
                    }
                }
            }
            
            Console.WriteLine("----- ORDEM CRESCENTE----");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet1[i] + " ");
            }       

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet2[j] < vet2[j + 1])
                    {
                        int trocaNumero = vet2[j];
                        vet2[j] = vet2[j + 1];
                        vet2[j + 1] = trocaNumero;
                    }
                }
            }

            Console.WriteLine("\n----- ORDEM DECRESCENTE----");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet2[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j= n - 1; j >= 0; j--)
                {
                    soma =soma + vet1[j] + vet2[i];
                    i++;
                }
            }

            Console.WriteLine("\nSOMA DOS VALORES: " +soma);



            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci=0;


            for (int i = 0; i < soma; i++)
            {
                if (fibonacci < soma) 
                { 
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine("\n FIBONNACI: "+ fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
                }
            }
        }
    }
}