using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class spellcheckdisplay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            LoadForm();
    }

    public void LoadForm()
    {
        litMisspelledWords.Text = "";
        if (Global.ServerInterface._Essay.Analysis.MisspelledWords.Any())
        {
            foreach (string word in Global.ServerInterface._Essay.Analysis.MisspelledWords)
            {
                litMisspelledWords.Text += "<tr><td>";
                litMisspelledWords.Text += word.ToString();
                litMisspelledWords.Text += "</td></tr>";
            }
        }
    }
}