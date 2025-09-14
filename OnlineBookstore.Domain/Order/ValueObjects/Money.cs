using OnlineBookstore.Common;
using OnlineBookstore.Domain.Order.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.Order.ValueObjects
{
    public class Money : ValueObject
    {
        public readonly Currency Currency;
        public readonly decimal Amount;

        public Money(Currency currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Amount.ToString("C", GetCurrencyCulterInfo(Currency))}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var other = (Money)obj;




            return base.Equals(obj);
        }

        private static CultureInfo GetCurrencyCulterInfo(Currency currency) => currency switch
        {
            Currency.UsDollar => new CultureInfo("en-US"),
            Currency.Euro => new CultureInfo("fr-FR"),
            Currency.Yen => new CultureInfo("ja-JP"),
            Currency.PhilippinesPeso => new CultureInfo("en-PH"),
            _ => throw new ArgumentOutOfRangeException(nameof(currency))
        };

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
