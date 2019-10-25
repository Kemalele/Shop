using System;
using System.Collections.Generic;
using System.Text;
namespace Shop.Services
{
    public class CodeGenerator
    {
        public string Generate()
        {
            var diapasonMinValue = 100000;
            var diapasonMaxValue = 999999;
            var random = new Random();
            var code = random.Next(diapasonMinValue, diapasonMaxValue);
            var result = code.ToString();
            return result;
        }
    }
}
