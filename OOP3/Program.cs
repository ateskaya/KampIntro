using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); 

            BasvuruManager basvuru = new BasvuruManager();
            basvuru.BasvuruYap(ihtiyacKrediManager,new List<ILoggerService>() { databaseLoggerService,fileLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasıtKrediManager};

            //basvuru.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}