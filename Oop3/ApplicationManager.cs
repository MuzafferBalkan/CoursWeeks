using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class ApplicationManager
    {
        // Method injection
        public void MakeApplication(ICreditManager creditManager , ILoggerService loggerService)
        {
            //Başvurulan bilgileri değerlendirme
            //

            creditManager.Calculate();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> creditManagers)
        {
            foreach (ICreditManager credit in creditManagers)
            {
                credit.Calculate();
            }
        }
    }
}
