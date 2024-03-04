namespace zad4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Button();
            this.sport = new System.Windows.Forms.RadioButton();
            this.truck = new System.Windows.Forms.RadioButton();
            this.spoiler = new System.Windows.Forms.CheckBox();
            this.nos = new System.Windows.Forms.CheckBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.engine = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.Roald = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Скорост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Двигател";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвят";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Път";
            // 
            // showTime
            // 
            this.showTime.Location = new System.Drawing.Point(252, 204);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(331, 176);
            this.showTime.TabIndex = 4;
            this.showTime.Text = "Покажи време";
            this.showTime.UseVisualStyleBackColor = true;
            this.showTime.Click += new System.EventHandler(this.showTime_Click);
            // 
            // sport
            // 
            this.sport.AutoSize = true;
            this.sport.Location = new System.Drawing.Point(128, 137);
            this.sport.Name = "sport";
            this.sport.Size = new System.Drawing.Size(72, 19);
            this.sport.TabIndex = 5;
            this.sport.TabStop = true;
            this.sport.Text = "Спортна";
            this.sport.UseVisualStyleBackColor = true;
            // 
            // truck
            // 
            this.truck.AutoSize = true;
            this.truck.Location = new System.Drawing.Point(212, 137);
            this.truck.Name = "truck";
            this.truck.Size = new System.Drawing.Size(68, 19);
            this.truck.TabIndex = 6;
            this.truck.TabStop = true;
            this.truck.Text = "Камион";
            this.truck.UseVisualStyleBackColor = true;
            // 
            // spoiler
            // 
            this.spoiler.AutoSize = true;
            this.spoiler.Location = new System.Drawing.Point(125, 180);
            this.spoiler.Name = "spoiler";
            this.spoiler.Size = new System.Drawing.Size(75, 19);
            this.spoiler.TabIndex = 7;
            this.spoiler.Text = "Спойлер";
            this.spoiler.UseVisualStyleBackColor = true;
            // 
            // nos
            // 
            this.nos.AutoSize = true;
            this.nos.Location = new System.Drawing.Point(225, 179);
            this.nos.Name = "nos";
            this.nos.Size = new System.Drawing.Size(50, 19);
            this.nos.TabIndex = 8;
            this.nos.Text = "NOS";
            this.nos.UseVisualStyleBackColor = true;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(117, 25);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(100, 23);
            this.speed.TabIndex = 9;
            // 
            // engine
            // 
            this.engine.Location = new System.Drawing.Point(105, 58);
            this.engine.Name = "engine";
            this.engine.Size = new System.Drawing.Size(100, 23);
            this.engine.TabIndex = 10;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(98, 96);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 23);
            this.color.TabIndex = 11;
            // 
            // Roald
            // 
            this.Roald.Location = new System.Drawing.Point(88, 282);
            this.Roald.Name = "Roald";
            this.Roald.Size = new System.Drawing.Size(100, 23);
            this.Roald.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Roald);
            this.Controls.Add(this.color);
            this.Controls.Add(this.engine);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.nos);
            this.Controls.Add(this.spoiler);
            this.Controls.Add(this.truck);
            this.Controls.Add(this.sport);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button showTime;
        private RadioButton sport;
        private RadioButton truck;
        private CheckBox spoiler;
        private CheckBox nos;
        private TextBox speed;
        private TextBox engine;
        private TextBox color;
        private TextBox Roald;
    }
}