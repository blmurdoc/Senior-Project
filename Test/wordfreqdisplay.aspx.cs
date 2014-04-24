using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wordfreqdisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            LoadForm();
    }

    public void LoadForm()
    {
        litWordFrequency.Text = "";
        var items = from pair in Global.ServerInterface._Essay.Analysis.IndividualWordFrequency
                    orderby pair.Value descending
                    select pair;
        foreach (KeyValuePair<string, int> entry in items)
        {
            litWordFrequency.Text += "<tr><td>";
            litWordFrequency.Text += entry.Key.ToString();
            litWordFrequency.Text += "</td><td>";
            litWordFrequency.Text += entry.Value.ToString();
            litWordFrequency.Text += "</td></tr>";
        }
    }
}