﻿using Core.Utilities.Results;
using Entitiy.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetCustomerByUserId(int id);

    }
}
