﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteNube.ServicioNube {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ejemplar", Namespace="http://schemas.datacontract.org/2004/07/ServicioNube")]
    [System.SerializableAttribute()]
    public partial class Ejemplar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CostoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaPublicacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrecioVentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string editoraidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ejemplaridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tituloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Costo {
            get {
                return this.CostoField;
            }
            set {
                if ((object.ReferenceEquals(this.CostoField, value) != true)) {
                    this.CostoField = value;
                    this.RaisePropertyChanged("Costo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaPublicacion {
            get {
                return this.FechaPublicacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaPublicacionField, value) != true)) {
                    this.FechaPublicacionField = value;
                    this.RaisePropertyChanged("FechaPublicacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PrecioVenta {
            get {
                return this.PrecioVentaField;
            }
            set {
                if ((object.ReferenceEquals(this.PrecioVentaField, value) != true)) {
                    this.PrecioVentaField = value;
                    this.RaisePropertyChanged("PrecioVenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string editoraid {
            get {
                return this.editoraidField;
            }
            set {
                if ((object.ReferenceEquals(this.editoraidField, value) != true)) {
                    this.editoraidField = value;
                    this.RaisePropertyChanged("editoraid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ejemplarid {
            get {
                return this.ejemplaridField;
            }
            set {
                if ((object.ReferenceEquals(this.ejemplaridField, value) != true)) {
                    this.ejemplaridField = value;
                    this.RaisePropertyChanged("ejemplarid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string titulo {
            get {
                return this.tituloField;
            }
            set {
                if ((object.ReferenceEquals(this.tituloField, value) != true)) {
                    this.tituloField = value;
                    this.RaisePropertyChanged("titulo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Editora", Namespace="http://schemas.datacontract.org/2004/07/ServicioNube")]
    [System.SerializableAttribute()]
    public partial class Editora : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_EditoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string editoraidField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre_Editora {
            get {
                return this.Nombre_EditoraField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_EditoraField, value) != true)) {
                    this.Nombre_EditoraField = value;
                    this.RaisePropertyChanged("Nombre_Editora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string editoraid {
            get {
                return this.editoraidField;
            }
            set {
                if ((object.ReferenceEquals(this.editoraidField, value) != true)) {
                    this.editoraidField = value;
                    this.RaisePropertyChanged("editoraid");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioNube.IServicioNube")]
    public interface IServicioNube {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/ObtenerEjemplares", ReplyAction="http://tempuri.org/IServicioNube/ObtenerEjemplaresResponse")]
        ClienteNube.ServicioNube.Ejemplar[] ObtenerEjemplares();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/ObtenerEjemplares", ReplyAction="http://tempuri.org/IServicioNube/ObtenerEjemplaresResponse")]
        System.Threading.Tasks.Task<ClienteNube.ServicioNube.Ejemplar[]> ObtenerEjemplaresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/devolverMensaje", ReplyAction="http://tempuri.org/IServicioNube/devolverMensajeResponse")]
        string devolverMensaje();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/devolverMensaje", ReplyAction="http://tempuri.org/IServicioNube/devolverMensajeResponse")]
        System.Threading.Tasks.Task<string> devolverMensajeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/IngresarLibro", ReplyAction="http://tempuri.org/IServicioNube/IngresarLibroResponse")]
        string IngresarLibro(string EjemplarId, string EditoraId, string titulo, string FechaPublicacion, string Costo, string PrecioVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/IngresarLibro", ReplyAction="http://tempuri.org/IServicioNube/IngresarLibroResponse")]
        System.Threading.Tasks.Task<string> IngresarLibroAsync(string EjemplarId, string EditoraId, string titulo, string FechaPublicacion, string Costo, string PrecioVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/BuscarEjemplar", ReplyAction="http://tempuri.org/IServicioNube/BuscarEjemplarResponse")]
        ClienteNube.ServicioNube.Ejemplar BuscarEjemplar(string EjemplarId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/BuscarEjemplar", ReplyAction="http://tempuri.org/IServicioNube/BuscarEjemplarResponse")]
        System.Threading.Tasks.Task<ClienteNube.ServicioNube.Ejemplar> BuscarEjemplarAsync(string EjemplarId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/BorrarEjemplar", ReplyAction="http://tempuri.org/IServicioNube/BorrarEjemplarResponse")]
        bool BorrarEjemplar(string Ejemplar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/BorrarEjemplar", ReplyAction="http://tempuri.org/IServicioNube/BorrarEjemplarResponse")]
        System.Threading.Tasks.Task<bool> BorrarEjemplarAsync(string Ejemplar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/ModificarEjemplar", ReplyAction="http://tempuri.org/IServicioNube/ModificarEjemplarResponse")]
        bool ModificarEjemplar(string Ejemplarid, string editoraid, string titulo, string fechapublicacion, string Costo, string PrecioVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/ModificarEjemplar", ReplyAction="http://tempuri.org/IServicioNube/ModificarEjemplarResponse")]
        System.Threading.Tasks.Task<bool> ModificarEjemplarAsync(string Ejemplarid, string editoraid, string titulo, string fechapublicacion, string Costo, string PrecioVenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/BuscarEditorial", ReplyAction="http://tempuri.org/IServicioNube/BuscarEditorialResponse")]
        ClienteNube.ServicioNube.Editora BuscarEditorial(string editoraid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/BuscarEditorial", ReplyAction="http://tempuri.org/IServicioNube/BuscarEditorialResponse")]
        System.Threading.Tasks.Task<ClienteNube.ServicioNube.Editora> BuscarEditorialAsync(string editoraid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/ObtenerEditoras", ReplyAction="http://tempuri.org/IServicioNube/ObtenerEditorasResponse")]
        ClienteNube.ServicioNube.Editora[] ObtenerEditoras();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioNube/ObtenerEditoras", ReplyAction="http://tempuri.org/IServicioNube/ObtenerEditorasResponse")]
        System.Threading.Tasks.Task<ClienteNube.ServicioNube.Editora[]> ObtenerEditorasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioNubeChannel : ClienteNube.ServicioNube.IServicioNube, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioNubeClient : System.ServiceModel.ClientBase<ClienteNube.ServicioNube.IServicioNube>, ClienteNube.ServicioNube.IServicioNube {
        
        public ServicioNubeClient() {
        }
        
        public ServicioNubeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioNubeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioNubeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioNubeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteNube.ServicioNube.Ejemplar[] ObtenerEjemplares() {
            return base.Channel.ObtenerEjemplares();
        }
        
        public System.Threading.Tasks.Task<ClienteNube.ServicioNube.Ejemplar[]> ObtenerEjemplaresAsync() {
            return base.Channel.ObtenerEjemplaresAsync();
        }
        
        public string devolverMensaje() {
            return base.Channel.devolverMensaje();
        }
        
        public System.Threading.Tasks.Task<string> devolverMensajeAsync() {
            return base.Channel.devolverMensajeAsync();
        }
        
        public string IngresarLibro(string EjemplarId, string EditoraId, string titulo, string FechaPublicacion, string Costo, string PrecioVenta) {
            return base.Channel.IngresarLibro(EjemplarId, EditoraId, titulo, FechaPublicacion, Costo, PrecioVenta);
        }
        
        public System.Threading.Tasks.Task<string> IngresarLibroAsync(string EjemplarId, string EditoraId, string titulo, string FechaPublicacion, string Costo, string PrecioVenta) {
            return base.Channel.IngresarLibroAsync(EjemplarId, EditoraId, titulo, FechaPublicacion, Costo, PrecioVenta);
        }
        
        public ClienteNube.ServicioNube.Ejemplar BuscarEjemplar(string EjemplarId) {
            return base.Channel.BuscarEjemplar(EjemplarId);
        }
        
        public System.Threading.Tasks.Task<ClienteNube.ServicioNube.Ejemplar> BuscarEjemplarAsync(string EjemplarId) {
            return base.Channel.BuscarEjemplarAsync(EjemplarId);
        }
        
        public bool BorrarEjemplar(string Ejemplar) {
            return base.Channel.BorrarEjemplar(Ejemplar);
        }
        
        public System.Threading.Tasks.Task<bool> BorrarEjemplarAsync(string Ejemplar) {
            return base.Channel.BorrarEjemplarAsync(Ejemplar);
        }
        
        public bool ModificarEjemplar(string Ejemplarid, string editoraid, string titulo, string fechapublicacion, string Costo, string PrecioVenta) {
            return base.Channel.ModificarEjemplar(Ejemplarid, editoraid, titulo, fechapublicacion, Costo, PrecioVenta);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarEjemplarAsync(string Ejemplarid, string editoraid, string titulo, string fechapublicacion, string Costo, string PrecioVenta) {
            return base.Channel.ModificarEjemplarAsync(Ejemplarid, editoraid, titulo, fechapublicacion, Costo, PrecioVenta);
        }
        
        public ClienteNube.ServicioNube.Editora BuscarEditorial(string editoraid) {
            return base.Channel.BuscarEditorial(editoraid);
        }
        
        public System.Threading.Tasks.Task<ClienteNube.ServicioNube.Editora> BuscarEditorialAsync(string editoraid) {
            return base.Channel.BuscarEditorialAsync(editoraid);
        }
        
        public ClienteNube.ServicioNube.Editora[] ObtenerEditoras() {
            return base.Channel.ObtenerEditoras();
        }
        
        public System.Threading.Tasks.Task<ClienteNube.ServicioNube.Editora[]> ObtenerEditorasAsync() {
            return base.Channel.ObtenerEditorasAsync();
        }
    }
}
