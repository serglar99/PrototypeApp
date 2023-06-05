using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace PrototypeApp.ViewModel.Commands
{
    public class IntRangeRule : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public IntRangeRule()
        {
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int mark = 0;

            try
            {
                if (((string)value).Length > 0)
                    mark = Int32.Parse((String)value);
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
