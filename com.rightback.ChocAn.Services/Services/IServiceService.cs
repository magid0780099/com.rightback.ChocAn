﻿using com.rightback.ChocAn.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.rightback.ChocAn.Services.Services
{
    public interface IServiceService
    {
        /// <summary>
        /// Returns name for the provided service code.
        /// </summary>
        /// <param name="serviceCode"></param>
        /// <returns></returns>
        string getServiceName(string serviceCode);

        /// <summary>
        /// Returns all services from the repository.
        /// </summary>
        /// <returns></returns>
        List<Service> getAllServices();
    }
}
