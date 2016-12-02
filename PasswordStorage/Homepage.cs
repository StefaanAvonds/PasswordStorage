using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordStorage
{
    public partial class Homepage : Form
    {
        private XmlManager _xmlManager;
        private PasswordEntity _selectedPassword;

        public Homepage()
        {
            InitializeComponent();
            this.CenterToScreen();
            
            _xmlManager = new XmlManager();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            ReloadPasswords();
        }

        /// <summary>
        /// Initialize the data binding on the page.
        /// </summary>
        private void InitializeDataBinding()
        {
            txtTitle.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtURL.DataBindings.Clear();
            txtExtra.DataBindings.Clear();

            txtTitle.DataBindings.Add(new Binding("Text", lstPasswords.DataSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged));
            txtUsername.DataBindings.Add(new Binding("Text", lstPasswords.DataSource, "Username", true, DataSourceUpdateMode.OnPropertyChanged));
            txtPassword.DataBindings.Add(new Binding("Text", lstPasswords.DataSource, "Password", true, DataSourceUpdateMode.OnPropertyChanged));
            txtURL.DataBindings.Add(new Binding("Text", lstPasswords.DataSource, "Url", true, DataSourceUpdateMode.OnPropertyChanged));
            txtExtra.DataBindings.Add(new Binding("Text", lstPasswords.DataSource, "Extra", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        /// <summary>
        /// Loads all passwords.
        /// </summary>
        private void ReloadPasswords()
        {
            var list = _xmlManager.ReadPasswordsFromXml();
            
            lstPasswords.DataSource = list;
            //lstPasswords.ValueMember = "Title";

            InitializeDataBinding();
        }

        /// <summary>
        /// Checks if the password has it's properties initialized right.
        /// </summary>
        /// <returns></returns>
        private bool IsPasswordValid()
        {
            if (String.IsNullOrWhiteSpace(_selectedPassword.Title)) return false;
            if (String.IsNullOrWhiteSpace(_selectedPassword.Username)) return false;
            if (String.IsNullOrWhiteSpace(_selectedPassword.Password)) return false;

            return true;
        }

        /// <summary>
        /// Copy a specific text to the clipboard.
        /// </summary>
        /// <param name="text">Text to copy.</param>
        private void CopyToClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsPasswordValid())
            {
                MessageBox.Show("Not all properties are initialized right!");
                return;
            }

            _selectedPassword.Id = Guid.NewGuid();
            bool result = _xmlManager.AddNewPassword(_selectedPassword);
            if (result)
            {
                MessageBox.Show("Password added!");
                ReloadPasswords();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedPassword == null)
            {
                MessageBox.Show("Please select a password!");
                return;
            }

            if (!IsPasswordValid())
            {
                MessageBox.Show("Not all properties are initialized right!");
                return;
            }

            bool result = _xmlManager.UpdatePassword(_selectedPassword);
            if (result)
            {
                MessageBox.Show("Password updated!");
                ReloadPasswords();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPassword == null)
            {
                MessageBox.Show("Please select a password!");
                return;
            }

            DialogResult doDelete = MessageBox.Show("Are you sure you want to delete this password? It is irreversible!", "Delete", MessageBoxButtons.YesNo);
            if (doDelete != DialogResult.Yes) return;

            bool result = _xmlManager.DeletePassword(_selectedPassword);
            if (result)
            {
                MessageBox.Show("Password deleted!");
                ReloadPasswords();
            }
        }

        private void lstPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPassword = (PasswordEntity)lstPasswords.SelectedValue;
        }

        private void btnCopyUsername_Click(object sender, EventArgs e)
        {
            CopyToClipboard(_selectedPassword.Username);
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            CopyToClipboard(_selectedPassword.Password);
        }

        private void btnCopyUrl_Click(object sender, EventArgs e)
        {
            CopyToClipboard(_selectedPassword.Url);
        }
    }
}
