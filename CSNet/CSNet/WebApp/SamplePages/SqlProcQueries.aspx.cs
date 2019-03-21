using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using NorthwindSystem.BLL;
using NorthwindSystem.Data;
#endregion

namespace WebApp.SamplePages
{
    public partial class SqlProcQueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear old messages 
            MessageLabel.Text = "";

            //the dropdownlist (ddl) control will be loaded with data from the database. 
            //consideration needs to be given to the data as to it change frequence.
            //if your data does not change frequently then you can consider loading on page load. 
            if (!Page.IsPostBack)
            {
                //user friendly error handling
                try
                {
                    //create and connect to the appropriate BLL class
                    CategoryController sysmgr = new CategoryController();
                    //issue the request to the appropriate BLL class method and capture results 
                    List<Category> datainfo = sysmgr.Category_List();
                    //optionally: sort the results
                    datainfo.Sort((x,y) => x.CategoryName.CompareTo(y.CategoryName));
                    //attach data source collection to the DDL.
                    CategoryList.DataSource = datainfo;
                    //Set the dll DataTextField and DataValueField properties.
                    CategoryList.DataTextField = nameof(Category.CategoryName);
                    CategoryList.DataValueField = "CategoryID";
                    //Physically bind the data to the DDL control.
                    CategoryList.DataBind();
                    //optionally: add a prompt to the DDL control
                    CategoryList.Items.Insert(0, "select ...");
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
        }

       
    }
}