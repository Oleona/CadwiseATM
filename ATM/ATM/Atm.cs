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
            Dictionary<int, int> banknotesByDenominationsInRequest = banknotes.CountByDenominations;

            var sumToAdd = banknotes.PlanSumToAddOrWithdraw;        
            Users[userName] += sumToAdd;
            
            banknotesByDenomination = banknotesByDenomination.ToDictionary(
                orig => orig.Key,
                orig => orig.Value + banknotesByDenominationsInRequest[orig.Key]
                );
        }

        public static void WithdrawMoney(string userName, BanknotesByDenominations banknotes)
        {
            Dictionary<int, int> banknotesByDenominationsInRequest = banknotes.CountByDenominations;

            var sumToWithdraw = banknotes.PlanSumToAddOrWithdraw;
            Users[userName] -= sumToWithdraw;

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
                sb.Append("       ");
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

        public static (string Name, int DepositValue) GetUserInfo(string userName)
        {
            if (!Users.ContainsKey(userName))
            {
                return ("Неизвестный пользователь", 0);
            }

            return (userName, Users[userName]);
        }

        public static int TotalBanknotesCount => banknotesByDenomination.Sum(b => b.Value);

        public static int TotalMoney => banknotesByDenomination.Sum(b => b.Key * b.Value);

        public static int MaxBanknotesCapacity => 150;

        public static string SerialNumber => "ATM № 123456/1122";


        public static string GetDate()
        {
            DateTime curDate = DateTime.Now;
            return string.Concat("Дата и время проверки ", "\n", curDate.ToShortDateString(), " ", curDate.ToLongTimeString());
        }

        public static string GetMaxBanknotesCapacityToString()
            => string.Concat("\n", "Максимальное количество \r\nхранимых купюр  ", MaxBanknotesCapacity.ToString());

        private static readonly Dictionary<string, int> Users = new Dictionary<string, int>()
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

        private static Dictionary<int, int> banknotesByDenomination = new()
        {
            [Denominations.R10] = 0,
            [Denominations.R50] = 0,
            [Denominations.R100] = 0,
            [Denominations.R200] = 0,
            [Denominations.R500] = 0,
            [Denominations.R1000] = 0,
            [Denominations.R2000] = 0,
            [Denominations.R5000] = 0,
        };
    }
}
