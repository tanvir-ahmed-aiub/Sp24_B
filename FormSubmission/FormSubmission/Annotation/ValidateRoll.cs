using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Annotation
{
    public class ValidateRoll : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;

            var roll = (int)value;
            if (roll > 0 && roll <= 40)
            {
                return true;
            }
            return false;
        }

    }
}