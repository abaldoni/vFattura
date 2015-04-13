namespace Styler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtXMLFileName = new System.Windows.Forms.TextBox();
            this.txtXSLFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseXML = new System.Windows.Forms.Button();
            this.btnBrowseXSL = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter XML File Name: ";
            // 
            // txtXMLFileName
            // 
            this.txtXMLFileName.Location = new System.Drawing.Point(148, 42);
            this.txtXMLFileName.Name = "txtXMLFileName";
            this.txtXMLFileName.Size = new System.Drawing.Size(253, 20);
            this.txtXMLFileName.TabIndex = 1;
            // 
            // txtXSLFileName
            // 
            this.txtXSLFileName.Location = new System.Drawing.Point(148, 101);
            this.txtXSLFileName.Name = "txtXSLFileName";
            this.txtXSLFileName.Size = new System.Drawing.Size(253, 20);
            this.txtXSLFileName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter XSL File Name: ";
            // 
            // btnBrowseXML
            // 
            this.btnBrowseXML.Location = new System.Drawing.Point(148, 68);
            this.btnBrowseXML.Name = "btnBrowseXML";
            this.btnBrowseXML.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXML.TabIndex = 4;
            this.btnBrowseXML.Text = "Browse...";
            this.btnBrowseXML.UseVisualStyleBackColor = true;
            this.btnBrowseXML.Click += new System.EventHandler(this.btnBrowseXML_Click);
            // 
            // btnBrowseXSL
            // 
            this.btnBrowseXSL.Location = new System.Drawing.Point(148, 127);
            this.btnBrowseXSL.Name = "btnBrowseXSL";
            this.btnBrowseXSL.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXSL.TabIndex = 5;
            this.btnBrowseXSL.Text = "Browse...";
            this.btnBrowseXSL.UseVisualStyleBackColor = true;
            this.btnBrowseXSL.Click += new System.EventHandler(this.btnBrowseXSL_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(71, 173);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(180, 173);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(407, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(561, 430);
            this.webBrowser1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 444);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnBrowseXSL);
            this.Controls.Add(this.btnBrowseXML);
            this.Controls.Add(this.txtXSLFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXMLFileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Apply Stylesheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXMLFileName;
        private System.Windows.Forms.TextBox txtXSLFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseXML;
        private System.Windows.Forms.Button btnBrowseXSL;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

