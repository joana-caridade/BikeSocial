﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeSocialDTOs;

namespace BikeSocialBLL.Services.IServices
{
    public interface ITrainingsService
    {
        Task<bool> Create(CreateTrainingDto training);
    }
}
