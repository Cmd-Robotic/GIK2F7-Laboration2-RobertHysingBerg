using System;

namespace Laboration2
{
    public class Organization : AbstractOrganization, IOrganization
    {
        private new string Name;
        private new string Address;
        private new int OrgNr;
        private new string OrgUrl;
        public string GetName()
        {
            return this.Name;
        }
        public string GetAddress()
        {
            return this.Address;
        }
        public int GetOrgNr()
        {
            return this.OrgNr;
        }
        public string GetOrgUrl()
        {
            return this.OrgUrl;
        }
    }
}
