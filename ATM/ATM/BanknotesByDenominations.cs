using System.Collections.Generic;

namespace ATM
{
    public class BanknotesByDenominations
    {
        private const int R10 = 10;
        private const int R50 = 50;
        private const int R100 = 100;
        private const int R200 = 200;
        private const int R500 = 500;
        private const int R1000 = 1000;
        private const int R2000 = 2000;
        private const int R5000 = 5000;
        
        private int r10count, r50count, r100count, r200count, r500count, r1000count, r2000count, r5000count;

        public BanknotesByDenominations(
            int r10count, 
            int r50count, 
            int r100count,
            int r200count,
            int r500count, 
            int r1000count, 
            int r2000count, 
            int r5000count
            )
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
        /// Показываем сумму, которую пользователь планирует внести или снять
        /// </summary>
        /// <returns></returns>
        public int GetPlanSumToAddOrWithdraw() =>
            r10count * R10 +
            r50count * R50 +
            r100count * R100 +
            r200count * R200 +
            r500count * R500 +
            r1000count * R1000 +
            r2000count * R2000 +
            r5000count * R5000;

        /// <summary>
        /// Получить общее количество банкнот, планируемых к внесению или снятию
        /// </summary>
        public int GetTotalBanknotesCount()
        {
            return r10count + r50count + r100count + r200count + r500count + r1000count + r2000count + r5000count;

        }

        public Dictionary<int, int> GetCountByDenominations() => new Dictionary<int, int>
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
    }
}
