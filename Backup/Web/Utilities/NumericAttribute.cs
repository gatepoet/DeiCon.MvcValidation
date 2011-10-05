using System.ComponentModel.DataAnnotations;

namespace MvcValidation.Web.Utilities
{
    public class NumericAttribute : RegularExpressionAttribute
    {
        private const string NumericPattern = @"^\d+$";
        public NumericAttribute() : base(NumericPattern) { }
    }
}