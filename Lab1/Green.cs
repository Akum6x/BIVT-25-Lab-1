using System.Xml.Schema;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d) >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double arf = (d +  f) / 2;
            answer = arf > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int sum = a + b;
            double am = (Math.Abs(a) + Math.Abs(b)) / 2.0;
            answer = sum > am;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(Math.Max(a, b), c);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            if (Math.Abs(x) <= 1)
            {
                answer = x * x - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (y < 0)
            {
                answer = false;
                return answer;
            }
            if (x < 0)
            {
                answer = y <= 1 + x;
            }
            else
            {
                answer = y <= 1 - x;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
            }
                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            if (X < 7)
            {
                return false;
            }
            int td = (X + 1) / 2;
            int ts = td * Y;

            answer = ts >= 240;
            // end

            return answer;
        }
    }
}
