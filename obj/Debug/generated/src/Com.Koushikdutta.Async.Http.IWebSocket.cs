using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket.PongCallback']"
	[Register ("com/koushikdutta/async/http/WebSocket$PongCallback", "", "Com.Koushikdutta.Async.Http.IWebSocketPongCallbackInvoker")]
	public partial interface IWebSocketPongCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket.PongCallback']/method[@name='onPongReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onPongReceived", "(Ljava/lang/String;)V", "GetOnPongReceived_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.IWebSocketPongCallbackInvoker, AndroidAsyncBinding")]
		void OnPongReceived (string p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/WebSocket$PongCallback", DoNotGenerateAcw=true)]
	internal class IWebSocketPongCallbackInvoker : global::Java.Lang.Object, IWebSocketPongCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/WebSocket$PongCallback");
		IntPtr class_ref;

		public static IWebSocketPongCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocketPongCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.WebSocket.PongCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketPongCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWebSocketPongCallbackInvoker); }
		}

		static Delegate cb_onPongReceived_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPongReceived_Ljava_lang_String_Handler ()
		{
			if (cb_onPongReceived_Ljava_lang_String_ == null)
				cb_onPongReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPongReceived_Ljava_lang_String_);
			return cb_onPongReceived_Ljava_lang_String_;
		}

		static void n_OnPongReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPongReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPongReceived_Ljava_lang_String_;
		public unsafe void OnPongReceived (string p0)
		{
			if (id_onPongReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_onPongReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPongReceived", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onPongReceived_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket.StringCallback']"
	[Register ("com/koushikdutta/async/http/WebSocket$StringCallback", "", "Com.Koushikdutta.Async.Http.IWebSocketStringCallbackInvoker")]
	public partial interface IWebSocketStringCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket.StringCallback']/method[@name='onStringAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStringAvailable", "(Ljava/lang/String;)V", "GetOnStringAvailable_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.IWebSocketStringCallbackInvoker, AndroidAsyncBinding")]
		void OnStringAvailable (string p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/WebSocket$StringCallback", DoNotGenerateAcw=true)]
	internal class IWebSocketStringCallbackInvoker : global::Java.Lang.Object, IWebSocketStringCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/WebSocket$StringCallback");
		IntPtr class_ref;

		public static IWebSocketStringCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocketStringCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.WebSocket.StringCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketStringCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWebSocketStringCallbackInvoker); }
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
			global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']"
	[Register ("com/koushikdutta/async/http/WebSocket", "", "Com.Koushikdutta.Async.Http.IWebSocketInvoker")]
	public partial interface IWebSocket : global::Com.Koushikdutta.Async.IAsyncSocket {

		bool IsBuffering {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='isBuffering' and count(parameter)=0]"
			[Register ("isBuffering", "()Z", "GetIsBufferingHandler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback PongCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='getPongCallback' and count(parameter)=0]"
			[Register ("getPongCallback", "()Lcom/koushikdutta/async/http/WebSocket$PongCallback;", "GetGetPongCallbackHandler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='setPongCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.WebSocket.PongCallback']]"
			[Register ("setPongCallback", "(Lcom/koushikdutta/async/http/WebSocket$PongCallback;)V", "GetSetPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_Handler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")] set;
		}

		global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetGetSocketHandler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback StringCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='getStringCallback' and count(parameter)=0]"
			[Register ("getStringCallback", "()Lcom/koushikdutta/async/http/WebSocket$StringCallback;", "GetGetStringCallbackHandler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='setStringCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.WebSocket.StringCallback']]"
			[Register ("setStringCallback", "(Lcom/koushikdutta/async/http/WebSocket$StringCallback;)V", "GetSetStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_Handler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='ping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ping", "(Ljava/lang/String;)V", "GetPing_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")]
		void Ping (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("send", "([B)V", "GetSend_arrayBHandler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")]
		void Send (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("send", "([BII)V", "GetSend_arrayBIIHandler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")]
		void Send (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.IWebSocketInvoker, AndroidAsyncBinding")]
		void Send (string p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/WebSocket", DoNotGenerateAcw=true)]
	internal class IWebSocketInvoker : global::Java.Lang.Object, IWebSocket {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/WebSocket");
		IntPtr class_ref;

		public static IWebSocket GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocket> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.WebSocket"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWebSocketInvoker); }
		}

		static Delegate cb_isBuffering;
#pragma warning disable 0169
		static Delegate GetIsBufferingHandler ()
		{
			if (cb_isBuffering == null)
				cb_isBuffering = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBuffering);
			return cb_isBuffering;
		}

		static bool n_IsBuffering (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBuffering;
		}
#pragma warning restore 0169

		IntPtr id_isBuffering;
		public unsafe bool IsBuffering {
			get {
				if (id_isBuffering == IntPtr.Zero)
					id_isBuffering = JNIEnv.GetMethodID (class_ref, "isBuffering", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isBuffering);
			}
		}

		static Delegate cb_getPongCallback;
#pragma warning disable 0169
		static Delegate GetGetPongCallbackHandler ()
		{
			if (cb_getPongCallback == null)
				cb_getPongCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPongCallback);
			return cb_getPongCallback;
		}

		static IntPtr n_GetPongCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PongCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_;
#pragma warning disable 0169
		static Delegate GetSetPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_Handler ()
		{
			if (cb_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ == null)
				cb_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_);
			return cb_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_;
		}

		static void n_SetPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback p0 = (global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PongCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPongCallback;
		IntPtr id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_;
		public unsafe global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback PongCallback {
			get {
				if (id_getPongCallback == IntPtr.Zero)
					id_getPongCallback = JNIEnv.GetMethodID (class_ref, "getPongCallback", "()Lcom/koushikdutta/async/http/WebSocket$PongCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback> (JNIEnv.CallObjectMethod (Handle, id_getPongCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ == IntPtr.Zero)
					id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ = JNIEnv.GetMethodID (class_ref, "setPongCallback", "(Lcom/koushikdutta/async/http/WebSocket$PongCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_, __args);
			}
		}

		static Delegate cb_getSocket;
#pragma warning disable 0169
		static Delegate GetGetSocketHandler ()
		{
			if (cb_getSocket == null)
				cb_getSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocket);
			return cb_getSocket;
		}

		static IntPtr n_GetSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		IntPtr id_getSocket;
		public unsafe global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Lcom/koushikdutta/async/AsyncSocket;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallObjectMethod (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStringCallback;
#pragma warning disable 0169
		static Delegate GetGetStringCallbackHandler ()
		{
			if (cb_getStringCallback == null)
				cb_getStringCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStringCallback);
			return cb_getStringCallback;
		}

		static IntPtr n_GetStringCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StringCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_;
#pragma warning disable 0169
		static Delegate GetSetStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_Handler ()
		{
			if (cb_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ == null)
				cb_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_);
			return cb_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_;
		}

		static void n_SetStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback p0 = (global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StringCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getStringCallback;
		IntPtr id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_;
		public unsafe global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback StringCallback {
			get {
				if (id_getStringCallback == IntPtr.Zero)
					id_getStringCallback = JNIEnv.GetMethodID (class_ref, "getStringCallback", "()Lcom/koushikdutta/async/http/WebSocket$StringCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback> (JNIEnv.CallObjectMethod (Handle, id_getStringCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ == IntPtr.Zero)
					id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ = JNIEnv.GetMethodID (class_ref, "setStringCallback", "(Lcom/koushikdutta/async/http/WebSocket$StringCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_, __args);
			}
		}

		static Delegate cb_ping_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPing_Ljava_lang_String_Handler ()
		{
			if (cb_ping_Ljava_lang_String_ == null)
				cb_ping_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Ping_Ljava_lang_String_);
			return cb_ping_Ljava_lang_String_;
		}

		static void n_Ping_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ping (p0);
		}
#pragma warning restore 0169

		IntPtr id_ping_Ljava_lang_String_;
		public unsafe void Ping (string p0)
		{
			if (id_ping_Ljava_lang_String_ == IntPtr.Zero)
				id_ping_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ping", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_ping_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_send_arrayB;
#pragma warning disable 0169
		static Delegate GetSend_arrayBHandler ()
		{
			if (cb_send_arrayB == null)
				cb_send_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_arrayB);
			return cb_send_arrayB;
		}

		static void n_Send_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_send_arrayB;
		public unsafe void Send (byte[] p0)
		{
			if (id_send_arrayB == IntPtr.Zero)
				id_send_arrayB = JNIEnv.GetMethodID (class_ref, "send", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_send_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_send_arrayBII;
#pragma warning disable 0169
		static Delegate GetSend_arrayBIIHandler ()
		{
			if (cb_send_arrayBII == null)
				cb_send_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Send_arrayBII);
			return cb_send_arrayBII;
		}

		static void n_Send_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_send_arrayBII;
		public unsafe void Send (byte[] p0, int p1, int p2)
		{
			if (id_send_arrayBII == IntPtr.Zero)
				id_send_arrayBII = JNIEnv.GetMethodID (class_ref, "send", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_send_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getDataCallback;
#pragma warning disable 0169
		static Delegate GetGetDataCallbackHandler ()
		{
			if (cb_getDataCallback == null)
				cb_getDataCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataCallback);
			return cb_getDataCallback;
		}

		static IntPtr n_GetDataCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
#pragma warning disable 0169
		static Delegate GetSetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_Handler ()
		{
			if (cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ == null)
				cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_);
			return cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		}

		static void n_SetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDataCallback;
		IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			get {
				if (id_getDataCallback == IntPtr.Zero)
					id_getDataCallback = JNIEnv.GetMethodID (class_ref, "getDataCallback", "()Lcom/koushikdutta/async/callback/DataCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (JNIEnv.CallObjectMethod (Handle, id_getDataCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ == IntPtr.Zero)
					id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ = JNIEnv.GetMethodID (class_ref, "setDataCallback", "(Lcom/koushikdutta/async/callback/DataCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_, __args);
			}
		}

		static Delegate cb_getEndCallback;
#pragma warning disable 0169
		static Delegate GetGetEndCallbackHandler ()
		{
			if (cb_getEndCallback == null)
				cb_getEndCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndCallback);
			return cb_getEndCallback;
		}

		static IntPtr n_GetEndCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_SetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getEndCallback;
		IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			get {
				if (id_getEndCallback == IntPtr.Zero)
					id_getEndCallback = JNIEnv.GetMethodID (class_ref, "getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod (Handle, id_getEndCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			}
		}

		static Delegate cb_isChunked;
#pragma warning disable 0169
		static Delegate GetIsChunkedHandler ()
		{
			if (cb_isChunked == null)
				cb_isChunked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChunked);
			return cb_isChunked;
		}

		static bool n_IsChunked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		IntPtr id_isChunked;
		public unsafe bool IsChunked {
			get {
				if (id_isChunked == IntPtr.Zero)
					id_isChunked = JNIEnv.GetMethodID (class_ref, "isChunked", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isChunked);
			}
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		IntPtr id_isPaused;
		public unsafe bool IsPaused {
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPaused);
			}
		}

		static Delegate cb_charset;
#pragma warning disable 0169
		static Delegate GetCharsetHandler ()
		{
			if (cb_charset == null)
				cb_charset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Charset);
			return cb_charset;
		}

		static IntPtr n_Charset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		IntPtr id_charset;
		public unsafe string Charset ()
		{
			if (id_charset == IntPtr.Zero)
				id_charset = JNIEnv.GetMethodID (class_ref, "charset", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_charset), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (Handle, id_pause);
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		IntPtr id_resume;
		public unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			JNIEnv.CallVoidMethod (Handle, id_resume);
		}

		static Delegate cb_getClosedCallback;
#pragma warning disable 0169
		static Delegate GetGetClosedCallbackHandler ()
		{
			if (cb_getClosedCallback == null)
				cb_getClosedCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClosedCallback);
			return cb_getClosedCallback;
		}

		static IntPtr n_GetClosedCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClosedCallback);
		}
#pragma warning restore 0169

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
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getClosedCallback;
		IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			get {
				if (id_getClosedCallback == IntPtr.Zero)
					id_getClosedCallback = JNIEnv.GetMethodID (class_ref, "getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod (Handle, id_getClosedCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			}
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe bool IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isOpen);
			}
		}

		static Delegate cb_getWriteableCallback;
#pragma warning disable 0169
		static Delegate GetGetWriteableCallbackHandler ()
		{
			if (cb_getWriteableCallback == null)
				cb_getWriteableCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWriteableCallback);
			return cb_getWriteableCallback;
		}

		static IntPtr n_GetWriteableCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteableCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
#pragma warning disable 0169
		static Delegate GetSetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_Handler ()
		{
			if (cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ == null)
				cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_);
			return cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		}

		static void n_SetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getWriteableCallback;
		IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			get {
				if (id_getWriteableCallback == IntPtr.Zero)
					id_getWriteableCallback = JNIEnv.GetMethodID (class_ref, "getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (JNIEnv.CallObjectMethod (Handle, id_getWriteableCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ == IntPtr.Zero)
					id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ = JNIEnv.GetMethodID (class_ref, "setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_, __args);
			}
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		IntPtr id_end;
		public unsafe void End ()
		{
			if (id_end == IntPtr.Zero)
				id_end = JNIEnv.GetMethodID (class_ref, "end", "()V");
			JNIEnv.CallVoidMethod (Handle, id_end);
		}

		static Delegate cb_write_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_write_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_write_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_write_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static void n_Write_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		public unsafe void Write (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_write_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_write_Lcom_koushikdutta_async_ByteBufferList_, __args);
		}

	}

}
