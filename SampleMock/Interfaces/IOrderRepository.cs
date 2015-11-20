using SampleMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMock.Interfaces
{
    public interface IOrderRepository
    {
        void Add(List<OrderItemModel> items);
    }
}
