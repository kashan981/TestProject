using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sonic_Admin
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    class Properties
    {
        public static IWebDriver Driver { get; set; }
    }
}
