using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Product elma = new Product();
			elma.Id = 1;
			elma.Name = "Elma";
			elma.Price = 10;
			elma.Description = "Amasya elması";

            Product karpuz = new Product();
            karpuz.Id = 2;
            karpuz.Name = "Karpuz";
            karpuz.Price = 80;
            karpuz.Description = "Diyarbakır Karpuzu";

			Product[] products = new Product[] {elma, karpuz};

			foreach (Product p in products )
			{
				Console.WriteLine( p.Id+"  "+p.Name+"  "+p.Price+"TL  "+p.Description);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("----------------Metotlar----------------");

			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(elma);
			sepetManager.Ekle(karpuz);

			sepetManager.Ekle2("Armut", "Yeşil Armut", 15);
        }
	}
}