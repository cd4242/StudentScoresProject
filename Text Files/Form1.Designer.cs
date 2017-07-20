namespace Text_Files
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.lbNameAndScore = new System.Windows.Forms.ListBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.txtMaxStudentScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScoreAverage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butShow = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(12, 59);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(170, 20);
            this.txtStudentName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student\'s Name";
            // 
            // txtStudentScore
            // 
            this.txtStudentScore.Location = new System.Drawing.Point(12, 110);
            this.txtStudentScore.Name = "txtStudentScore";
            this.txtStudentScore.Size = new System.Drawing.Size(170, 20);
            this.txtStudentScore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student\'s Score ";
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Yellow;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butAdd.Location = new System.Drawing.Point(53, 136);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 27);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNameAndScore
            // 
            this.lbNameAndScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbNameAndScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbNameAndScore.FormattingEnabled = true;
            this.lbNameAndScore.Location = new System.Drawing.Point(12, 184);
            this.lbNameAndScore.Name = "lbNameAndScore";
            this.lbNameAndScore.Size = new System.Drawing.Size(170, 264);
            this.lbNameAndScore.TabIndex = 5;
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Yellow;
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butDelete.Location = new System.Drawing.Point(12, 454);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(116, 59);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Delete Selected Item";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMaxStudentScore
            // 
            this.txtMaxStudentScore.Location = new System.Drawing.Point(303, 59);
            this.txtMaxStudentScore.Name = "txtMaxStudentScore";
            this.txtMaxStudentScore.Size = new System.Drawing.Size(199, 20);
            this.txtMaxStudentScore.TabIndex = 7;
            this.txtMaxStudentScore.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(299, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student With Max Score";
            // 
            // txtScoreAverage
            // 
            this.txtScoreAverage.Location = new System.Drawing.Point(303, 110);
            this.txtScoreAverage.Name = "txtScoreAverage";
            this.txtScoreAverage.Size = new System.Drawing.Size(199, 20);
            this.txtScoreAverage.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(305, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average Score of Class";
            // 
            // butShow
            // 
            this.butShow.BackColor = System.Drawing.Color.Yellow;
            this.butShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butShow.Location = new System.Drawing.Point(365, 136);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(75, 29);
            this.butShow.TabIndex = 11;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = false;
            this.butShow.Click += new System.EventHandler(this.button3_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Yellow;
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butSave.Location = new System.Drawing.Point(134, 454);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(48, 59);
            this.butSave.TabIndex = 12;
            this.butSave.Text = "SAVE";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 329);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(573, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScoreAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxStudentScore);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.lbNameAndScore);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.ListBox lbNameAndScore;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox txtMaxStudentScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

