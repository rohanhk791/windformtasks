
namespace windformtasks
{
    partial class register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.com_city = new System.Windows.Forms.ComboBox();
            this.com_state = new System.Windows.Forms.ComboBox();
            this.com_country = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone_no = new System.Windows.Forms.TextBox();
            this.lbl_qualification = new System.Windows.Forms.Label();
            this.txt_qualification = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Page";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_id.Location = new System.Drawing.Point(37, 60);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(32, 19);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Id :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(37, 91);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 19);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name :";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_age.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_age.Location = new System.Drawing.Point(37, 129);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(45, 19);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Age :";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_gender.Location = new System.Drawing.Point(37, 167);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(68, 19);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "Gender :";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_city.Location = new System.Drawing.Point(37, 202);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(46, 19);
            this.lbl_city.TabIndex = 5;
            this.lbl_city.Text = "City :";
            this.lbl_city.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_state.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_state.Location = new System.Drawing.Point(38, 234);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(53, 19);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "State :";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_country.Location = new System.Drawing.Point(38, 265);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(72, 19);
            this.lbl_country.TabIndex = 7;
            this.lbl_country.Text = "Country :";
            // 
            // lbl_phone_no
            // 
            this.lbl_phone_no.AutoSize = true;
            this.lbl_phone_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_phone_no.Location = new System.Drawing.Point(38, 301);
            this.lbl_phone_no.Name = "lbl_phone_no";
            this.lbl_phone_no.Size = new System.Drawing.Size(79, 19);
            this.lbl_phone_no.TabIndex = 8;
            this.lbl_phone_no.Text = "Phone no :";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_address.Location = new System.Drawing.Point(38, 339);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(73, 19);
            this.lbl_address.TabIndex = 9;
            this.lbl_address.Text = "Address :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(154, 60);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(119, 23);
            this.txt_id.TabIndex = 10;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(154, 87);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(119, 23);
            this.txt_name.TabIndex = 11;
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(154, 125);
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(50, 23);
            this.num_age.TabIndex = 12;
            // 
            // com_city
            // 
            this.com_city.AutoCompleteCustomSource.AddRange(new string[] {
            "Bagalkot",
            "Ballari ",
            "Belagavi ",
            "Bengaluru  Rural",
            "Bengaluru Urban",
            "Bidar",
            "Chamarajanagar",
            "Chikballapur",
            "Chikkamagaluru ",
            "Chitradurga",
            "Dakshina Kannada",
            "Davangere",
            "Dharwad",
            "Gadag",
            "Hassan",
            "Haveri",
            "Kalaburagi ",
            "Kodagu",
            "Kolar",
            "Koppal",
            "Mandya",
            "Mysuru ",
            "Raichur",
            "Ramanagara",
            "Shivamogga ",
            "Tumakuru",
            "Udupi",
            "Karwar",
            "Vijayapura",
            "Yadgir"});
            this.com_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_city.FormattingEnabled = true;
            this.com_city.Items.AddRange(new object[] {
            "Bagalkot",
            "Ballari (Bellary)",
            "Belagavi (Belgaum)",
            "Bengaluru (Bangalore) Rural",
            "Bengaluru (Bangalore) Urban",
            "Bidar",
            "Chamarajanagar",
            "Chikballapur",
            "Chikkamagaluru (Chikmagalur)",
            "Chitradurga",
            "Dakshina Kannada",
            "Davangere",
            "Dharwad",
            "Gadag",
            "Hassan",
            "Haveri",
            "Kalaburagi (Gulbarga)",
            "Kodagu",
            "Kolar",
            "Koppal",
            "Mandya",
            "Mysuru (Mysore)",
            "Raichur",
            "Ramanagara",
            "Shivamogga (Shimoga)",
            "Tumakuru (Tumkur)",
            "Udupi",
            "Uttara Kannada (Karwar)",
            "Vijayapura (Bijapur)",
            "Yadgir"});
            this.com_city.Location = new System.Drawing.Point(153, 198);
            this.com_city.Name = "com_city";
            this.com_city.Size = new System.Drawing.Size(121, 23);
            this.com_city.TabIndex = 13;
            this.com_city.SelectedIndexChanged += new System.EventHandler(this.com_city_SelectedIndexChanged);
            // 
            // com_state
            // 
            this.com_state.AutoCompleteCustomSource.AddRange(new string[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal",
            "Andaman and Nicobar Islands",
            "Chandigarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Lakshadweep",
            "Puducherry"});
            this.com_state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_state.FormattingEnabled = true;
            this.com_state.Location = new System.Drawing.Point(154, 230);
            this.com_state.Name = "com_state";
            this.com_state.Size = new System.Drawing.Size(121, 23);
            this.com_state.TabIndex = 14;
            // 
            // com_country
            // 
            this.com_country.AutoCompleteCustomSource.AddRange(new string[] {
            "India"});
            this.com_country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_country.FormattingEnabled = true;
            this.com_country.Location = new System.Drawing.Point(154, 261);
            this.com_country.Name = "com_country";
            this.com_country.Size = new System.Drawing.Size(121, 23);
            this.com_country.TabIndex = 15;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_add.Location = new System.Drawing.Point(129, 427);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(184, 456);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 19;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(38, 427);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Close";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(223, 427);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(82, 456);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 22;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Location = new System.Drawing.Point(153, 166);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(51, 19);
            this.rad_male.TabIndex = 23;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(210, 166);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(63, 19);
            this.rad_female.TabIndex = 24;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(153, 339);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(122, 23);
            this.txt_address.TabIndex = 25;
            // 
            // txt_phone_no
            // 
            this.txt_phone_no.Location = new System.Drawing.Point(153, 297);
            this.txt_phone_no.Name = "txt_phone_no";
            this.txt_phone_no.Size = new System.Drawing.Size(122, 23);
            this.txt_phone_no.TabIndex = 26;
            this.txt_phone_no.TextChanged += new System.EventHandler(this.txt_phone_no_TextChanged);
            // 
            // lbl_qualification
            // 
            this.lbl_qualification.AutoSize = true;
            this.lbl_qualification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_qualification.Location = new System.Drawing.Point(37, 372);
            this.lbl_qualification.Name = "lbl_qualification";
            this.lbl_qualification.Size = new System.Drawing.Size(103, 19);
            this.lbl_qualification.TabIndex = 27;
            this.lbl_qualification.Text = "Qualification :";
            // 
            // txt_qualification
            // 
            this.txt_qualification.Location = new System.Drawing.Point(153, 368);
            this.txt_qualification.Name = "txt_qualification";
            this.txt_qualification.Size = new System.Drawing.Size(122, 23);
            this.txt_qualification.TabIndex = 28;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(313, 483);
            this.Controls.Add(this.txt_qualification);
            this.Controls.Add(this.lbl_qualification);
            this.Controls.Add(this.txt_phone_no);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.com_country);
            this.Controls.Add(this.com_state);
            this.Controls.Add(this.com_city);
            this.Controls.Add(this.num_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phone_no);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "register";
            this.Text = "Register page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_phone_no;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label lbl_qualification;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.NumericUpDown num_age;
        public System.Windows.Forms.ComboBox com_city;
        public System.Windows.Forms.ComboBox com_state;
        public System.Windows.Forms.ComboBox com_country;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.RadioButton rad_male;
        public System.Windows.Forms.RadioButton rad_female;
        public System.Windows.Forms.TextBox txt_address;
        public System.Windows.Forms.TextBox txt_phone_no;
        public System.Windows.Forms.TextBox txt_qualification;
    }
}

