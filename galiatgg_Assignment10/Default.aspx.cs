/*
File Name: Default.aspx
Name: Gabe Galiatsatos
email: galiatgg@mail.uc.edu
Assignment Number: Assignment 10  
Due Date: April 10, 2025
Course #/Section: IS3050/001
Semester/Year: Spring 2025
Brief Description of the assignment: Recreating website from Assignment 2
Brief Description of what this module does. Displays information about desired topic.
Citations: w3schools.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace galiatgg_Assignment10
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var tableheader = new TableRow();
            var columnheader1 = new TableCell();
            var columnheader2 = new TableCell();

            columnheader1.Text = "Agency";
            columnheader2.Text = "Country";

            tableheader.Cells.Add(columnheader1);
            tableheader.Cells.Add(columnheader2);

            tblSpaceAgencies.Rows.Add(tableheader);

            var nasarow = new TableRow();
            var nasa1 = new TableCell();
            var nasa2 = new TableCell();

            nasa1.Text = "NASA";
            nasa2.Text = "USA";

            nasarow.Cells.Add(nasa1);
            nasarow.Cells.Add(nasa2);

            tblSpaceAgencies.Rows.Add(nasarow);

            var esarow = new TableRow();
            var esa1 = new TableCell();
            var esa2 = new TableCell();

            esa1.Text = "ESA";
            esa2.Text = "Europe";

            esarow.Cells.Add(esa1);
            esarow.Cells.Add(esa2);

            tblSpaceAgencies.Rows.Add(esarow);

            var isrorow = new TableRow();
            var isro1 = new TableCell();
            var isro2 = new TableCell();

            esa1.Text = "ISRO";
            esa2.Text = "India";

            isrorow.Cells.Add(isro1);
            isrorow.Cells.Add(isro2);

            tblSpaceAgencies.Rows.Add(isrorow);

            blkeymissions.Items.Add("Apollo 11 - First Moon Landing (1969)");
            blkeymissions.Items.Add("Voyager 1 & 2 - Deep Space Probes");
            blkeymissions.Items.Add("Mars Rovers - Curiosity, Perseverance");

            img1.ImageUrl = "space_image.jpg";

            txtabout.Text = "Space exploration has been one of humanity's greatest endeavors, leading to incredible discoveries about our universe.";
            txtquote.Text = "\"That's one small step for man, one giant leap for mankind.\" – Neil Armstrong";

            lnknasa.NavigateUrl = "https://nasa.gov";
        }
    }
}