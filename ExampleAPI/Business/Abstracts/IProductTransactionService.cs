using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ExampleAPI.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace ExampleAPI.Business.Abstracts;

    public interface IProductTransactionService
    {
        IList<ProductTransaction> GetAll(
            Expression<Func<ProductTransaction, bool>>? predicate = null,
            Func<IQueryable<ProductTransaction>, IIncludableQueryable<ProductTransaction, object>>? include = null,
            Func<IQueryable<ProductTransaction>, IOrderedQueryable<ProductTransaction>>? orderBy = null
        );
    ProductTransaction? Get(
        Expression<Func<ProductTransaction, bool>> predicate,
        Func<IQueryable<ProductTransaction>, IIncludableQueryable<ProductTransaction, object>>? include = null
    );
    ProductTransaction Add(ProductTransaction entity);
    ProductTransaction Update(ProductTransaction entity);
    void DeleteById(Guid id); 
    }
