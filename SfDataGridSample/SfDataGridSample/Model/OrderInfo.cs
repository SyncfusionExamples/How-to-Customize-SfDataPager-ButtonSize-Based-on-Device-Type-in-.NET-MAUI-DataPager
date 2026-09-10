using System;
using System.Collections.Generic;
using System.Text;

namespace SfDataGridSample
{
    public class OrderInfo
    {
        private string? orderID;
        private string? customer;
        private string? city;
        private string? country;

        public string? OrderID
        {
            get { return orderID; }
            set { this.orderID = value; }
        }

        public string? Country
        {
            get { return country; }
            set { this.country = value; }
        }

        public string? Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public string? City
        {
            get { return city; }
            set { this.city = value; }
        }

        public OrderInfo(string orderId, string country, string customer, string City)
        {
            this.OrderID = orderId;
            this.Customer = customer;
            this.Country = country;
            this.City = City;
        }
    }
}
