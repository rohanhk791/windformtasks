using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions.Regex Regex;

namespace windformtasks
{
   
    public partial class register : Form
    {
        DataTable dt = new DataTable();
        public static int id { get; set; }
        public static int age { get; set; }
        public static long phone_no { get; set; }

        public static string name { get; set; }
        public static string gender { get; set; }
        public static string city { get; set; }
        public static string state { get; set; }

        public static string country { get; set; }
        public static string address { get; set; }
        public static string qualification { get; set; }
        public static int index { get; set; }
       public static string text1 { get; set; }



        public register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void but_add_Click(object sender, EventArgs e)
        { 
            id = int.Parse(txt_id.Text);
            name = txt_name.Text;
             age = int.Parse(num_age.Text);
            gender = rad_male.Text;
             city = com_city.Text;
             state = com_state.Text;
            country = com_country.Text;
            phone_no = Convert.ToInt64(txt_phone_no.Text);
            address = txt_address.Text;
             qualification = txt_qualification.Text;
             text1 = txt_name.Text;


            if (rad_male.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
           
            details r = new details();
            r.Show();
        }
        
        private void com_city_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (var clear in this.Controls)
            {
                if (clear is TextBox)                
                {
                    ((TextBox)clear).Text = String.Empty;
                  
                }

                if (clear is ComboBox)
                {
                    
                    ((ComboBox)clear).Text = String.Empty;
                }
                if (clear is NumericUpDown)
                {

                    ((NumericUpDown)clear).Text = String.Empty;
                }
               
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            //foreach (DataGridViewRow item in this.datagrid.SelectedRows)
            //{
            //    datagrid.Rows.RemoveAt(item.Index);
            //}

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex(Index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.datagrid.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_phone_no_TextChanged(object sender, EventArgs e)
        {

            if (txt_phone_no.Text.StartsWith("0"))
            {
                MessageBox.Show("Dont start with Mobile Number 0 ");
                return;
            }
            //Regex re = new Regex("^9[0-9]{9}");

            //if (re.IsMatch(txt_phone_no.Text.Trim()) == false || txt_phone_no.Text.Length > 10)
            //{
            if (/*re.IsMatch(txt_phone_no.Text.Trim()) == false || */txt_phone_no.Text.Length > 10)
            {
                MessageBox.Show("Invalid Mobile Number!!");
                txt_phone_no.Focus();
            }
        }
    }


    
}
