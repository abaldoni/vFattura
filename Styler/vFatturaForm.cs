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

namespace vFattura
{
    public partial class vFatturaForm : Form
    {
        public vFatturaForm()
        {
            InitializeComponent();
        }
       
        public void doOpenDocument(string filename)
        {
            try
            {
                string outfile = Path.GetTempFileName().Replace(".tmp", ".html");
                XslCompiledTransform transform = new XslCompiledTransform();

                transform.Load(XmlReader.Create(new StringReader(vFattura.Properties.Resources.Fattura_1_1)));
                transform.Transform(filename, outfile);
                webBrowser1.Navigate(outfile);

                XmlDocument fattura = new XmlDocument();
                fattura.Load(filename);
                XmlNodeList attachments = fattura.SelectNodes("/*/FatturaElettronicaBody/Allegati");
                int i = attachments.Count;
                foreach (XmlNode attachment in attachments)
                {
                    ToolStripButton attachmentButton = new ToolStripButton();
                    
                    attachmentButton.Image = ((System.Drawing.Image)vFattura.Properties.Resources.ResourceManager.GetObject("document_number_" + i--));
                    attachmentButton.Click += (sender, e) => pdfDocument_Click(sender, e, attachment);
                    attachmentButton.ToolTipText = attachment["NomeAttachment"].InnerText;
                    attachmentButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;

                    toolStrip1.Items.Add(attachmentButton);
                }
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
                byte[] bytes = Convert.FromBase64String(attachment["Attachment"].InnerText.Trim());
                string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + "." + attachment["FormatoAttachment"].InnerText.ToLower().Trim();
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