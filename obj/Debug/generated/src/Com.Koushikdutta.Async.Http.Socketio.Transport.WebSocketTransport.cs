using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio.Transport {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/transport/WebSocketTransport", DoNotGenerateAcw=true)]
	public partial class WebSocketTransport : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/transport/WebSocketTransport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketTransport); }
		}

		protected WebSocketTransport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_WebSocket_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/constructor[@name='WebSocketTransport' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/WebSocket;Ljava/lang/String;)V", "")]
		public unsafe WebSocketTransport (global::Com.Koushikdutta.Async.Http.IWebSocket p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (WebSocketTransport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/WebSocket;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/WebSocket;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_WebSocket_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_WebSocket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/WebSocket;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_WebSocket_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_WebSocket_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='getServer' and count(parameter)=0]"
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

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionId;
		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_heartbeats;
#pragma warning disable 0169
		static Delegate GetHeartbeatsHandler ()
		{
			if (cb_heartbeats == null)
				cb_heartbeats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Heartbeats);
			return cb_heartbeats;
		}

		static bool n_Heartbeats (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Heartbeats ();
		}
#pragma warning restore 0169

		static IntPtr id_heartbeats;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='heartbeats' and count(parameter)=0]"
		[Register ("heartbeats", "()Z", "GetHeartbeatsHandler")]
		public virtual unsafe bool Heartbeats ()
		{
			if (id_heartbeats == IntPtr.Zero)
				id_heartbeats = JNIEnv.GetMethodID (class_ref, "heartbeats", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_heartbeats);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "heartbeats", "()Z"));
			} finally {
			}
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_SetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClosedCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
		public virtual unsafe void SetClosedCallback (global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0)
		{
			if (id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_;
#pragma warning disable 0169
		static Delegate GetSetStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_Handler ()
		{
			if (cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ == null)
				cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_);
			return cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_;
		}

		static void n_SetStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.WebSocketTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStringCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/class[@name='WebSocketTransport']/method[@name='setStringCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.transport.SocketIOTransport.StringCallback']]"
		[Register ("setStringCallback", "(Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback;)V", "GetSetStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_Handler")]
		public virtual unsafe void SetStringCallback (global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback p0)
		{
			if (id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ == IntPtr.Zero)
				id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ = JNIEnv.GetMethodID (class_ref, "setStringCallback", "(Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStringCallback", "(Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback;)V"), __args);
			} finally {
			}
		}

	}
}
