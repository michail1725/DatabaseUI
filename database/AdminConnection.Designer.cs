namespace database
{
  partial class AdminConnection
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.Disconnect = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.DisplayMember = "Клиенты";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Клиенты",
            "Договора",
            "Тарифы",
            "Магистраль",
            "Сетевые узлы",
            "Заявки",
            "База работников",
            "Vps-сервера",
            "Хранилища",
            "Оборудование",
            "Классификация оборудования"});
      this.comboBox1.Location = new System.Drawing.Point(50, 76);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 0;
      // 
      // Disconnect
      // 
      this.Disconnect.Location = new System.Drawing.Point(661, 397);
      this.Disconnect.Name = "Disconnect";
      this.Disconnect.Size = new System.Drawing.Size(127, 41);
      this.Disconnect.TabIndex = 1;
      this.Disconnect.Text = "Выйти";
      this.Disconnect.UseVisualStyleBackColor = true;
      this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
      // 
      // AdminConnection
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Disconnect);
      this.Controls.Add(this.comboBox1);
      this.Name = "AdminConnection";
      this.Text = "AdminConnection";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button Disconnect;
  }
}