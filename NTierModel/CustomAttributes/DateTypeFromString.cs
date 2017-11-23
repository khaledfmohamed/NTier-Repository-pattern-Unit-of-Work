using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierModel.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property |
           AttributeTargets.Field, AllowMultiple = false)]
    class DateTypeFromStringAttribute : ValidationAttribute
    {
        public string DateFormate { get; set; }
        private DateTime dateField;
        
        public override bool IsValid(object value)
        {
            bool result = true;
            
            try
            {
                dateField = DateTime.ParseExact(value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch(Exception ex)
            {
                
                result = false;
                
            }
            
            // Add validation logic here.
            return result;
        }
       

    }
}
