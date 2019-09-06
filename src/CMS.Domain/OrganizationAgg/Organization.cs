namespace CMS.Domain.Aggregates.OrganizationAgg
{
    #region using namespaces
    using CMS.Domain.Aggregates.AccountAgg;
    using CMS.Domain.Aggregates.NetAgg;
    using CMS.Domain.Aggregates.ProjectAgg;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Resources;

    #endregion

    [Serializable]
    public class Organization : Entity, IValidatableObject
    {

        /// <summary>
        /// Organization Name
        /// </summary>
        public string OrganizationName { get; set; }

        public string ParentId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}