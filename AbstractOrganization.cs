using System;
using System.Collections.Generic;

namespace Laboration2
{
    public abstract class AbstractOrganization
    {
        protected string Name;
        protected string Address;
        protected int OrgNr;
        protected string OrgUrl;
        protected List<AbstractDivision> Divisions;
    }
}
