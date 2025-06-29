namespace LibraryManager
{
    partial class AddEditForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(30, 50);
            this.txtAuthor.Name = "txtAuthor";
            //this.txtAuthor.PlaceholderText = "Автор";
            this.txtAuthor.Size = new System.Drawing.Size(240, 22);
            this.txtAuthor.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(30, 85);
            this.txtTitle.Name = "txtTitle";
            //this.txtTitle.PlaceholderText = "Назва книги";
            this.txtTitle.Size = new System.Drawing.Size(240, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(30, 120);
            this.txtPublisher.Name = "txtPublisher";
            //this.txtPublisher.PlaceholderText = "Видавництво";
            this.txtPublisher.Size = new System.Drawing.Size(240, 22);
            this.txtPublisher.TabIndex = 2;
            // 
            // numPages
            // 
            this.numPages.Location = new System.Drawing.Point(30, 155);
            this.numPages.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(240, 22);
            this.numPages.TabIndex = 3;
            this.numPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(30, 190);
            this.txtGenre.Name = "txtGenre";
            //this.txtGenre.PlaceholderText = "Жанр";
            this.txtGenre.Size = new System.Drawing.Size(240, 22);
            this.txtGenre.TabIndex = 4;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(30, 225);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(240, 22);
            this.numPrice.TabIndex = 5;
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(30, 260);
            this.txtStorage.Name = "txtStorage";
            //this.txtStorage.PlaceholderText = "Місце зберігання";
            this.txtStorage.Size = new System.Drawing.Size(240, 22);
            this.txtStorage.TabIndex = 6;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(30, 295);
            this.txtInventory.Name = "txtInventory";
           // this.txtInventory.PlaceholderText = "Інвентарний №";
            this.txtInventory.Size = new System.Drawing.Size(240, 22);
            this.txtInventory.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 30);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Нова книга";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEditForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtStorage);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Name = "AddEditForm";
            this.Text = "Книга";
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
