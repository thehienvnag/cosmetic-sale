using System;

namespace CSharpAssignment.Components
{
    public partial class SearchBar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            string name = TxtSearchName.Text;
            Response.Redirect("ShowProduct.aspx?name=" + name);
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;

            string category = CbCategory.Text;
            if (category.Equals("-- Select --"))
            {
                category = "";
            }
            string fromPrice = TxtFromPrice.Text;
            string toPrice = TxtToPrice.Text;
            string urlRewriting = "ShowProduct.aspx"
                + "?name=" + name
                + "&category=" + category
                + "&fromPrice=" + fromPrice
                + "&toPrice=" + toPrice;

            Response.Redirect(urlRewriting);
        }
    }
}