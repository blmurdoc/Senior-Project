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
    protected void btnAddEssay_Click(object sender, EventArgs e)
    {
        // Convert the stream from the uploaded file to a string.
        StreamReader reader = new StreamReader(fuEssayUpload.FileContent);
        string essayText = reader.ReadToEnd();

        // Get the filename.
        var filename = fuEssayUpload.FileName;

        // Create the essay object.
        var essay = new Essay
        {
            Name = filename,
            UploadedText = essayText
        };

        try
        {
            // Get the essay ID.
            var essayID = Global.ServerInterface.AddEssay(essay);

            // Analyze the essay.
            Global.ServerInterface.AnalyzeEssay(essayID);

            // Redirect to the results page with the essayID.
            Response.Redirect(String.Format("Results.aspx?EssayID={0}", essayID));
        }
        catch(Exception exc)
        {
            // List errors in validation summary.
        }
    }
}