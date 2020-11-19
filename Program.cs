using System;

namespace Projeto_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome= Console.ReadLine();

            Console.WriteLine("Agora digite a uma senha:");
            string senha= Console.ReadLine();

            
            while(nome==senha){
                Console.WriteLine("Senha inválida. Digite outra");
                senha = Console.ReadLine();
            }

            
            }
        }
    }

