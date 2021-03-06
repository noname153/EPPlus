/*******************************************************************************
 * You may amend and distribute as you like, but don't remove this header!
 *
 * Required Notice: Copyright (C) EPPlus Software AB. 
 * https://epplussoftware.com
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.

 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
 * See the GNU Lesser General Public License for more details.
 *
 * The GNU Lesser General Public License can be viewed at http://www.opensource.org/licenses/lgpl-license.php
 * If you unfamiliar with this license or have questions about it, here is an http://www.gnu.org/licenses/gpl-faq.html
 *
 * All code and executables are provided "" as is "" with no warranty either express or implied. 
 * The author accepts no liability for any damage or loss of business that this product may cause.
 *
 * Code change notes:
 * 
  Date               Author                       Change
 *******************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *******************************************************************************/
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPPlusTest.Properties {
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Reflection;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
 //   [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EPPlusTest.Properties.Resources", 
#if Core 
                        typeof(Resources).GetTypeInfo().Assembly);
#else
                        typeof(Resources).Assembly);
#endif

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
        internal static System.Drawing.Bitmap Test1
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length>4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return (Bitmap)Image.FromFile(path + "\\Resources\\Test1.jpg");
            }
        }
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static MemoryStream VectorDrawing
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources") && path.Length > 4)
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\Vector Drawing.wmf"));
            }
        }

        internal static System.Drawing.Bitmap Pattern1
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return (Bitmap)Image.FromFile(path + "\\Resources\\Pattern1.jpeg");
            }
        }
        internal static MemoryStream TestThemeThmx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\TestTheme.thmx"));
            }
        }
        internal static MemoryStream SavonThmx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\Savon.thmx"));
            }
        }
        internal static MemoryStream WoodTypeThmx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\WoodType.thmx"));
            }
        }
        internal static MemoryStream TestLine3Crtx
        {
            get
            {
                string path = AppContext.BaseDirectory;
                while (!Directory.Exists(path + "\\Resources"))
                {
                    path = new DirectoryInfo(path + "\\..").FullName;
                }
                return new MemoryStream(File.ReadAllBytes(path + "\\Resources\\LineChart3.crtx"));
            }
        }
    }
}
