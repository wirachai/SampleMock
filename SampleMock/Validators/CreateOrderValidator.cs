using SampleMock.Interfaces;
using SampleMock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMock.Validators
{
    public class CreateOrderValidator : IValidator
    {
        public List<OrderItemModel> Items { get; set; }
        public bool IsValid { get; set; }

        public CreateOrderValidator(List<OrderItemModel> items)
        {
            Items = items;
        }

        public void Validate()
        {
            // some validation

            IsValid = true;
        }
    }
}
