using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM
{
    public static class ATM
    {
        public static void AddMoney(string userName, BanknotesByDenominations banknotes)
        {
            Dictionary<int, int> banknotesByDenominationsInRequest = banknotes.GetCountByDenominations();

            var sumToAdd = banknotes.GetPlanSumToAddOrWithdraw();        
            Users[userName] += sumToAdd;
            
            TotalMoney += sumToAdd;    
            TotalBanknotesCount += banknotes.GetTotalBanknotesCount();
            
            banknotesByDenomination = banknotesByDenomination.ToDictionary(
                orig => orig.Key,
                orig => orig.Value + banknotesByDenominationsInRequest[orig.Key]
                );
        }

        public static void WithdrawMoney(string userName, BanknotesByDenominations banknotes)
        {
            Dictionary<int, int> banknotesByDenominationsInRequest = banknotes.GetCountByDenominations();

            var sumToWithdraw = banknotes.GetPlanSumToAddOrWithdraw();
            Users[userName] -= sumToWithdraw;
            
            TotalMoney -= sumToWithdraw;
            TotalBanknotesCount += banknotes.GetTotalBanknotesCount();

            banknotesByDenomination = banknotesByDenomination.ToDictionary(
                orig => orig.Key,
                orig => orig.Value - banknotesByDenominationsInRequest[orig.Key]
                );
        }


        public static string ShowState()
        {
            var sb = new StringBuilder();
            foreach (var banknotes in banknotesByDenomination)
            {
                sb.Append(banknotes.Value);
                sb.Append("      ");
            }

            return sb.ToString();
        }

        public static int FindBanknotes(int denomination)
        {
            if (banknotesByDenomination.Keys.Contains(denomination))
            {
                return banknotesByDenomination[denomination];
            }

            return 0;
        }

        public static Dictionary<string, int> Users = new Dictionary<string, int>()
        {
            { "Иван", 20000 } ,
            { "Василий", 25000 },
            { "Петр", 70000 },
            { "Егор", 750000 },
            { "Анна", 25300 },
            { "Сергей", 78000 },
            { "Елена", 22000 },
            { "Антон", 27000 },
            { "Михаил", 70500 }
        };

        private const string SerialNumber = "ATM № 123456/1122";
        private const int MaxBanknotesCapacity = 150;

        public static int TotalBanknotesCount = 0;

        public static int TotalMoney = 0;



        public static int GetMaxBanknotesCapacity() => MaxBanknotesCapacity;

        public static string GetATMNumber() => SerialNumber;


        public static string GetDate()
        {
            DateTime curDate = DateTime.Now;
            return string.Concat("Дата и время проверки ", "\n", curDate.ToShortDateString(), " ", curDate.ToLongTimeString());
        }

        public static string GetMaxBanknotesCapacityToString()
            => string.Concat("\n", "Максимальное количество \r\nхранимых купюр  ", MaxBanknotesCapacity.ToString());


        private static Dictionary<int, int> banknotesByDenomination = new Dictionary<int, int>
        {
            [10] = 0,
            [50] = 0,
            [100] = 0,
            [200] = 0,
            [500] = 0,
            [1000] = 0,
            [2000] = 0,
            [5000] = 0,
        };
    }
}
