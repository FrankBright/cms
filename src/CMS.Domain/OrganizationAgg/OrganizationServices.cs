using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Aggregates.OrganizationAgg
{
    [Serializable]
    public class OrganizationServices : Entity, IValidatableObject
    {
        public Guid ServicesId { get; set; }

        public Guid OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        /// <summary>
        /// Subscriber services
        /// </summary>

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //todo
            return null;
            //var validationResults = new List<ValidationResult>();
            //if (validationContext != null)
            //{
            //    var orgService = validationContext.ObjectInstance as OrganizationServices;
            //    if (orgService.ServicesId.Equals(Guid.Empty))
            //    {
            //        validationResults.Add(new ValidationResult(Messages.ResourceManager.GetCodeMsg(nameof(Messages.MessageID_40154_OrganizationServicesServicesIdNotNull))));
            //    }
            //    if (orgService.OrganizationId.Equals(Guid.Empty))
            //    {
            //        validationResults.Add(new ValidationResult(Messages.ResourceManager.GetCodeMsg(nameof(Messages.MessageID_40155_OrganizationServicesOrganizationIdNotNull))));
            //    }
            //}
            //else
            //{
            //    validationResults.Add(new ValidationResult(Messages.ResourceManager.GetCodeMsg(nameof(Messages.MessageID_40153_OrganizationServicesNotNull))));
            //}
            //return validationResults;
        }
    }
}
