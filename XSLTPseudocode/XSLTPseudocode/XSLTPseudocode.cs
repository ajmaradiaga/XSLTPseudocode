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
using System.Xml.Xsl;
using System.Xml.XPath;

namespace XSLTPseudocode
{
    public partial class XSLTPseudocode : Form
    {
        String _prefix = "";
        
        public XSLTPseudocode()
        {
            InitializeComponent();
        }

        private void btnGeneratePseudocode_Click(object sender, EventArgs e)
        {
            XmlDocument xsltDoc = new XmlDocument();

            try
            {
                
                xsltDoc.LoadXml(txtXSLT.Text);

                XmlNode firstNode = xsltDoc.FirstChild;

                while(!firstNode.Name.ToLower().Contains("stylesheet")){
                    firstNode = firstNode.NextSibling;
                }

                _prefix = firstNode.Prefix + ":";

                Console.WriteLine("XSLT Prefix: " + _prefix);

                this.txtXSLT.Text = processNode(firstNode, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private String getTabs(int numTabs) {
            String tabs = "";
            
            for (int i = 0; i < numTabs; i++)
            {
                tabs += "\t";
            }

            return tabs;
        }

        String[] _nextSiblingSkip = new String[] { "value-of" };

        private String processNode(XmlNode node, int numTabs) {
            String retVal = "";

            String tabs = getTabs(numTabs);

            retVal += tabs;

            String nodeText = "";
            String nextSib = "";
            XmlNode child = node.FirstChild;
            String nodeName = node.Name.ToLower().Replace(_prefix,"");

            if (child != null)
            {
                if (child.NodeType == XmlNodeType.Text)
                {
                    nodeText = node.InnerText;
                }
            }

            if(node.NextSibling != null)
                nextSib = node.NextSibling.Name.ToLower().Replace(_prefix, "");

            switch (nodeName)
            {
                case "stylesheet":
                    retVal += processAttributesList(node, nodeName, numTabs + 1) + Environment.NewLine + Environment.NewLine;
                    break;
                case "template":
                    retVal += "Template: " + processAttributes(node, nodeName) + Environment.NewLine;
                    break;
                case "element":
                    retVal += "Create Element with name: " + processAttributes(node, nodeName) + Environment.NewLine;
                    break;
                case "apply-templates":
                    retVal += "Apply Template " + processAttributes(node, nodeName) + Environment.NewLine;
                    break;
                case "value-of": 
                    retVal += processAttributes(node, nodeName) + Environment.NewLine;
                    break;
                case "for-each":
                    retVal += "for each " + processAttributes(node, nodeName) + Environment.NewLine;
                    break;
                case "output":
                    retVal += processAttributesList(node, nodeName, numTabs + 1) + Environment.NewLine;
                    break;
                default:
                    retVal += nodeName + " " + processAttributes(node, nodeName) + " -> ";
                    if (!_nextSiblingSkip.Contains(nextSib))
                        retVal += nodeText + Environment.NewLine;
                    break;
            }

            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                XmlNode item = node.ChildNodes[i];

                if (item.NodeType == XmlNodeType.Text) {
                    //retVal += item.InnerText;
                } else if(item.NodeType == XmlNodeType.EndElement){
                    break;
                }
                else {
                    retVal += processNode(node.ChildNodes[i], numTabs + 1);
                }
            }
            switch (nodeName)
            {
                case "template":
                    retVal += Environment.NewLine;
                    break;
                default:
                    break;
            }
            return retVal;
        }

        String[] _selectAttribSkip = new String[]{"apply-templates", "value-of", "for-each"};

        private String processAttributes(XmlNode node, String nodeName) { 
            String attributeString = "";

            XmlNode nameAttribute = null;

            nameAttribute = node.Attributes.GetNamedItem("name");

            if (nameAttribute == null) {
                nameAttribute = node.Attributes.GetNamedItem("Name");
            }

            if (nameAttribute != null)
            {
                attributeString = nameAttribute.Value + "\t";
            }

            for (int i = 0; i < node.Attributes.Count; i++)
            {
                XmlNode item = node.Attributes[i];

                switch (item.Name.ToLower())
                {
                    case "name":
                        break;
                    case "match":
                        attributeString += "match: " + item.Value + "\t";
                        break;
                    case "select": case "test":
                    if(item.Value == "."){
                        attributeString += " -> node()" + "\t";
                    }    
                    else if (_selectAttribSkip.Contains(nodeName))
                        {
                            attributeString += " -> " + item.Value + "\t";
                        }
                        break;
                    default:
                        attributeString += "@" + item.Name.ToLower() + ": " + item.Value + ((i+1 == node.Attributes.Count) ? " " : ", ");
                        break;
                }
            }

            

            return attributeString;
        }

        private String processAttributesList(XmlNode node, String nodeName, int numTabs)
        {

            String tabs = getTabs(numTabs);
            String attributeString = nodeName + ": " + Environment.NewLine;

            for (int i = 0; i < node.Attributes.Count; i++)
            {
                XmlNode item = node.Attributes[i];

                switch (item.Name.ToLower())
                {
                    default:
                        attributeString += tabs + "* " + item.Name.Replace("xmlns:","Namespace ") + ": " + item.Value + Environment.NewLine;
                        break;
                }
            }

            return attributeString;
        }
    }
}
