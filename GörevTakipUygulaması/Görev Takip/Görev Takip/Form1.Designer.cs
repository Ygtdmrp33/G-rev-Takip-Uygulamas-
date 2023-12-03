namespace Görev_Takip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addTask = new Guna.UI2.WinForms.Guna2Button();
            this.deleteTask = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaskTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ListTaskTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTaskDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTaskStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTaskEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addTask.FillColor = System.Drawing.Color.DarkGreen;
            this.addTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addTask.ForeColor = System.Drawing.Color.White;
            this.addTask.Location = new System.Drawing.Point(821, 12);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(180, 65);
            this.addTask.TabIndex = 1;
            this.addTask.Text = "Görev Ekle";
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteTask.ForeColor = System.Drawing.Color.White;
            this.deleteTask.Location = new System.Drawing.Point(821, 146);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(180, 65);
            this.deleteTask.TabIndex = 1;
            this.deleteTask.Text = "Görev Sil";
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.DateTimePicker);
            this.guna2GroupBox1.Controls.Add(this.TaskDesc);
            this.guna2GroupBox1.Controls.Add(this.TaskTitle);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(92)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(803, 199);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Görev Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bitiş Zamanı";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(340, 87);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(279, 23);
            this.DateTimePicker.TabIndex = 2;
            // 
            // TaskDesc
            // 
            this.TaskDesc.Animated = true;
            this.TaskDesc.BackColor = System.Drawing.Color.Transparent;
            this.TaskDesc.BorderRadius = 16;
            this.TaskDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaskDesc.DefaultText = "";
            this.TaskDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TaskDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TaskDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TaskDesc.ForeColor = System.Drawing.Color.Black;
            this.TaskDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskDesc.Location = new System.Drawing.Point(18, 105);
            this.TaskDesc.Name = "TaskDesc";
            this.TaskDesc.PasswordChar = '\0';
            this.TaskDesc.PlaceholderText = "Görev Açıklaması";
            this.TaskDesc.SelectedText = "";
            this.TaskDesc.Size = new System.Drawing.Size(296, 71);
            this.TaskDesc.TabIndex = 0;
            // 
            // TaskTitle
            // 
            this.TaskTitle.Animated = true;
            this.TaskTitle.BackColor = System.Drawing.Color.Transparent;
            this.TaskTitle.BorderRadius = 12;
            this.TaskTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaskTitle.DefaultText = "";
            this.TaskTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TaskTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TaskTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TaskTitle.ForeColor = System.Drawing.Color.Black;
            this.TaskTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskTitle.Location = new System.Drawing.Point(18, 63);
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.PasswordChar = '\0';
            this.TaskTitle.PlaceholderText = "Görev Adını giriniz";
            this.TaskTitle.SelectedText = "";
            this.TaskTitle.Size = new System.Drawing.Size(296, 36);
            this.TaskTitle.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskId,
            this.ListTaskTitle,
            this.ListTaskDesc,
            this.ListTaskStatus,
            this.ListTaskEndDate});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 217);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(989, 400);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ListTaskTitle
            // 
            this.ListTaskTitle.DisplayIndex = 0;
            this.ListTaskTitle.Text = "Görev";
            this.ListTaskTitle.Width = 200;
            // 
            // ListTaskDesc
            // 
            this.ListTaskDesc.DisplayIndex = 1;
            this.ListTaskDesc.Text = "Açıklama";
            this.ListTaskDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListTaskDesc.Width = 200;
            // 
            // ListTaskStatus
            // 
            this.ListTaskStatus.DisplayIndex = 2;
            this.ListTaskStatus.Text = "Durumu";
            this.ListTaskStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListTaskStatus.Width = 200;
            // 
            // ListTaskEndDate
            // 
            this.ListTaskEndDate.DisplayIndex = 3;
            this.ListTaskEndDate.Text = "Bitiş";
            this.ListTaskEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListTaskEndDate.Width = 200;
            // 
            // TaskId
            // 
            this.TaskId.DisplayIndex = 4;
            this.TaskId.Text = "TaskId";
            this.TaskId.Width = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(821, 83);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 57);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Tamamlandı Olarak İşaretle";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1013, 629);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.deleteTask);
            this.Controls.Add(this.addTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Görev Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addTask;
        private Guna.UI2.WinForms.Guna2Button deleteTask;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox TaskDesc;
        private Guna.UI2.WinForms.Guna2TextBox TaskTitle;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ListTaskTitle;
        private System.Windows.Forms.ColumnHeader ListTaskDesc;
        private System.Windows.Forms.ColumnHeader ListTaskStatus;
        private System.Windows.Forms.ColumnHeader ListTaskEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader TaskId;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

