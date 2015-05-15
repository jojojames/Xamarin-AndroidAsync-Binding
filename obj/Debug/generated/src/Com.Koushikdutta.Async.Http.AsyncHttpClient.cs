using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClient", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClient : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClient.WebSocketConnectCallback']"
		[Register ("com/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback", "", "Com.Koushikdutta.Async.Http.AsyncHttpClient/IWebSocketConnectCallbackInvoker")]
		public partial interface IWebSocketConnectCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClient.WebSocketConnectCallback']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='com.koushikdutta.async.http.WebSocket']]"
			[Register ("onCompleted", "(Ljava/lang/Exception;Lcom/koushikdutta/async/http/WebSocket;)V", "GetOnCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_Handler:Com.Koushikdutta.Async.Http.AsyncHttpClient/IWebSocketConnectCallbackInvoker, AndroidAsyncBinding")]
			void OnCompleted (global::Java.Lang.Exception p0, global::Com.Koushikdutta.Async.Http.IWebSocket p1);

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback", DoNotGenerateAcw=true)]
		internal class IWebSocketConnectCallbackInvoker : global::Java.Lang.Object, IWebSocketConnectCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback");
			IntPtr class_ref;

			public static IWebSocketConnectCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWebSocketConnectCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.AsyncHttpClient.WebSocketConnectCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWebSocketConnectCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IWebSocketConnectCallbackInvoker); }
			}

			static Delegate cb_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_;
