using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    partial class GameState
    {
        public void SetGameObjects()
        {
            this.Places = (List<Place>)GetPlaces();
            this.Containers = (List<Container>)GetContainers();
            this.Gravestones = (List<Attribute>)GetGravestones();
            this.Wreaths = (List<Attribute>)GetWreaths();
            this.Services = (List<Attribute>)GetServices();
            this.Customers = (List<Customer>)GetCustomers();
            this.CustomerOrdersToday = (List<CustomerOrder>)GetOrders(Day);
        }

        //Add objects here
        private IEnumerable<Customer> GetCustomers()
        {
            yield break;
        }

        private IEnumerable<CustomerOrder> GetOrders(int day)
        {
            switch (day)
            {
                case 0:
                    yield return new CustomerOrder(Customers[0]);
                    break;
            }
            yield break;
        }

        private IEnumerable<Place> GetPlaces()
        {
            yield break;
        }

        private IEnumerable<Container> GetContainers()
        {
            yield break;
        }

        private IEnumerable<Attribute> GetGravestones()
        {
            yield break;
        }

        private IEnumerable<Attribute> GetWreaths()
        {
            yield break;
        }

        private IEnumerable<Attribute> GetServices()
        {
            yield break;
        }
    }
}
