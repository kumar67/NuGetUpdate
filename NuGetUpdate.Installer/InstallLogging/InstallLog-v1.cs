﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace NuGetUpdate.Installer.InstallLogging {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://github.com/pvginkel/NuGetUpdate/InstallLog/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://github.com/pvginkel/NuGetUpdate/InstallLog/v1", IsNullable=false)]
    public partial class InstallLog {
        
        private InstallLogEntry[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreateDirectory", typeof(InstallLogCreateDirectory))]
        [System.Xml.Serialization.XmlElementAttribute("CreateFile", typeof(InstallLogCreateFile))]
        public InstallLogEntry[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://github.com/pvginkel/NuGetUpdate/InstallLog/v1")]
    public partial class InstallLogCreateDirectory : InstallLogEntry {
        
        private string pathField;
        
        private bool forceField;
        
        public InstallLogCreateDirectory() {
            this.forceField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Force {
            get {
                return this.forceField;
            }
            set {
                this.forceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://github.com/pvginkel/NuGetUpdate/InstallLog/v1")]
    public partial class InstallLogEntry {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://github.com/pvginkel/NuGetUpdate/InstallLog/v1")]
    public partial class InstallLogCreateFile : InstallLogEntry {
        
        private string pathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
    }
}
