﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VelocityCoders.LotteryGame.Webforms
{
    public partial class Error : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //notes: set back link
            if (!string.IsNullOrEmpty(Request.ServerVariables["HTTP_REFERER"]))
                PreviousPageLink.NavigateUrl = Request.ServerVariables["HTTP_REFERER"];
        }
    }
}