﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vFattura.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("vFattura.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_1 {
            get {
                object obj = ResourceManager.GetObject("document_number_1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_2 {
            get {
                object obj = ResourceManager.GetObject("document_number_2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_3 {
            get {
                object obj = ResourceManager.GetObject("document_number_3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_4 {
            get {
                object obj = ResourceManager.GetObject("document_number_4", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_5 {
            get {
                object obj = ResourceManager.GetObject("document_number_5", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_6 {
            get {
                object obj = ResourceManager.GetObject("document_number_6", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_7 {
            get {
                object obj = ResourceManager.GetObject("document_number_7", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_8 {
            get {
                object obj = ResourceManager.GetObject("document_number_8", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap document_number_9 {
            get {
                object obj = ResourceManager.GetObject("document_number_9", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;xsl:stylesheet 
        ///	version=&quot;1.1&quot; 
        ///	xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot; 
        ///	xmlns:a=&quot;http://www.fatturapa.gov.it/sdi/fatturapa/v1.1&quot;&gt;
        ///	&lt;xsl:output method=&quot;html&quot; /&gt;
        ///
        ///	&lt;xsl:template name=&quot;FormatDate&quot;&gt;
        ///		&lt;xsl:param name=&quot;DateTime&quot; /&gt;
        ///
        ///		&lt;xsl:variable name=&quot;year&quot; select=&quot;substring($DateTime,1,4)&quot; /&gt;
        ///		&lt;xsl:variable name=&quot;month&quot; select=&quot;substring($DateTime,6,2)&quot; /&gt;
        ///		&lt;xsl:variable name=&quot;day&quot; select=&quot;substring($DateTime,9,2)&quot; /&gt;
        ///
        ///		&lt;xsl:value-of select=&quot;&apos; (&apos;&quot; /&gt;
        ///		&lt;xs [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Fattura_1_1 {
            get {
                return ResourceManager.GetString("Fattura_1_1", resourceCulture);
            }
        }
    }
}