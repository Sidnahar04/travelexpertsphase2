using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_experts_phase_2
{
    public class Validator
    {
        public static bool IsNotEmpty(string value, string fieldName, Control control)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"{fieldName} is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        //Checking if the field postive or not.
        public static bool IsPositiveDecimal(string value, string fieldName, Control control)
        {
            if (!decimal.TryParse(value, out decimal result) || result < 0)
            {
                MessageBox.Show($"{fieldName} must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        //Checking if the date field and making it a valid format.
        public static bool IsValidDate(string value, string fieldName, Control control)
        {
            if (!DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show($"{fieldName} must be a valid date in the format yyyy-MM-dd like 2024-12-10.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool IsCommissionValid(decimal baseprice,decimal commission,Control control)
        {
            if (commission > baseprice)
            {
                MessageBox.Show("Agency Commission cannot be greater than base price.","Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool AreDatesValid(DateTime startDate, DateTime endDate, Control control)
        {
            if (endDate <= startDate)
            {
                MessageBox.Show("Package End Date must be later than Package Start Date.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        public static bool CheckCharacterLimit(string fieldName, int maxLength, string value, Control control)
        {
            if (value.Length > maxLength)
            {
                MessageBox.Show($"{fieldName} must not exceed {maxLength} characters.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }
    }
}
