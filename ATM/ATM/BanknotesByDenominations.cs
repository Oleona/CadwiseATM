using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    public class BanknotesByDenominations
    {
        public Dictionary<int, int> CountByDenominations { get; private set; }

        public BanknotesByDenominations(Dictionary<int, int> countByDenominations)
        {
            this.CountByDenominations = countByDenominations;
        }

        /// <summary>
        /// Показываем сумму, которую пользователь планирует внести или снять
        /// </summary>
        /// <returns></returns>
        public int PlanSumToAddOrWithdraw => CountByDenominations.Sum(b => b.Key * b.Value);

        /// <summary>
        /// Получить общее количество банкнот, планируемых к внесению или снятию
        /// </summary>
        public int TotalBanknotesCount => CountByDenominations.Sum(b => b.Value);
    }
}
