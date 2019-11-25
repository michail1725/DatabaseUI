namespace database
{
  partial class Authorization
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
      this.signInBtn = new System.Windows.Forms.Button();
      this.loginField = new System.Windows.Forms.TextBox();
      this.passwordField = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // signInBtn
      // 
      this.signInBtn.Location = new System.Drawing.Point(346, 188);
      this.signInBtn.Name = "signInBtn";
      this.signInBtn.Size = new System.Drawing.Size(139, 42);
      this.signInBtn.TabIndex = 0;
      this.signInBtn.Text = "Войти";
      this.signInBtn.UseVisualStyleBackColor = true;
      this.signInBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // loginField
      // 
      this.loginField.Location = new System.Drawing.Point(254, 95);
      this.loginField.Name = "loginField";
      this.loginField.Size = new System.Drawing.Size(231, 20);
      this.loginField.TabIndex = 1;
      // 
      // passwordField
      // 
      this.passwordField.Location = new System.Drawing.Point(254, 139);
      this.passwordField.Name = "passwordField";
      this.passwordField.PasswordChar = '*';
      this.passwordField.Size = new System.Drawing.Size(231, 20);
      this.passwordField.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(156, 91);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 24);
      this.label1.TabIndex = 3;
      this.label1.Text = "Логин:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(156, 134);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(81, 24);
      this.label2.TabIndex = 4;
      this.label2.Text = "Пароль:";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox1.Location = new System.Drawing.Point(12, 38);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(131, 165);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(50, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(407, 33);
      this.label3.TabIndex = 6;
      this.label3.Text = "Для входа введите данные";
      // 
      // Authorization
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(497, 242);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.passwordField);
      this.Controls.Add(this.loginField);
      this.Controls.Add(this.signInBtn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Authorization";
      this.Text = "Вход";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button signInBtn;
    private System.Windows.Forms.TextBox loginField;
    private System.Windows.Forms.TextBox passwordField;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label3;
  }
}

