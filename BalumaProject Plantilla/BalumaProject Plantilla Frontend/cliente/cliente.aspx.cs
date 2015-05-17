﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.EN.BalumaProject;
namespace BalumaProject_Plantilla_Frontend.cliente
{
    public partial class cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<ProductoEN> pedido = (IList<ProductoEN>)Session["carrito"];
            if (pedido != null) Master.HtmlGenericControl.InnerText = pedido.Count.ToString();
        }
    }
}