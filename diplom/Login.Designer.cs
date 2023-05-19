namespace diplom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.captcha_textBox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.captcha_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autor_button = new System.Windows.Forms.Button();
            this.registr_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(6, 48);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(200, 20);
            this.login_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(6, 104);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(200, 20);
            this.password_textBox.TabIndex = 1;
            // 
            // captcha_textBox
            // 
            this.captcha_textBox.Location = new System.Drawing.Point(33, 166);
            this.captcha_textBox.Name = "captcha_textBox";
            this.captcha_textBox.Size = new System.Drawing.Size(142, 20);
            this.captcha_textBox.TabIndex = 2;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(12, 26);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(52, 19);
            this.login_label.TabIndex = 3;
            this.login_label.Text = "Логин";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(6, 82);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(58, 19);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Пароль";
            // 
            // captcha_label
            // 
            this.captcha_label.AutoSize = true;
            this.captcha_label.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captcha_label.ForeColor = System.Drawing.Color.Red;
            this.captcha_label.Location = new System.Drawing.Point(51, 127);
            this.captcha_label.Name = "captcha_label";
            this.captcha_label.Size = new System.Drawing.Size(102, 36);
            this.captcha_label.TabIndex = 5;
            this.captcha_label.Text = "Captcha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(42, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Осталось Попыток: 3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // autor_button
            // 
            this.autor_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autor_button.Location = new System.Drawing.Point(33, 220);
            this.autor_button.Name = "autor_button";
            this.autor_button.Size = new System.Drawing.Size(134, 44);
            this.autor_button.TabIndex = 7;
            this.autor_button.Text = "Авторизоваться";
            this.autor_button.UseVisualStyleBackColor = true;
            this.autor_button.Click += new System.EventHandler(this.autor_button_Click);
            // 
            // registr_button
            // 
            this.registr_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registr_button.Location = new System.Drawing.Point(33, 270);
            this.registr_button.Name = "registr_button";
            this.registr_button.Size = new System.Drawing.Size(134, 35);
            this.registr_button.TabIndex = 8;
            this.registr_button.Text = "Зарегистрироваться";
            this.registr_button.UseVisualStyleBackColor = true;
            this.registr_button.Click += new System.EventHandler(this.registr_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 317);
            this.Controls.Add(this.registr_button);
            this.Controls.Add(this.autor_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.captcha_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.captcha_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox captcha_textBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label captcha_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button autor_button;
        private System.Windows.Forms.Button registr_button;
        private System.Windows.Forms.Timer timer1;
    }
}