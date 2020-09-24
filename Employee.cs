using System;

namespace Laboration2
{
    public class Employee : AbstractEmployee, IEmployee
    {
        private new string Name;
        private new string Occupation;
        public string GetName()
        {
            return this.Name;
        }
        public string GetOccupation()
        {
            return this.Occupation;
        }
    }
}
