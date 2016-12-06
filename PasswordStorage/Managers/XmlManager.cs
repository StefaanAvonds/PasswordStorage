using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PasswordStorage.Managers
{
    public class XmlManager
    {
        private string _filename;
        private XDocument _xmlDocument;

        public XmlManager()
        {
            _filename = GetFullFilename("passwords.xml");

            if (!File.Exists(_filename))
            {
                _xmlDocument = new XDocument();
                CreateBasicXmlFile();
            }
            else
            {
                _xmlDocument = XDocument.Load(_filename);
            }
        }

        /// <summary>
        /// Get the full filename with a specific path.
        /// </summary>
        /// <param name="filename">The name of the file.</param>
        /// <returns>The full path.</returns>
        private string GetFullFilename(string filename)
        {
            string localAppdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string userFilepath = Path.Combine(localAppdata, "Avonds");

            if (!Directory.Exists(userFilepath)) Directory.CreateDirectory(userFilepath);

            return Path.Combine(userFilepath, filename);
        }
        
        /// <summary>
        /// Create a basic XML-file.
        /// </summary>
        private void CreateBasicXmlFile()
        {
            PasswordEntity emptyPassword = new PasswordEntity();
            emptyPassword.Title = "New password";
            emptyPassword.Username = "Enter username";
            emptyPassword.Password = "Enter password";

            XElement xml = new XElement("Passwords",
                GetNewPasswordElement(emptyPassword));

            _xmlDocument.Add(xml);
            _xmlDocument.Save(_filename);
        }

        /// <summary>
        /// Read the XML-document.
        /// </summary>
        /// <returns>A list of all found passwords.</returns>
        public List<PasswordEntity> ReadPasswordsFromXml()
        {
            var passwords = from x in _xmlDocument.Descendants("PasswordEntity")
                            select new PasswordEntity
                            {
                                Id = Guid.Parse(x.Attribute("Id").Value),
                                Title = x.Descendants("Title").First().Value,
                                Username = x.Descendants("Username").First().Value,
                                Password = x.Descendants("Password").First().Value,
                                Url = x.Descendants("Url").First().Value,
                                Extra = x.Descendants("Extra").First().Value
                            };

            passwords = passwords.OrderBy(x => x.Title);
            
            return new List<PasswordEntity>(passwords);
        }

        /// <summary>
        /// Add a new password-element to the XML.
        /// </summary>
        /// <param name="password">The password with all the properties.</param>
        /// <returns>If the XML has been added or not.</returns>
        public bool AddNewPassword(PasswordEntity password)
        {
            XElement newPassword = GetNewPasswordElement(password);

            _xmlDocument.Element("Passwords").Add(newPassword);
            _xmlDocument.Save(_filename);

            return true;
        }

        /// <summary>
        /// Updates the values for a specific password.
        /// </summary>
        /// <param name="password">The password with all the properties.</param>
        /// <returns>If the XML has been updated or not.</returns>
        public bool UpdatePassword(PasswordEntity password)
        {
            bool result = DeletePassword(password);
            if (!result) return false;

            result = AddNewPassword(password);
            if (!result) return false;

            return true;
        }

        /// <summary>
        /// Delete a password from XML.
        /// </summary>
        /// <param name="password">The password with all its properties.</param>
        /// <returns>If the XML has been changed or not.</returns>
        public bool DeletePassword(PasswordEntity password)
        {
            XElement element = null;

            foreach (var item in _xmlDocument.Descendants("PasswordEntity"))
            {
                if (Guid.Parse(item.Attribute("Id").Value) == password.Id)
                {
                    element = item;
                    break;
                }
            }

            if (element == null) return false;

            element.Remove();
            _xmlDocument.Save(_filename);

            return true;
        }

        /// <summary>
        /// Get a new password-element for XML.
        /// </summary>
        /// <param name="password">The password with all the properties.</param>
        /// <returns>The element for XML.</returns>
        private XElement GetNewPasswordElement(PasswordEntity password)
        {
            var element = new XElement("PasswordEntity",
                GetNewXmlElement("Title", password.Title),
                GetNewXmlElement("Username", password.Username),
                GetNewXmlElement("Password", password.Password),
                GetNewXmlElement("Url", password.Url),
                GetNewXmlElement("Extra", password.Extra));
            
            element.SetAttributeValue("Id", password.Id.ToString());

            return element;
        }
        
        /// <summary>
        /// Get a new XElement-object.
        /// </summary>
        /// <param name="name">The name of the element.</param>
        /// <param name="value">The value of the element</param>
        /// <returns></returns>
        private XElement GetNewXmlElement(string name, string value)
        {
            return new XElement(name, value);
        }
    }
}
