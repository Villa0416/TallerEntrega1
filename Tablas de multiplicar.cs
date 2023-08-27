using System;

namespace Tablas_de_Multiplicar
{
 class MainClass
    {
        public static void Main (string[] args)
        {
   
            Console.WriteLine ("Ingrese el primer rango ");
            int rango1=int.Parse(Console.ReadLine());
            Console.WriteLine ("Ingresa el segundo rango ");
            int rango2=int.Parse(Console.ReadLine());
            Console.Clear();
    
   
            for(int i=rango1;i<=rango2;i++){
   
                for(int j=1;j<=10;j++){
                    Console.WriteLine (i+"x"+j+"="+(i*j));
 
                }
                Console.WriteLine (" ");
            }
            Console.ReadKey();
        }
    }
}