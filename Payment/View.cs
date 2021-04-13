using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    static class View
    {
        public static void Show(PaymentAccount account)
        {
            if (PaymentAccount.IsCalculate)
                Console.WriteLine("\nЗ обрахунками");
            else Console.WriteLine("\nБез обрахункiв");

            Console.WriteLine
            (
                $"Денна оплата    {account.PaymentPerDay}\n" +
                $"Кiлькiсть днiв  {account.NumOfDay}\n" +
                $"Штраф за день   {account.FinePerDay}\n" +
                $"Кi-ть штрафних  {account.DaysOfDelay}\n" +
                $"Оплата без штр. {account.AmountDue}\n" +
                $"Штрафи          {account.Fine}\n" +
                $"Загальна оплата {account.Total}"
            );
        }
    }
}
