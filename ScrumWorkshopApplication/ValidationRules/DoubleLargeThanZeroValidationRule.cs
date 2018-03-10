using System.Globalization;
using System.Windows.Controls;

namespace ScrumWorkshopApplication.ValidationRules
{
    public class DoubleLargeThanZeroValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double d;
            bool result = double.TryParse(value.ToString(), out d);
            if (result && d>0)
                return new ValidationResult(true, null);
            else
                return new ValidationResult(false, "Please enter correct value.");
        }
    }
}
