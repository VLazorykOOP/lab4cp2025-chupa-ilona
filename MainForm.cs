using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        private string userRole;

        public MainForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Ласкаво просимо! Ваша роль: {userRole}";
            LoadBooks();

            if (userRole == "worker")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = DatabaseHelper.GetAllBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm form = new AddEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBooks.SelectedRows[0];
                AddEditForm form = new AddEditForm(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Оберіть книгу для редагування.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["id"].Value);
                var confirm = MessageBox.Show("Видалити цю книгу?", "Підтвердження", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteBook(id);
                    LoadBooks();
                }
            }
            else
            {
                MessageBox.Show("Оберіть книгу для видалення.");
            }
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
