using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteRational
{
    public class Rational
    {
        public int num;
        public int denom;
        public Rational()
        {
            this.num = 0;
            this.denom = 1;
        }
        public Rational(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }
        public static void WriteRational(Rational x)
        {
            Console.Write(x.num);
            Console.Write("/");
            Console.Write(x.denom);
            Console.WriteLine();
           
        }
        //reverse signs
        public void Negate()
        {
            this.num = -this.num;
        }

        //swap numerator and denominator
        public void Invert()
        {
            int temp = this.num;
            this.num = this.denom;
            this.denom = temp;
        }

        //converts to double
        public double ToDouble()
        {
            return Convert.ToDouble(this.num) / Convert.ToDouble(this.denom);
        }

        //find GCD
        public static int GCD(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return GCD(n2, n1 % n2);
            }
        }

        //reduce to lowest terms
        public Rational Reduce()
        {
            int gcd = GCD(this.num, this.denom);
                return new Rational(this.num/gcd, this.denom/gcd);
        }

        //adds two rationals
        public static Rational Add(Rational d, Rational i)
        {
            Rational sum = new Rational(d.num * i.denom + i.num * d.denom, d.denom * i.denom);
            return sum.Reduce();

        }
        public static void Main(string[] args)
        {
            Rational x = new Rational(5,6);
            Rational.WriteRational(x);
            x.Negate();
            Rational.WriteRational(x);
           
            Rational y = new Rational(4,2);
            y.Invert();
            Rational.WriteRational(y);

            Rational z = new Rational(7, 3);
            z.ToDouble();
            Console.WriteLine(z.ToDouble());

            y.Reduce();
            Rational.WriteRational(y.Reduce());

            Rational d = new Rational(4, 6);
            Rational i = new Rational(8, 4);
            Rational.WriteRational(Rational.Add(d,i));
        }
        }
}