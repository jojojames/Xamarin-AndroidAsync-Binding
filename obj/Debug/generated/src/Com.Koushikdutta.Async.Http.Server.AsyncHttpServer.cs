using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncHttpServer", DoNotGenerateAcw=true)]
	public partial class AsyncHttpServer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer.Pair']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncHttpServer$Pair", DoNotGenerateAcw=true)]
		public partial class Pair : global::Java.Lang.Object {

			protected Pair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServer.WebSocketRequestCallback']"
		[Register ("com/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback", "", "Com.Koushikdutta.Async.Http.Server.AsyncHttpServer/IWebSocketRequestCallbackInvoker")]
		public partial interface IWebSocketRequestCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServer.WebSocketRequestCallback']/method[@name='onConnected' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.WebSocket'] and parameter[2][@type='com.koushikdutta.async.http.server.AsyncHttpServerRequest']]"
			[Register ("onConnected", "(Lcom/koushikdutta/async/http/WebSocket;Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;)V", "GetOnConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Handler:Com.Koushikdutta.Async.Http.Server.AsyncHttpServer/IWebSocketRequestCallbackInvoker, AndroidAsyncBinding")]
			void OnConnected (global::Com.Koushikdutta.Async.Http.IWebSocket p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p1);

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback", DoNotGenerateAcw=true)]
		internal class IWebSocketRequestCallbackInvoker : global::Java.Lang.Object, IWebSocketRequestCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback");
			IntPtr class_ref;

			public static IWebSocketRequestCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IWebSocketRequestCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.server.AsyncHttpServer.WebSocketRequestCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IWebSocketRequestCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IWebSocketRequestCallbackInvoker); }
			}

			static Delegate cb_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_;
