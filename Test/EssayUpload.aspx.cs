using Services;
using Services.ServiceObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddEssay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Sends the essay to the server side for analysis and brings user to analysis page.
    /// </summary>
    protected void btnAnalyzeEssay_Click(object sender, EventArgs e)
    {
        // Convert the stream from the uploaded file to a string.
        StreamReader reader = new StreamReader(fuEssayUpload.FileContent);
        string essayText = reader.ReadToEnd();

        // Get the filename.
        var filename = fuEssayUpload.FileName;

        Global.ServerInterface._Essay.Name = filename;
        Global.ServerInterface._Essay.UploadedText = essayText;

        try
        {
            // Analyze the essay.
            Global.ServerInterface.AnalyzeEssay();

            // Redirect to the results page with the essayID.
            Response.Redirect("Results.aspx");
        }
        catch (Exception exc)
        {
            // List errors in validation summary.
        }
    }
}