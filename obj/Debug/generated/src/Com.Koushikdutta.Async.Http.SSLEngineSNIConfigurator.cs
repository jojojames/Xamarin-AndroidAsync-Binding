using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SSLEngineSNIConfigurator']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/SSLEngineSNIConfigurator", DoNotGenerateAcw=true)]
	public partial class SSLEngineSNIConfigurator : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SSLEngineSNIConfigurator.EngineHolder']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/SSLEngineSNIConfigurator$EngineHolder", DoNotGenerateAcw=true)]
		public partial class EngineHolder : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.IAsyncSSLEngineConfigurator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/SSLEngineSNIConfigurator$EngineHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EngineHolder); }
			}

			protected EngineHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Class_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SSLEngineSNIConfigurator.EngineHolder']/constructor[@name='SSLEngineSNIConfigurator.EngineHolder' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
			[Register (".ctor", "(Ljava/lang/Class;)V", "")]
			public unsafe EngineHolder (global::Java.Lang.Class p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (EngineHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Class;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Class_, __args);
				} finally {
				}
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
				global::Com.Koushikdutta.Async.Http.SSLEngineSNIConfigurator.EngineHolder __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SSLEngineSNIConfigurator.EngineHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Net.Ssl.SSLEngine p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.ConfigureEngine (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SSLEngineSNIConfigurator.EngineHolder']/method[@name='configureEngine' and count(parameter)=4 and parameter[1][@type='javax.net.ssl.SSLEngine'] and parameter[2][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
			[Register ("configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V", "GetConfigureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_IHandler")]
			public virtual unsafe void ConfigureEngine (global::Javax.Net.Ssl.SSLEngine p0, global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1, string p2, int p3)
			{
				if (id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I == IntPtr.Zero)
					id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/SSLEngineSNIConfigurator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLEngineSNIConfigurator); }
		}

		protected SSLEngineSNIConfigurator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SSLEngineSNIConfigurator']/constructor[@name='SSLEngineSNIConfigurator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SSLEngineSNIConfigurator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SSLEngineSNIConfigurator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.SSLEngineSNIConfigurator __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SSLEngineSNIConfigurator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLEngine p0 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureEngine (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SSLEngineSNIConfigurator']/method[@name='configureEngine' and count(parameter)=4 and parameter[1][@type='javax.net.ssl.SSLEngine'] and parameter[2][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V", "GetConfigureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_IHandler")]
		public virtual unsafe void ConfigureEngine (global::Javax.Net.Ssl.SSLEngine p0, global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p1, string p2, int p3)
		{
			if (id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I == IntPtr.Zero)
				id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_configureEngine_Ljavax_net_ssl_SSLEngine_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureEngine", "(Ljavax/net/ssl/SSLEngine;Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
