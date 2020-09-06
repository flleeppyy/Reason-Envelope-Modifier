using System;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace EnvelopeModifier
{
    public partial class EnvelopeWindow : Form
    {
        XmlDocument doc = new XmlDocument();

        public string RepatchDestination;
        
        void ReadRepatch()
        {
            XmlNodeList elemList = doc.GetElementsByTagName("Value");
            for (int i = 0; i < elemList.Count; i++)
            {
                if (elemList[i].Attributes[0].Value == "Curve1") {
                    Console.WriteLine("Curve 1: " + elemList[i].InnerText);
                }
                
            }
        }
        public void OpenRepatch(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rack Extention Patch (*.repatch)|*.repatch";
            openFileDialog.FileName = "";
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                RepatchDestination = openFileDialog.FileName;
                doc.Load(RepatchDestination);
                ReadRepatch();
            } else
                RepatchDestination = string.Empty;
            Console.WriteLine(RepatchDestination);
        }
        public EnvelopeWindow()
        {
            InitializeComponent();
        }

    }
}
