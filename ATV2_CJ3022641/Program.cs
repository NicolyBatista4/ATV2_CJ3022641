
using System.Security.Claims;
using System.Threading.Channels;

namespace ATV2_CJ3022641
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            // Leitura do salário
            Console.WriteLine("Entre com o seu salário");
            salario = float.Parse (Console.ReadLine() );

            salario = salario + (25.0f/100.0f) * salario;

            Console.ReadKey();

               
            
              
                
                


        }
    }
}
