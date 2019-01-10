using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaBestCalc
{
    class Converter
    {
        public const int MIN_S_VALUE = 0;
        public const int MAX_S_VALUE = 1023;
        public const int MIN_X_VALUE = 1024;
        public const int MAX_X_VALUE = 1279;
        public const int MIN_Y_VALUE = 1280;
        public const int MAX_Y_VALUE = 1535;
        public const int MIN_T_VALUE = 1536;
        public const int MAX_T_VALUE = 1791;
        public const int MIN_M_VALUE = 2048;
        public const int MAX_M_VALUE = 3583;
        public const int MIN_M_VALUE_TWO = 43522;
        public const int MAX_M_VALUE_TWO = 46081;
        public const int MIN_C_VALUE = 3584;
        public const int MAX_C_VALUE = 3783;
        public const int MIN_C_VALUE_TWO = 3784;
        public const int MAX_C_VALUE_TWO = 3839;
        public const int MIN_D_VALUE = 4096;
        public const int MAX_D_VALUE = 8191;
        public const int MIN_D_VALUE_TWO = 32768;
        public const int MAX_D_VALUE_TWO = 40863;

        public string CheckValue(int value)
        {
            string result = "";
            if ((value >= MIN_S_VALUE) && (value <= MAX_S_VALUE))
            {
                result = "Value: S" + value.ToString(); 
                Logger.Print(result);
            }
            if ((value >= MIN_X_VALUE) && (value <= MAX_X_VALUE))
            {
                value -= MIN_X_VALUE;
                result = "Value: X" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_Y_VALUE) && (value <= MAX_Y_VALUE))
            {
                value -= MIN_Y_VALUE;
                result = "Value: Y" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_T_VALUE) && (value <= MAX_T_VALUE))
            {
                value -= MIN_T_VALUE;
                result = "Value: T" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_M_VALUE) && (value <= MAX_M_VALUE))
            {
                value -= MIN_M_VALUE;
                result = "Value: M" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_M_VALUE_TWO) && (value <= MAX_M_VALUE_TWO))
            {
                value -= MIN_M_VALUE_TWO;
                result = "Value: M" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_C_VALUE) && (value <= MAX_C_VALUE))
            {
                value -= MIN_C_VALUE;
                result = "Value: C" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_C_VALUE_TWO) && (value <= MAX_C_VALUE_TWO))
            {
                value -= MIN_C_VALUE_TWO - 200;
                result = "Value: C" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_D_VALUE) && (value <= MAX_D_VALUE))
            {
                value -= MIN_D_VALUE;
                result = "Value: D" + value.ToString();
                Logger.Print(result);
            }
            if ((value >= MIN_D_VALUE_TWO) && (value <= MAX_D_VALUE_TWO))
            {
                value -= MIN_D_VALUE_TWO;
                result = "Value: D" + value.ToString();
                Logger.Print(result);
            }
            return result;
        }
    }
}
