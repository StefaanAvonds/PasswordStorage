using PasswordStorage.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage
{
    public static class App
    {
        private static UrlManager _urlManager;
        private static XmlManager _xmlManager;

        /// <summary>
        /// The URL-manager to manage all URLs.
        /// </summary>
        public static UrlManager UrlManager
        {
            get
            {
                if (_urlManager == null) _urlManager = new UrlManager();
                return _urlManager;
            }
        }

        /// <summary>
        /// Manager for all XML functionalities.
        /// </summary>
        public static XmlManager XmlManager
        {
            get
            {
                if (_xmlManager == null) _xmlManager = new XmlManager();
                return _xmlManager;
            }
        }
    }
}
