﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProduct(Guid productId, bool trackChanges);
        Product GetProduct(Guid productId, Guid id, bool trackChanges);
        void CreateProductForAnimal(Guid animalId, Product product);
    }
}
