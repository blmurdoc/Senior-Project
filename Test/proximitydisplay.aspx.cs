using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class proximitydisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            LoadForm();
    }

    public void LoadForm()
    {
        litWordProximity.Text = "";
        foreach (string entry in Global.ServerInterface._Essay.Analysis.CloseProximityWordList)
        {
            litWordProximity.Text += "<tr><td>";
            litWordProximity.Text += entry.ToString();
            litWordProximity.Text += "</td></tr>";
        }
    }
}