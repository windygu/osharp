﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSharp.Web.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OSharp.Web.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 返回数据处理错误，请尝试升级客户端以解决问题。 的本地化字符串。
        /// </summary>
        internal static string Http_Seciruty_Client_DecryptResponse_Failt {
            get {
                return ResourceManager.GetString("Http_Seciruty_Client_DecryptResponse_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 客户端对发送数据进行加密处理时发生异常。 的本地化字符串。
        /// </summary>
        internal static string Http_Security_Client_EncryptRequest_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Client_EncryptRequest_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 客户端对返回数据签名验证未通过。 的本地化字符串。
        /// </summary>
        internal static string Http_Security_Client_VerifyResponse_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Client_VerifyResponse_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 服务器对请求数据进行解密处理时发生异常。 的本地化字符串。
        /// </summary>
        internal static string Http_Security_Host_DecryptRequest_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Host_DecryptRequest_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 服务器对返回数据进行加密处理时发生异常。 的本地化字符串。
        /// </summary>
        internal static string Http_Security_Host_EncryptResponse_Failt {
            get {
                return ResourceManager.GetString("Http_Security_Host_EncryptResponse_Failt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 参数hashType必须为MD5或SHA1。 的本地化字符串。
        /// </summary>
        internal static string Http_Security_RSA_Sign_HashType {
            get {
                return ResourceManager.GetString("Http_Security_RSA_Sign_HashType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 指定功能只支持使用Ajax的方式来调用。 的本地化字符串。
        /// </summary>
        internal static string Mvc_ActionAttribute_AjaxOnlyMessage {
            get {
                return ResourceManager.GetString("Mvc_ActionAttribute_AjaxOnlyMessage", resourceCulture);
            }
        }
    }
}