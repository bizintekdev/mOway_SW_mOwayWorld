﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime version: 4.0.30319.42000
//
//     Changes in this file may cause incorrect behavior and will be lost if
//     the code is rebuilt.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moway.Panels {
    using System;
    
    
    /// <summary>
    ///  Strongly typed resource class, to search for translated strings, etc.
    /// </summary>
    // StronglyTypedResourceBuilder automatically generated this class
    //  through a tool such as ResGen or Visual Studio.
    // To add or remove a member, edit the .ResX file and then run ResGen again
    // with the / str option or recompile your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CommunicationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CommunicationMessages() {
        }
        
        /// <summary>
        ///  Returns the ResourceManager instance cached used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Moway.Panels.CommunicationMessages", typeof(CommunicationMessages).Assembly);
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
        ///   Search for a translated string similar to Communications.
        /// </summary>
        internal static string COMMUNICATIONS {
            get {
                return ResourceManager.GetString("COMMUNICATIONS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Are you sure you want to close communication box?.
        /// </summary>
        internal static string CONTINUE {
            get {
                return ResourceManager.GetString("CONTINUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Receiver is not reached.
        /// </summary>
        internal static string MSG_ACK_ERROR {
            get {
                return ResourceManager.GetString("MSG_ACK_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Can&apos;t send message.
        /// </summary>
        internal static string MSG_SEND_ERROR {
            get {
                return ResourceManager.GetString("MSG_SEND_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Message sent.
        /// </summary>
        internal static string MSG_SEND_OK {
            get {
                return ResourceManager.GetString("MSG_SEND_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Sending message....
        /// </summary>
        internal static string SENDING_MESSAGE {
            get {
                return ResourceManager.GetString("SENDING_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Communic..
        /// </summary>
        internal static string SHORT_TITTLE {
            get {
                return ResourceManager.GetString("SHORT_TITTLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Can&apos;t open RF communications. Try to reconnect RFUSB to computer..
        /// </summary>
        internal static string START_ERROR {
            get {
                return ResourceManager.GetString("START_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to Communications.
        /// </summary>
        internal static string TITTLE {
            get {
                return ResourceManager.GetString("TITTLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search for a translated string similar to If you close communication box, radio communication will close..
        /// </summary>
        internal static string WARNING_CLOSE {
            get {
                return ResourceManager.GetString("WARNING_CLOSE", resourceCulture);
            }
        }
    }
}