using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace SplitDateDemo
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString SplitValidationMessageFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            var metadata = ModelMetadata.FromLambdaExpression(expression, helper.ViewData);

            if (typeof(TProperty) == typeof(DateTime?))
            {
                var dayValidator = helper.ValidationMessage(metadata.PropertyName + ".Day", "Day is required").ToString();
                var monthValidator = helper.ValidationMessage(metadata.PropertyName + ".Month", "Month is required").ToString();
                var yearValidator = helper.ValidationMessage(metadata.PropertyName + ".Year", "Year is required").ToString();

                return new MvcHtmlString(dayValidator + monthValidator + yearValidator);
            }
            return null;
        }
    }
}