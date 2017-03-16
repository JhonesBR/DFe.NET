﻿/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 

using CTeDLL.Wsdl.Configuracao;

namespace CTeDLL.Wsdl.Recepcao
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "CteRecepcaoSoap12",
        Namespace = "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao")]
    public partial class CteRecepcao : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private cteCabecMsg cteCabecMsgValueField;

        private System.Threading.SendOrPostCallback cteRecepcaoLoteOperationCompleted;

        /// <remarks/>
        public CteRecepcao(WsdlConfiguracao configuracao)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = configuracao.Url;
            this.cteCabecMsgValue = new cteCabecMsg
            {
                cUF = configuracao.CodigoIbgeEstado,
                versaoDados = configuracao.Versao
            };
            this.ClientCertificates.Add(configuracao.CertificadoDigital);
            this.Timeout = configuracao.TimeOut;
        }

        public cteCabecMsg cteCabecMsgValue
        {
            get { return this.cteCabecMsgValueField; }
            set { this.cteCabecMsgValueField = value; }
        }

        /// <remarks/>
        public event cteRecepcaoLoteCompletedEventHandler cteRecepcaoLoteCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("cteCabecMsgValue",
            Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute(
            "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao/cteRecepcaoLote",
            Use = System.Web.Services.Description.SoapBindingUse.Literal,
            ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return:
            System.Xml.Serialization.XmlElementAttribute(
                Namespace = "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao")]
        public System.Xml.XmlNode cteRecepcaoLote(
        [System.Xml.Serialization.XmlElementAttribute(
            Namespace = "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao")] System.Xml.XmlNode cteDadosMsg)
        {
            object[] results = this.Invoke("cteRecepcaoLote", new object[]
            {
                cteDadosMsg
            });
            return ((System.Xml.XmlNode) (results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegincteRecepcaoLote(System.Xml.XmlNode cteDadosMsg, System.AsyncCallback callback,
            object asyncState)
        {
            return this.BeginInvoke("cteRecepcaoLote", new object[]
            {
                cteDadosMsg
            }, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndcteRecepcaoLote(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode) (results[0]));
        }

        /// <remarks/>
        public void cteRecepcaoLoteAsync(System.Xml.XmlNode cteDadosMsg)
        {
            this.cteRecepcaoLoteAsync(cteDadosMsg, null);
        }

        /// <remarks/>
        public void cteRecepcaoLoteAsync(System.Xml.XmlNode cteDadosMsg, object userState)
        {
            if ((this.cteRecepcaoLoteOperationCompleted == null))
            {
                this.cteRecepcaoLoteOperationCompleted =
                    new System.Threading.SendOrPostCallback(this.OncteRecepcaoLoteOperationCompleted);
            }
            this.InvokeAsync("cteRecepcaoLote", new object[]
            {
                cteDadosMsg
            }, this.cteRecepcaoLoteOperationCompleted, userState);
        }

        private void OncteRecepcaoLoteOperationCompleted(object arg)
        {
            if ((this.cteRecepcaoLoteCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs =
                    ((System.Web.Services.Protocols.InvokeCompletedEventArgs) (arg));
                this.cteRecepcaoLoteCompleted(this,
                    new cteRecepcaoLoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled,
                        invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/cte/wsdl/CteRecepcao",
        IsNullable = false)]
    public partial class cteCabecMsg : System.Web.Services.Protocols.SoapHeader
    {

        private string cUFField;

        private string versaoDadosField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        public string cUF
        {
            get { return this.cUFField; }
            set { this.cUFField = value; }
        }

        /// <remarks/>
        public string versaoDados
        {
            get { return this.versaoDadosField; }
            set { this.versaoDadosField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get { return this.anyAttrField; }
            set { this.anyAttrField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    public delegate void cteRecepcaoLoteCompletedEventHandler(object sender, cteRecepcaoLoteCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cteRecepcaoLoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal cteRecepcaoLoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled,
            object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Xml.XmlNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode) (this.results[0]));
            }
        }
    }

}
