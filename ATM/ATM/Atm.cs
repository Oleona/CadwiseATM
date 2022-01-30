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


        public static bool WithdrawMoneySomehow(int sumToWithdraw, string userName)
        {
            for (int i = 0; i < Denominations.AllDenominations.Count; i++)
            {
                var withdrawSuccessed = WithdrawMoneySomehow(sumToWithdraw, userName, currentDenominationIndex: i);
                if (withdrawSuccessed)
                {
                    Users[userName] -= sumToWithdraw;
                    return true;
                }
            }
 

            return false;
        }

        public static bool WithdrawMoneySomehow(int sumToWithdraw, string userName, int currentDenominationIndex)
        {
            if (currentDenominationIndex < 0)
            {
                return false;
            }

            if (sumToWithdraw == 0)
            {
                return true;
            }

            var currentDenomination = Denominations.AllDenominations[currentDenominationIndex];
            var currentDenominationInAtm = banknotesByDenomination[currentDenomination];

            if (currentDenominationIndex == 0)
            {
                var canBeObtainedWithBanknote = sumToWithdraw % currentDenomination == 0;
                var hasEnoughBanknotes = sumToWithdraw / currentDenomination <= currentDenominationInAtm;

                if (canBeObtainedWithBanknote && hasEnoughBanknotes)
                {
                    banknotesByDenomination[currentDenomination] -= sumToWithdraw / currentDenomination;
                    return true;
                }

                return false;
            }

            for (int count = 1; count <= currentDenominationInAtm; count++)
            {
                int remainder = sumToWithdraw - count * currentDenomination;
                if (WithdrawMoneySomehow(remainder, userName, currentDenominationIndex - 1))
                {
                    banknotesByDenomination[currentDenomination] -= count;
                    return true;
                }
            }

            return WithdrawMoneySomehow(sumToWithdraw, userName, currentDenominationIndex - 1);
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

        public static int FindBanknotesCount(int denomination)
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
