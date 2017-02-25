using System;
using System.Reflection;
using System.Web.UI;

namespace HelloASPNET
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.hello.Text = "Hello, ASP.NET from C# code";
            this.location.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}