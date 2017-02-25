using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventsPageLifecycle
{
    public partial class _Default : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Response.Write("Page preinit" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Write("Page init" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("Page load" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Response.Write("Page prerender" + "<br/>");
        }
        protected void Page_Render(object sender, EventArgs e)
        {
            this.Response.Write("Page render" + "<br/>");
        }
    }
}