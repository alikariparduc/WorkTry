﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Abstract.Result
{
    public interface IResult
    {
        public bool Success { get;}
        public string Message { get;}
    }
}
