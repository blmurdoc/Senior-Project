using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Brings user to the essay upload page.
    /// </summary>
    protected void btnAdvanceToEssayUpload_Click(object sender, EventArgs e)
    {
        Response.Redirect("EssayUpload.aspx");
    }
}