﻿using Entitiy.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.FluentValidation
{
   public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.BrandName).MinimumLength(2);
        }
    }
}
