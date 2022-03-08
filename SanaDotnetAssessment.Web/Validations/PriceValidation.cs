using SanaDotnetAssessment.Web.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanaDotnetAssessment.Web.Validations
{
    public class PriceValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (Product)validationContext.ObjectInstance;

            return (product.Price > 0)
                ? ValidationResult.Success
                : new ValidationResult("The price cannot be 0 or less.");

        }
    }
}