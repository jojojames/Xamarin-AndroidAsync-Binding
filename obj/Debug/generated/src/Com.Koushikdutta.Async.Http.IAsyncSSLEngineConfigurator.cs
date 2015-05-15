using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncSSLEngineConfigurator']"
	[Register ("com/koushikdutta/async/http/AsyncSSLEngineConfigurator", "", "Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfiguratorInvoker")]
	public partial interface IAsyncSSLEngineConfigurator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncSSLEngineConfigurator']/method[@name='configureEngine' and count(parameter)=4 and parameter[1][@type='javax.net.ssl.SSLEngine'] and parameter[2][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V", "GetConfigureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_IHandler:Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfiguratorInvoker, AndroidAsyncBinding")]
		void ConfigureEngine (global::Javax.Net.Ssl.SSLEngine p0, global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1, string p2, int p3);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncSSLEngineConfigurator", DoNotGenerateAcw=true)]
	internal class IAsyncSSLEngineConfiguratorInvoker : global::Java.Lang.Object, IAsyncSSLEngineConfigurator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncSSLEngineConfigurator");
		IntPtr class_ref;

		public static IAsyncSSLEngineConfigurator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncSSLEngineConfigurator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.AsyncSSLEngineConfigurator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncSSLEngineConfiguratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncSSLEngineConfiguratorInvoker); }
		}

		static Delegate cb_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetConfigureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_IHandler ()
		{
			if (cb_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I == null)
				cb_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ConfigureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I);
			return cb_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
		}

		static void n_ConfigureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLEngine p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureEngine (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
		public unsafe void ConfigureEngine (global::Javax.Net.Ssl.SSLEngine p0, global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1, string p2, int p3)
		{
			if (id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I == IntPtr.Zero)
				id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
