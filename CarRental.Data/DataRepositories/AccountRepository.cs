﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarRental.Business.Entities;
using Core.Common.Data;
using CarRental.Data.Contracts.RepositoryInterfaces;
using System.ComponentModel.Composition;

namespace CarRental.Data.DataRepositories
{
    [Export(typeof(IAccountRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AccountRepository : DataRepositoryBase<Account>, IAccountRepository
    {
        protected override Account AddEntity(CarRentalContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Add(entity);
        }

        protected override IEnumerable<Account> GetEntities(CarRentalContext entityContext)
        {
            return from e in entityContext.AccountSet
                   select e;
        }

        protected override Account GetEntity(CarRentalContext entityContext, int id)
        {
            var query = (from e in entityContext.AccountSet
                         where e.AccountId == id
                         select e);
            var results = query.FirstOrDefault();

            return results;
        }

        protected override Account UpdateEntity(CarRentalContext entityContext, Account entity)
        {
            return (from e in entityContext.AccountSet
                    where e.AccountId == entity.AccountId
                    select e).FirstOrDefault();
        }

        public Account GetLogin(string login)
        {
            using (CarRentalContext entityContext = new CarRentalContext())
            {
                return (from a in entityContext.AccountSet
                        where a.LoginEmail == login
                        select a).FirstOrDefault();
            }
        }
    }
}