#pragma warning disable 0169
			static Delegate GetOnCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_Handler ()
			{
				if (cb_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_ == null)
					cb_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_);
				return cb_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_;
			}

			static void n_OnCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Http.IWebSocket p1 = (global::Com.Koushikdutta.Async.Http.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnCompleted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_;
			public unsafe void OnCompleted (global::Java.Lang.Exception p0, global::Com.Koushikdutta.Async.Http.IWebSocket p1)
			{
				if (id_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_ == IntPtr.Zero)
					id_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;Lcom/koushikdutta/async/http/WebSocket;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_http_WebSocket_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClient); }
		}

		protected AsyncHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_AsyncServer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/constructor[@name='AsyncHttpClient' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.AsyncServer']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/AsyncServer;)V", "")]
		public unsafe AsyncHttpClient (global::Com.Koushikdutta.Async.AsyncServer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsyncHttpClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/AsyncServer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/AsyncServer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_AsyncServer_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_AsyncServer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/AsyncServer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_AsyncServer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_AsyncServer_, __args);
			} finally {
			}
		}

		static IntPtr id_getDefaultInstance;
		public static unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpClient DefaultInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='getDefaultInstance' and count(parameter)=0]"
			[Register ("getDefaultInstance", "()Lcom/koushikdutta/async/http/AsyncHttpClient;", "GetGetDefaultInstanceHandler")]
			get {
				if (id_getDefaultInstance == IntPtr.Zero)
					id_getDefaultInstance = JNIEnv.GetStaticMethodID (class_ref, "getDefaultInstance", "()Lcom/koushikdutta/async/http/AsyncHttpClient;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMiddleware;
#pragma warning disable 0169
		static Delegate GetGetMiddlewareHandler ()
		{
			if (cb_getMiddleware == null)
				cb_getMiddleware = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiddleware);
			return cb_getMiddleware;
		}

		static IntPtr n_GetMiddleware (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware>.ToLocalJniHandle (__this.Middleware);
		}
#pragma warning restore 0169

		static IntPtr id_getMiddleware;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> Middleware {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='getMiddleware' and count(parameter)=0]"
			[Register ("getMiddleware", "()Ljava/util/ArrayList;", "GetGetMiddlewareHandler")]
			get {
				if (id_getMiddleware == IntPtr.Zero)
					id_getMiddleware = JNIEnv.GetMethodID (class_ref, "getMiddleware", "()Ljava/util/ArrayList;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMiddleware), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiddleware", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSSLSocketMiddleware;
#pragma warning disable 0169
		static Delegate GetGetSSLSocketMiddlewareHandler ()
		{
			if (cb_getSSLSocketMiddleware == null)
				cb_getSSLSocketMiddleware = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSSLSocketMiddleware);
			return cb_getSSLSocketMiddleware;
		}

		static IntPtr n_GetSSLSocketMiddleware (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SSLSocketMiddleware);
		}
#pragma warning restore 0169

		static IntPtr id_getSSLSocketMiddleware;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware SSLSocketMiddleware {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='getSSLSocketMiddleware' and count(parameter)=0]"
			[Register ("getSSLSocketMiddleware", "()Lcom/koushikdutta/async/http/spdy/SpdyMiddleware;", "GetGetSSLSocketMiddlewareHandler")]
			get {
				if (id_getSSLSocketMiddleware == IntPtr.Zero)
					id_getSSLSocketMiddleware = JNIEnv.GetMethodID (class_ref, "getSSLSocketMiddleware", "()Lcom/koushikdutta/async/http/spdy/SpdyMiddleware;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware> (JNIEnv.CallObjectMethod  (Handle, id_getSSLSocketMiddleware), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLSocketMiddleware", "()Lcom/koushikdutta/async/http/spdy/SpdyMiddleware;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServer;
#pragma warning disable 0169
		static Delegate GetGetServerHandler ()
		{
			if (cb_getServer == null)
				cb_getServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServer);
			return cb_getServer;
		}

		static IntPtr n_GetServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetServerHandler")]
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/koushikdutta/async/AsyncServer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallObjectMethod  (Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServer", "()Lcom/koushikdutta/async/AsyncServer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSocketMiddleware;
#pragma warning disable 0169
		static Delegate GetGetSocketMiddlewareHandler ()
		{
			if (cb_getSocketMiddleware == null)
				cb_getSocketMiddleware = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocketMiddleware);
			return cb_getSocketMiddleware;
		}

		static IntPtr n_GetSocketMiddleware (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SocketMiddleware);
		}
#pragma warning restore 0169

		static IntPtr id_getSocketMiddleware;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware SocketMiddleware {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='getSocketMiddleware' and count(parameter)=0]"
			[Register ("getSocketMiddleware", "()Lcom/koushikdutta/async/http/AsyncSocketMiddleware;", "GetGetSocketMiddlewareHandler")]
			get {
				if (id_getSocketMiddleware == IntPtr.Zero)
					id_getSocketMiddleware = JNIEnv.GetMethodID (class_ref, "getSocketMiddleware", "()Lcom/koushikdutta/async/http/AsyncSocketMiddleware;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (JNIEnv.CallObjectMethod  (Handle, id_getSocketMiddleware), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocketMiddleware", "()Lcom/koushikdutta/async/http/AsyncSocketMiddleware;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_Handler ()
		{
			if (cb_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ == null)
				cb_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_);
			return cb_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_;
		}

		static IntPtr n_Execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback p1 = (global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpRequest'] and parameter[2][@type='com.koushikdutta.async.http.callback.HttpConnectCallback']]"
		[Register ("execute", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/http/callback/HttpConnectCallback;)Lcom/koushikdutta/async/future/Future;", "GetExecute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture Execute (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0, global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback p1)
		{
			if (id_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ == IntPtr.Zero)
				id_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/http/callback/HttpConnectCallback;)Lcom/koushikdutta/async/future/Future;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_execute_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/http/callback/HttpConnectCallback;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_Handler ()
		{
			if (cb_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ == null)
				cb_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_);
			return cb_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_;
		}

		static IntPtr n_Execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback p1 = (global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='execute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.callback.HttpConnectCallback']]"
		[Register ("execute", "(Ljava/lang/String;Lcom/koushikdutta/async/http/callback/HttpConnectCallback;)Lcom/koushikdutta/async/future/Future;", "GetExecute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture Execute (string p0, global::Com.Koushikdutta.Async.Http.Callback.IHttpConnectCallback p1)
		{
			if (id_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ == IntPtr.Zero)
				id_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/String;Lcom/koushikdutta/async/http/callback/HttpConnectCallback;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_execute_Ljava_lang_String_Lcom_koushikdutta_async_http_callback_HttpConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/String;Lcom/koushikdutta/async/http/callback/HttpConnectCallback;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_;
#pragma warning disable 0169
		static Delegate GetInsertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_Handler ()
		{
			if (cb_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_ == null)
				cb_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InsertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_);
			return cb_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_;
		}

		static void n_InsertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware p0 = (global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InsertMiddleware (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='insertMiddleware' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware']]"
		[Register ("insertMiddleware", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware;)V", "GetInsertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_Handler")]
		public virtual unsafe void InsertMiddleware (global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware p0)
		{
			if (id_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_ == IntPtr.Zero)
				id_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_ = JNIEnv.GetMethodID (class_ref, "insertMiddleware", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insertMiddleware_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertMiddleware", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_;
#pragma warning disable 0169
		static Delegate GetWebsocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_Handler ()
		{
			if (cb_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ == null)
				cb_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_);
			return cb_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_;
		}

		static IntPtr n_Websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback p2 = (global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Websocket (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='websocket' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpRequest'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.http.AsyncHttpClient.WebSocketConnectCallback']]"
		[Register ("websocket", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Ljava/lang/String;Lcom/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback;)Lcom/koushikdutta/async/future/Future;", "GetWebsocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture Websocket (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0, string p1, global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback p2)
		{
			if (id_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ == IntPtr.Zero)
				id_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ = JNIEnv.GetMethodID (class_ref, "websocket", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Ljava/lang/String;Lcom/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_websocket_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "websocket", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Ljava/lang/String;Lcom/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_;
#pragma warning disable 0169
		static Delegate GetWebsocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_Handler ()
		{
			if (cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ == null)
				cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_);
			return cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_;
		}

		static IntPtr n_Websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback p2 = (global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Websocket (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClient']/method[@name='websocket' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.http.AsyncHttpClient.WebSocketConnectCallback']]"
		[Register ("websocket", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback;)Lcom/koushikdutta/async/future/Future;", "GetWebsocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture Websocket (string p0, string p1, global::Com.Koushikdutta.Async.Http.AsyncHttpClient.IWebSocketConnectCallback p2)
		{
			if (id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ == IntPtr.Zero)
				id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_ = JNIEnv.GetMethodID (class_ref, "websocket", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_AsyncHttpClient_WebSocketConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "websocket", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/AsyncHttpClient$WebSocketConnectCallback;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
