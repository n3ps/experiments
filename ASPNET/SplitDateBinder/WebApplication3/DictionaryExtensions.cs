using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SplitDateDemo
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Given a dictionary, add values to this dictionary overwriting if required
        /// </summary>
        /// <returns>The dictionary, augmented with the values in the additional dictionary</returns>
        public static IDictionary<string, object> AugmentDictionary(this IDictionary<string, object> thisDictionary,
            IDictionary<string, object> additionalDictionary, bool overwriteValues)
        {
            if (thisDictionary == null) throw new ArgumentNullException("thisDictionary");

            var result = new Dictionary<string, object>(thisDictionary);

            if (additionalDictionary == null) return result;

            foreach (var v in additionalDictionary)
            {
                if (!result.ContainsKey(v.Key))
                {
                    result.Add(v.Key, v.Value);
                }
                else if (overwriteValues)
                {
                    result[v.Key] = v.Value;
                }
            }

            return result;
        }

        /// <summary>
        /// Given an object of key/value pairs, add values to this dictionary overwriting if required
        /// </summary>
        /// <returns>The dictionary, augmented with the values in the additional attributes</returns>
        public static IDictionary<string, object> AugmentDictionary(this IDictionary<string, object> thisDictionary,
            object additionalAttributes, bool overwriteValues)
        {
            return thisDictionary.AugmentDictionary(HtmlHelper.AnonymousObjectToHtmlAttributes(additionalAttributes), overwriteValues);
        }
    }
}