using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            // створюєм клас оплати з обовязковими даними
            PaymentAccount account = new PaymentAccount() {PaymentPerDay = 15, NumOfDay = 30, FinePerDay = 5, DaysOfDelay = 3 };
            DoSerialize.Write(account, "Pay.xml");                      // записуємо клас в файл
            PaymentAccount.IsCalculate = true;                          // задаєм змінну для обрахунку (вона і так була true, але перестраховуємося)
            PaymentAccount new1Account = DoSerialize.Read("Pay.xml");   // зчитуємо клас з файлу з обрахунками
            View.Show(new1Account);                                     // дивимся акаунт з обрахунками 


            PaymentAccount.IsCalculate = false;                         // обрахунок false
            PaymentAccount new2Account = DoSerialize.Read("Pay.xml");   // зчитуємо клас з файлу без обрахунків
            View.Show(new2Account);                                     // виводим без обрахунків

            Console.ReadKey();
        }
    }
}
