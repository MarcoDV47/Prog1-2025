using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Address
    {
        #region Atributos
        public int Id { get; set; }
        public string? StreetLine1 { get; set; }
        public string? StreetLine2 { get; set; }
        public string? City { get; set; }
        public string? StateOrProvince { get; set; }
        public int PostalCode { get; set; }
        public string? Country { get; set; }
        public string? AddressType { get; set; }
        public string? ShippingAddress { get; set; }
        #endregion

        public bool Validate()
        {
            bool isValid = true;

            isValid = this.Id > 0 &&
            !string.IsNullOrEmpty(StreetLine1) &&
            !string.IsNullOrEmpty(StreetLine2) &&
            !string.IsNullOrEmpty(City) &&
            !string.IsNullOrEmpty(StateOrProvince) &&
            !string.IsNullOrEmpty(Country) &&
            !string.IsNullOrEmpty(AddressType) &&
            !string.IsNullOrEmpty(ShippingAddress);

            return isValid;
        }
    }
}
