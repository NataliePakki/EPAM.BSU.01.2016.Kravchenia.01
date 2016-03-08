using System;

namespace Task1{
    public static class Calculator{
        public static double RootNewtonMethod(double number, int n, double eps){
            if (number < 0 || n < 0)
                return Double.NaN;
            double xk1 = number / n;
            double xk;
            do{
                xk = xk1;
                xk1 = ((n - 1) * xk + number / Math.Pow(xk, n - 1)) / n;
            } while (Math.Abs(xk - xk1) > eps);
            return xk1;
        }
    }
}
