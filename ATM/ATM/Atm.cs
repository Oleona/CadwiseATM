using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        private static string stringDate;
        private static string AtmNumber = "ATM № 123456/1122";
        private static int maxBanknotesCapacity = 150;
        private static int r10 = 10;
        private static int r50 = 50;
        private static int r100 = 100;
        private static int r200 = 200;
        private static int r500 = 500;
        private static int r1000 = 1000;
        private static int r2000 = 2000;
        private static int r5000 = 5000;
        private int r10count, r50count, r100count, r200count, r500count, r1000count, r2000count, r5000count;


        public struct MoneyAdd
        {
            private int v1;
            private int v2;

            public MoneyAdd(int v1, int v2) : this()
            {
                this.v1 = v1;
                this.v2 = v2;
            }

        }

        public int GetMaxBanknotesCapasity()
        {
            return maxBanknotesCapacity;
        }

        
        public ATM(int r10count, int r50count, int r100count, int r200count, int r500count, int r1000count, int r2000count, int r5000count)
        {
            this.r10count = r10count;
            this.r50count = r50count;
            this.r100count = r100count;
            this.r200count = r200count;
            this.r500count = r500count;
            this.r1000count = r1000count;
            this.r2000count = r2000count;
            this.r5000count = r5000count;
        }


        /// <summary>
        /// Показываем пользователю сколько он планирует положить на счет
        /// </summary>
        /// <returns></returns>
        public int GetPlanSummToAddIntoAcc()
        {
            ATM atm = new ATM(r10count, r50count, r100count, r200count, r500count, r1000count, r2000count, r5000count);
            return (atm.r10count * (ATM.r10) + atm.r50count * (ATM.r50) + atm.r100count * (ATM.r100) + atm.r200count * (ATM.r200) + atm.r500count * (ATM.r500) + atm.r1000count * (ATM.r1000) + atm.r2000count * (ATM.r2000) + atm.r5000count * (ATM.r5000));
        }

        /// <summary>
        /// Количество банкнот, которое планируется положить на счет
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public int GetPlanBancnotesCountInATM(string userName)
        {
            ATM atm = new ATM(r10count, r50count, r100count, r200count, r500count, r1000count, r2000count, r5000count);
            return (atm.r10count + atm.r50count + atm.r100count + atm.r200count + atm.r500count + atm.r1000count + atm.r2000count + atm.r5000count);

        }
        //public int GetBancnotesCount(Dictionary<int, int> allBanknotesInATM)
        //{
        //    int BancnotesCount = 0;
        //    foreach (KeyValuePair<int, int> k in allBanknotesInATM)
        //    {
        //        BancnotesCount += k.Value;
        //    }
        //    return BancnotesCount;
        //}


        
        public Dictionary<int, int> GetCountByDenominations()   //(Dictionary<int, int> allBanknotesStart)
        {
            ATM atm = new ATM(r10count, r50count, r100count, r200count, r500count, r1000count, r2000count, r5000count);
            Dictionary<int, int> temp = new Dictionary<int, int>
            {
                [10] = r10count,
                [50] = r50count,
                [100] = r100count,
                [200] = r200count,
                [500] = r500count,
                [1000] = r1000count,
                [2000] = r2000count,
                [5000] = r5000count
            };
            // Dictionary<int, int> allBanknotesInATM = allBanknotesStart.ToDictionary(orig => orig.Key, orig => orig.Value + temp[orig.Key]);

            //return allBanknotesInATM;
            return temp;
        }





        public string GetDate()
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            stringDate = String.Concat("Дата и время проверки ", "\n", curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            return (stringDate);
        }
        public string GetATMNumber()
        {
            return (AtmNumber);
        }


        public string GetmaxBanknotesCapacityToString()
        {

            return (String.Concat("\n", "Максимальное количество \r\nхранимых купюр  ", maxBanknotesCapacity.ToString()));
        }

    }
}
