using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LR7
{
    class Rational:IComparable<Rational>
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            set
            {
                numerator = value;
            }
            get
            {
                return numerator;
            }
        }
        public int Denominator
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка ввода");
                }
                else
                {
                    denominator = value;
                }
            }
            get
            {
                return denominator;
            }
        }
        public Rational(int n,int m)
        {
            this.Numerator = n;
            this.Denominator = m;
        }       
        public Rational(string str)
        {
            string pat = @"[-0-9]+";
            Regex regex = new Regex(pat, RegexOptions.IgnoreCase);
            Match m = regex.Match(str);
            if(m.Success)
            {
                this.Numerator = Convert.ToInt32(m.Value);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
            m = m.NextMatch();
            if (m.Success)
            {
                this.Denominator = Convert.ToInt32(m.Value);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
        public static Rational operator+(Rational a,Rational b)
        {
            Rational result = new Rational(1, 1);
            if(a.Denominator==b.Denominator)
            {
                result.Denominator = a.Denominator;
                result.Numerator = a.Numerator + b.Numerator;
            }
            else
            {
                result.Numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
                result.Denominator = a.Denominator*b.Denominator;

            }
            return result;
        }
        public static Rational operator-(Rational a, Rational b)
        {
            Rational result = new Rational(1, 1);
            if (a.Denominator == b.Denominator)
            {
                result.Denominator = a.Denominator;
                result.Numerator = a.Numerator - b.Numerator;
            }
            else
            {
                result.Numerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
                result.Denominator = a.Denominator * b.Denominator;

            }
            return result;
        }
        public static Rational operator*(Rational a,Rational b)
        {
            Rational result = new Rational(1, 1);
            result.Numerator = a.Numerator * b.Numerator;
            result.Denominator = a.Denominator * b.Denominator;
            return result;
        }
        public static Rational operator/(Rational a, Rational b)
        {
            Rational result = new Rational(1, 1);
            result.Numerator = a.Numerator * b.Denominator;
            result.Denominator = a.Denominator * b.Numerator;
            return result;
        }
        public static Rational operator ^(Rational a, int n)
        {
            Rational result = new Rational(1, 1);
            if (n > 0)
            {
                result.Numerator = (int)Math.Pow(a.Numerator, n);
                result.Denominator = (int)Math.Pow(a.Denominator, n);
            }
            else if (n < 0)
            {
                result.Numerator = (int)Math.Pow(a.Denominator, (-n));
                result.Denominator = (int)Math.Pow(a.Numerator, (-n));
            }
            else 
            {
                result.Numerator = 1;
                result.Denominator = 1;
            }
            return result;
        }
        public void Show()
        {
            Console.WriteLine("Рациональное число:");
            string str= this.Numerator+"/"+ this.Denominator;
            Console.WriteLine(str);
            str = "Числитель="+ this.Numerator+"."+"Знаменатель="+ this.Denominator+ ".";
            Console.WriteLine(str);
        }
        public int CompareTo(Rational a)
        {
            if (this.Numerator * a.Denominator < a.Numerator * this.Denominator)
            {
                return 1;
            }
            else if(this.Numerator * a.Denominator > a.Numerator * this.Denominator)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static bool operator <(Rational a, Rational b)
        {
            if(a.CompareTo(b)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Rational a, Rational b)
        {
            if (a.CompareTo(b) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Rational a, Rational b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Rational a, Rational b)
        {
            if (a.CompareTo(b) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Rational a, Rational b)
        {
            if (a.CompareTo(b) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Rational a, Rational b)
        {
            if (a.CompareTo(b) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static explicit operator int(Rational a)
        {
            return a.Numerator / a.Denominator;
        }
        public static explicit operator double(Rational a)
        {
            string result = "";
            int n=4;//длина дробной части числа
            result += (a.Numerator / a.Denominator);
            result +=",";
            if(a.Numerator>=0)
            {
                result += ((a.Numerator * (int)Math.Pow(10, n)) / a.Denominator) - (a.Numerator / a.Denominator) * (int)Math.Pow(10, n);
            }
            else
            {
                result += (((-1)*a.Numerator * (int)Math.Pow(10, n)) / a.Denominator) - ((-1)*a.Numerator / a.Denominator) * (int)Math.Pow(10, n);
            }
            return Convert.ToDouble(result);
        }
    }
}
