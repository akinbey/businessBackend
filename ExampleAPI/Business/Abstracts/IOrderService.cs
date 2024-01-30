using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ExampleAPI.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace ExampleAPI.Business.Abstracts;

    public interface IOrderService
    {
        
    IList<Order> GetAll(
            Expression<Func<Order, bool>>? predicate = null,
            Func<IQueryable<Order>, IIncludableQueryable<Order, object>>? include = null,
            Func<IQueryable<Order>, IOrderedQueryable<Order>>? orderBy = null
        );
    Order? Get(
        Expression<Func<Order, bool>> predicate,
        Func<IQueryable<Order>, IIncludableQueryable<Order, object>>? include = null
    );
    Order Add(Order order);
    Order Update(Order order);
    void DeleteById(Guid id); 
    }
