﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameInCSharp1.Dialogue.ClassInfo {
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
    internal class MageAbout {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MageAbout() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GameInCSharp1.Dialogue.ClassInfo.MageAbout", typeof(MageAbout).Assembly);
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
        ///   Looks up a localized string similar to His max health is 75..
        /// </summary>
        internal static string MageHealthInfo {
            get {
                return ResourceManager.GetString("MageHealthInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mage is weak, but makes up for it based on his many damaging abilities..
        /// </summary>
        internal static string MageInfo {
            get {
                return ResourceManager.GetString("MageInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to His max mana is 175..
        /// </summary>
        internal static string MageManaInfo {
            get {
                return ResourceManager.GetString("MageManaInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to His max stamina is 50..
        /// </summary>
        internal static string MageStaminaInfo {
            get {
                return ResourceManager.GetString("MageStaminaInfo", resourceCulture);
            }
        }
    }
}