using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
    
namespace Consultor_trucades_a_la_xarxa_RESCAT
{
    public partial class FrmMain : Form
    {
        static XPathDocument document = new XPathDocument("Disponibilitat i trucades a la xarxa RESCAT.xml");
        XPathNavigator navegador = document.CreateNavigator(); ;

        XmlDocument xDoc;
        XmlNode xNodeArrel;
        XmlDeclaration xDeclaracio;
        XmlComment xComentari;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btDades_Click(object sender, EventArgs e)
        {
            xDoc = new XmlDocument();
            xDeclaracio = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        }

    }
}
