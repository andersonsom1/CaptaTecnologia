﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CaptaTecnologia.Models.Interfaces
{
    public interface IAppExecute
    {
        Task<bool> Start();
    }
}
