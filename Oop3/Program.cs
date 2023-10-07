using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonelCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager trandesmanCreditManager = new TradesmanCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(trandesmanCreditManager, new SmsLoggerService()); // yukarıdaki gibide instance edebiliriz bu şekilde de

            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager, mortgageCreditManager, vehicleCreditManager,trandesmanCreditManager };

            //applicationManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}
