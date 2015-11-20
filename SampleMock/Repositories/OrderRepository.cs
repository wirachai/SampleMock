using SampleMock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMock.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(List<Models.OrderItemModel> items)
        {
            // save data to database
        }
    }
}
