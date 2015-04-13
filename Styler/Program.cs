using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * Visualizzatore di fatture elettroniche XML con applicazione di foglio di stile XSL da http://www.fatturapa.gov.it/export/fatturazione/it/a-3.htm
 * Ispirazione originale: http://www.codeproject.com/Articles/294380/Applying-XSLT-Stylesheet-to-an-XML-File-at-Runtime
 * 
 * 20150331 AB
 */
namespace vFattura
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Il programma può essere eseguito in modalità interattiva o invocato da menu contestuale di Explorer
        /// selezionando un file XML da visualizzare.
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            vFatturaForm form = new vFatturaForm();
            if (args.Length == 1)
            {
                form.doOpenDocument(args[0]);
            }
            Application.Run(form);
        }
    }
}