
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
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_phone_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
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
            this.col_name,
            this.Col_age,
            this.Col_gender,
            this.col_city,
            this.Col_state,
            this.Col_Country,
            this.Col_phone_no,
            this.col_address,
            this.Col_qualification});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(881, 200);
            this.dataGridView1.TabIndex = 1;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
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
            // col_city
            // 
            this.col_city.HeaderText = "City";
            this.col_city.Name = "col_city";
            // 
            // Col_state
            // 
            this.Col_state.HeaderText = "State";
            this.Col_state.Name = "Col_state";
            // 
            // Col_Country
            // 
            this.Col_Country.HeaderText = "Country";
            this.Col_Country.Name = "Col_Country";
            // 
            // Col_phone_no
            // 
            this.Col_phone_no.HeaderText = "Phone no";
            this.Col_phone_no.Name = "Col_phone_no";
            // 
            // col_address
            // 
            this.col_address.HeaderText = "Address";
            this.col_address.Name = "col_address";
            // 
            // Col_qualification
            // 
            this.Col_qualification.HeaderText = "Qualification";
            this.Col_qualification.Name = "Col_qualification";
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(190, 322);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(75, 23);
            this.but_edit.TabIndex = 2;
            this.but_edit.Text = "Edit";
            this.but_edit.UseVisualStyleBackColor = true;
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(314, 322);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 23);
            this.but_delete.TabIndex = 3;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = true;
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(433, 322);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 23);
            this.but_clear.TabIndex = 4;
            this.but_clear.Text = "Clear";
            this.but_clear.UseVisualStyleBackColor = true;
            // 
            // but_close
            // 
            this.but_close.Location = new System.Drawing.Point(551, 322);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(75, 23);
            this.but_close.TabIndex = 5;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 469);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "details";
            this.Text = "details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_phone_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_qualification;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_clear;
        private System.Windows.Forms.Button but_close;
    }
}