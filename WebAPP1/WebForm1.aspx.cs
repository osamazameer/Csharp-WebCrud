using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPP1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DAO db = new DAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO users (NAME,EMAIL) VALUES ('" + name.Text + "','" + email.Text + "')";
            if (db.UDI(qry))
            {
                Label1.Text = "Saved";
            }
            else
            {
                Label1.Text = "Error";
            }
        }
    }
}