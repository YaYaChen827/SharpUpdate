using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace SharpUpdate
{
    public interface ISharpUpdatable
    {
        /// <summary>
        /// The application name as you want it shown on the update fore.
        /// </summary>
        string ApplicationName { get; }
        /// <summary>
        /// An identifier string to use to identify application in the update.xml
        /// Should be the same as applicaiton ID in update.xml
        /// </summary>
        string ApplicationID { get; }
        /// <summary>
        /// Current assembly
        /// </summary>
        Assembly ApplicationAssembly { get; }
        /// <summary>
        /// The application's icon to be shown in the top left
        /// </summary>
        Icon ApplicationIcon { get; }
        /// <summary>
        /// The location of the update.xml on a server
        /// </summary>
        Uri UpdateXmlLocation { get; }
        /// <summary>
        /// The context of the program
        /// For WinForm application, use "this"
        /// Console application, reference System.Windows.Forms and return null.
        /// </summary>
        Form Context { get; }
    }
    
}
