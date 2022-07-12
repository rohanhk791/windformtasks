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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dxbtn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.dxbtn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.dxbtn_Addnew = new DevExpress.XtraEditors.SimpleButton();
            this.dxbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.dxdatagridview = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(842, 112);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.dataGridView1_BindingContextChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(130, 185);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 26);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(290, 185);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(97, 26);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(443, 185);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 26);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Add new";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(595, 185);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 26);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dxbtn_edit
            // 
            this.dxbtn_edit.Location = new System.Drawing.Point(130, 228);
            this.dxbtn_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dxbtn_edit.Name = "dxbtn_edit";
            this.dxbtn_edit.Size = new System.Drawing.Size(97, 26);
            this.dxbtn_edit.TabIndex = 6;
            this.dxbtn_edit.Text = "Edit";
            this.dxbtn_edit.Click += new System.EventHandler(this.dxbtn_edit_Click);
            // 
            // dxbtn_delete
            // 
            this.dxbtn_delete.Location = new System.Drawing.Point(290, 228);
            this.dxbtn_delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dxbtn_delete.Name = "dxbtn_delete";
            this.dxbtn_delete.Size = new System.Drawing.Size(97, 26);
            this.dxbtn_delete.TabIndex = 7;
            this.dxbtn_delete.Text = "Delete";
            this.dxbtn_delete.Click += new System.EventHandler(this.dxbtn_delete_Click);
            // 
            // dxbtn_Addnew
            // 
            this.dxbtn_Addnew.Location = new System.Drawing.Point(443, 228);
            this.dxbtn_Addnew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dxbtn_Addnew.Name = "dxbtn_Addnew";
            this.dxbtn_Addnew.Size = new System.Drawing.Size(97, 26);
            this.dxbtn_Addnew.TabIndex = 8;
            this.dxbtn_Addnew.Text = "Add new";
            this.dxbtn_Addnew.Click += new System.EventHandler(this.dxbtn_Addnew_Click);
            // 
            // dxbtn_close
            // 
            this.dxbtn_close.Location = new System.Drawing.Point(595, 228);
            this.dxbtn_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dxbtn_close.Name = "dxbtn_close";
            this.dxbtn_close.Size = new System.Drawing.Size(97, 26);
            this.dxbtn_close.TabIndex = 9;
            this.dxbtn_close.Text = "Close";
            this.dxbtn_close.Click += new System.EventHandler(this.dxbtn_close_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(863, 257);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(475, 280);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.CardWidth = 257;
            this.cardView1.DetailHeight = 396;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // dxdatagridview
            // 
            this.dxdatagridview.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dxdatagridview.Location = new System.Drawing.Point(13, 269);
            this.dxdatagridview.MainView = this.gridView1;
            this.dxdatagridview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dxdatagridview.Name = "dxdatagridview";
            this.dxdatagridview.Size = new System.Drawing.Size(842, 226);
            this.dxdatagridview.TabIndex = 12;
            this.dxdatagridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 396;
            this.gridView1.GridControl = this.dxdatagridview;
            this.gridView1.Name = "gridView1";
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1361, 538);
            this.Controls.Add(this.dxdatagridview);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dxbtn_close);
            this.Controls.Add(this.dxbtn_Addnew);
            this.Controls.Add(this.dxbtn_delete);
            this.Controls.Add(this.dxbtn_edit);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "details";
            this.Text = "details";
            this.Load += new System.EventHandler(this.details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_edit;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_close;
        private DevExpress.XtraEditors.SimpleButton dxbtn_edit;
        private DevExpress.XtraEditors.SimpleButton dxbtn_delete;
        private DevExpress.XtraEditors.SimpleButton dxbtn_Addnew;
        private DevExpress.XtraEditors.SimpleButton dxbtn_close;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.GridControl dxdatagridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}