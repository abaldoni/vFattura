using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace vFattura
{
    public partial class vFatturaForm : Form
    {
        public vFatturaForm()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = Application.ProductVersion;
            this.Text = Application.ProductName + " " + Application.ProductVersion;
        }
       
        public void doOpenDocument(string filename)
        {
            try
            {
                XslCompiledTransform transform = new XslCompiledTransform();

                // Hack per consentire la trasformazione di file XML 1.1 che
                // non sono supportati da .NET
                // Read the file as one string.
                string xmlHackFind = "version=\"1\\.1\"";
                string xmlHackReplace = "version=\"1.0\"";
                Regex rgx = new Regex(xmlHackFind);

                System.IO.StreamReader xmlFile = new System.IO.StreamReader(filename);
                string xmlString = xmlFile.ReadToEnd();
                xmlFile.Close();
                string xmlHacked = rgx.Replace(xmlString, xmlHackReplace);

                transform.Load(XmlReader.Create(new StringReader(vFattura.Properties.Resources.Fattura_1_1)));
                using (StringReader sr = new StringReader(xmlHacked))
                {
                    using (XmlReader xr = XmlReader.Create(sr))
                    {
                        using (StringWriter sw = new StringWriter())
                        {
                            transform.Transform(xr, null, sw);

                            // http://stackoverflow.com/questions/5362591/how-to-display-the-string-html-contents-into-webbrowser-control
                            webBrowser1.Navigate("about:blank");
                            try
                            {
                                if (webBrowser1.Document != null)
                                {
                                    webBrowser1.Document.Write(string.Empty);
                                }
                            }
                            catch (Exception e)
                            { } // do nothing with this
                            webBrowser1.DocumentText = sw.ToString();
                        }
                    }
                }

                // Parse degli attachment della fattura e reset della barra dei pulsanti.
                toolStrip1.Items.Clear();
                toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openDocument, printDocument, closeWindow});


                XmlDocument fattura = new XmlDocument();
                fattura.Load(new StringReader(xmlHacked));
                XmlNodeList attachments = fattura.SelectNodes("/*/FatturaElettronicaBody/Allegati");
                int i = attachments.Count;
                foreach (XmlNode attachment in attachments)
                {
                    ToolStripButton attachmentButton = new ToolStripButton();
                    
                    attachmentButton.Image = ((System.Drawing.Image)vFattura.Properties.Resources.ResourceManager.GetObject("document_number_" + i--));
                    attachmentButton.Click += (sender, e) => pdfDocument_Click(sender, e, attachment);
                    attachmentButton.ToolTipText = attachment["NomeAttachment"].InnerText;
                    attachmentButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                    attachmentButton.Name = "document_number_" + i;

                    toolStrip1.Items.Add(attachmentButton);
                }
                this.Text = Application.ProductName + " " + Application.ProductVersion + " - " + filename;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pdfDocument_Click(object sender, EventArgs e, XmlNode attachment)
        {
            try
            {
                string fileName;
                byte[] bytes = Convert.FromBase64String(attachment["Attachment"].InnerText.Trim());
                // Il nodo FormatoAttachment è opzionale...
                if (attachment["FormatoAttachment"] != null) { 
                    fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + "." + attachment["FormatoAttachment"].InnerText.ToLower().Trim();
                }
                else
                {
                    fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + attachment["NomeAttachment"].InnerText.Trim();
                }
                System.IO.FileStream stream = new FileStream(fileName, FileMode.CreateNew);
                System.IO.BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(bytes, 0, bytes.Length);
                writer.Close();
                System.Diagnostics.Process.Start(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void openDocument_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog dialog = new OpenFileDialog();
                dialog.Filter = "XML files (*.xml)|*.xml|Tutti i file (*.*)|*.*";
                dialog.FilterIndex = 1;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    doOpenDocument(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printDocument_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     }
}