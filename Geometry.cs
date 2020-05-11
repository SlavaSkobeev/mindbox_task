using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /* класс для планиметрических фигур*/
    public static class Planimetry
    {
        /*площадь круга*/
        public static double Circle(double radius)
        {
            double area= Math.Pow(radius, 2) * Math.PI;
            return radius>=0 ? area : -1;
        }

        /*поиск площади трегольника по формуле Герона*/
        public static double Triangle(double side_one, double side_two, double side_three)
        {
            double halfPerimetr = (side_one + side_two + side_three) / 2; //нахождение полупериметра
            double tempArea = halfPerimetr * (halfPerimetr - side_one) * (halfPerimetr - side_two) * (halfPerimetr - side_three);
            
            return Planimetry.isPositive(side_one, side_two, side_three) &&
                   Planimetry.checkTriagle(side_one, side_two, side_three) ? Math.Sqrt(tempArea) : -1;
        }

        /*проверка на полодительную длину сторон любой фигуры*/
        private static bool isPositive(params double[] list)
        {
            foreach(var elem in list)
            {
                if (elem < 0)
                    return false;
            }
            return true;

        }

        /*проверка на существование треугольника*/
        private static bool checkTriagle(double oneS, double twoS, double threeS)
        {
            return (oneS < twoS + threeS) && (twoS < oneS + threeS) && (threeS < oneS + twoS) ? true : false;
        }

        /*проверка трегольника на прямоугольность*/
        public static bool IsRightTriagle(double side_one, double side_two, double side_three)
        {
            bool right = (side_one * side_one + side_two * side_two == side_three * side_three) ||
                         (side_three * side_three + side_two * side_two == side_one * side_one) ||
                         (side_one * side_one + side_three * side_three == side_two * side_two);

            return Planimetry.isPositive(side_one, side_two, side_three) &&
                   Planimetry.checkTriagle(side_one, side_two, side_three) && right ? true : false;
        }

        /*вычисление площади без знания типа фигуры*/
        public static double UnknowFigure(params double[] list)
        {
            switch (list.Length)
            {
                case 1:
                    return Planimetry.Circle(list[0]);
                case 3:
                    return Planimetry.Triangle(list[0], list[1], list[2]);
                default: return -1;
            }
        }
    }
}
