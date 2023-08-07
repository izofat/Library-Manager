namespace Library_Manager
{
    partial class Library
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonbarrow = new System.Windows.Forms.Button();
            this.buttonreturn = new System.Windows.Forms.Button();
            this.groupBoxactions = new System.Windows.Forms.GroupBox();
            this.buttonworker = new System.Windows.Forms.Button();
            this.buttoncustomer = new System.Windows.Forms.Button();
            this.groupBoxlogin = new System.Windows.Forms.GroupBox();
            this.buttonshowpw = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxpassw = new System.Windows.Forms.TextBox();
            this.labelpw = new System.Windows.Forms.Label();
            this.textBoxusern = new System.Windows.Forms.TextBox();
            this.labelun = new System.Windows.Forms.Label();
            this.groupBoxworkactions = new System.Windows.Forms.GroupBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.labelpubly = new System.Windows.Forms.Label();
            this.textBoxpubly = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxactions.SuspendLayout();
            this.groupBoxlogin.SuspendLayout();
            this.groupBoxworkactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(540, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(431, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonbarrow
            // 
            this.buttonbarrow.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonbarrow.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonbarrow.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbarrow.ForeColor = System.Drawing.Color.White;
            this.buttonbarrow.Location = new System.Drawing.Point(9, 19);
            this.buttonbarrow.Name = "buttonbarrow";
            this.buttonbarrow.Size = new System.Drawing.Size(125, 69);
            this.buttonbarrow.TabIndex = 1;
            this.buttonbarrow.Text = "Barrow";
            this.buttonbarrow.UseVisualStyleBackColor = false;
            this.buttonbarrow.Click += new System.EventHandler(this.buttonbarrow_Click);
            // 
            // buttonreturn
            // 
            this.buttonreturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonreturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonreturn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonreturn.FlatAppearance.BorderSize = 0;
            this.buttonreturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonreturn.Location = new System.Drawing.Point(9, 107);
            this.buttonreturn.Name = "buttonreturn";
            this.buttonreturn.Size = new System.Drawing.Size(125, 68);
            this.buttonreturn.TabIndex = 3;
            this.buttonreturn.Text = "Return";
            this.buttonreturn.UseVisualStyleBackColor = false;
            this.buttonreturn.Click += new System.EventHandler(this.buttonreturn_Click);
            // 
            // groupBoxactions
            // 
            this.groupBoxactions.Controls.Add(this.buttonbarrow);
            this.groupBoxactions.Controls.Add(this.buttonreturn);
            this.groupBoxactions.Location = new System.Drawing.Point(376, 314);
            this.groupBoxactions.Name = "groupBoxactions";
            this.groupBoxactions.Size = new System.Drawing.Size(158, 190);
            this.groupBoxactions.TabIndex = 4;
            this.groupBoxactions.TabStop = false;
            this.groupBoxactions.Visible = false;
            // 
            // buttonworker
            // 
            this.buttonworker.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonworker.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonworker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonworker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonworker.Location = new System.Drawing.Point(268, 27);
            this.buttonworker.Name = "buttonworker";
            this.buttonworker.Size = new System.Drawing.Size(125, 85);
            this.buttonworker.TabIndex = 5;
            this.buttonworker.Text = "Worker";
            this.buttonworker.UseVisualStyleBackColor = false;
            this.buttonworker.Click += new System.EventHandler(this.buttonworker_Click);
            // 
            // buttoncustomer
            // 
            this.buttoncustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttoncustomer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttoncustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttoncustomer.Location = new System.Drawing.Point(86, 27);
            this.buttoncustomer.Name = "buttoncustomer";
            this.buttoncustomer.Size = new System.Drawing.Size(125, 85);
            this.buttoncustomer.TabIndex = 6;
            this.buttoncustomer.Text = "Customer";
            this.buttoncustomer.UseVisualStyleBackColor = false;
            this.buttoncustomer.Click += new System.EventHandler(this.buttoncustomer_Click);
            // 
            // groupBoxlogin
            // 
            this.groupBoxlogin.Controls.Add(this.textBoxpubly);
            this.groupBoxlogin.Controls.Add(this.labelpubly);
            this.groupBoxlogin.Controls.Add(this.buttonshowpw);
            this.groupBoxlogin.Controls.Add(this.buttonlogin);
            this.groupBoxlogin.Controls.Add(this.textBoxpassw);
            this.groupBoxlogin.Controls.Add(this.labelpw);
            this.groupBoxlogin.Controls.Add(this.textBoxusern);
            this.groupBoxlogin.Controls.Add(this.labelun);
            this.groupBoxlogin.Location = new System.Drawing.Point(41, 163);
            this.groupBoxlogin.Name = "groupBoxlogin";
            this.groupBoxlogin.Size = new System.Drawing.Size(307, 266);
            this.groupBoxlogin.TabIndex = 7;
            this.groupBoxlogin.TabStop = false;
            this.groupBoxlogin.Visible = false;
            // 
            // buttonshowpw
            // 
            this.buttonshowpw.Location = new System.Drawing.Point(269, 78);
            this.buttonshowpw.Name = "buttonshowpw";
            this.buttonshowpw.Size = new System.Drawing.Size(32, 28);
            this.buttonshowpw.TabIndex = 9;
            this.buttonshowpw.UseVisualStyleBackColor = true;
            this.buttonshowpw.Click += new System.EventHandler(this.buttonshowpw_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonlogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.Black;
            this.buttonlogin.Location = new System.Drawing.Point(118, 170);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(81, 54);
            this.buttonlogin.TabIndex = 8;
            this.buttonlogin.Text = "Log in";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxpassw
            // 
            this.textBoxpassw.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassw.Location = new System.Drawing.Point(128, 78);
            this.textBoxpassw.Name = "textBoxpassw";
            this.textBoxpassw.Size = new System.Drawing.Size(145, 28);
            this.textBoxpassw.TabIndex = 6;
            // 
            // labelpw
            // 
            this.labelpw.AutoSize = true;
            this.labelpw.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpw.Location = new System.Drawing.Point(31, 85);
            this.labelpw.Name = "labelpw";
            this.labelpw.Size = new System.Drawing.Size(88, 21);
            this.labelpw.TabIndex = 2;
            this.labelpw.Text = "Password :";
            // 
            // textBoxusern
            // 
            this.textBoxusern.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusern.Location = new System.Drawing.Point(128, 30);
            this.textBoxusern.Name = "textBoxusern";
            this.textBoxusern.Size = new System.Drawing.Size(145, 28);
            this.textBoxusern.TabIndex = 1;
            // 
            // labelun
            // 
            this.labelun.AutoSize = true;
            this.labelun.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelun.Location = new System.Drawing.Point(31, 37);
            this.labelun.Name = "labelun";
            this.labelun.Size = new System.Drawing.Size(91, 21);
            this.labelun.TabIndex = 0;
            this.labelun.Text = "Username :";
            // 
            // groupBoxworkactions
            // 
            this.groupBoxworkactions.Controls.Add(this.buttondelete);
            this.groupBoxworkactions.Controls.Add(this.buttonadd);
            this.groupBoxworkactions.Location = new System.Drawing.Point(376, 118);
            this.groupBoxworkactions.Name = "groupBoxworkactions";
            this.groupBoxworkactions.Size = new System.Drawing.Size(158, 190);
            this.groupBoxworkactions.TabIndex = 5;
            this.groupBoxworkactions.TabStop = false;
            this.groupBoxworkactions.Visible = false;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttondelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttondelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.Color.White;
            this.buttondelete.Location = new System.Drawing.Point(9, 19);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(125, 69);
            this.buttondelete.TabIndex = 1;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonadd.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonadd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonadd.FlatAppearance.BorderSize = 0;
            this.buttonadd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonadd.Location = new System.Drawing.Point(9, 107);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(125, 68);
            this.buttonadd.TabIndex = 3;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // labelpubly
            // 
            this.labelpubly.AutoSize = true;
            this.labelpubly.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpubly.Location = new System.Drawing.Point(34, 129);
            this.labelpubly.Name = "labelpubly";
            this.labelpubly.Size = new System.Drawing.Size(77, 21);
            this.labelpubly.TabIndex = 10;
            this.labelpubly.Text = "PubYear :";
            this.labelpubly.Visible = false;
            // 
            // textBoxpubly
            // 
            this.textBoxpubly.Font = new System.Drawing.Font("Calibri", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpubly.Location = new System.Drawing.Point(128, 126);
            this.textBoxpubly.Name = "textBoxpubly";
            this.textBoxpubly.Size = new System.Drawing.Size(145, 28);
            this.textBoxpubly.TabIndex = 11;
            this.textBoxpubly.Visible = false;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 532);
            this.Controls.Add(this.groupBoxworkactions);
            this.Controls.Add(this.groupBoxlogin);
            this.Controls.Add(this.buttoncustomer);
            this.Controls.Add(this.buttonworker);
            this.Controls.Add(this.groupBoxactions);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Library";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxactions.ResumeLayout(false);
            this.groupBoxlogin.ResumeLayout(false);
            this.groupBoxlogin.PerformLayout();
            this.groupBoxworkactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonbarrow;
        private System.Windows.Forms.Button buttonreturn;
        private System.Windows.Forms.GroupBox groupBoxactions;
        private System.Windows.Forms.Button buttonworker;
        private System.Windows.Forms.Button buttoncustomer;
        private System.Windows.Forms.GroupBox groupBoxlogin;
        private System.Windows.Forms.Label labelpw;
        private System.Windows.Forms.TextBox textBoxusern;
        private System.Windows.Forms.Label labelun;
        private System.Windows.Forms.GroupBox groupBoxworkactions;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textBoxpassw;
        private System.Windows.Forms.Button buttonshowpw;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxpubly;
        private System.Windows.Forms.Label labelpubly;
    }
}

