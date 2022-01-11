﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.structs
{
    public struct Address
    {
        public string Street;
        public string City;
        public string PostalCode;
        public string Province;

        public Address(string street, string city, string province, string postalCode)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Province = province;
        }

        public override string ToString()
        {
            return $"Street: {Street}, City: {City}, Province: {Province}, Postal Code: {PostalCode}\n";
        }
    }
}
