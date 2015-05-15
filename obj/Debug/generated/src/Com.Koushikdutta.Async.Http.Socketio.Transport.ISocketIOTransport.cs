using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio.Transport {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport.StringCallback']"
	[Register ("com/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback", "", "Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallbackInvoker")]
	public partial interface ISocketIOTransportStringCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport.StringCallback']/method[@name='onStringAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStringAvailable", "(Ljava/lang/String;)V", "GetOnStringAvailable_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallbackInvoker, AndroidAsyncBinding")]
		void OnStringAvailable (string p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback", DoNotGenerateAcw=true)]
	internal class ISocketIOTransportStringCallbackInvoker : global::Java.Lang.Object, ISocketIOTransportStringCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback");
		IntPtr class_ref;

		public static ISocketIOTransportStringCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketIOTransportStringCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.transport.SocketIOTransport.StringCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketIOTransportStringCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISocketIOTransportStringCallbackInvoker); }
		}

		static Delegate cb_onStringAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStringAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_onStringAvailable_Ljava_lang_String_ == null)
				cb_onStringAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStringAvailable_Ljava_lang_String_);
			return cb_onStringAvailable_Ljava_lang_String_;
		}

		static void n_OnStringAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStringAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStringAvailable_Ljava_lang_String_;
		public unsafe void OnStringAvailable (string p0)
		{
			if (id_onStringAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_onStringAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStringAvailable", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onStringAvailable_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']"
	[Register ("com/koushikdutta/async/http/socketio/transport/SocketIOTransport", "", "Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker")]
	public partial interface ISocketIOTransport : IJavaObject {

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetServerHandler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")] get;
		}

		string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='heartbeats' and count(parameter)=0]"
		[Register ("heartbeats", "()Z", "GetHeartbeatsHandler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")]
		bool Heartbeats ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")]
		void Send (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")]
		void SetClosedCallback (global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio.transport']/interface[@name='SocketIOTransport']/method[@name='setStringCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.transport.SocketIOTransport.StringCallback']]"
		[Register ("setStringCallback", "(Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback;)V", "GetSetStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_Handler:Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportInvoker, AndroidAsyncBinding")]
		void SetStringCallback (global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/transport/SocketIOTransport", DoNotGenerateAcw=true)]
	internal class ISocketIOTransportInvoker : global::Java.Lang.Object, ISocketIOTransport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/transport/SocketIOTransport");
		IntPtr class_ref;

		public static ISocketIOTransport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketIOTransport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.transport.SocketIOTransport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketIOTransportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISocketIOTransportInvoker); }
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public unsafe bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isConnected);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		IntPtr id_getServer;
		public unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/koushikdutta/async/AsyncServer;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallObjectMethod (Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		IntPtr id_getSessionId;
		public unsafe string SessionId {
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (Handle, id_disconnect);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Heartbeats ();
		}
#pragma warning restore 0169

		IntPtr id_heartbeats;
		public unsafe bool Heartbeats ()
		{
			if (id_heartbeats == IntPtr.Zero)
				id_heartbeats = JNIEnv.GetMethodID (class_ref, "heartbeats", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_heartbeats);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_;
		public unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_send_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClosedCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe void SetClosedCallback (global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0)
		{
			if (id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
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
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStringCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_;
		public unsafe void SetStringCallback (global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransportStringCallback p0)
		{
			if (id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ == IntPtr.Zero)
				id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_ = JNIEnv.GetMethodID (class_ref, "setStringCallback", "(Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport$StringCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setStringCallback_Lcom_koushikdutta_async_http_socketio_transport_SocketIOTransport_StringCallback_, __args);
		}

	}

}
