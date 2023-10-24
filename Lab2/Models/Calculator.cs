using System.Security.Cryptography.X509Certificates;

namespace Lab2.Models
{
    public class Calculator
    {
        public Operators Operator { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double a { get; set; }
        public double b { get; set; }

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.Add: return (double)(x + y);
                case Operators.Sub: return (double)(x - y);
                case Operators.Mul: return (double)(x * y);
                case Operators.Div: return (double)(x / y);
                default: return double.NaN;


            }
        }
            public  bool IsValid()
            {
                return Operator != null && x != null && y != null;
            }

        }
    }
