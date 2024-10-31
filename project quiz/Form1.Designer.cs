namespace project_quiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelquestion = new System.Windows.Forms.Label();
            this.question1 = new System.Windows.Forms.RadioButton();
            this.question2 = new System.Windows.Forms.RadioButton();
            this.question3 = new System.Windows.Forms.RadioButton();
            this.question4 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelquestion
            // 
            this.labelquestion.AutoSize = true;
            this.labelquestion.Location = new System.Drawing.Point(290, 52);
            this.labelquestion.Name = "labelquestion";
            this.labelquestion.Size = new System.Drawing.Size(16, 17);
            this.labelquestion.TabIndex = 0;
            this.labelquestion.Text = "0";
            this.labelquestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelquestion.Visible = false;
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Location = new System.Drawing.Point(613, 17);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(106, 21);
            this.question1.TabIndex = 1;
            this.question1.TabStop = true;
            this.question1.Text = "radioButton1";
            this.question1.UseVisualStyleBackColor = true;
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Location = new System.Drawing.Point(400, 17);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(106, 21);
            this.question2.TabIndex = 2;
            this.question2.TabStop = true;
            this.question2.Text = "radioButton2";
            this.question2.UseVisualStyleBackColor = true;
            // 
            // question3
            // 
            this.question3.AutoSize = true;
            this.question3.Location = new System.Drawing.Point(206, 17);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(106, 21);
            this.question3.TabIndex = 3;
            this.question3.TabStop = true;
            this.question3.Text = "radioButton3";
            this.question3.UseVisualStyleBackColor = true;
            // 
            // question4
            // 
            this.question4.AutoSize = true;
            this.question4.Location = new System.Drawing.Point(24, 17);
            this.question4.Name = "question4";
            this.question4.Size = new System.Drawing.Size(106, 21);
            this.question4.TabIndex = 4;
            this.question4.TabStop = true;
            this.question4.Text = "radioButton4";
            this.question4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Location = new System.Drawing.Point(397, 205);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(16, 17);
            this.labeltime.TabIndex = 5;
            this.labeltime.Text = "0";
            this.labeltime.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.question2);
            this.panel1.Controls.Add(this.question1);
            this.panel1.Controls.Add(this.question4);
            this.panel1.Controls.Add(this.question3);
            this.panel1.Location = new System.Drawing.Point(54, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 51);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(380, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 76);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(575, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 76);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelquestion);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labeltime);
            this.panel2.Location = new System.Drawing.Point(3, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 260);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "الرجاء اختيار احد المجالات التالية لبداء المسابقة";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(173, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 71);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "رياضة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "ثقافة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "دينية";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelquestion;
        private System.Windows.Forms.RadioButton question1;
        private System.Windows.Forms.RadioButton question2;
        private System.Windows.Forms.RadioButton question3;
        private System.Windows.Forms.RadioButton question4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

