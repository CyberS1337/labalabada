﻿using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        private IProductRepository _productRepository;
        private IAnimalRepository _animalRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);
                return _companyRepository;
            }
        }
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository;
            }
        }
        public IAnimalRepository Animal
        {
            get
            {
                if (_animalRepository == null)
                    _animalRepository = new AnimalRepository(_repositoryContext);
                return _animalRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_repositoryContext);
                return _productRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();
    }
}
