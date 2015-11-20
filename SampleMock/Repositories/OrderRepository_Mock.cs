using SampleMock.Interfaces;
using SampleMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMock.Repositories
{
    public class OrderRepository_Mock : IOrderRepository
    {
        public bool IsSaved { get; set; }
        public void Add(List<OrderItemModel> items)
        {
            IsSaved = true;
        }
    }
}
