using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class LoginForm : Form
    {
        public string UserRole { get; private set; }


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Приклад: перевірка в БД через DatabaseHelper (псевдокод)
            string query = $"SELECT role FROM users WHERE username = '{username}' AND password = '{password}'";

            var dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count == 1)
            {
                UserRole = dt.Rows[0]["role"].ToString();
                this.DialogResult = DialogResult.OK; // Позначаємо успішний вхід
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
