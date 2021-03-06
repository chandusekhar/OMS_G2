﻿namespace Ordermanagement_01
{
    partial class Research_Order_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grd_Proposal_Comments = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txt_FollowupDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Update_County = new System.Windows.Forms.Button();
            this.ddl_New_County_Type = new System.Windows.Forms.ComboBox();
            this.txt_Subscription_Link = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.lbl_Proposal_client = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Proposal_Comments)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_Proposal_Comments
            // 
            this.grd_Proposal_Comments.AllowUserToAddRows = false;
            this.grd_Proposal_Comments.AllowUserToResizeRows = false;
            this.grd_Proposal_Comments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_Proposal_Comments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd_Proposal_Comments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grd_Proposal_Comments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Proposal_Comments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Proposal_Comments.ColumnHeadersHeight = 30;
            this.grd_Proposal_Comments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column1,
            this.Column3,
            this.Column7,
            this.Column6,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Proposal_Comments.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_Proposal_Comments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Proposal_Comments.Location = new System.Drawing.Point(3, 3);
            this.grd_Proposal_Comments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grd_Proposal_Comments.Name = "grd_Proposal_Comments";
            this.grd_Proposal_Comments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grd_Proposal_Comments.RowHeadersVisible = false;
            this.grd_Proposal_Comments.Size = new System.Drawing.Size(784, 349);
            this.grd_Proposal_Comments.TabIndex = 5;
            this.grd_Proposal_Comments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Proposal_Comments_CellClick);
            // 
            // Column8
            // 
            this.Column8.FillWeight = 15.47853F;
            this.Column8.HeaderText = "S.No";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.FillWeight = 212.4173F;
            this.Column9.HeaderText = "Comments";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 38.61141F;
            this.Column1.HeaderText = "Follow-up Date";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "User";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 30.11381F;
            this.Column7.HeaderText = "View";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Proposal_Client_Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User_Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grd_Proposal_Comments);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add/Edit Comments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 381);
            this.tabControl1.TabIndex = 221;
            this.tabControl1.TabStop = false;
            // 
            // txt_FollowupDate
            // 
            this.txt_FollowupDate.CustomFormat = " ";
            this.txt_FollowupDate.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FollowupDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_FollowupDate.Location = new System.Drawing.Point(124, 17);
            this.txt_FollowupDate.Name = "txt_FollowupDate";
            this.txt_FollowupDate.Size = new System.Drawing.Size(104, 25);
            this.txt_FollowupDate.TabIndex = 87;
            this.txt_FollowupDate.Value = new System.DateTime(2016, 1, 21, 0, 0, 0, 0);
            this.txt_FollowupDate.ValueChanged += new System.EventHandler(this.txt_FollowupDate_ValueChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(660, 118);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(131, 27);
            this.btn_Clear.TabIndex = 92;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Follow-up Date:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(660, 53);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(131, 27);
            this.btn_Submit.TabIndex = 91;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Update_County);
            this.groupBox1.Controls.Add(this.ddl_New_County_Type);
            this.groupBox1.Controls.Add(this.txt_Subscription_Link);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_FollowupDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Comments);
            this.groupBox1.Location = new System.Drawing.Point(8, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 210);
            this.groupBox1.TabIndex = 218;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Comments";
            // 
            // btn_Update_County
            // 
            this.btn_Update_County.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_County.Location = new System.Drawing.Point(660, 86);
            this.btn_Update_County.Name = "btn_Update_County";
            this.btn_Update_County.Size = new System.Drawing.Size(134, 26);
            this.btn_Update_County.TabIndex = 144;
            this.btn_Update_County.Text = "Update County Type";
            this.btn_Update_County.UseVisualStyleBackColor = true;
            this.btn_Update_County.Click += new System.EventHandler(this.btn_Update_County_Click);
            // 
            // ddl_New_County_Type
            // 
            this.ddl_New_County_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_New_County_Type.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_New_County_Type.FormattingEnabled = true;
            this.ddl_New_County_Type.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddl_New_County_Type.Location = new System.Drawing.Point(331, 17);
            this.ddl_New_County_Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddl_New_County_Type.Name = "ddl_New_County_Type";
            this.ddl_New_County_Type.Size = new System.Drawing.Size(323, 28);
            this.ddl_New_County_Type.TabIndex = 143;
            // 
            // txt_Subscription_Link
            // 
            this.txt_Subscription_Link.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subscription_Link.Location = new System.Drawing.Point(122, 171);
            this.txt_Subscription_Link.Multiline = true;
            this.txt_Subscription_Link.Name = "txt_Subscription_Link";
            this.txt_Subscription_Link.Size = new System.Drawing.Size(532, 30);
            this.txt_Subscription_Link.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Subscription Link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "County Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comments.Location = new System.Drawing.Point(122, 53);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(532, 105);
            this.txt_Comments.TabIndex = 89;
            // 
            // lbl_Proposal_client
            // 
            this.lbl_Proposal_client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Proposal_client.AutoSize = true;
            this.lbl_Proposal_client.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proposal_client.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(156)))));
            this.lbl_Proposal_client.Location = new System.Drawing.Point(309, 5);
            this.lbl_Proposal_client.Name = "lbl_Proposal_client";
            this.lbl_Proposal_client.Size = new System.Drawing.Size(0, 31);
            this.lbl_Proposal_client.TabIndex = 217;
            this.lbl_Proposal_client.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Research_Order_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Proposal_client);
            this.Name = "Research_Order_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Research_Order_History";
            this.Load += new System.EventHandler(this.Research_Order_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Proposal_Comments)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Proposal_Comments;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker txt_FollowupDate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Label lbl_Proposal_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Subscription_Link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddl_New_County_Type;
        private System.Windows.Forms.Button btn_Update_County;
    }
}