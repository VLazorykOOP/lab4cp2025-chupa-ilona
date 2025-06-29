using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text.Trim().Replace("'", "''");
            string title = txtTitle.Text.Trim().Replace("'", "''");
            string genre = txtGenre.Text.Trim().Replace("'", "''");

            string query = "SELECT * FROM books WHERE 1=1";

            if (!string.IsNullOrEmpty(author))
            {
                query += $" AND author LIKE '%{author}%'";
            }
            if (!string.IsNullOrEmpty(title))
            {
                query += $" AND title LIKE '%{title}%'";
            }
            if (!string.IsNullOrEmpty(genre))
            {
                query += $" AND genre LIKE '%{genre}%'";
            }

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvResults.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при пошуку: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtTitle.Clear();
            txtGenre.Clear();
            dgvResults.DataSource = null;
        }
    }
}
