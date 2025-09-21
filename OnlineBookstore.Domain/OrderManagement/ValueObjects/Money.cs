using OnlineBookstore.Common;
using OnlineBookstore.Domain.OrderManagement.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Domain.OrderManagement.ValueObjects
{
    public class Money(Currency currency, decimal amount) : ValueObject
    {
        public readonly Currency Currency = currency;
        public readonly decimal Amount = amount;

        public override string ToString()
        {
            return $"{Amount.ToString("C", GetCurrencyCulterInfo(Currency))}";
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
            return [Currency, Amount];
        }


        public static Money operator +(Money a, Money b)
        {
            ValidateCurrency(a, b);
            return new Money(a.Currency, a.Amount + b.Amount);
        }

        public static Money operator -(Money a, Money b)
        {
            ValidateCurrency(a, b);
            return new Money(a.Currency, a.Amount - b.Amount);
        }

        public static Money operator *(Money a, decimal factor)
        {
            return new Money(a.Currency, a.Amount * factor);
        }

        public static Money operator /(Money a, decimal divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return new Money(a.Currency, a.Amount / divisor);
        }

        private static void ValidateCurrency(Money a, Money b)
        {
            if (a.Currency != b.Currency)
            {
                throw new InvalidOperationException("Cannot subtract amounts with different currencies.");
            }
        }
    }
}
