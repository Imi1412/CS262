using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal oldAmount;
            bool success = Decimal.TryParse(US.Value, out oldAmount);
            
            if (this.IsPostBack == false)
            {
                // The HtlSelect control accepts text or ListItem objects
                Currency.Items.Add(new ListItem("Euro", "0.85"));
                Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
                Currency.Items.Add(new ListItem("Canadian Dollar", "1.2"));
            }
            
            if (success)
            {
                ListItem item = Currency.Items[Currency.SelectedIndex];

                decimal newAmount = oldAmount * Decimal.Parse(item.Value);
                Result.InnerText = oldAmount.ToString() + " U.S. dollars = ";
                Result.InnerText += newAmount.ToString() + " " + item.Text;
            }
            else
            {
               
                Result.InnerText = "The number you typed in was not in the correct format. Use only numbers.";
            }

            //decimal USAmount;

            // Attempt the conversion.
            //bool success = Decimal.TryParse(US.Value, out USAmount);

            // Check if it succeeded.
        }
    }
}