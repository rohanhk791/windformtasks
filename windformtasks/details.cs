using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace windformtasks
{
   

    public partial class details : Form
    {
        
        //DataTable dt = new DataTable();
        register res = new register();
        
        //details det = new details();

        public details()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        public void display()
        {

            //dt.Columns.Add("id");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Age");
            //dt.Columns.Add("Gender");
            //dt.Columns.Add("City");
            //dt.Columns.Add("State");
            //dt.Columns.Add("Country");
            //dt.Columns.Add("Phone_no");
            //dt.Columns.Add("Address");
            //dt.Columns.Add("Qualification");

            //DataRow dr = dt.NewRow();

            //dr[0] = id;
            //dr[1] = name;
            //dr[2] = age;
            //dr[3] = gender;
            //dr[4] = city;
            //dr[5] = state;
            //dr[6] = country;
            //dr[7] = phone_no;
            //dr[8] = address;
            //dr[9] = qualification;

            //dt.Rows.Add(dr);
            //dataGridView1.DataSource = dt;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            res.txt_id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            res.txt_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            res.num_age.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            res.rad_male.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            res.com_city.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            res.com_state.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            res.com_country.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            res.txt_phone_no.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            res.txt_address.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            res.txt_qualification.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void details_Load(object sender, EventArgs e)
        {
         
            dataGridView1.Text = register.text1;
             int id = register.id;
            string name = register.name;
            int age = register.age;
            string gender = register.gender;
            string city = register.city;
            string state = register.state;
            string country = register.country;
            string address = register.address;
            long phone_no = register.phone_no;
            string qualification = register.qualification;

         
            

            dataGridView1.Rows.Add(id,name,age,gender,city,state,country,phone_no,address,qualification);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
