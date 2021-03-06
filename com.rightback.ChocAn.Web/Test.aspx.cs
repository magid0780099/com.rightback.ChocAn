﻿using com.rightback.ChocAn.DAL;
using com.rightback.ChocAn.Services;
using com.rightback.ChocAn.Services.Providers;
using com.rightback.ChocAn.Web.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.rightback.ChocAn.Web
{
    public partial class Test : BasePage
    {


        protected void Page_Load(object sender, EventArgs e)
        {//test commit
            List<Provider> providers = providerService.getAllProviders().ToList();

            foreach (Provider provider in providers)
            {
                lblProviders.Text += provider.Name;
                lblProviders.Text += "<br/>";

            }
        }
    }
}