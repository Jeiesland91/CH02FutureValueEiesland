using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ch02FutureValueEiesland.Models
{
    public class FutureValueModel
    {
        [Required]
        [Range(1,500)]
        public decimal? MonthlyInvestment { get; set; }
        [Required]
        public decimal? YearlyInterestRate { get; set; }

        public int Years { get; set; }

        public decimal CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = YearlyInterestRate.Value / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment.Value) *
                              (1 + monthlyInterestRate);

            }
            return futureValue;
        }
    }
}
