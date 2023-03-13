using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public interface IMoneyPrinter
    {
        public string PrintMoney();
    }

    // Single Responsibility Principle - 
    // This class does only operations which are connected to the money,
    // it contains only two fields, which describe integer and decimal part of money
    // and 4 methods which are implemented to change fields
    // Open-Closed Principle - this class is abstract, so it can not have instance, so it can be extended
    // by inheritence and extension method C# functionality
    // Liskov-Substitution Principle - C# automatically implements this SOLID principle, derived class
    // always has functionality of parent class
    // Interface Sergregation Principle - instances of this abstract class (Hryvnia, Dollar) implement
    // IMoneyPrinter interface, which needed only for get class instance string, this interface does not make
    // classes implement useless methods

    public abstract class Money
    {
        public int IntegerPart { get; set; }

        public decimal DecimalPart { get; set; }   

        public Money(int integerPart, decimal decimalPart)
        {
            this.IntegerPart = integerPart;
            this.DecimalPart = decimalPart;
        }
    }

    public class Hryvnia : Money, IMoneyPrinter
    {
        public Hryvnia(int integerPart, decimal decimalPart) : base(integerPart, decimalPart)
        {
        }

        public string PrintMoney()
        {
            return $"Integer part of hryvnia is - {this.IntegerPart}, decimal part - {this.DecimalPart}";
        }
    }

    public class Dollar : Money, IMoneyPrinter
    {
        public Dollar(int integerPart, decimal decimalPart) : base(integerPart, decimalPart)
        {
        }

        public string PrintMoney()
        {
            return $"Integer part of dollar is - {this.IntegerPart}, decimal part - {this.DecimalPart}";
        }
    }
}
