using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shaurya.net
{
    public partial class Form6 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form6()
        {
            InitializeComponent();
            //step1
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //step3 pass SP name in the command
                cmd = new SqlCommand("SP_Insert_Employeedetails", con);
                //need to add the following code to tell to command that execute the SP
                cmd.CommandType = CommandType.StoredProcedure;
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@Name", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtEmpSalary.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdateusingSP_Click(object sender, EventArgs e)
        {
            try
            {
                ///step1 pass SP name in the command
                cmd = new SqlCommand("SP_Update_Employeedetails", con);
                //step2 need to add the following code to tell to command that exe the SP
                cmd.CommandType = CommandType.StoredProcedure;
                // step 3  assign parameter value
                cmd.Parameters.AddWithValue("@Name", txtEmpName.Text);      //.Text is used because CommandType is text type
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtEmpSalary.Text));
                // step 4 open the connection to fire query
                con.Open();
                // step 5 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDeleteusingSP_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SP_Delete_Employeedetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtEmpId.Text));
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record deleted");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtEmpId.Clear();
                txtEmpName.Clear();
                txtEmpSalary.Clear();
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearchByIdusingSP_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SP_Select_ById_Employeedetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtEmpId.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)                  //HasRows = to check entered input is ocurred in database or not
                {

                    while (dr.Read())
                    {
                        txtEmpName.Text = dr["Name"].ToString();                        // Name , Salary are the col names
                        txtEmpSalary.Text = dr["Salary"].ToString();            //ToString() = used to convert current object to string 
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        

        private void btnShowAllusingSP_Click(object sender, EventArgs e)
        {
            try
            {


                cmd = new SqlCommand("SP_ShowAll_Employeedetails", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    EmpGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSaveusingSP_Click(object sender, EventArgs e)
        {

        }
    }
    
}
