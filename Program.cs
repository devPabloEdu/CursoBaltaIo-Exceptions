using System;
namespace CursoBaltaIo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Array[3];

            try {
                for (var index = 0; index < 10; index++)
            {
                //System.IndexOutOfRangeException - este é o tipo da exceção
                Console.WriteLine(arr[index]);
            }
            }catch(IndexOutOfRangeException ex){
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o indice na lista");
            }
             catch(Exception ex) {
                Console.WriteLine("ops, algo deu errado");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            
            
        } 
    }
}