﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime version: 4.0.30319.42000
//
//     Changes in this file may cause incorrect behavior and will be lost if
//     the code is rebuilt.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moway.Controller {
    using System;
    
    
    /// <summary>
    ///  Strongly typed resource class, to search for translated strings, etc.
    /// </summary>
    // StronglyTypedResourceBuilder automatically generated this class
    //  through a tool such as ResGen or Visual Studio.
    // To add or remove a member, edit the .ResX file and then run ResGen again
    // with the / str option or recompile your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ControllerMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ControllerMessages() {
        }
        
        /// <summary>
        ///  Returns the ResourceManager instance cached used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Moway.Controller.ControllerMessages", typeof(ControllerMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Replaces the CurrentUICulture property of the current thread
        ///   for all resource searches using this strongly typed resource class.
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
        ///   Search for a translated string similar to Communication error.
        /// </summary>
        internal static string COMMUNICATION_ERROR_TITLE {
            get {
                return ResourceManager.GetString("COMMUNICATION_ERROR_TITLE", resourceCulture);
            }
        }

        /// <summary>
        ///   Search for a translated string similar to mOway-PC communication error. Disconnect Moway from PC and restart MowayWorld.
        /// </summary>
        internal static string MOWAY_COMMUNICATION_ERROR {
            get {
                return ResourceManager.GetString("MOWAY_COMMUNICATION_ERROR", resourceCulture);
            }
        }
    }
}
