using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CovidPatientTrackingSystem
{
    public partial class CovidPatientRecord : Form
    {
        int id;
        DataSet DTSet;
        DataTable DTTable;
        SqlCommandBuilder Builder;
        SqlDataAdapter DTAdapter;
        string credentials, query;
        SqlConnection connection;

        public CovidPatientRecord()
        {
            InitializeComponent();
        }
        

        private void LoadDB()
        {
            credentials = "Data Source=DESKTOP-U1HQOM7; Initial Catalog= CovidPatientDB; User ID=sa; Password=headyland";
            query = " select * from CovidPatientData";
            connection = new SqlConnection(credentials);
            DTAdapter = new SqlDataAdapter(query, connection);
            DTSet = new DataSet();

            try
            {
                connection.Open();
                Builder = new SqlCommandBuilder(DTAdapter); 
                DTAdapter.Fill(DTSet, "CovidPatientData");
                DTTable = DTSet.Tables["CovidPatientData"];
                connection.Close();
                View.DataSource = DTSet.Tables["CovidPatientData"];
                View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, there is an Error: " + ex.Message);
            }
        }

        private void SearchDB_byName()
        {
            DTSet.Clear();
            string searchText = SearchBox.Text;
            query = " select * from CovidPatientData where Patient_Name like '%" + searchText + "%'";
            connection = new SqlConnection(credentials);
            DTAdapter = new SqlDataAdapter(query, connection);
            try
            {
                connection.Open();
                Builder = new SqlCommandBuilder(DTAdapter);
                DTAdapter.Fill(DTSet, "CovidPatientData");
                DTTable = DTSet.Tables["CovidPatientData"];
                connection.Close();
                View.DataSource = DTSet.Tables["CovidPatientData"];
                View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, there is an Error: " + ex.Message);
            }
        }

        private void SearchDB_byPhone()
        {
            DTSet.Clear();
            string searchText = SearchBox.Text;
            query = " select * from CovidPatientData where Patient_Phone like '%" + searchText + "%'";
            connection = new SqlConnection(credentials);
            DTAdapter = new SqlDataAdapter(query, connection);
            try
            {
                connection.Open();
                Builder = new SqlCommandBuilder(DTAdapter);
                DTAdapter.Fill(DTSet, "CovidPatientData");
                DTTable = DTSet.Tables["CovidPatientData"];
                connection.Close();
                View.DataSource = DTSet.Tables["CovidPatientData"];
                View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, there is an Error: " + ex.Message);
            }
        }

        private void ViewDB_Click(object sender, EventArgs e)
        {
            LoadDB();
            View.ReadOnly = true;
            SaveRecord.Enabled = false;
        }

        private void NewPatient_Click(object sender, EventArgs e)
        {
            Edit.Enabled = false;
            View.ReadOnly = false;
            SaveRecord.Enabled = true;
            NewPatient.Enabled = false;
            DeleteRecord.Enabled = false; 
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit.Enabled = false;
            View.ReadOnly = false;
            SaveRecord.Enabled = true;
            NewPatient.Enabled = false;
            DeleteRecord.Enabled = false;
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            Edit.Enabled = true;
            View.ReadOnly = true;
            SaveRecord.Enabled = false;
            NewPatient.Enabled = true;
            DeleteRecord.Enabled = true;
            try
            {
                if(DTAdapter.Update(DTTable) > 0)
                {
                    MessageBox.Show("Record Saved Successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            Edit.Enabled = true;
            SaveRecord.Enabled = false;
            NewPatient.Enabled = true;
            DeleteRecord.Enabled = true;

            if (MessageBox.Show("Of course delete it!", "Siriously?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    id = View.SelectedRows[0].Index;
                    View.Rows.RemoveAt(id);
                    if (DTAdapter.Update(DTTable) > 0)
                    {
                        MessageBox.Show("Record has been deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void PID_TextChanged(object sender, EventArgs e)
        {

        }
        private void Search_Click(object sender, EventArgs e)
        {
            SearchDB_byName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchDB_byPhone();
        }
    }
}
