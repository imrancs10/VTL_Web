﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTL_Web.Global {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VTL_Web.Global.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to No response from server.
        /// </summary>
        internal static string Common_NoResponseFromServer {
            get {
                return ResourceManager.GetString("Common_NoResponseFromServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data already exists.
        /// </summary>
        internal static string Crud_DataAlreadyExist {
            get {
                return ResourceManager.GetString("Crud_DataAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data delete from database.
        /// </summary>
        internal static string Crud_DataDelete {
            get {
                return ResourceManager.GetString("Crud_DataDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data has not been saved.
        /// </summary>
        internal static string Crud_DataNotSaved {
            get {
                return ResourceManager.GetString("Crud_DataNotSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data has not been updated.
        /// </summary>
        internal static string Crud_DataNotUpdated {
            get {
                return ResourceManager.GetString("Crud_DataNotUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data has been saved.
        /// </summary>
        internal static string Crud_DataSaved {
            get {
                return ResourceManager.GetString("Crud_DataSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data has been updated.
        /// </summary>
        internal static string Crud_DataUpdated {
            get {
                return ResourceManager.GetString("Crud_DataUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data has not been deleted.
        /// </summary>
        internal static string Crud_NotDelete {
            get {
                return ResourceManager.GetString("Crud_NotDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Date should not be in past.
        /// </summary>
        internal static string Invalid_Past_Date {
            get {
                return ResourceManager.GetString("Invalid_Past_Date", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Posted Data is invalid.
        /// </summary>
        internal static string Invalid_Posted_Data {
            get {
                return ResourceManager.GetString("Invalid_Posted_Data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided Credentials are invalid.
        /// </summary>
        internal static string Login_InvalidCredential {
            get {
                return ResourceManager.GetString("Login_InvalidCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Session has been expired.
        /// </summary>
        internal static string Session_Expired {
            get {
                return ResourceManager.GetString("Session_Expired", resourceCulture);
            }
        }
    }
}
