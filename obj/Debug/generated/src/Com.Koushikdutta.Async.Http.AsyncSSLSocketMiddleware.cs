using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncSSLSocketMiddleware", DoNotGenerateAcw=true)]
	public partial class AsyncSSLSocketMiddleware : global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware {


		static IntPtr engineConfigurators_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/field[@name='engineConfigurators']"
		[Register ("engineConfigurators")]
		protected global::System.Collections.IList EngineConfigurators {
			get {
				if (engineConfigurators_jfieldId == IntPtr.Zero)
					engineConfigurators_jfieldId = JNIEnv.GetFieldID (class_ref, "engineConfigurators", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, engineConfigurators_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (engineConfigurators_jfieldId == IntPtr.Zero)
					engineConfigurators_jfieldId = JNIEnv.GetFieldID (class_ref, "engineConfigurators", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, engineConfigurators_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr hostnameVerifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/field[@name='hostnameVerifier']"
		[Register ("hostnameVerifier")]
		protected global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier {
			get {
				if (hostnameVerifier_jfieldId == IntPtr.Zero)
					hostnameVerifier_jfieldId = JNIEnv.GetFieldID (class_ref, "hostnameVerifier", "Ljavax/net/ssl/HostnameVerifier;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, hostnameVerifier_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (hostnameVerifier_jfieldId == IntPtr.Zero)
					hostnameVerifier_jfieldId = JNIEnv.GetFieldID (class_ref, "hostnameVerifier", "Ljavax/net/ssl/HostnameVerifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, hostnameVerifier_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sslContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/field[@name='sslContext']"
		[Register ("sslContext")]
		protected global::Javax.Net.Ssl.SSLContext SslContext {
			get {
				if (sslContext_jfieldId == IntPtr.Zero)
					sslContext_jfieldId = JNIEnv.GetFieldID (class_ref, "sslContext", "Ljavax/net/ssl/SSLContext;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sslContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sslContext_jfieldId == IntPtr.Zero)
					sslContext_jfieldId = JNIEnv.GetFieldID (class_ref, "sslContext", "Ljavax/net/ssl/SSLContext;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, sslContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr trustManagers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/field[@name='trustManagers']"
		[Register ("trustManagers")]
		protected IList<Javax.Net.Ssl.ITrustManager> TrustManagers {
			get {
				if (trustManagers_jfieldId == IntPtr.Zero)
					trustManagers_jfieldId = JNIEnv.GetFieldID (class_ref, "trustManagers", "[Ljavax/net/ssl/TrustManager;");
				return JavaArray<global::Javax.Net.Ssl.ITrustManager>.FromJniHandle (JNIEnv.GetObjectField (Handle, trustManagers_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (trustManagers_jfieldId == IntPtr.Zero)
					trustManagers_jfieldId = JNIEnv.GetFieldID (class_ref, "trustManagers", "[Ljavax/net/ssl/TrustManager;");
				IntPtr native_value = JavaArray<global::Javax.Net.Ssl.ITrustManager>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, trustManagers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncSSLSocketMiddleware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncSSLSocketMiddleware); }
		}

		protected AsyncSSLSocketMiddleware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/constructor[@name='AsyncSSLSocketMiddleware' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", "")]
		public unsafe AsyncSSLSocketMiddleware (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsyncSSLSocketMiddleware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_, __args);
			} finally {
			}
		}

		static Delegate cb_getSSLContext;
#pragma warning disable 0169
		static Delegate GetGetSSLContextHandler ()
		{
			if (cb_getSSLContext == null)
				cb_getSSLContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSSLContext);
			return cb_getSSLContext;
		}

		static IntPtr n_GetSSLContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SSLContext);
		}
#pragma warning restore 0169

		static Delegate cb_setSSLContext_Ljavax_net_ssl_SSLContext_;
#pragma warning disable 0169
		static Delegate GetSetSSLContext_Ljavax_net_ssl_SSLContext_Handler ()
		{
			if (cb_setSSLContext_Ljavax_net_ssl_SSLContext_ == null)
				cb_setSSLContext_Ljavax_net_ssl_SSLContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSSLContext_Ljavax_net_ssl_SSLContext_);
			return cb_setSSLContext_Ljavax_net_ssl_SSLContext_;
		}

		static void n_SetSSLContext_Ljavax_net_ssl_SSLContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLContext p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SSLContext = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSSLContext;
		static IntPtr id_setSSLContext_Ljavax_net_ssl_SSLContext_;
		public virtual unsafe global::Javax.Net.Ssl.SSLContext SSLContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='getSSLContext' and count(parameter)=0]"
			[Register ("getSSLContext", "()Ljavax/net/ssl/SSLContext;", "GetGetSSLContextHandler")]
			get {
				if (id_getSSLContext == IntPtr.Zero)
					id_getSSLContext = JNIEnv.GetMethodID (class_ref, "getSSLContext", "()Ljavax/net/ssl/SSLContext;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (JNIEnv.CallObjectMethod  (Handle, id_getSSLContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLContext", "()Ljavax/net/ssl/SSLContext;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='setSSLContext' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLContext']]"
			[Register ("setSSLContext", "(Ljavax/net/ssl/SSLContext;)V", "GetSetSSLContext_Ljavax_net_ssl_SSLContext_Handler")]
			set {
				if (id_setSSLContext_Ljavax_net_ssl_SSLContext_ == IntPtr.Zero)
					id_setSSLContext_Ljavax_net_ssl_SSLContext_ = JNIEnv.GetMethodID (class_ref, "setSSLContext", "(Ljavax/net/ssl/SSLContext;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSSLContext_Ljavax_net_ssl_SSLContext_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSSLContext", "(Ljavax/net/ssl/SSLContext;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_;
#pragma warning disable 0169
		static Delegate GetAddEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_Handler ()
		{
			if (cb_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_ == null)
				cb_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_);
			return cb_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_;
		}

		static void n_AddEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator p0 = (global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddEngineConfigurator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='addEngineConfigurator' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncSSLEngineConfigurator']]"
		[Register ("addEngineConfigurator", "(Lcom/koushikdutta/async/http/AsyncSSLEngineConfigurator;)V", "GetAddEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_Handler")]
		public virtual unsafe void AddEngineConfigurator (global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator p0)
		{
			if (id_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_ == IntPtr.Zero)
				id_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_ = JNIEnv.GetMethodID (class_ref, "addEngineConfigurator", "(Lcom/koushikdutta/async/http/AsyncSSLEngineConfigurator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addEngineConfigurator_Lcom_koushikdutta_async_http_AsyncSSLEngineConfigurator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEngineConfigurator", "(Lcom/koushikdutta/async/http/AsyncSSLEngineConfigurator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearEngineConfigurators;
#pragma warning disable 0169
		static Delegate GetClearEngineConfiguratorsHandler ()
		{
			if (cb_clearEngineConfigurators == null)
				cb_clearEngineConfigurators = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearEngineConfigurators);
			return cb_clearEngineConfigurators;
		}

		static void n_ClearEngineConfigurators (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearEngineConfigurators ();
		}
#pragma warning restore 0169

		static IntPtr id_clearEngineConfigurators;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='clearEngineConfigurators' and count(parameter)=0]"
		[Register ("clearEngineConfigurators", "()V", "GetClearEngineConfiguratorsHandler")]
		public virtual unsafe void ClearEngineConfigurators ()
		{
			if (id_clearEngineConfigurators == IntPtr.Zero)
				id_clearEngineConfigurators = JNIEnv.GetMethodID (class_ref, "clearEngineConfigurators", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearEngineConfigurators);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearEngineConfigurators", "()V"));
			} finally {
			}
		}

		static Delegate cb_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCreateConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_IHandler ()
		{
			if (cb_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I == null)
				cb_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreateConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I);
			return cb_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
		}

		static IntPtr n_CreateConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConfiguredSSLEngine (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='createConfiguredSSLEngine' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("createConfiguredSSLEngine", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;", "GetCreateConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_IHandler")]
		protected virtual unsafe global::Javax.Net.Ssl.SSLEngine CreateConfiguredSSLEngine (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0, string p1, int p2)
		{
			if (id_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I == IntPtr.Zero)
				id_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "createConfiguredSSLEngine", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Javax.Net.Ssl.SSLEngine __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (JNIEnv.CallObjectMethod  (Handle, id_createConfiguredSSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createConfiguredSSLEngine", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)Ljavax/net/ssl/SSLEngine;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetCreateHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_Handler ()
		{
			if (cb_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_ == null)
				cb_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_);
			return cb_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_;
		}

		static IntPtr n_CreateHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IConnectCallback p1 = (global::Com.Koushikdutta.Async.Callback.IConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateHandshakeCallback (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='createHandshakeCallback' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[2][@type='com.koushikdutta.async.callback.ConnectCallback']]"
		[Register ("createHandshakeCallback", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Lcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback;", "GetCreateHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_Handler")]
		protected virtual unsafe global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback CreateHandshakeCallback (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0, global::Com.Koushikdutta.Async.Callback.IConnectCallback p1)
		{
			if (id_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_ == IntPtr.Zero)
				id_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "createHandshakeCallback", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Lcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback> (JNIEnv.CallObjectMethod  (Handle, id_createHandshakeCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Lcom_koushikdutta_async_callback_ConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createHandshakeCallback", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Lcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
#pragma warning disable 0169
		static Delegate GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler ()
		{
			if (cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == null)
				cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_);
			return cb_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
		}

		static void n_SetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.IHostnameVerifier p0 = (global::Javax.Net.Ssl.IHostnameVerifier)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHostnameVerifier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='setHostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
		[Register ("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", "GetSetHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_Handler")]
		public virtual unsafe void SetHostnameVerifier (global::Javax.Net.Ssl.IHostnameVerifier p0)
		{
			if (id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ == IntPtr.Zero)
				id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_ = JNIEnv.GetMethodID (class_ref, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHostnameVerifier_Ljavax_net_ssl_HostnameVerifier_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrustManagers_arrayLjavax_net_ssl_TrustManager_;
#pragma warning disable 0169
		static Delegate GetSetTrustManagers_arrayLjavax_net_ssl_TrustManager_Handler ()
		{
			if (cb_setTrustManagers_arrayLjavax_net_ssl_TrustManager_ == null)
				cb_setTrustManagers_arrayLjavax_net_ssl_TrustManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrustManagers_arrayLjavax_net_ssl_TrustManager_);
			return cb_setTrustManagers_arrayLjavax_net_ssl_TrustManager_;
		}

		static void n_SetTrustManagers_arrayLjavax_net_ssl_TrustManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.ITrustManager[] p0 = (global::Javax.Net.Ssl.ITrustManager[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Javax.Net.Ssl.ITrustManager));
			__this.SetTrustManagers (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrustManagers_arrayLjavax_net_ssl_TrustManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='setTrustManagers' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.TrustManager[]']]"
		[Register ("setTrustManagers", "([Ljavax/net/ssl/TrustManager;)V", "GetSetTrustManagers_arrayLjavax_net_ssl_TrustManager_Handler")]
		public virtual unsafe void SetTrustManagers (global::Javax.Net.Ssl.ITrustManager[] p0)
		{
			if (id_setTrustManagers_arrayLjavax_net_ssl_TrustManager_ == IntPtr.Zero)
				id_setTrustManagers_arrayLjavax_net_ssl_TrustManager_ = JNIEnv.GetMethodID (class_ref, "setTrustManagers", "([Ljavax/net/ssl/TrustManager;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTrustManagers_arrayLjavax_net_ssl_TrustManager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrustManagers", "([Ljavax/net/ssl/TrustManager;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetTryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_Handler ()
		{
			if (cb_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_ == null)
				cb_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_TryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_);
			return cb_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_;
		}

		static void n_TryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IAsyncSocket p0 = (global::Com.Koushikdutta.Async.IAsyncSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p2 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IConnectCallback p4 = (global::Com.Koushikdutta.Async.Callback.IConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.TryHandshake (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSSLSocketMiddleware']/method[@name='tryHandshake' and count(parameter)=5 and parameter[1][@type='com.koushikdutta.async.AsyncSocket'] and parameter[2][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='int'] and parameter[5][@type='com.koushikdutta.async.callback.ConnectCallback']]"
		[Register ("tryHandshake", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Landroid/net/Uri;ILcom/koushikdutta/async/callback/ConnectCallback;)V", "GetTryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_Handler")]
		protected virtual unsafe void TryHandshake (global::Com.Koushikdutta.Async.IAsyncSocket p0, global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1, global::Android.Net.Uri p2, int p3, global::Com.Koushikdutta.Async.Callback.IConnectCallback p4)
		{
			if (id_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_ == IntPtr.Zero)
				id_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "tryHandshake", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Landroid/net/Uri;ILcom/koushikdutta/async/callback/ConnectCallback;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_tryHandshake_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_ILcom_koushikdutta_async_callback_ConnectCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryHandshake", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Landroid/net/Uri;ILcom/koushikdutta/async/callback/ConnectCallback;)V"), __args);
			} finally {
			}
		}

	}
}
