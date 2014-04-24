using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wordcountdisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            LoadForm();
    }

    public void LoadForm()
    {
        litWordCount.Text = Global.ServerInterface._Essay.Analysis.TotalWordCount.ToString();
    }
}