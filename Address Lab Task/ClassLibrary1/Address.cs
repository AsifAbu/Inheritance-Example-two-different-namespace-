using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary1
{
    public class Address
    {
        string houseNo, roadNo, area, city;
        public Address(string houseno, string roadno, string area, string city)
        {
            this.houseNo = houseno;
            this.roadNo = roadno;
            this.area = area;
            this.city = city;
        }
        public Address(Address a)
        {
            this.houseNo = a.HouseNo;
            this.roadNo = a.RoadNo;
            this.area = a.Area;
            this.city = a.City;
        }
        public Address()
        {
            this.houseNo = "Default House Number";
            this.roadNo = "Default Road Number";
            this.area = "Default Area";
            this.city = "Default City";
        }
        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return houseNo; }
        }
        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return roadNo; }
        }
        public string Area
        {
            set { this.area = value; }
            get { return area; }
        }
        public string City
        {
            set { this.city = value; }
            get { return city; }
        }
        public string AddressReturn()
        {
            return "House " + HouseNo + ", Road " + RoadNo + ", " + Area + " Area ," + City + " City.";
        }

    }
}
