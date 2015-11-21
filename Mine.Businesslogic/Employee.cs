using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Mine.Databaselogic;

namespace Mine.Businesslogic
{
    public class Employee
    {
        public string strUserName;
        public string strfirstname;
        public string strlastname;
        public string strPass_word;
        public string strGender;
        public string strDateOfBirth;
        public string strEmail;
        public string strMobile;

        SQL objSQL;

        public int Insert()
        {
            string strInsertyQuery = "INSERT INTO [dbo].[EmployeeDetails] (";
            string strColumns = string.Empty;
            string strValues = string.Empty;

            strColumns = "UserName,";
            strValues = "'" + strUserName + "',";

            strColumns = strColumns + "FirstName,";
            strValues = strValues + "'" + strfirstname + "',";

            strColumns = strColumns + "LastName,";
            strValues = strValues + "'" + strlastname + "',";

            strColumns = strColumns + "Pass_word,";
            strValues = strValues + "'" + strPass_word + "',";

            strColumns = strColumns + "Gender,";
            strValues = strValues + "'" + strGender + "',";

            strColumns = strColumns + "DateOfBirth,";
            strValues = strValues + "'" + strDateOfBirth + "',";

            strColumns = strColumns + "Email,";
            strValues = strValues + "'" + strEmail + "',";

            strColumns = strColumns + "Mobile";
            strValues = strValues + "'" + strMobile + "'";

            strInsertyQuery = strInsertyQuery + strColumns + ") VALUES (" + strValues + ")";

            objSQL = new SQL();

            return objSQL.ExecutiveNonQuery(strInsertyQuery);
        }
        public int Update()
        {
            return 0;
        }
        public int Delete()
        {
            string strDeleteQuery = string.Empty;
            strDeleteQuery = "DELETE FROM [dbo].[EmployeeDetails] WHERE UserName = '" + strUserName + "'";
            objSQL = new SQL();
            return objSQL.ExecutiveNonQuery(strDeleteQuery);
        }

        public DataTable GetData()
        {
            string strQuery = "SELECT * FROM [dbo].[EmployeeDetails]";
            objSQL = new SQL();
            return objSQL.GetData(strQuery);
        }

        public DataTable GetDataWithWhere(string type, string keyword)
        {
            string strQuery = "SELECT * FROM [dbo].[EmployeeDetails] WHERE " + type + "= "+"'" + keyword + "'";
            objSQL = new SQL();
            return objSQL.GetData(strQuery);
        }
        public DataTable GetDataByColumn(string columnName)
        {
            string strQuery = "SELECT "+columnName+ " FROM [dbo].[EmployeeDetails]";
            objSQL = new SQL();
            return objSQL.GetData(strQuery);
        }

        public bool IsValidUser()
        {
            string strQuery = "SELECT * FROM [dbo].[EmployeeDetails] WHERE UserName = '" + strUserName + "' and Pass_word = '" + strPass_word + "'";
            objSQL = new SQL();
            DataTable dtUserInformation = new DataTable();
            dtUserInformation = objSQL.GetData(strQuery);
            bool bValid = false;

            if (dtUserInformation != null)
            {
                if (dtUserInformation.Rows.Count > 0)
                {
                    bValid = true;
                }
            }
            return bValid;
        }
    }
}