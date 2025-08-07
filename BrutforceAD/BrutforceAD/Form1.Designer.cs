namespace BrutforceAD
{
    partial class mainForm
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
            this.btn_start_brutforce = new System.Windows.Forms.Button();
            this.txb_logins = new System.Windows.Forms.TextBox();
            this.txb_passwords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_report = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_report_clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start_brutforce
            // 
            this.btn_start_brutforce.Location = new System.Drawing.Point(113, 410);
            this.btn_start_brutforce.Name = "btn_start_brutforce";
            this.btn_start_brutforce.Size = new System.Drawing.Size(187, 33);
            this.btn_start_brutforce.TabIndex = 0;
            this.btn_start_brutforce.Text = "Запустить брутфорс";
            this.btn_start_brutforce.UseVisualStyleBackColor = true;
            this.btn_start_brutforce.Click += new System.EventHandler(this.btn_start_brutforce_Click);
            // 
            // txb_logins
            // 
            this.txb_logins.Location = new System.Drawing.Point(12, 39);
            this.txb_logins.Multiline = true;
            this.txb_logins.Name = "txb_logins";
            this.txb_logins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_logins.Size = new System.Drawing.Size(194, 353);
            this.txb_logins.TabIndex = 1;
            // 
            // txb_passwords
            // 
            this.txb_passwords.Location = new System.Drawing.Point(223, 39);
            this.txb_passwords.Multiline = true;
            this.txb_passwords.Name = "txb_passwords";
            this.txb_passwords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_passwords.Size = new System.Drawing.Size(194, 353);
            this.txb_passwords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список логинов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "База паролей:";
            // 
            // txb_report
            // 
            this.txb_report.Location = new System.Drawing.Point(438, 39);
            this.txb_report.Multiline = true;
            this.txb_report.Name = "txb_report";
            this.txb_report.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_report.Size = new System.Drawing.Size(239, 353);
            this.txb_report.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Найденные пароли:";
            // 
            // btn_report_clean
            // 
            this.btn_report_clean.Location = new System.Drawing.Point(465, 410);
            this.btn_report_clean.Name = "btn_report_clean";
            this.btn_report_clean.Size = new System.Drawing.Size(187, 33);
            this.btn_report_clean.TabIndex = 7;
            this.btn_report_clean.Text = "Очистить отчет";
            this.btn_report_clean.UseVisualStyleBackColor = true;
            this.btn_report_clean.Click += new System.EventHandler(this.btn_report_clean_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 455);
            this.Controls.Add(this.btn_report_clean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_passwords);
            this.Controls.Add(this.txb_logins);
            this.Controls.Add(this.btn_start_brutforce);
            this.Name = "mainForm";
            this.Text = "Брутфорс Active Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_brutforce;
        private System.Windows.Forms.TextBox txb_logins;
        private System.Windows.Forms.TextBox txb_passwords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_report_clean;
    }
}

