namespace AnotherBank
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.txtGetCash = new System.Windows.Forms.TextBox();
            this.txtTakeCash = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCash);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(77, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtCash.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtCash.Location = new System.Drawing.Point(77, 107);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(194, 20);
            this.txtCash.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cash";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtName.Location = new System.Drawing.Point(77, 72);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(194, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(77, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.ForeColor = System.Drawing.Color.Gold;
            this.btnDeposit.Location = new System.Drawing.Point(13, 253);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(141, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTake.ForeColor = System.Drawing.Color.Gold;
            this.btnTake.Location = new System.Drawing.Point(173, 253);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(141, 23);
            this.btnTake.TabIndex = 8;
            this.btnTake.Text = "Take Out";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // txtGetCash
            // 
            this.txtGetCash.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtGetCash.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtGetCash.Location = new System.Drawing.Point(12, 218);
            this.txtGetCash.Name = "txtGetCash";
            this.txtGetCash.Size = new System.Drawing.Size(142, 20);
            this.txtGetCash.TabIndex = 7;
            // 
            // txtTakeCash
            // 
            this.txtTakeCash.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtTakeCash.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtTakeCash.Location = new System.Drawing.Point(173, 218);
            this.txtTakeCash.Name = "txtTakeCash";
            this.txtTakeCash.Size = new System.Drawing.Size(142, 20);
            this.txtTakeCash.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Lime;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnCreate.Location = new System.Drawing.Point(90, 287);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(141, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create New Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(326, 322);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtTakeCash);
            this.Controls.Add(this.txtGetCash);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Green Hill Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.TextBox txtGetCash;
        private System.Windows.Forms.TextBox txtTakeCash;
        private System.Windows.Forms.Button btnCreate;
    }
}

