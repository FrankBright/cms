using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Aggregates.OrganizationAgg
{
    public static class OrganizationServicesFactory
    {
        public static OrganizationServices CreateOrganizationServices(Guid id,
            Guid servicesId,
            Guid organizationId)
        {
            var orgServices = new OrganizationServices()
            {
                ServicesId = servicesId,
                OrganizationId = organizationId
            };
            orgServices.ChangeCurrentIdentity(id);
            return orgServices;
        }
    }
}
