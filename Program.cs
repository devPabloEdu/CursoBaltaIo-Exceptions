using System;
namespace CursoBaltaIo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Array[3];

            try {
            //     for (var index = 0; index < 10; index++)
            // {
            //     //System.IndexOutOfRangeException - este é o tipo da exceção
            //     Console.WriteLine(arr[index]);
            // }

                Cadastrar("aaaakjakjakja");

            }
            catch(IndexOutOfRangeException ex){
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice na lista");
            }
             catch(ArgumentNullException ex) {
                Console.WriteLine("Falha ao Cadastrar texto");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            catch(MinhaException ex) {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("exceção customizada!");
            }
             catch(Exception ex) {
                Console.WriteLine("ops, algo deu errado");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }           
        } 
        private static void Cadastrar(string texto){
            if(string.IsNullOrEmpty(texto)){
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
                throw new MinhaException(DateTime.Now);

            }
        } 
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu {get; set;}
        }
    }
}