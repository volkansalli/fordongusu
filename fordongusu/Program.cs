using System;

namespace fordongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, tektop=0, cifttop=0, tumtop=0;
            Console.WriteLine("1 den 1000 e kadar olan tek ve çift sayıların kendi içinde toplamı");
            for(i=0;i<=1000;i++){
                if(i%2==0)
                cifttop+=i;
                else
                tektop+=i;
            }
            tumtop=tektop+cifttop;
            Console.WriteLine("tektoplam=   ");
            Console.WriteLine(tektop);
            
            Console.WriteLine("cifttoplam=   ");
            Console.WriteLine(cifttop);
            Console.WriteLine("tumtoplam=   ");
            Console.WriteLine(tumtop);





        }
    }
}
