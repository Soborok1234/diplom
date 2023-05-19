namespace diplom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.capo_label = new System.Windows.Forms.Label();
            this.boy_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.capo1_radioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.capo_groupBox = new System.Windows.Forms.GroupBox();
            this.boy_groupBox = new System.Windows.Forms.GroupBox();
            this.boy3_radioButton = new System.Windows.Forms.RadioButton();
            this.boy2_radioButton = new System.Windows.Forms.RadioButton();
            this.boy1_radioButton = new System.Windows.Forms.RadioButton();
            this.checkBox1lad1stryna = new System.Windows.Forms.CheckBox();
            this.checkBox1lad2stryna = new System.Windows.Forms.CheckBox();
            this.checkBox1lad3stryna = new System.Windows.Forms.CheckBox();
            this.checkBox1lad4stryna = new System.Windows.Forms.CheckBox();
            this.checkBox1lad5stryna = new System.Windows.Forms.CheckBox();
            this.checkBox1lad6stryna = new System.Windows.Forms.CheckBox();
            this.checkBox2lad5stryna = new System.Windows.Forms.CheckBox();
            this.checkBox2lad3stryna = new System.Windows.Forms.CheckBox();
            this.checkBox2lad6stryna = new System.Windows.Forms.CheckBox();
            this.checkBox2lad4stryna = new System.Windows.Forms.CheckBox();
            this.checkBox2lad1stryna = new System.Windows.Forms.CheckBox();
            this.checkBox2lad2stryna = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.open_gp_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.capo_groupBox.SuspendLayout();
            this.boy_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // capo_label
            // 
            this.capo_label.AutoSize = true;
            this.capo_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capo_label.Location = new System.Drawing.Point(5, 4);
            this.capo_label.Name = "capo_label";
            this.capo_label.Size = new System.Drawing.Size(95, 21);
            this.capo_label.TabIndex = 2;
            this.capo_label.Text = "Каподастр";
            // 
            // boy_label
            // 
            this.boy_label.AutoSize = true;
            this.boy_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boy_label.Location = new System.Drawing.Point(11, 7);
            this.boy_label.Name = "boy_label";
            this.boy_label.Size = new System.Drawing.Size(41, 21);
            this.boy_label.TabIndex = 8;
            this.boy_label.Text = "Бой";
            // 
            // start_button
            // 
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_button.Image = ((System.Drawing.Image)(resources.GetObject("start_button.Image")));
            this.start_button.Location = new System.Drawing.Point(379, 2);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(34, 30);
            this.start_button.TabIndex = 12;
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stop_button.Image = ((System.Drawing.Image)(resources.GetObject("stop_button.Image")));
            this.stop_button.Location = new System.Drawing.Point(419, 2);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(34, 30);
            this.stop_button.TabIndex = 13;
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // capo1_radioButton
            // 
            this.capo1_radioButton.AutoSize = true;
            this.capo1_radioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capo1_radioButton.Location = new System.Drawing.Point(9, 28);
            this.capo1_radioButton.Name = "capo1_radioButton";
            this.capo1_radioButton.Size = new System.Drawing.Size(52, 19);
            this.capo1_radioButton.TabIndex = 14;
            this.capo1_radioButton.TabStop = true;
            this.capo1_radioButton.Text = "1 лад";
            this.capo1_radioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(9, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2 лад";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(9, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3 лад";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(9, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 19);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4 лад";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(9, 127);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 19);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "5 лад";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // capo_groupBox
            // 
            this.capo_groupBox.Controls.Add(this.radioButton4);
            this.capo_groupBox.Controls.Add(this.radioButton3);
            this.capo_groupBox.Controls.Add(this.radioButton2);
            this.capo_groupBox.Controls.Add(this.radioButton1);
            this.capo_groupBox.Controls.Add(this.capo1_radioButton);
            this.capo_groupBox.Controls.Add(this.capo_label);
            this.capo_groupBox.Location = new System.Drawing.Point(7, 27);
            this.capo_groupBox.Name = "capo_groupBox";
            this.capo_groupBox.Size = new System.Drawing.Size(130, 159);
            this.capo_groupBox.TabIndex = 19;
            this.capo_groupBox.TabStop = false;
            // 
            // boy_groupBox
            // 
            this.boy_groupBox.Controls.Add(this.boy3_radioButton);
            this.boy_groupBox.Controls.Add(this.boy2_radioButton);
            this.boy_groupBox.Controls.Add(this.boy1_radioButton);
            this.boy_groupBox.Controls.Add(this.boy_label);
            this.boy_groupBox.Location = new System.Drawing.Point(192, 24);
            this.boy_groupBox.Name = "boy_groupBox";
            this.boy_groupBox.Size = new System.Drawing.Size(169, 123);
            this.boy_groupBox.TabIndex = 20;
            this.boy_groupBox.TabStop = false;
            // 
            // boy3_radioButton
            // 
            this.boy3_radioButton.AutoSize = true;
            this.boy3_radioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boy3_radioButton.Location = new System.Drawing.Point(15, 80);
            this.boy3_radioButton.Name = "boy3_radioButton";
            this.boy3_radioButton.Size = new System.Drawing.Size(86, 19);
            this.boy3_radioButton.TabIndex = 14;
            this.boy3_radioButton.TabStop = true;
            this.boy3_radioButton.Text = "Восьмёрка";
            this.boy3_radioButton.UseVisualStyleBackColor = true;
            // 
            // boy2_radioButton
            // 
            this.boy2_radioButton.AutoSize = true;
            this.boy2_radioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boy2_radioButton.Location = new System.Drawing.Point(15, 55);
            this.boy2_radioButton.Name = "boy2_radioButton";
            this.boy2_radioButton.Size = new System.Drawing.Size(79, 19);
            this.boy2_radioButton.TabIndex = 13;
            this.boy2_radioButton.TabStop = true;
            this.boy2_radioButton.Text = "Шестёрка";
            this.boy2_radioButton.UseVisualStyleBackColor = true;
            // 
            // boy1_radioButton
            // 
            this.boy1_radioButton.AutoSize = true;
            this.boy1_radioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boy1_radioButton.Location = new System.Drawing.Point(15, 31);
            this.boy1_radioButton.Name = "boy1_radioButton";
            this.boy1_radioButton.Size = new System.Drawing.Size(118, 19);
            this.boy1_radioButton.TabIndex = 12;
            this.boy1_radioButton.TabStop = true;
            this.boy1_radioButton.Text = "Удар по струнам";
            this.boy1_radioButton.UseVisualStyleBackColor = true;
            // 
            // checkBox1lad1stryna
            // 
            this.checkBox1lad1stryna.AutoSize = true;
            this.checkBox1lad1stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1lad1stryna.Location = new System.Drawing.Point(41, 370);
            this.checkBox1lad1stryna.Name = "checkBox1lad1stryna";
            this.checkBox1lad1stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox1lad1stryna.TabIndex = 21;
            this.checkBox1lad1stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox1lad2stryna
            // 
            this.checkBox1lad2stryna.AutoSize = true;
            this.checkBox1lad2stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1lad2stryna.Location = new System.Drawing.Point(40, 390);
            this.checkBox1lad2stryna.Name = "checkBox1lad2stryna";
            this.checkBox1lad2stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox1lad2stryna.TabIndex = 22;
            this.checkBox1lad2stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox1lad3stryna
            // 
            this.checkBox1lad3stryna.AutoSize = true;
            this.checkBox1lad3stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1lad3stryna.Location = new System.Drawing.Point(41, 410);
            this.checkBox1lad3stryna.Name = "checkBox1lad3stryna";
            this.checkBox1lad3stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox1lad3stryna.TabIndex = 23;
            this.checkBox1lad3stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox1lad4stryna
            // 
            this.checkBox1lad4stryna.AutoSize = true;
            this.checkBox1lad4stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1lad4stryna.Location = new System.Drawing.Point(41, 429);
            this.checkBox1lad4stryna.Name = "checkBox1lad4stryna";
            this.checkBox1lad4stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox1lad4stryna.TabIndex = 24;
            this.checkBox1lad4stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox1lad5stryna
            // 
            this.checkBox1lad5stryna.AutoSize = true;
            this.checkBox1lad5stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1lad5stryna.Location = new System.Drawing.Point(42, 449);
            this.checkBox1lad5stryna.Name = "checkBox1lad5stryna";
            this.checkBox1lad5stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox1lad5stryna.TabIndex = 25;
            this.checkBox1lad5stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox1lad6stryna
            // 
            this.checkBox1lad6stryna.AutoSize = true;
            this.checkBox1lad6stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1lad6stryna.Location = new System.Drawing.Point(43, 469);
            this.checkBox1lad6stryna.Name = "checkBox1lad6stryna";
            this.checkBox1lad6stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox1lad6stryna.TabIndex = 26;
            this.checkBox1lad6stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox2lad5stryna
            // 
            this.checkBox2lad5stryna.AutoSize = true;
            this.checkBox2lad5stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2lad5stryna.Location = new System.Drawing.Point(104, 449);
            this.checkBox2lad5stryna.Name = "checkBox2lad5stryna";
            this.checkBox2lad5stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox2lad5stryna.TabIndex = 27;
            this.checkBox2lad5stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox2lad3stryna
            // 
            this.checkBox2lad3stryna.AutoSize = true;
            this.checkBox2lad3stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2lad3stryna.Location = new System.Drawing.Point(104, 409);
            this.checkBox2lad3stryna.Name = "checkBox2lad3stryna";
            this.checkBox2lad3stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox2lad3stryna.TabIndex = 27;
            this.checkBox2lad3stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox2lad6stryna
            // 
            this.checkBox2lad6stryna.AutoSize = true;
            this.checkBox2lad6stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2lad6stryna.Location = new System.Drawing.Point(104, 469);
            this.checkBox2lad6stryna.Name = "checkBox2lad6stryna";
            this.checkBox2lad6stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox2lad6stryna.TabIndex = 27;
            this.checkBox2lad6stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox2lad4stryna
            // 
            this.checkBox2lad4stryna.AutoSize = true;
            this.checkBox2lad4stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2lad4stryna.Location = new System.Drawing.Point(104, 428);
            this.checkBox2lad4stryna.Name = "checkBox2lad4stryna";
            this.checkBox2lad4stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox2lad4stryna.TabIndex = 27;
            this.checkBox2lad4stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox2lad1stryna
            // 
            this.checkBox2lad1stryna.AutoSize = true;
            this.checkBox2lad1stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2lad1stryna.Location = new System.Drawing.Point(106, 370);
            this.checkBox2lad1stryna.Name = "checkBox2lad1stryna";
            this.checkBox2lad1stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox2lad1stryna.TabIndex = 27;
            this.checkBox2lad1stryna.UseVisualStyleBackColor = true;
            // 
            // checkBox2lad2stryna
            // 
            this.checkBox2lad2stryna.AutoSize = true;
            this.checkBox2lad2stryna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2lad2stryna.Location = new System.Drawing.Point(106, 390);
            this.checkBox2lad2stryna.Name = "checkBox2lad2stryna";
            this.checkBox2lad2stryna.Size = new System.Drawing.Size(12, 11);
            this.checkBox2lad2stryna.TabIndex = 27;
            this.checkBox2lad2stryna.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(525, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 255);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // open_gp_button
            // 
            this.open_gp_button.Location = new System.Drawing.Point(525, 52);
            this.open_gp_button.Name = "open_gp_button";
            this.open_gp_button.Size = new System.Drawing.Size(135, 46);
            this.open_gp_button.TabIndex = 29;
            this.open_gp_button.Text = "button1";
            this.open_gp_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 496);
            this.Controls.Add(this.open_gp_button);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkBox2lad2stryna);
            this.Controls.Add(this.checkBox2lad4stryna);
            this.Controls.Add(this.checkBox2lad6stryna);
            this.Controls.Add(this.checkBox2lad1stryna);
            this.Controls.Add(this.checkBox2lad3stryna);
            this.Controls.Add(this.checkBox2lad5stryna);
            this.Controls.Add(this.checkBox1lad6stryna);
            this.Controls.Add(this.checkBox1lad5stryna);
            this.Controls.Add(this.checkBox1lad4stryna);
            this.Controls.Add(this.checkBox1lad3stryna);
            this.Controls.Add(this.checkBox1lad2stryna);
            this.Controls.Add(this.checkBox1lad1stryna);
            this.Controls.Add(this.boy_groupBox);
            this.Controls.Add(this.capo_groupBox);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guitar TabMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.capo_groupBox.ResumeLayout(false);
            this.capo_groupBox.PerformLayout();
            this.boy_groupBox.ResumeLayout(false);
            this.boy_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label capo_label;
        private System.Windows.Forms.Label boy_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.RadioButton capo1_radioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox capo_groupBox;
        private System.Windows.Forms.GroupBox boy_groupBox;
        private System.Windows.Forms.RadioButton boy3_radioButton;
        private System.Windows.Forms.RadioButton boy2_radioButton;
        private System.Windows.Forms.RadioButton boy1_radioButton;
        private System.Windows.Forms.CheckBox checkBox1lad1stryna;
        private System.Windows.Forms.CheckBox checkBox1lad2stryna;
        private System.Windows.Forms.CheckBox checkBox1lad3stryna;
        private System.Windows.Forms.CheckBox checkBox1lad4stryna;
        private System.Windows.Forms.CheckBox checkBox1lad5stryna;
        private System.Windows.Forms.CheckBox checkBox1lad6stryna;
        private System.Windows.Forms.CheckBox checkBox2lad5stryna;
        private System.Windows.Forms.CheckBox checkBox2lad3stryna;
        private System.Windows.Forms.CheckBox checkBox2lad6stryna;
        private System.Windows.Forms.CheckBox checkBox2lad4stryna;
        private System.Windows.Forms.CheckBox checkBox2lad1stryna;
        private System.Windows.Forms.CheckBox checkBox2lad2stryna;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button open_gp_button;
    }
}

