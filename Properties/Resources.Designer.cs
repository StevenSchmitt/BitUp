﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataOne.BitUp.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataOne.BitUp.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to DefaultEndpointsProtocol=https;.
        /// </summary>
        internal static string AzureEndpointsProtocol {
            get {
                return ResourceManager.GetString("AzureEndpointsProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://.
        /// </summary>
        internal static string AzureFileLocation {
            get {
                return ResourceManager.GetString("AzureFileLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .file.core.windows.net/.
        /// </summary>
        internal static string AzureFileUri {
            get {
                return ResourceManager.GetString("AzureFileUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /issues/export/zip.
        /// </summary>
        internal static string BitbucketIssueExportDownloadUri {
            get {
                return ResourceManager.GetString("BitbucketIssueExportDownloadUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /issues/export.
        /// </summary>
        internal static string BitbucketIssueExportUri {
            get {
                return ResourceManager.GetString("BitbucketIssueExportUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.bitbucket.org/2.0/repositories/.
        /// </summary>
        internal static string BitbucketRepositoryNewApi {
            get {
                return ResourceManager.GetString("BitbucketRepositoryNewApi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://bitbucket.org/!api/1.0/repositories/.
        /// </summary>
        internal static string BitbucketRepositoryOldApi {
            get {
                return ResourceManager.GetString("BitbucketRepositoryOldApi", resourceCulture);
            }
        }
    }
}
