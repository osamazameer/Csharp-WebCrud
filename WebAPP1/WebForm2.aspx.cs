using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAPP1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DAO db = new DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO products (NAME,DESCRIPTION,PRICE,COST,SALES_PRICE,TAX) VALUES ('" + name.Text + "','" + description.Text + "','" + price.Text + "','" + cost.Text + "','" + sales_price.Text + "','" + tax.Text + "')";
            if (db.UDI(qry))
            {
                Label1.Text = "Saved Successfully!";
            }
            else
            {
                Label1.Text = "Error Occured on the server";

            }
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string qry = "Select * from products where ID = '" + Convert.ToInt32(id.Text) + "'";
            DataTable dt = db.Search(qry);
            if(dt != null)
            {
                name.Text = dt.Rows[0]["NAME"].ToString();
                description.Text = dt.Rows[0]["DESCRIPTION"].ToString();
                price.Text = dt.Rows[0]["PRICE"].ToString();
                cost.Text = dt.Rows[0]["COST"].ToString();
                sales_price.Text = dt.Rows[0]["SALES_PRICE"].ToString();
                tax.Text = dt.Rows[0]["TAX"].ToString();
            }
             else
            {
                Label1.Text = "Not Found!";
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            string qry = "Delete from products where ID = '" + Convert.ToInt32(id.Text) + "'";
            
            if (db.UDI(qry))
            {
                Label1.Text = "Deleted Successfully!";
            }
            else
            {
                Label1.Text = "Error Occured on the server";

            }
        }

        protected void clearBtn_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            description.Text = "";
            price.Text = "";
            cost.Text = "";
            sales_price.Text = "";
            tax.Text = "";
        }
    
        private void LoadGridView()
        {
            string qry = "SELECT * FROM products";
            DataTable dt = db.Search(qry);
            if(dt != null)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
           
            string qry = "UPDATE products SET name = '" + name.Text + "', description = '" + description.Text +"', price = '"+ price.Text + "', cost ='" + cost.Text + "', sales_price ='" +sales_price.Text + "', tax ='"+ tax.Text+ "' WHERE id= '" + id.Text + "'";

            if (db.UDI(qry))
            {
                Label1.Text = "Product Has been Updated!";
            }
            else
            {
                Label1.Text = "Error Occured on the server";
            }
        }

        protected void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}