using System.Collections.Generic;

namespace geopost.Models.UmbracoIdentity
{
    public class RoleManagementModel
    {
        public IEnumerable<string> AvailableRoles { get; set; }
        public IEnumerable<string> AssignedRoles { get; set; }
    }
}
