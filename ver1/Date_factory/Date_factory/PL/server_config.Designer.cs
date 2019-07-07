namespace Date_factory.PL
{
    partial class server_config
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_server_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_uer_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rb_sql = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data Base";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(42, 294);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 46);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(159, 294);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 46);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(114, 45);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(157, 20);
            this.txt_db.TabIndex = 20;
            // 
            // txt_server_name
            // 
            this.txt_server_name.Location = new System.Drawing.Point(114, 9);
            this.txt_server_name.Name = "txt_server_name";
            this.txt_server_name.Size = new System.Drawing.Size(157, 20);
            this.txt_server_name.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Server Name";
            // 
            // txt_uer_name
            // 
            this.txt_uer_name.Location = new System.Drawing.Point(99, 18);
            this.txt_uer_name.Name = "txt_uer_name";
            this.txt_uer_name.ReadOnly = true;
            this.txt_uer_name.Size = new System.Drawing.Size(157, 20);
            this.txt_uer_name.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(99, 78);
            this.txt_password.Name = "txt_password";
            this.txt_password.ReadOnly = true;
            this.txt_password.Size = new System.Drawing.Size(157, 20);
            this.txt_password.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(60, 31);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_uer_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 127);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(169, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Windows Authentication";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_sql
            // 
            this.rb_sql.AutoSize = true;
            this.rb_sql.Location = new System.Drawing.Point(19, 99);
            this.rb_sql.Name = "rb_sql";
            this.rb_sql.Size = new System.Drawing.Size(117, 17);
            this.rb_sql.TabIndex = 21;
            this.rb_sql.TabStop = true;
            this.rb_sql.Text = "SQL Authentication";
            this.rb_sql.UseVisualStyleBackColor = true;
            this.rb_sql.CheckedChanged += new System.EventHandler(this.rb_sql_CheckedChanged);
            // 
            // server_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.txt_server_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb_sql);
            this.Name = "server_config";
            this.Text = "server_config";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_uer_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb_sql;
        public System.Windows.Forms.TextBox txt_db;
        public System.Windows.Forms.TextBox txt_server_name;
    }
}