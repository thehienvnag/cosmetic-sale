using CSharpAssignment.Components;
using CSharpAssignment.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace CSharpAssignment
{
    public partial class CosmeticSale : System.Web.UI.MasterPage
    {
        Header header;
        Footer footer;
        SideBar sideBar;
        protected void Page_Load(object sender, EventArgs e)
        {

            header = (Header)Page.LoadControl("./Components/Header.ascx");
            footer = (Footer)Page.LoadControl("./Components/Footer.ascx");
            sideBar = (SideBar)Page.LoadControl("./Components/SideBar.ascx");

            HeaderContainer.Controls.Add(header);
            FooterPanel.Controls.Add(footer);
            SideBarPanel.Controls.Add(sideBar);
            if (Session["ShoppingCart"] != null)
            {
                int count = ((System.Data.DataTable)Session["ShoppingCart"]).Rows.Count;
                Session["CountItem"] = count;
            }
        }



    }
}