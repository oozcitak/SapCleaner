﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SapCleaner {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SapCleaner.LocalizedStrings", typeof(LocalizedStrings).Assembly);
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
        ///   Looks up a localized string similar to Analysis File Cleaner.
        /// </summary>
        internal static string AppTitle {
            get {
                return ResourceManager.GetString("AppTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Size.
        /// </summary>
        internal static string AssociatedFilesColumnName {
            get {
                return ResourceManager.GetString("AssociatedFilesColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1} files).
        /// </summary>
        internal static string AssociatedFilesSubItemText {
            get {
                return ResourceManager.GetString("AssociatedFilesSubItemText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Back.
        /// </summary>
        internal static string BackButtonText {
            get {
                return ResourceManager.GetString("BackButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Close.
        /// </summary>
        internal static string CloseButtonText {
            get {
                return ResourceManager.GetString("CloseButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete selected analysis result files?.
        /// </summary>
        internal static string ConfirmDeleteMessage {
            get {
                return ResourceManager.GetString("ConfirmDeleteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleted {0} files. Claimed {1} of hard disk space..
        /// </summary>
        internal static string DeleteResultLabelText {
            get {
                return ResourceManager.GetString("DeleteResultLabelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The model file has {0} analysis result files with a total file size of {1}..
        /// </summary>
        internal static string DetailsLabelText {
            get {
                return ResourceManager.GetString("DetailsLabelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path.
        /// </summary>
        internal static string FilePathColumnName {
            get {
                return ResourceManager.GetString("FilePathColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder.
        /// </summary>
        internal static string FolderColumnName {
            get {
                return ResourceManager.GetString("FolderColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Modified.
        /// </summary>
        internal static string ModifiedColumnName {
            get {
                return ResourceManager.GetString("ModifiedColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        internal static string NameColumnName {
            get {
                return ResourceManager.GetString("NameColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Next.
        /// </summary>
        internal static string NextButtonText {
            get {
                return ResourceManager.GetString("NextButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} files with analysis results were found. When these result files are deleted {1} of hard disk space will be claimed. Select the files to delete and click the next button. Model files will be kept, only the associated analysis result files will be deleted..
        /// </summary>
        internal static string SearchResultLabelText {
            get {
                return ResourceManager.GetString("SearchResultLabelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select at least one type of analysis file to search for..
        /// </summary>
        internal static string SelectAnalysisFilesMessage {
            get {
                return ResourceManager.GetString("SelectAnalysisFilesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select analysis result files to delete..
        /// </summary>
        internal static string SelectDeleteFilesMessage {
            get {
                return ResourceManager.GetString("SelectDeleteFilesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected {0} models contain {1} analysis files with a total file size of {2}..
        /// </summary>
        internal static string SelectionDetails {
            get {
                return ResourceManager.GetString("SelectionDetails", resourceCulture);
            }
        }
    }
}
