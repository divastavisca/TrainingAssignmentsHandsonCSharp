﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary
{
    public class Address
    {
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }

        /// <summary>
        /// Get the complete mailing address
        /// </summary>
        /// <returns></returns>
        ///
        public override string ToString()
        { 
            return (this.HouseNo + ", " + this.Street + ", " + this.City + ", " + this.PinCode);
        }

        /// <summary>
        /// Set House No
        /// </summary>
        /// <param name="hNo"></param>
        public void SetHouseNo(string hNo)
        {
            HouseNo = hNo;
        }

        /// <summary>
        /// Set Street
        /// </summary>
        /// <param name="street"></param>
        public void SetStreet(string street)
        {
            Street = street;
        }

        /// <summary>
        /// Set City
        /// </summary>
        /// <param name="city"></param>
        public void SetCity(string city)
        {
            City = city;
        }

        /// <summary>
        /// Set Pincode
        /// </summary>
        /// <param name="pinCode"></param>
        public void SetPinCode(int pinCode)
        {
            PinCode = pinCode;
        }
    }
}