#pragma warning disable 0169
			static Delegate GetOnConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Handler ()
			{
				if (cb_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_ == null)
					cb_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_);
				return cb_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_;
			}

			static void n_OnConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Http.IWebSocket p0 = (global::Com.Koushikdutta.Async.Http.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p1 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnConnected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_;
			public unsafe void OnConnected (global::Com.Koushikdutta.Async.Http.IWebSocket p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p1)
			{
				if (id_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_ == IntPtr.Zero)
					id_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Lcom/koushikdutta/async/http/WebSocket;Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onConnected_Lcom_koushikdutta_async_http_WebSocket_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/server/AsyncHttpServer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpServer); }
		}

		protected AsyncHttpServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/constructor[@name='AsyncHttpServer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpServer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpServer)) {
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

		static Delegate cb_getErrorCallback;
#pragma warning disable 0169
		static Delegate GetGetErrorCallbackHandler ()
		{
			if (cb_getErrorCallback == null)
				cb_getErrorCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorCallback);
			return cb_getErrorCallback;
		}

		static IntPtr n_GetErrorCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSetErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_SetErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCallback;
		static IntPtr id_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ErrorCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='getErrorCallback' and count(parameter)=0]"
			[Register ("getErrorCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;", "GetGetErrorCallbackHandler")]
			get {
				if (id_getErrorCallback == IntPtr.Zero)
					id_getErrorCallback = JNIEnv.GetMethodID (class_ref, "getErrorCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod  (Handle, id_getErrorCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
			[Register ("setErrorCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
			set {
				if (id_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setErrorCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setErrorCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getListenCallback;
#pragma warning disable 0169
		static Delegate GetGetListenCallbackHandler ()
		{
			if (cb_getListenCallback == null)
				cb_getListenCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListenCallback);
			return cb_getListenCallback;
		}

		static IntPtr n_GetListenCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListenCallback);
		}
#pragma warning restore 0169

		static IntPtr id_getListenCallback;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IListenCallback ListenCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='getListenCallback' and count(parameter)=0]"
			[Register ("getListenCallback", "()Lcom/koushikdutta/async/callback/ListenCallback;", "GetGetListenCallbackHandler")]
			get {
				if (id_getListenCallback == IntPtr.Zero)
					id_getListenCallback = JNIEnv.GetMethodID (class_ref, "getListenCallback", "()Lcom/koushikdutta/async/callback/ListenCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IListenCallback> (JNIEnv.CallObjectMethod  (Handle, id_getListenCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IListenCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListenCallback", "()Lcom/koushikdutta/async/callback/ListenCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
#pragma warning disable 0169
		static Delegate GetAddAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Handler ()
		{
			if (cb_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ == null)
				cb_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_);
			return cb_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
		}

		static void n_AddAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p2 = (global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddAction (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='addAction' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.http.server.HttpServerRequestCallback']]"
		[Register ("addAction", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V", "GetAddAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Handler")]
		public virtual unsafe void AddAction (string p0, string p1, global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p2)
		{
			if (id_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ == IntPtr.Zero)
				id_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ = JNIEnv.GetMethodID (class_ref, "addAction", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addAction_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAction", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDirectory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Directory (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='directory' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("directory", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetDirectory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Directory (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "directory", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_directory_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "directory", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_directory_Ljava_lang_String_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDirectory_Ljava_lang_String_Ljava_io_File_Handler ()
		{
			if (cb_directory_Ljava_lang_String_Ljava_io_File_ == null)
				cb_directory_Ljava_lang_String_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Directory_Ljava_lang_String_Ljava_io_File_);
			return cb_directory_Ljava_lang_String_Ljava_io_File_;
		}

		static void n_Directory_Ljava_lang_String_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Directory (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_directory_Ljava_lang_String_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='directory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("directory", "(Ljava/lang/String;Ljava/io/File;)V", "GetDirectory_Ljava_lang_String_Ljava_io_File_Handler")]
		public virtual unsafe void Directory (string p0, global::Java.IO.File p1)
		{
			if (id_directory_Ljava_lang_String_Ljava_io_File_ == IntPtr.Zero)
				id_directory_Ljava_lang_String_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "directory", "(Ljava/lang/String;Ljava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_directory_Ljava_lang_String_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "directory", "(Ljava/lang/String;Ljava/io/File;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_directory_Ljava_lang_String_Ljava_io_File_Z;
#pragma warning disable 0169
		static Delegate GetDirectory_Ljava_lang_String_Ljava_io_File_ZHandler ()
		{
			if (cb_directory_Ljava_lang_String_Ljava_io_File_Z == null)
				cb_directory_Ljava_lang_String_Ljava_io_File_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Directory_Ljava_lang_String_Ljava_io_File_Z);
			return cb_directory_Ljava_lang_String_Ljava_io_File_Z;
		}

		static void n_Directory_Ljava_lang_String_Ljava_io_File_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Directory (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_directory_Ljava_lang_String_Ljava_io_File_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='directory' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File'] and parameter[3][@type='boolean']]"
		[Register ("directory", "(Ljava/lang/String;Ljava/io/File;Z)V", "GetDirectory_Ljava_lang_String_Ljava_io_File_ZHandler")]
		public virtual unsafe void Directory (string p0, global::Java.IO.File p1, bool p2)
		{
			if (id_directory_Ljava_lang_String_Ljava_io_File_Z == IntPtr.Zero)
				id_directory_Ljava_lang_String_Ljava_io_File_Z = JNIEnv.GetMethodID (class_ref, "directory", "(Ljava/lang/String;Ljava/io/File;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_directory_Ljava_lang_String_Ljava_io_File_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "directory", "(Ljava/lang/String;Ljava/io/File;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ == null)
				cb_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_);
			return cb_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
		}

		static void n_Get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p1 = (global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.server.HttpServerRequestCallback']]"
		[Register ("get", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V", "GetGet_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Handler")]
		public virtual unsafe void Get (string p0, global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p1)
		{
			if (id_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_get_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAssetStream_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='getAssetStream' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAssetStream", "(Landroid/content/Context;Ljava/lang/String;)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair GetAssetStream (global::Android.Content.Context p0, string p1)
		{
			if (id_getAssetStream_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getAssetStream_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAssetStream", "(Landroid/content/Context;Ljava/lang/String;)Landroid/util/Pair;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Util.Pair __ret = global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAssetStream_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getContentType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='getContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContentType", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetContentType (string p0)
		{
			if (id_getContentType_Ljava_lang_String_ == IntPtr.Zero)
				id_getContentType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getContentType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContentType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getResponseCodeDescription_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='getResponseCodeDescription' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getResponseCodeDescription", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetResponseCodeDescription (int p0)
		{
			if (id_getResponseCodeDescription_I == IntPtr.Zero)
				id_getResponseCodeDescription_I = JNIEnv.GetStaticMethodID (class_ref, "getResponseCodeDescription", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResponseCodeDescription_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listen_Lcom_koushikdutta_async_AsyncServer_I;
#pragma warning disable 0169
		static Delegate GetListen_Lcom_koushikdutta_async_AsyncServer_IHandler ()
		{
			if (cb_listen_Lcom_koushikdutta_async_AsyncServer_I == null)
				cb_listen_Lcom_koushikdutta_async_AsyncServer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Listen_Lcom_koushikdutta_async_AsyncServer_I);
			return cb_listen_Lcom_koushikdutta_async_AsyncServer_I;
		}

		static IntPtr n_Listen_Lcom_koushikdutta_async_AsyncServer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.AsyncServer p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listen (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listen_Lcom_koushikdutta_async_AsyncServer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='listen' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.AsyncServer'] and parameter[2][@type='int']]"
		[Register ("listen", "(Lcom/koushikdutta/async/AsyncServer;I)Lcom/koushikdutta/async/AsyncServerSocket;", "GetListen_Lcom_koushikdutta_async_AsyncServer_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.IAsyncServerSocket Listen (global::Com.Koushikdutta.Async.AsyncServer p0, int p1)
		{
			if (id_listen_Lcom_koushikdutta_async_AsyncServer_I == IntPtr.Zero)
				id_listen_Lcom_koushikdutta_async_AsyncServer_I = JNIEnv.GetMethodID (class_ref, "listen", "(Lcom/koushikdutta/async/AsyncServer;I)Lcom/koushikdutta/async/AsyncServerSocket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.IAsyncServerSocket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (JNIEnv.CallObjectMethod  (Handle, id_listen_Lcom_koushikdutta_async_AsyncServer_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listen", "(Lcom/koushikdutta/async/AsyncServer;I)Lcom/koushikdutta/async/AsyncServerSocket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_listen_I;
#pragma warning disable 0169
		static Delegate GetListen_IHandler ()
		{
			if (cb_listen_I == null)
				cb_listen_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Listen_I);
			return cb_listen_I;
		}

		static IntPtr n_Listen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listen (p0));
		}
#pragma warning restore 0169

		static IntPtr id_listen_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='listen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("listen", "(I)Lcom/koushikdutta/async/AsyncServerSocket;", "GetListen_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.IAsyncServerSocket Listen (int p0)
		{
			if (id_listen_I == IntPtr.Zero)
				id_listen_I = JNIEnv.GetMethodID (class_ref, "listen", "(I)Lcom/koushikdutta/async/AsyncServerSocket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (JNIEnv.CallObjectMethod  (Handle, id_listen_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listen", "(I)Lcom/koushikdutta/async/AsyncServerSocket;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listenSecure_ILjavax_net_ssl_SSLContext_;
#pragma warning disable 0169
		static Delegate GetListenSecure_ILjavax_net_ssl_SSLContext_Handler ()
		{
			if (cb_listenSecure_ILjavax_net_ssl_SSLContext_ == null)
				cb_listenSecure_ILjavax_net_ssl_SSLContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ListenSecure_ILjavax_net_ssl_SSLContext_);
			return cb_listenSecure_ILjavax_net_ssl_SSLContext_;
		}

		static void n_ListenSecure_ILjavax_net_ssl_SSLContext_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.SSLContext p1 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ListenSecure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_listenSecure_ILjavax_net_ssl_SSLContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='listenSecure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='javax.net.ssl.SSLContext']]"
		[Register ("listenSecure", "(ILjavax/net/ssl/SSLContext;)V", "GetListenSecure_ILjavax_net_ssl_SSLContext_Handler")]
		public virtual unsafe void ListenSecure (int p0, global::Javax.Net.Ssl.SSLContext p1)
		{
			if (id_listenSecure_ILjavax_net_ssl_SSLContext_ == IntPtr.Zero)
				id_listenSecure_ILjavax_net_ssl_SSLContext_ = JNIEnv.GetMethodID (class_ref, "listenSecure", "(ILjavax/net/ssl/SSLContext;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_listenSecure_ILjavax_net_ssl_SSLContext_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listenSecure", "(ILjavax/net/ssl/SSLContext;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
#pragma warning disable 0169
		static Delegate GetOnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_Handler ()
		{
			if (cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == null)
				cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_);
			return cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		}

		static bool n_OnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p0 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p1 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnRequest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='onRequest' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.server.AsyncHttpServerRequest'] and parameter[2][@type='com.koushikdutta.async.http.server.AsyncHttpServerResponse']]"
		[Register ("onRequest", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)Z", "GetOnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_Handler")]
		protected virtual unsafe bool OnRequest (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p1)
		{
			if (id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == IntPtr.Zero)
				id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequest", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
#pragma warning disable 0169
		static Delegate GetOnRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_Handler ()
		{
			if (cb_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == null)
				cb_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_);
			return cb_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		}

		static void n_OnRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p0 = (global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p1 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p2 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnRequest (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='onRequest' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.server.HttpServerRequestCallback'] and parameter[2][@type='com.koushikdutta.async.http.server.AsyncHttpServerRequest'] and parameter[3][@type='com.koushikdutta.async.http.server.AsyncHttpServerResponse']]"
		[Register ("onRequest", "(Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V", "GetOnRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_Handler")]
		protected virtual unsafe void OnRequest (global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p1, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p2)
		{
			if (id_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == IntPtr.Zero)
				id_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRequest_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequest", "(Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUnknownBody_Lcom_koushikdutta_async_http_Headers_;
#pragma warning disable 0169
		static Delegate GetOnUnknownBody_Lcom_koushikdutta_async_http_Headers_Handler ()
		{
			if (cb_onUnknownBody_Lcom_koushikdutta_async_http_Headers_ == null)
				cb_onUnknownBody_Lcom_koushikdutta_async_http_Headers_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUnknownBody_Lcom_koushikdutta_async_http_Headers_);
			return cb_onUnknownBody_Lcom_koushikdutta_async_http_Headers_;
		}

		static IntPtr n_OnUnknownBody_Lcom_koushikdutta_async_http_Headers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Headers p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnUnknownBody (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onUnknownBody_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='onUnknownBody' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("onUnknownBody", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;", "GetOnUnknownBody_Lcom_koushikdutta_async_http_Headers_Handler")]
		protected virtual unsafe global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody OnUnknownBody (global::Com.Koushikdutta.Async.Http.Headers p0)
		{
			if (id_onUnknownBody_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_onUnknownBody_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetMethodID (class_ref, "onUnknownBody", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (JNIEnv.CallObjectMethod  (Handle, id_onUnknownBody_Lcom_koushikdutta_async_http_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnknownBody", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Handler ()
		{
			if (cb_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ == null)
				cb_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_);
			return cb_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
		}

		static void n_Post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p1 = (global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='post' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.server.HttpServerRequestCallback']]"
		[Register ("post", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V", "GetPost_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_Handler")]
		public virtual unsafe void Post (string p0, global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback p1)
		{
			if (id_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_post_Ljava_lang_String_Lcom_koushikdutta_async_http_server_HttpServerRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/HttpServerRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static IntPtr id_tryGetContentType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='tryGetContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tryGetContentType", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string TryGetContentType (string p0)
		{
			if (id_tryGetContentType_Ljava_lang_String_ == IntPtr.Zero)
				id_tryGetContentType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "tryGetContentType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_tryGetContentType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_;
#pragma warning disable 0169
		static Delegate GetWebsocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_Handler ()
		{
			if (cb_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ == null)
				cb_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_);
			return cb_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_;
		}

		static void n_Websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback p1 = (global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Websocket (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='websocket' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.server.AsyncHttpServer.WebSocketRequestCallback']]"
		[Register ("websocket", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback;)V", "GetWebsocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_Handler")]
		public virtual unsafe void Websocket (string p0, global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback p1)
		{
			if (id_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ == IntPtr.Zero)
				id_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ = JNIEnv.GetMethodID (class_ref, "websocket", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_websocket_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "websocket", "(Ljava/lang/String;Lcom/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_;
#pragma warning disable 0169
		static Delegate GetWebsocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_Handler ()
		{
			if (cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ == null)
				cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_);
			return cb_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_;
		}

		static void n_Websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback p2 = (global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Websocket (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServer']/method[@name='websocket' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.http.server.AsyncHttpServer.WebSocketRequestCallback']]"
		[Register ("websocket", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback;)V", "GetWebsocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_Handler")]
		public virtual unsafe void Websocket (string p0, string p1, global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer.IWebSocketRequestCallback p2)
		{
			if (id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ == IntPtr.Zero)
				id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_ = JNIEnv.GetMethodID (class_ref, "websocket", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_websocket_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_server_AsyncHttpServer_WebSocketRequestCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "websocket", "(Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/server/AsyncHttpServer$WebSocketRequestCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
