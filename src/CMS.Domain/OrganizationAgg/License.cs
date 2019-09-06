namespace CMS.Domain.Aggregates.OrganizationAgg
{
    #region using namespaces
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    [Serializable]
    public class License : Entity
    {
        /// <summary>
        /// Row Version
        /// </summary>
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// Organization Identifier
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Max project number
        /// </summary>
        public int? MaxProjectNum { get; set; }

        /// <summary>
        /// Max virtual machine number
        /// </summary>
        public int? MaxActiveVMNum { get; set; }

        /// <summary>
        /// Expiration time.
        /// </summary>
        public DateTime? Expire { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
