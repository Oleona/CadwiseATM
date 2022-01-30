using System.Collections.Generic;

namespace ATM
{
    /// <summary>
    /// Номиналы купюр
    /// </summary>
    public static class Denominations
    {
        public const int R10 = 10;
        public const int R50 = 50;
        public const int R100 = 100;
        public const int R200 = 200;
        public const int R500 = 500;
        public const int R1000 = 1000;
        public const int R2000 = 2000;
        public const int R5000 = 5000;


        /// <summary>
        /// Список номиналов купюр
        /// </summary>
        public static List<int> AllDenominations { get; private set; } 
            = new() { R5000, R2000, R1000, R500, R200, R100, R50, R10 };
    }




}
