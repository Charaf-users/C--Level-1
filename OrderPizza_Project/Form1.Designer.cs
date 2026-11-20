namespace OrderPizza_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RD_Large = new System.Windows.Forms.RadioButton();
            this.RB_Meduim = new System.Windows.Forms.RadioButton();
            this.RB_Small = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdThickCrust = new System.Windows.Forms.RadioButton();
            this.RdThinkCrust = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RdTakeOut = new System.Windows.Forms.RadioButton();
            this.RdEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbUpdateSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbWereToEat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBTotalPrice = new System.Windows.Forms.Label();
            this.Eat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RD_Large);
            this.groupBox1.Controls.Add(this.RB_Meduim);
            this.groupBox1.Controls.Add(this.RB_Small);
            this.groupBox1.Location = new System.Drawing.Point(38, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // RD_Large
            // 
            this.RD_Large.AutoSize = true;
            this.RD_Large.Location = new System.Drawing.Point(48, 164);
            this.RD_Large.Name = "RD_Large";
            this.RD_Large.Size = new System.Drawing.Size(75, 24);
            this.RD_Large.TabIndex = 2;
            this.RD_Large.TabStop = true;
            this.RD_Large.Tag = "40";
            this.RD_Large.Text = "Large";
            this.RD_Large.UseVisualStyleBackColor = true;
            this.RD_Large.CheckedChanged += new System.EventHandler(this.RD_Large_CheckedChanged);
            // 
            // RB_Meduim
            // 
            this.RB_Meduim.AutoSize = true;
            this.RB_Meduim.Location = new System.Drawing.Point(48, 106);
            this.RB_Meduim.Name = "RB_Meduim";
            this.RB_Meduim.Size = new System.Drawing.Size(90, 24);
            this.RB_Meduim.TabIndex = 1;
            this.RB_Meduim.TabStop = true;
            this.RB_Meduim.Tag = "30";
            this.RB_Meduim.Text = "Meduim";
            this.RB_Meduim.UseVisualStyleBackColor = true;
            this.RB_Meduim.CheckedChanged += new System.EventHandler(this.RB_Meduim_CheckedChanged);
            // 
            // RB_Small
            // 
            this.RB_Small.AutoSize = true;
            this.RB_Small.Checked = true;
            this.RB_Small.Location = new System.Drawing.Point(48, 40);
            this.RB_Small.Name = "RB_Small";
            this.RB_Small.Size = new System.Drawing.Size(73, 24);
            this.RB_Small.TabIndex = 0;
            this.RB_Small.TabStop = true;
            this.RB_Small.Tag = "20";
            this.RB_Small.Text = "Small";
            this.RB_Small.UseVisualStyleBackColor = true;
            this.RB_Small.CheckedChanged += new System.EventHandler(this.RB_Small_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdThickCrust);
            this.groupBox2.Controls.Add(this.RdThinkCrust);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(38, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 167);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "5";
            this.groupBox2.Text = "Crust Type";
            // 
            // RdThickCrust
            // 
            this.RdThickCrust.AutoSize = true;
            this.RdThickCrust.Location = new System.Drawing.Point(22, 92);
            this.RdThickCrust.Name = "RdThickCrust";
            this.RdThickCrust.Size = new System.Drawing.Size(113, 24);
            this.RdThickCrust.TabIndex = 1;
            this.RdThickCrust.TabStop = true;
            this.RdThickCrust.Tag = "10";
            this.RdThickCrust.Text = "Thick Crust";
            this.RdThickCrust.UseVisualStyleBackColor = true;
            this.RdThickCrust.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // RdThinkCrust
            // 
            this.RdThinkCrust.AutoSize = true;
            this.RdThinkCrust.Checked = true;
            this.RdThinkCrust.Location = new System.Drawing.Point(24, 45);
            this.RdThinkCrust.Name = "RdThinkCrust";
            this.RdThinkCrust.Size = new System.Drawing.Size(114, 24);
            this.RdThinkCrust.TabIndex = 0;
            this.RdThinkCrust.TabStop = true;
            this.RdThinkCrust.Tag = "0";
            this.RdThinkCrust.Text = "Think Crust";
            this.RdThinkCrust.UseVisualStyleBackColor = true;
            this.RdThinkCrust.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(353, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 249);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(230, 148);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(143, 24);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Tag = "5";
            this.checkBox6.Text = "Green Peppers";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(230, 59);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(77, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Tag = "5";
            this.checkBox5.Text = "Onion";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(230, 107);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Tag = "5";
            this.checkBox4.Text = "Olives";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(44, 148);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Tag = "5";
            this.checkBox3.Text = "Tomatos";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(44, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "5";
            this.checkBox2.Text = "Mashrooms";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(44, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "5";
            this.checkBox1.Text = "Extra Chees";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RdTakeOut);
            this.groupBox4.Controls.Add(this.RdEatIn);
            this.groupBox4.Location = new System.Drawing.Point(353, 414);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where To Eat";
            // 
            // RdTakeOut
            // 
            this.RdTakeOut.AutoSize = true;
            this.RdTakeOut.Location = new System.Drawing.Point(148, 45);
            this.RdTakeOut.Name = "RdTakeOut";
            this.RdTakeOut.Size = new System.Drawing.Size(99, 24);
            this.RdTakeOut.TabIndex = 1;
            this.RdTakeOut.TabStop = true;
            this.RdTakeOut.Text = "Take Out";
            this.RdTakeOut.UseVisualStyleBackColor = true;
            this.RdTakeOut.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // RdEatIn
            // 
            this.RdEatIn.AutoSize = true;
            this.RdEatIn.Checked = true;
            this.RdEatIn.Location = new System.Drawing.Point(24, 45);
            this.RdEatIn.Name = "RdEatIn";
            this.RdEatIn.Size = new System.Drawing.Size(77, 24);
            this.RdEatIn.TabIndex = 0;
            this.RdEatIn.TabStop = true;
            this.RdEatIn.Text = "Eat In";
            this.RdEatIn.UseVisualStyleBackColor = true;
            this.RdEatIn.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Location = new System.Drawing.Point(323, 592);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(147, 55);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(556, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reset Form";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(819, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size : ";
            // 
            // LbUpdateSize
            // 
            this.LbUpdateSize.AutoSize = true;
            this.LbUpdateSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUpdateSize.Location = new System.Drawing.Point(905, 194);
            this.LbUpdateSize.Name = "LbUpdateSize";
            this.LbUpdateSize.Size = new System.Drawing.Size(0, 22);
            this.LbUpdateSize.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(818, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toppings :";
            // 
            // lbToppings
            // 
            this.lbToppings.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(819, 283);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(353, 133);
            this.lbToppings.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(825, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Crust Type :";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(990, 420);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(0, 22);
            this.lbCrustType.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(819, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Where To Eat :";
            // 
            // lbWereToEat
            // 
            this.lbWereToEat.AutoSize = true;
            this.lbWereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWereToEat.Location = new System.Drawing.Point(934, 495);
            this.lbWereToEat.Name = "lbWereToEat";
            this.lbWereToEat.Size = new System.Drawing.Size(0, 22);
            this.lbWereToEat.TabIndex = 16;
            this.lbWereToEat.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(819, 563);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Price  :";
            // 
            // LBTotalPrice
            // 
            this.LBTotalPrice.AutoSize = true;
            this.LBTotalPrice.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LBTotalPrice.Location = new System.Drawing.Point(878, 623);
            this.LBTotalPrice.Name = "LBTotalPrice";
            this.LBTotalPrice.Size = new System.Drawing.Size(97, 62);
            this.LBTotalPrice.TabIndex = 18;
            this.LBTotalPrice.Text = "$0";
            this.LBTotalPrice.Click += new System.EventHandler(this.LBTotalPrice_Click);
            // 
            // Eat
            // 
            this.Eat.AutoSize = true;
            this.Eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eat.Location = new System.Drawing.Point(934, 503);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(0, 25);
            this.Eat.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1213, 726);
            this.Controls.Add(this.Eat);
            this.Controls.Add(this.LBTotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbWereToEat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCrustType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbUpdateSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OrderPizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RD_Large;
        private System.Windows.Forms.RadioButton RB_Meduim;
        private System.Windows.Forms.RadioButton RB_Small;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdThickCrust;
        private System.Windows.Forms.RadioButton RdThinkCrust;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RdTakeOut;
        private System.Windows.Forms.RadioButton RdEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbUpdateSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbWereToEat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBTotalPrice;
        private System.Windows.Forms.Label Eat;
    }
}

