using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage
{
    public class PasswordEntity : BaseEntity
    {
        private string _title;
        private string _username;
        private string _password;
        private string _url;
        private string _extra;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged();
            }
        }
        public string Extra
        {
            get { return _extra; }
            set
            {
                _extra = value;
                OnPropertyChanged();
            }
        }

        public PasswordEntity()
            : base()
        {

        }

        public override string ToString()
        {
            return Title;
        }
    }
}
