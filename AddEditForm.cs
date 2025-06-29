using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class AddEditForm : Form
    {
        private int? bookId = null;

        public AddEditForm()
        {
            InitializeComponent();
        }

        public AddEditForm(DataGridViewRow row)
        {
            InitializeComponent();
            bookId = Convert.ToInt32(row.Cells["id"].Value);
            txtAuthor.Text = row.Cells["author"].Value.ToString();
            txtTitle.Text = row.Cells["title"].Value.ToString();
            txtPublisher.Text = row.Cells["publisher"].Value.ToString();
            numPages.Value = Convert.ToInt32(row.Cells["page_count"].Value);
            txtGenre.Text = row.Cells["genre"].Value.ToString();
            numPrice.Value = Convert.ToDecimal(row.Cells["price"].Value);
            txtStorage.Text = row.Cells["storage"].Value.ToString();
            txtInventory.Text = row.Cells["inventory_number"].Value.ToString();
            lblTitle.Text = "Редагування книги";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            string publisher = txtPublisher.Text;
            int pages = (int)numPages.Value;
            string genre = txtGenre.Text;
            decimal price = numPrice.Value;
            string storage = txtStorage.Text;
            string inventory = txtInventory.Text;

            try
            {
                if (bookId == null)
                {
                    DatabaseHelper.AddBook(author, title, publisher, pages, genre, price, storage, inventory);
                }
                else
                {
                    DatabaseHelper.UpdateBook(bookId.Value, author, title, publisher, pages, genre, price, storage, inventory);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
