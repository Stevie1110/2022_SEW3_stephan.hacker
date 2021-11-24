using System;

namespace _11Pythagoras
{
    public class Pythagoras
    {
        public static double calculateHypothenuse(decimal A, decimal B)
        {
            return Math.Sqrt((double)((A * A) + (B * B)));
        }

        public static double calculateCathetus(decimal A, decimal C)
        {
            return Math.Sqrt((double)(C * C - A * A));
        }

        public static double calculateAreaKK(decimal A, decimal B)
        {
            return (double)(A * A / 2);
        }

        public static double calculateAreaKH(decimal A, decimal C)
        {
            return (double)(A * (decimal)calculateCathetus(A, C)) / 2;
        }

        public static double calculateCircumstanceKK(decimal A, decimal B)
        {
            return (double)(A + B + (decimal)calculateHypothenuse(A, B));
        }

        public static double calculateCircumstanceKH(decimal A, decimal C)
        {
            return (double)(A + (decimal)calculateCathetus(A, C) + C);
        }

        public static double calculateCircumstance(decimal A, decimal B, decimal C)
        {
            return (double)(A + B + C);
        }
    }
}
