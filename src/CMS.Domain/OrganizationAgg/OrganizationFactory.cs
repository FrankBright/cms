using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Aggregates.OrganizationAgg
{
    public static class OrganizationFactory
    {
        public static Organization CreateOrganization(Guid organizationId,
            string organizationName,
            int maxProjectCount,
            int maxRunningVMCount,
            int maxAvailableVMCount,
            string siteId,
            string customerIdentifier,
            string contentRepositoryHostId,
             int RemainingHours,
            int OverageHours,
            int SessionCores,
            int UserCount,
            string CC,
            string BCC
            )
        {
            var organization = new Organization()
            {
                MaxAvailableVMCount = maxAvailableVMCount,
                MaxProjectCount = maxProjectCount,
                MaxRunningVMCount = maxRunningVMCount,
                OrganizationName = organizationName,
                SiteId = siteId,
                CustomerIdentifier = customerIdentifier,
                ContentRepositoryHostId = contentRepositoryHostId,
                 RemainingHours= RemainingHours,
                 OverageHours= OverageHours,
                 SessionCores= SessionCores,
                 UserCount= UserCount,
                 CC=CC,
                 BCC=BCC

            };
            organization.ChangeCurrentIdentity(organizationId);
            return organization;
        }

    }
}
