using System;
using System.Collections.Generic;

namespace Laboration2
{
    public class Organization : AbstractOrganization, IOrganization
    {
        private new string Name;
        private new string Address;
        private new int OrgNr;
        private new string OrgUrl;
        // private List<Division> Divisions;
        public Organization(string Name, string Address, int OrgNr, string OrgUrl, List<AbstractDivision> Divisions)
        {
            this.Name = Name;
            this.Address = Address;
            this.OrgNr = OrgNr;
            this.OrgUrl = OrgUrl;
            this.Divisions = Divisions;
        }
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
        public List<AbstractDivision> GetDivisions()
        {
            return this.Divisions;
        }
    }
}
