using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "http://pluralsight.com";
            static string PageTitle = "Pluralsight | Unlimited Online Developer, IT and Creative Training";

            public static void GoTo()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
            }
        }
    }
}
