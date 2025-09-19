using System;
namespace Lab1
{
    public class Green
    { 
        public bool Task1(double d)
        {
            bool answer = false;

            if (Math.Abs(d)>= 1)
            {
                answer = true;
            }

            return answer;
        }
        
        public bool Task2(double d, double f)
        {
            bool answer = false;

            if ((d+f)/2 > 0)
            {
                answer = true;
            }

            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (a+b>(Math.Abs(a)+Math.Abs(b))/2)
            {
                answer = true;
            }

            return answer;
        }
  
        public int Task4(int a, int b, int c)
        {
            int answer = c;
            

            if (a >= b && a >= c)
            {
                answer = a;
            }
            if (b >= a && b >= c)
            {
                answer = b;
            }
            

            return answer;
        }
        
        public double Task5(double x)
        {
            double answer = 0;

            if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x,2)-1;
            }

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

             if (x < 0)
            {
                answer = (y > 0) && (y <= 1 + x) && (x >= -1);
            }
            else
            {
                answer = (y > 0) && (y <= 1 - x) && (x <= 1);
            }

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            if (n<0)
            {
                answer = false;
            }
            else
            {
                if (n%2==0)
                {
                    answer = false ;
                }
                
            }

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            return answer;
        }
        static void Main()
        {
            Green green = new Green();
