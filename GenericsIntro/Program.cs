using System;

namespace GenericsIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
           var isimler = new MyList<string>() ;
            isimler.Add("şevval");
            isimler.Add("zülal");
            isimler.Add("alihan");
           
            
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();



            var sozluk = new MyDictionary<int, string>() ;
            sozluk.Add(1,"sevval");
            sozluk.Add(2, "zulal");

            foreach (var key in sozluk.GetKeys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in sozluk.GetValues)
            {
                Console.WriteLine(value);
            }




        }
    }
}
