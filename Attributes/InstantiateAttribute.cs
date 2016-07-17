using System;

namespace Attributes
{
    // Should be applied to classes only.
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class InstantiateUserAttribute : Attribute
    {
        public InstantiateUserAttribute() { }

        public InstantiateUserAttribute(string firstName, string lastName)
        {

        }

        public InstantiateUserAttribute(int id, string firstName, string lastName)
        {

        }

    }
}
