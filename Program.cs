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
                //System.IndexOutOfRangeException
                Console.WriteLine(arr[index]);
            }
            } catch {
                Console.WriteLine("ops, algo deu errado");
            }
            
            
        } 
    }
}