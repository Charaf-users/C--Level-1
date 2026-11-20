namespace PictureBox_Ex
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RB_Boy = new System.Windows.Forms.RadioButton();
            this.RB_Girl = new System.Windows.Forms.RadioButton();
            this.RB_Book = new System.Windows.Forms.RadioButton();
            this.RB_Pencil = new System.Windows.Forms.RadioButton();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(225, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RB_Boy
            // 
            this.RB_Boy.AutoSize = true;
            this.RB_Boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Boy.Location = new System.Drawing.Point(235, 512);
            this.RB_Boy.Name = "RB_Boy";
            this.RB_Boy.Size = new System.Drawing.Size(79, 33);
            this.RB_Boy.TabIndex = 1;
            this.RB_Boy.TabStop = true;
            this.RB_Boy.Tag = "Boy";
            this.RB_Boy.Text = "Boy";
            this.RB_Boy.UseVisualStyleBackColor = true;
            this.RB_Boy.CheckedChanged += new System.EventHandler(this.RB_Boy_CheckedChanged);
            // 
            // RB_Girl
            // 
            this.RB_Girl.AutoSize = true;
            this.RB_Girl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Girl.Location = new System.Drawing.Point(379, 512);
            this.RB_Girl.Name = "RB_Girl";
            this.RB_Girl.Size = new System.Drawing.Size(76, 33);
            this.RB_Girl.TabIndex = 2;
            this.RB_Girl.TabStop = true;
            this.RB_Girl.Tag = "Girl";
            this.RB_Girl.Text = "Girl";
            this.RB_Girl.UseVisualStyleBackColor = true;
            this.RB_Girl.CheckedChanged += new System.EventHandler(this.RB_Girl_CheckedChanged);
            // 
            // RB_Book
            // 
            this.RB_Book.AutoSize = true;
            this.RB_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Book.Location = new System.Drawing.Point(525, 512);
            this.RB_Book.Name = "RB_Book";
            this.RB_Book.Size = new System.Drawing.Size(94, 33);
            this.RB_Book.TabIndex = 3;
            this.RB_Book.TabStop = true;
            this.RB_Book.Tag = "Book";
            this.RB_Book.Text = "Book";
            this.RB_Book.UseVisualStyleBackColor = true;
            this.RB_Book.CheckedChanged += new System.EventHandler(this.RB_Book_CheckedChanged);
            // 
            // RB_Pencil
            // 
            this.RB_Pencil.AutoSize = true;
            this.RB_Pencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Pencil.Location = new System.Drawing.Point(705, 512);
            this.RB_Pencil.Name = "RB_Pencil";
            this.RB_Pencil.Size = new System.Drawing.Size(105, 33);
            this.RB_Pencil.TabIndex = 4;
            this.RB_Pencil.TabStop = true;
            this.RB_Pencil.Tag = "Pencil";
            this.RB_Pencil.Text = "Pencil";
            this.RB_Pencil.UseVisualStyleBackColor = true;
            this.RB_Pencil.CheckedChanged += new System.EventHandler(this.RB_Pencil_CheckedChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(431, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 46);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1100, 632);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.RB_Pencil);
            this.Controls.Add(this.RB_Book);
            this.Controls.Add(this.RB_Girl);
            this.Controls.Add(this.RB_Boy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RB_Boy;
        private System.Windows.Forms.RadioButton RB_Girl;
        private System.Windows.Forms.RadioButton RB_Book;
        private System.Windows.Forms.RadioButton RB_Pencil;
        private System.Windows.Forms.Label lbName;
    }
}

