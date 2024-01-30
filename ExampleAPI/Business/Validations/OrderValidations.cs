using ExampleAPI.Core.Exceptions;
using ExampleAPI.Entities;

namespace ExampleAPI.Business.Validations
{
    public class OrderValidations
    {
        public void IfExists(Order? order){
        if(order==null) throw new ValidationException("Order not found.");
    }  
    }
}