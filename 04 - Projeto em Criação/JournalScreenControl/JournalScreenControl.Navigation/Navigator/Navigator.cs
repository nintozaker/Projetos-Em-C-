using mshtml;
using SHDocVw;
using System.Runtime.InteropServices;
using System.Threading;

namespace JournalScreenControl.Navigation.Navigator
{
    public class Navigator : INavigator
    {
        private InternetExplorer browser { get; set; }

        public Navigator()
        {
        }

        public string Navigate(string url)
        {
            if (this.browser == null)
            {
                this.browser = new InternetExplorer();
                this.browser.Visible = true;
            }

            this.browser.Navigate(url);

            while (this.browser.ReadyState != tagREADYSTATE.READYSTATE_COMPLETE)
            {
                Thread.Sleep(1000);
            }

            HTMLDocument document = (HTMLDocument)this.browser.Document;

            string html = string.Empty;
            html = document.documentElement.outerHTML;

            return html;
        }

        public void Dispose()
        {
            this.browser = null;
        }
    }
}
