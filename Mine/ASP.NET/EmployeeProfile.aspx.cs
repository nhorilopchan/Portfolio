using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mine.Businesslogic;

namespace Mine.ASP.NET
{
    public partial class EmployeeProfile : System.Web.UI.Page
    {
        public Employee objEmployee = new Employee();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindControls();
            }
        }

        private void BindControls()
        {
            DataTable employeedt = new DataTable();
            employeedt = objEmployee.GetData();

            if (employeedt != null)
            {
                //Bind Dropdownlist with Columns
                if (ddlKeywordList != null)
                {
                    ddlKeywordList.DataSource = employeedt.Columns;
                    ddlKeywordList.DataBind();
                }
                rptEmployee.DataSource = employeedt;
                rptEmployee.DataBind();
                gvEmployee.DataSource = employeedt;
                gvEmployee.DataBind();

            }
        }
        protected void btnKeywordSearch_OnClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlKeywordValueList.SelectedValue))
            {
                DataTable searchresultdt = new DataTable();
                string selectedsection = ddlKeywordList.SelectedValue;
                //string searchkeyword = txtKeywordSearch.Text;
                string searchkeyword = ddlKeywordValueList.SelectedValue;

                searchresultdt = objEmployee.GetDataWithWhere(selectedsection, searchkeyword);
                gvEmployee.DataSource = searchresultdt;
                gvEmployee.DataBind();

            }
        }

        protected void ddlKeywordList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable searchkeyworddt = new DataTable();
            searchkeyworddt = objEmployee.GetDataByColumn(ddlKeywordList.SelectedValue);
            ddlKeywordValueList.Items.Clear();
            foreach (DataRow row in searchkeyworddt.Rows)
            {
                ddlKeywordValueList.Items.Add(row.ItemArray[0].ToString());
            }
        }

    }
}