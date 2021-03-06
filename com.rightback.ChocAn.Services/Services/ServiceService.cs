﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.rightback.ChocAn.DAL;

namespace com.rightback.ChocAn.Services.Services
{
    public class ServiceService : BaseService, IServiceService
    {
        public List<Service> getAllServices()
        {
            return db.Services
                .ToList();
        }

        public string getServiceName(string serviceCode)
        {
            return db.Services
                 .Where(s => s.Code.Equals(serviceCode))
                 .Select(s => s.Name)
                 .FirstOrDefault();
        }
    }
}
