using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace PrototypeApp.ViewModel.Commands
{
    public class DoubleRangeRule : ValidationRule
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public DoubleRangeRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double mark = 0;

            try
            {
                if (((string)value).Length > 0)
                    mark = Double.Parse((String)value);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, $"Illegal characters or {e.Message}");
            }

            if ((mark < Min) || (mark > Max))
            {
                return new ValidationResult(false,
                  $"Введите значение в диапозоне: {Min}-{Max}.");
            }
            return ValidationResult.ValidResult;
        }
    }
}
