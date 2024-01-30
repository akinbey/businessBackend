using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleAPI.Core.Exceptions;
using ExampleAPI.Entities;

namespace ExampleAPI.Business.Validations
{
    public class ProductTransactionValidations
    {
         public void IfExists(ProductTransaction? productTransaction){
        if(productTransaction==null) throw new ValidationException("ProductTransaction not found.");
    }   
    }
}