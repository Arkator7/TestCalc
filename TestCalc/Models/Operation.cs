using System.ComponentModel.DataAnnotations;

namespace TestCalc.Models
{
    public class Operation
    {
        [Display( Name = "First Number" )]
        public double FirstNumber { get; set; }

        [Display( Name = " Number" )]
        public double SecondNumber { get; set; }

        [Display( Name = "Result" )]
        public double Result { get; set; }

        [Display( Name = "Operation" )]
        public OperationType OperationType { get; set; }
    }
}