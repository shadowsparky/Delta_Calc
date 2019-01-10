using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaBestCalc
{
    class MainModel : IMainModel
    {
        public string ComputeValue(string value)
        {
            return ModbusAddress(value);
        }

        
        private string ModbusAddress(string value)
        {
            string result = ""; 
            try
            {
                var intValue = Int32.Parse(value);
                var convert = new Converter();
                result = convert.CheckValue(intValue);
            }
            catch (FormatException ex)
            {
                result = "Parse error";
                Logger.Print(" Parse exception: " + ex + " ");
            }
            return result;
        }

        private void DeltaAddress(string value)
        {
            var register = value[0].ToString().ToUpper();
            if (register == "S")
            {

            }
            else if (register == "D")
            {

            }
            else if (register == "X")
            {

            }
            else if (register == "Y")
            {

            }
            else if (register == "T")
            {

            }
            else if (register == "M")
            {

            }
            throw new NotImplementedException();
        }
    }
}
