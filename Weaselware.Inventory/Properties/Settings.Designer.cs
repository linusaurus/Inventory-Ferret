﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weaselware.InventoryFerret.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastSupplierSearch {
            get {
                return ((string)(this["LastSupplierSearch"]));
            }
            set {
                this["LastSupplierSearch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Neodynamic.SDK.Printing.PrinterSettings PrinterSetting {
            get {
                return ((global::Neodynamic.SDK.Printing.PrinterSettings)(this["PrinterSetting"]));
            }
            set {
                this["PrinterSetting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastJobSearch {
            get {
                return ((string)(this["LastJobSearch"]));
            }
            set {
                this["LastJobSearch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastOrderReciept {
            get {
                return ((string)(this["LastOrderReciept"]));
            }
            set {
                this["LastOrderReciept"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmailPassword {
            get {
                return ((string)(this["EmailPassword"]));
            }
            set {
                this["EmailPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastClaimSearch {
            get {
                return ((string)(this["LastClaimSearch"]));
            }
            set {
                this["LastClaimSearch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0775")]
        public decimal Taxrate {
            get {
                return ((decimal)(this["Taxrate"]));
            }
            set {
                this["Taxrate"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.10.3;Initial Catalog=Badger;Persist Security Info=True;User I" +
            "D=sa;Password=Kx09a32x;Pooling=False;MultipleActiveResultSets=False;Connect Time" +
            "out=60;TrustServerCertificate=False")]
        public string BadgerConnectionString {
            get {
                return ((string)(this["BadgerConnectionString"]));
            }
        }
    }
}
