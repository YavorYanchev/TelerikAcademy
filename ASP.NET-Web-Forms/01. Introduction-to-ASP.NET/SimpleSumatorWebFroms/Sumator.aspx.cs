using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleSumatorWebFroms
{
    public partial class Sumator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnSubmitButtonClick(object sender, EventArgs e)
        {
            this.sumResult.Text = (int.Parse(this.firstNum.Value) + int.Parse(this.secondNum.Value)).ToString();
        }
    }
}