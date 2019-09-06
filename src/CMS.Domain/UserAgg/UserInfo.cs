using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.UserAgg
{
    public class UserInfo : Entity, IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Age { get; set; }

        public string Sex { get; set; }

        public string MobilePhoneNumber { get; set; }
    }
}