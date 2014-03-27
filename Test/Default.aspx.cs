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
    /// Logs the user into the system.
    /// </summary>
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            // Get the username/password.
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            // Try to login to the system.
            var acceptedLogin = Global.ServerInterface.Login(username, password);

            // The login was accepted, go to the add essay page.
            if (acceptedLogin)
                Response.Redirect("AddEssay.aspx");
            else
            {
                // Show login error.
            }
        }
        catch (Exception exc)
        {
        }
    }

    /// <summary>
    /// Allows user to analyze an essay without the need to login.
    /// </summary>
    protected void btnWithoutLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddEssay.aspx");
    }

    /// <summary>
    /// Sends the user to the signup page.
    /// </summary>
    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateAccount.aspx");
    }
}