
namespace windformtasks
{
    partial class details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_phone_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(352, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.Col_name,
            this.Col_age,
            this.Col_gender,
            this.Col_city,
            this.Col_state,
            this.Col_country,
            this.Col_phone_no,
            this.Col_address,
            this.Col_qualification});
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(881, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // Col_name
            // 
            this.Col_name.HeaderText = "Name";
            this.Col_name.Name = "Col_name";
            // 
            // Col_age
            // 
            this.Col_age.HeaderText = "Age";
            this.Col_age.Name = "Col_age";
            // 
            // Col_gender
            // 
            this.Col_gender.HeaderText = "Gender";
            this.Col_gender.Name = "Col_gender";
            // 
            // Col_city
            // 
            this.Col_city.HeaderText = "City";
            this.Col_city.Name = "Col_city";
            // 
            // Col_state
            // 
            this.Col_state.HeaderText = "State";
            this.Col_state.Name = "Col_state";
            // 
            // Col_country
            // 
            this.Col_country.HeaderText = "Country";
            this.Col_country.Name = "Col_country";
            // 
            // Col_phone_no
            // 
            this.Col_phone_no.HeaderText = "Phone No";
            this.Col_phone_no.Name = "Col_phone_no";
            // 
            // Col_address
            // 
            this.Col_address.HeaderText = "Address";
            this.Col_address.Name = "Col_address";
            // 
            // Col_qualification
            // 
            this.Col_qualification.HeaderText = "Qualification";
            this.Col_qualification.Name = "Col_qualification";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(190, 322);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(314, 322);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(433, 322);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(551, 322);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(905, 367);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "details";
            this.Text = "details";
            this.Load += new System.EventHandler(this.details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_phone_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_qualification;
    }
}