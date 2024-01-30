using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ExampleAPI.Business.Abstracts;
using ExampleAPI.Business.Validations;
using ExampleAPI.Entities;
using ExampleAPI.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore.Query;

namespace ExampleAPI.Business.Concretes;

public class OrderManager : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly OrderValidations _orderValidations;
    public Order Add(Order order)
    {
        return _orderRepository.Add(order);
    }

    public void DeleteById(Guid id)
    {
          var order=_orderRepository.Get(u=>u.Id==id);
        _orderRepository.IfExists(order);
        _orderRepository.Delete(order);
    }

    public Order? Get(Expression<Func<Order, bool>> predicate, Func<IQueryable<Order>, IIncludableQueryable<Order, object>>? include = null)
    {
         return _orderRepository.Get(predicate,include);
    }

    public IList<Order> GetAll(Expression<Func<Order, bool>>? predicate = null, Func<IQueryable<Order>, IIncludableQueryable<Order, object>>? include = null, Func<IQueryable<Order>, IOrderedQueryable<Order>>? orderBy = null)
    {
        return _orderRepository.GetAll(predicate,include,orderBy).ToList();
    }

    public Order Update(Order order)
    {
        return _orderRepository.Update(order);
    }
}
