using SampleMock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleMock.Validators
{
    public class Validator_Stub : IValidator
    {

        public bool IsValid { get; set; }

        public void Validate()
        {
            
        }
    }
}
