﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waAgenda
{
    public partial class MasterPagePrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] == null) // Se Request.Cookies [login] for igual a vazio então o usuário será direcionado para a página login
            {
                Response.Redirect("^/login.aspx");
            }
        }
    }
}