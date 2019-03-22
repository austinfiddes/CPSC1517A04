using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAFiddes
{
    public partial class StudentForm : System.Web.UI.Page
    {
        public static List<Student> StudentListCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";

            if (!Page.IsPostBack)
            {
                StudentListCollection = new List<Student>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            StudentID.Text = "";
            Name.Text = "";
            Credits.Text = "";
            EmergencyPhoneNumber.Text = "";
        }
    }
}