﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to The configuration-specified type {0} must be public, and is not..
        /// </summary>
        internal static string ConfigurationTypeMustBePublic {
            get {
                return ResourceManager.GetString("ConfigurationTypeMustBePublic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration XAML reference to {0} requires a current HttpContext to resolve..
        /// </summary>
        internal static string ConfigurationXamlReferenceRequiresHttpContext {
            get {
                return ResourceManager.GetString("ConfigurationXamlReferenceRequiresHttpContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current IHttpHandler is not one of types: {0}.  An embedded resource URL provider must be set in your .config file..
        /// </summary>
        internal static string EmbeddedResourceUrlProviderRequired {
            get {
                return ResourceManager.GetString("EmbeddedResourceUrlProviderRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The empty string is not allowed..
        /// </summary>
        internal static string EmptyStringNotAllowed {
            get {
                return ResourceManager.GetString("EmptyStringNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument has an unexpected value..
        /// </summary>
        internal static string InvalidArgument {
            get {
                return ResourceManager.GetString("InvalidArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} must be set before this operation is allowed..
        /// </summary>
        internal static string RequiredPropertyNotYetPreset {
            get {
                return ResourceManager.GetString("RequiredPropertyNotYetPreset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object contains a response body, which is not supported..
        /// </summary>
        internal static string ResponseBodyNotSupported {
            get {
                return ResourceManager.GetString("ResponseBodyNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current HttpContext was detected, so an {0} instance must be explicitly provided or specified in the .config file.  Call the constructor overload that takes an {0}..
        /// </summary>
        internal static string StoreRequiredWhenNoHttpContextAvailable {
            get {
                return ResourceManager.GetString("StoreRequiredWhenNoHttpContextAvailable", resourceCulture);
            }
        }
    }
}
