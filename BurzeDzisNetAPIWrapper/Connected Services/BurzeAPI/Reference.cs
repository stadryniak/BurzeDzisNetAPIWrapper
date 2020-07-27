﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BurzeAPI
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://burze.dzis.net/soap.php", ConfigurationName="BurzeAPI.serwerSOAPPort")]
    public interface serwerSOAPPort
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#KeyAPI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> KeyAPIAsync(string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#miejscowosc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<BurzeAPI.MyComplexTypeMiejscowosc> miejscowoscAsync(string nazwa, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#ostrzezenia_pogodowe", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<BurzeAPI.MyComplexTypeOstrzezenia> ostrzezenia_pogodoweAsync(float y, float x, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#szukaj_burzy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<BurzeAPI.MyComplexTypeBurza> szukaj_burzyAsync(string y, string x, int promien, string klucz);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://burze.dzis.net/soap.php#miejscowosci_lista", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> miejscowosci_listaAsync(string nazwa, string kraj, string klucz);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://burze.dzis.net/soap.php")]
    public partial class MyComplexTypeMiejscowosc
    {
        
        private System.Nullable<float> yField;
        
        private System.Nullable<float> xField;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<float> y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<float> x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://burze.dzis.net/soap.php")]
    public partial class MyComplexTypeBurza
    {
        
        private System.Nullable<int> liczbaField;
        
        private System.Nullable<float> odlegloscField;
        
        private string kierunekField;
        
        private System.Nullable<int> okresField;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> liczba
        {
            get
            {
                return this.liczbaField;
            }
            set
            {
                this.liczbaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<float> odleglosc
        {
            get
            {
                return this.odlegloscField;
            }
            set
            {
                this.odlegloscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string kierunek
        {
            get
            {
                return this.kierunekField;
            }
            set
            {
                this.kierunekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> okres
        {
            get
            {
                return this.okresField;
            }
            set
            {
                this.okresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="https://burze.dzis.net/soap.php")]
    public partial class MyComplexTypeOstrzezenia
    {
        
        private string od_dniaField;
        
        private string do_dniaField;
        
        private System.Nullable<int> mrozField;
        
        private string mroz_od_dniaField;
        
        private string mroz_do_dniaField;
        
        private System.Nullable<int> upalField;
        
        private string upal_od_dniaField;
        
        private string upal_do_dniaField;
        
        private System.Nullable<int> wiatrField;
        
        private string wiatr_od_dniaField;
        
        private string wiatr_do_dniaField;
        
        private System.Nullable<int> opadField;
        
        private string opad_od_dniaField;
        
        private string opad_do_dniaField;
        
        private System.Nullable<int> burzaField;
        
        private string burza_od_dniaField;
        
        private string burza_do_dniaField;
        
        private System.Nullable<int> trabaField;
        
        private string traba_od_dniaField;
        
        private string traba_do_dniaField;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string od_dnia
        {
            get
            {
                return this.od_dniaField;
            }
            set
            {
                this.od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string do_dnia
        {
            get
            {
                return this.do_dniaField;
            }
            set
            {
                this.do_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> mroz
        {
            get
            {
                return this.mrozField;
            }
            set
            {
                this.mrozField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string mroz_od_dnia
        {
            get
            {
                return this.mroz_od_dniaField;
            }
            set
            {
                this.mroz_od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string mroz_do_dnia
        {
            get
            {
                return this.mroz_do_dniaField;
            }
            set
            {
                this.mroz_do_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> upal
        {
            get
            {
                return this.upalField;
            }
            set
            {
                this.upalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string upal_od_dnia
        {
            get
            {
                return this.upal_od_dniaField;
            }
            set
            {
                this.upal_od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string upal_do_dnia
        {
            get
            {
                return this.upal_do_dniaField;
            }
            set
            {
                this.upal_do_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> wiatr
        {
            get
            {
                return this.wiatrField;
            }
            set
            {
                this.wiatrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string wiatr_od_dnia
        {
            get
            {
                return this.wiatr_od_dniaField;
            }
            set
            {
                this.wiatr_od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string wiatr_do_dnia
        {
            get
            {
                return this.wiatr_do_dniaField;
            }
            set
            {
                this.wiatr_do_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> opad
        {
            get
            {
                return this.opadField;
            }
            set
            {
                this.opadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string opad_od_dnia
        {
            get
            {
                return this.opad_od_dniaField;
            }
            set
            {
                this.opad_od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string opad_do_dnia
        {
            get
            {
                return this.opad_do_dniaField;
            }
            set
            {
                this.opad_do_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> burza
        {
            get
            {
                return this.burzaField;
            }
            set
            {
                this.burzaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string burza_od_dnia
        {
            get
            {
                return this.burza_od_dniaField;
            }
            set
            {
                this.burza_od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string burza_do_dnia
        {
            get
            {
                return this.burza_do_dniaField;
            }
            set
            {
                this.burza_do_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<int> traba
        {
            get
            {
                return this.trabaField;
            }
            set
            {
                this.trabaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string traba_od_dnia
        {
            get
            {
                return this.traba_od_dniaField;
            }
            set
            {
                this.traba_od_dniaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string traba_do_dnia
        {
            get
            {
                return this.traba_do_dniaField;
            }
            set
            {
                this.traba_do_dniaField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface serwerSOAPPortChannel : BurzeAPI.serwerSOAPPort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class serwerSOAPPortClient : System.ServiceModel.ClientBase<BurzeAPI.serwerSOAPPort>, BurzeAPI.serwerSOAPPort
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public serwerSOAPPortClient() : 
                base(serwerSOAPPortClient.GetDefaultBinding(), serwerSOAPPortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.serwerSOAPPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serwerSOAPPortClient(EndpointConfiguration endpointConfiguration) : 
                base(serwerSOAPPortClient.GetBindingForEndpoint(endpointConfiguration), serwerSOAPPortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serwerSOAPPortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(serwerSOAPPortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serwerSOAPPortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(serwerSOAPPortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serwerSOAPPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> KeyAPIAsync(string klucz)
        {
            return base.Channel.KeyAPIAsync(klucz);
        }
        
        public System.Threading.Tasks.Task<BurzeAPI.MyComplexTypeMiejscowosc> miejscowoscAsync(string nazwa, string klucz)
        {
            return base.Channel.miejscowoscAsync(nazwa, klucz);
        }
        
        public System.Threading.Tasks.Task<BurzeAPI.MyComplexTypeOstrzezenia> ostrzezenia_pogodoweAsync(float y, float x, string klucz)
        {
            return base.Channel.ostrzezenia_pogodoweAsync(y, x, klucz);
        }
        
        public System.Threading.Tasks.Task<BurzeAPI.MyComplexTypeBurza> szukaj_burzyAsync(string y, string x, int promien, string klucz)
        {
            return base.Channel.szukaj_burzyAsync(y, x, promien, klucz);
        }
        
        public System.Threading.Tasks.Task<string> miejscowosci_listaAsync(string nazwa, string kraj, string klucz)
        {
            return base.Channel.miejscowosci_listaAsync(nazwa, kraj, klucz);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.serwerSOAPPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.serwerSOAPPort))
            {
                return new System.ServiceModel.EndpointAddress("https://burze.dzis.net/soap.php");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return serwerSOAPPortClient.GetBindingForEndpoint(EndpointConfiguration.serwerSOAPPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return serwerSOAPPortClient.GetEndpointAddress(EndpointConfiguration.serwerSOAPPort);
        }
        
        public enum EndpointConfiguration
        {
            
            serwerSOAPPort,
        }
    }
}