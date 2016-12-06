using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Managers
{
    public class UrlManager
    {
        public UrlManager()
        {

        }

        /// <summary>
        /// Checks whether a URL is valid.
        /// </summary>
        /// <param name="url">The URL to navigate.</param>
        /// <returns></returns>
        public bool IsValidUrl(string url)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        /// <summary>
        /// Open a specific URL inside a web browser.
        /// </summary>
        /// <param name="url">The URL to navigate.</param>
        public void OpenWebPage(string url)
        {
            if (IsValidUrl(url))
            {
                // Only navigate if it is a valid URL
                Process.Start(url);
            }
        }
    }
}
