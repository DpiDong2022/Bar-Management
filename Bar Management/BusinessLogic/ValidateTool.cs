using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Bar_Management.BusinessLogic {
    public class ValidateTool {
        public static bool TryValidateObject<T>(T obj, out ICollection<ValidationResult> results) {
            var context = new ValidationContext(obj, null, null);
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, context, results);
        }

        public static bool TryValidateProperty<T>(object obj, object value, string propertyName, out string error) {
            var context = new ValidationContext(obj, serviceProvider: null, items: null)
            {
                MemberName = propertyName
            };

            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateProperty(value, context, results);
            if(!isValid) {
                error = results[0].ErrorMessage;
            } error = null;
            return isValid;
        }
    }
}
