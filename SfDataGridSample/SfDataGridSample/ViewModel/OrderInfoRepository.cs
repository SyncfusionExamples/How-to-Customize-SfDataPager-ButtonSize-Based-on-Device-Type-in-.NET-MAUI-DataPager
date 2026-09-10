using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace SfDataGridSample
{
    public class OrderInfoRepository
    {
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            string[] customerNames = {"Maria Anders", "Ana Trujillo", "Ant Fuller", "Thomas Hardy","Tim Adams", "Hanna Moos", "Andrew Fuller", "Martin King", "Lenny Lin"  };

            string[] countries = {"Germany", "Mexico", "UK", "Sweden", "France", "Spain" };

            string[] customerIDs = {"ALFKI", "ANATR", "ANTON", "AROUT", "BERGS", "BLAUS", "BLONP", "BOLID", "BONAP" };

            string[] cities = {"Berlin", "Mexico D.F.", "London", "Mannheim","Strasbourg", "Madrid", "Marseille" };

            for (int i = 1; i <= 100; i++)
            {
                orderInfo.Add(new OrderInfo(
                    (1000 + i).ToString(),
                    customerNames[(i - 1) % customerNames.Length],
                    countries[(i - 1) % countries.Length],
                    cities[(i - 1) % cities.Length]
                ));
            }
        }
    }
    
}
