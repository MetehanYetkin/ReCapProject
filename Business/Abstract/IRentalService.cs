﻿using Core.Utilities.Results;
using Entitiy.Concrate;
using Entitiy.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult <List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalByCustomerId(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();

    }
}
