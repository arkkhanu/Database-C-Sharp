using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            combo_select.AddItem("Nothing");
            combo_select.AddItem("Insert");
            combo_select.AddItem("Update");
            combo_select.AddItem("Delete");
            LoadData_();

        }

        private void cross_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onselection(object sender, EventArgs e)
        {
            switch (combo_select.selectedValue.ToString())
            {
                case "Nothing" : btn_actionform.ButtonText = "Nothing";
                    break;
                case "Insert":
                    btn_actionform.ButtonText = "Insert";
                    break;
                case "Update":
                    btn_actionform.ButtonText = "Update";
                    break;
                case "Delete":
                    btn_actionform.ButtonText = "Delete";
                    break;
            }
        }

        private void btn_actionform_Click(object sender, EventArgs e)
        {
            switch (btn_actionform.ButtonText)
            {
                case "Action":
                    MessageBox.Show("No Action Performed");
                    break;
                case "Nothing":
                    MessageBox.Show("No Action Performed");
                    break;
                case "Insert":
                    InsertData_();
                    break;
                case "Update":
                    UpdateData_();
                    break;
                case "Delete":
                    DeleteData_();
                    break;
            }
            LoadData_();
            ClearAllField();
        }
       
        // Using Disconnected Way
        private void InsertData_()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    // Parametrized Query
                    //Insert_Using_ParametrizeQuery(con);
                    // Stored Procedure
                    Insert_Using_StoredProcedure(con);

                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                
            }
        }

        private void LoadData_()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    LoadData_StoreProcedure_Disconnected(con);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
        }
       
        private void UpdateData_()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    UpdateData_StoredProcedure_Disconnected(con);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
        }

        private void DeleteData_()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    DeleteData_StoreProcedure_Disconnected(con);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
        }

        ///  Disconnected Start   ///
        private void Insert_Using_ParametrizeQuery(SqlConnection con)
        {
            string query = "INSERT INTO usertable (fname , lname , age , address) ";
            query += "VALUES (@fname , @lname , @age , @address);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fname", tv_fname.Text);
            cmd.Parameters.AddWithValue("@lname", tv_lname.Text);
            cmd.Parameters.AddWithValue("@age", tv_age.Text);
            cmd.Parameters.AddWithValue("@address", tv_address.Text);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Successfully Inserted...");
            }
            else
            {
                MessageBox.Show("Problem Occured while Insertion...");
            }
        }

        private void Insert_Using_StoredProcedure(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("insertIntoTable", con);
            da.InsertCommand.Parameters.AddWithValue("@fname", tv_fname.Text);
            da.InsertCommand.Parameters.AddWithValue("@lname", tv_lname.Text);
            da.InsertCommand.Parameters.AddWithValue("@age", tv_age.Text);
            da.InsertCommand.Parameters.AddWithValue("@address", tv_address.Text);
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            int a = da.InsertCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Successfully Inserted...");
            }
            else
            {
                MessageBox.Show("Problem Occured while Insertion...");
            }
        }
  
        private void LoadData_StoreProcedure_Disconnected(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand("getdataTable", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                datagrid.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Not Data Here");
            }
        }

        private void UpdateData_StoredProcedure_Disconnected(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.UpdateCommand = new SqlCommand("updateTable", con);
            da.UpdateCommand.Parameters.AddWithValue("@id", tv_id.Text);
            da.UpdateCommand.Parameters.AddWithValue("@fname", tv_fname.Text);
            da.UpdateCommand.Parameters.AddWithValue("@lname", tv_lname.Text);
            da.UpdateCommand.Parameters.AddWithValue("@age", tv_age.Text);
            da.UpdateCommand.Parameters.AddWithValue("@address", tv_address.Text);
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            int a = da.UpdateCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Successfully Updated...");
            }
            else
            {
                MessageBox.Show("Problem Occured while Updation...");
            }

        }

        private void DeleteData_StoreProcedure_Disconnected(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.DeleteCommand = new SqlCommand("deleteTable", con);
            da.DeleteCommand.Parameters.AddWithValue("@id", tv_id.Text);
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            int a = da.DeleteCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Successfully Deleted...");
            }
            else
            {
                MessageBox.Show("Problem Occured while Deletion...");
            }
        }

        private void OnCellClickedonGridView(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                tv_id.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
                tv_fname.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
                tv_lname.Text = datagrid.SelectedRows[0].Cells[2].Value.ToString();
                tv_age.Text = datagrid.SelectedRows[0].Cells[3].Value.ToString();
                tv_address.Text = datagrid.SelectedRows[0].Cells[4].Value.ToString();
            }
        }


        private void ClearAllField()
        {
            tv_id.Text = "";
            tv_fname.Text = "";
            tv_lname.Text = "";
            tv_age.Text = "";
            tv_address.Text = "";
            btn_actionform.ButtonText = "Action";
            combo_select.Clear();
            combo_select.AddItem("Nothing");
            combo_select.AddItem("Insert");
            combo_select.AddItem("Update");
            combo_select.AddItem("Delete");
        }

        ///  Disconnected END   ///
    }
}
