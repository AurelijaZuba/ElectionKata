﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectionKataTests {
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
    internal class TestData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ElectionKataTests.TestData", typeof(TestData).Assembly);
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
        ///   Looks up a localized string similar to Aldershot, 4445, LD, 26545, UKIP, 244, Ind, 3, SNP, 4, G, 3, C
        ///Aldridge-Brownhills, 12703, G, 10543, L, 5327, Ind, 258, LD, 76, C, 67, UKIP
        ///Altrincham and Sale West, 28667, G, 3372, SNP, 11372, L, 127, Ind, 13, LD, 381, UKIP
        ///Amber Valley, 15242, C, 9295, UKIP, 8197, LD, 5474, Ind, 26, G, 269, L, 2336, SNP
        ///Arundel and South Downs, 14939, SNP, 10117, UKIP, 3379, LD, 9137, Ind, 8699, G, 765, C, 1423, L
        ///Ashfield, 2012, C, 5352, Ind, 2759, L, 31770, SNP, 1651, G, 138, LD, 53, UKIP
        ///Ashford, 36165, SNP, 1477 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LargeInput {
            get {
                return ResourceManager.GetString("LargeInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aldershot || Liberal Democrats | 14.23% || UKIP | 84.96% || Independent | 0.78% || SNP | 0.01% || Green Party | 0.01% || Conservative Party | 0.01%
        ///Aldridge-Brownhills || Green Party | 43.84% || Labour Party | 36.39% || Independent | 18.39% || Liberal Democrats | 0.89% || Conservative Party | 0.26% || UKIP | 0.23%
        ///Altrincham and Sale West || Green Party | 65.25% || SNP | 7.68% || Labour Party | 25.89% || Independent | 0.29% || Liberal Democrats | 0.03% || UKIP | 0.87%
        ///Amber Valley || Conservative Party | [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LargeInputExpectedResult {
            get {
                return ResourceManager.GetString("LargeInputExpectedResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cardiff West, 11014, C, 17803, L, 4923, UKIP, 2069, LD
        ///Islington South &amp; Finsbury, 22547, L, 9389, C, 4829, LD, 3375, UKIP, 3371, G, 309, Ind.
        /// </summary>
        internal static string SmallInput {
            get {
                return ResourceManager.GetString("SmallInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cardiff West || Conservative Party | 30.76% || Labour Party | 49.72% || UKIP | 13.75% || Liberal Democrats | 5.78%
        ///Islington South &amp; Finsbury || Labour Party | 51.45% || Conservative Party | 21.43% || Liberal Democrats | 11.02% || UKIP | 7.70% || Green Party | 7.69% || Independent | 0.71%
        ///.
        /// </summary>
        internal static string SmallInputExpectedResult {
            get {
                return ResourceManager.GetString("SmallInputExpectedResult", resourceCulture);
            }
        }
    }
}
