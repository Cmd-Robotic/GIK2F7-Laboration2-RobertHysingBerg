using System;

namespace Laboration2
{
    public interface IOrganization
    {
        string GetName();
        string GetAddress();
        int GetOrgNr();
        string GetOrgUrl();
    }
}
