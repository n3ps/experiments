using System;
using System.Globalization;
using System.Web.Mvc;

namespace SplitDateDemo
{
    public class SplitDateBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var day = GetValue(bindingContext, "Day");
            var month = GetValue(bindingContext, "Month");
            var year = GetValue(bindingContext, "Year");

            var dateString = String.Format("{0}/{1}/{2}", day, month, year);

            DateTime date;
            if (DateTime.TryParseExact(dateString, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                return date;
            }
            else
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Please specify a valid date");
                
                return null;
            }
        }

        private string GetValue(ModelBindingContext bindingContext, string key)
        {
            var result = bindingContext.ValueProvider.GetValue(bindingContext.ModelName + "." + key);
            
            if (result != null) return result.AttemptedValue;

            return null;
        }
    }
}