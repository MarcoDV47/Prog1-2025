using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Address? HomeAddress { get; set; }
        public Address? WorkAddress { get; set; }

        public static int InstanceCount = 0;
        public int ObjectCount = 0;

        public bool Validate()
        {
            bool isValid = true;

            isValid = 
                !string.IsNullOrEmpty(Name) &&
                this.Id > 0 &&
                HomeAddress != null &&
                WorkAddress != null;

            return isValid;
        }
    }
}
