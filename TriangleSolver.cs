using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFarooqiA2
{
    public class TriangleSolver
    {
        static string message;

        public static string Analyze(int side1, int side2, int side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                return "Side cannot be negative. Please try again";

            }

            if (side1 == 0 || side2 == 0 || side3 == 0)
            {
                return "Side cannot be 0. Please try again";

            }

            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                message = "This forms a triangle. \n\n";

                if (side1 == side2 && side2 == side3)
                {
                    message += "This is an equilateral triangle.\n";
                    return message;
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    message += "This is an isosceles triangle.\n";
                    return message;
                }
                else
                {
                    message += "This is a scalene triangle.\n";
                    return message;
                }
            }
            else
            {
                return "This doesn't form a triangle";
            }
        }
    }
}
