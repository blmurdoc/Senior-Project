using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Results : System.Web.UI.Page
{
    protected string dynamicHTML { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            LoadForm();
    }

    public void LoadForm()
    {
        var essayID = Convert.ToInt32(Request.QueryString["EssayID"]);
        var essay = Global.ServerInterface.GetCurrentUsersEssays().Where(i => i.EssayID == essayID).SingleOrDefault();

        dynamicHTML = essay.Analysis;
        litResults.Text = dynamicHTML;
    }
}