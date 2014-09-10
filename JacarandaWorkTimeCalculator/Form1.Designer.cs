namespace JacarandaWorkTimeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_correct_total = new System.Windows.Forms.TextBox();
            this.label_correct_total = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_total_time = new System.Windows.Forms.Label();
            this.label_total_sum = new System.Windows.Forms.Label();
            this.textBox_time_sum = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(20, 43);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(62, 25);
            this.textBox_start.TabIndex = 0;
            this.textBox_start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textbox_start_mouseClick);
            this.textBox_start.TextChanged += new System.EventHandler(this.textBox_start_TextChanged);
            // 
            // textBox_end
            // 
            this.textBox_end.Location = new System.Drawing.Point(109, 43);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.Size = new System.Drawing.Size(64, 25);
            this.textBox_end.TabIndex = 1;
            this.textBox_end.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textbox_end_mouseClick);
            this.textBox_end.TextChanged += new System.EventHandler(this.textBox_end_TextChanged);
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(207, 43);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(96, 25);
            this.textBox_total.TabIndex = 2;
            this.textBox_total.TextChanged += new System.EventHandler(this.textBox_total_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(17, 17);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(67, 15);
            this.label_start.TabIndex = 4;
            this.label_start.Text = "上班時間";
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(106, 17);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(67, 15);
            this.label_end.TabIndex = 5;
            this.label_end.Text = "下班時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "計算時數";
            // 
            // textBox_correct_total
            // 
            this.textBox_correct_total.Location = new System.Drawing.Point(319, 43);
            this.textBox_correct_total.Name = "textBox_correct_total";
            this.textBox_correct_total.Size = new System.Drawing.Size(92, 25);
            this.textBox_correct_total.TabIndex = 9;
            this.textBox_correct_total.TextChanged += new System.EventHandler(this.textBox_correct_total_TextChanged);
            // 
            // label_correct_total
            // 
            this.label_correct_total.AutoSize = true;
            this.label_correct_total.Location = new System.Drawing.Point(316, 17);
            this.label_correct_total.Name = "label_correct_total";
            this.label_correct_total.Size = new System.Drawing.Size(67, 15);
            this.label_correct_total.TabIndex = 8;
            this.label_correct_total.Text = "校正時數";
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(422, 43);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 10;
            this.button_enter.Text = "輸入";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(20, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(228, 184);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label_total_time
            // 
            this.label_total_time.Location = new System.Drawing.Point(17, 87);
            this.label_total_time.Name = "label_total_time";
            this.label_total_time.Size = new System.Drawing.Size(83, 23);
            this.label_total_time.TabIndex = 0;
            this.label_total_time.Text = "總時數";
            this.label_total_time.Click += new System.EventHandler(this.label_total_time_Click);
            // 
            // label_total_sum
            // 
            this.label_total_sum.AutoSize = true;
            this.label_total_sum.Location = new System.Drawing.Point(21, 311);
            this.label_total_sum.Name = "label_total_sum";
            this.label_total_sum.Size = new System.Drawing.Size(86, 15);
            this.label_total_sum.TabIndex = 12;
            this.label_total_sum.Text = "總時數計算:";
            // 
            // textBox_time_sum
            // 
            this.textBox_time_sum.Location = new System.Drawing.Point(113, 308);
            this.textBox_time_sum.Name = "textBox_time_sum";
            this.textBox_time_sum.Size = new System.Drawing.Size(91, 25);
            this.textBox_time_sum.TabIndex = 13;
            this.textBox_time_sum.TextChanged += new System.EventHandler(this.textBox_time_sum_TextChanged);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(129, 84);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(119, 23);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "刪除選取";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(282, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 162);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 120);
            this.label4.TabIndex = 0;
            this.label4.Text = "1. 上班時間，下班時間格式為\r\n     OOXX <OO-時 XX - 分>\r\n    (ex : 08:53 請輸入0853 )\r\n\r\n2. 校正時數為店長" +
    "輸入以小時\r\n    為單位 \r\n    (ex : 8 hr,53 min => 9 )\r\n    (ex : 8 hr, 31 min => 8.5)\r\n";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(279, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "使用說明";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::JacarandaWorkTimeCalculator.Properties.Resources.logo_n;
            this.pictureBox_logo.InitialImage = null;
            this.pictureBox_logo.Location = new System.Drawing.Point(297, 282);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(176, 51);
            this.pictureBox_logo.TabIndex = 17;
            this.pictureBox_logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 350);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_time_sum);
            this.Controls.Add(this.label_total_sum);
            this.Controls.Add(this.label_total_time);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.label_correct_total);
            this.Controls.Add(this.textBox_correct_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.textBox_end);
            this.Controls.Add(this.textBox_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "天生澳克打工時數計算器 @_larrywhy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_start;
        private System.Windows.Forms.TextBox textBox_end;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_correct_total;
        private System.Windows.Forms.Label label_correct_total;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_total_time;
        private System.Windows.Forms.Label label_total_sum;
        private System.Windows.Forms.TextBox textBox_time_sum;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}

