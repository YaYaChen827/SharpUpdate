using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpUpdate;

namespace TestApp
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }

        public Assembly ApplicationAssembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public Icon ApplicationIcon
        {
            get
            {
                return this.Icon;
            }
        }

        public string ApplicationID
        {
            get
            {
                return "TestApp";
            }
        }

        public string ApplicationName
        {
            get
            {
                return "TestApp";
            }
        }

        public Form Context
        {
            get
            {
                return this;
            }
        }

        public Uri UpdateXmlLocation
        {
            get
            {
                return new Uri("");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
