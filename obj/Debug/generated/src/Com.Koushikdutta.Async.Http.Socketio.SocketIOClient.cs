using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/SocketIOClient", DoNotGenerateAcw=true)]
	public partial class SocketIOClient : global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/SocketIOClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketIOClient); }
		}

		protected SocketIOClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDisconnectCallback;
#pragma warning disable 0169
		static Delegate GetGetDisconnectCallbackHandler ()
		{
			if (cb_getDisconnectCallback == null)
				cb_getDisconnectCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisconnectCallback);
			return cb_getDisconnectCallback;
		}

		static IntPtr n_GetDisconnectCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisconnectCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_;
#pragma warning disable 0169
		static Delegate GetSetDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_Handler ()
		{
			if (cb_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_ == null)
				cb_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_);
			return cb_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_;
		}

		static void n_SetDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IDisconnectCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.IDisconnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IDisconnectCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisconnectCallback;
		static IntPtr id_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.IDisconnectCallback DisconnectCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getDisconnectCallback' and count(parameter)=0]"
			[Register ("getDisconnectCallback", "()Lcom/koushikdutta/async/http/socketio/DisconnectCallback;", "GetGetDisconnectCallbackHandler")]
			get {
				if (id_getDisconnectCallback == IntPtr.Zero)
					id_getDisconnectCallback = JNIEnv.GetMethodID (class_ref, "getDisconnectCallback", "()Lcom/koushikdutta/async/http/socketio/DisconnectCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IDisconnectCallback> (JNIEnv.CallObjectMethod  (Handle, id_getDisconnectCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IDisconnectCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisconnectCallback", "()Lcom/koushikdutta/async/http/socketio/DisconnectCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='setDisconnectCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.DisconnectCallback']]"
			[Register ("setDisconnectCallback", "(Lcom/koushikdutta/async/http/socketio/DisconnectCallback;)V", "GetSetDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_Handler")]
			set {
				if (id_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_ == IntPtr.Zero)
					id_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_ = JNIEnv.GetMethodID (class_ref, "setDisconnectCallback", "(Lcom/koushikdutta/async/http/socketio/DisconnectCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDisconnectCallback_Lcom_koushikdutta_async_http_socketio_DisconnectCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisconnectCallback", "(Lcom/koushikdutta/async/http/socketio/DisconnectCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_;
#pragma warning disable 0169
		static Delegate GetSetErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_Handler ()
		{
			if (cb_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_ == null)
				cb_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_);
			return cb_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_;
		}

		static void n_SetErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IErrorCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.IErrorCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IErrorCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCallback;
		static IntPtr id_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.IErrorCallback ErrorCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getErrorCallback' and count(parameter)=0]"
			[Register ("getErrorCallback", "()Lcom/koushikdutta/async/http/socketio/ErrorCallback;", "GetGetErrorCallbackHandler")]
			get {
				if (id_getErrorCallback == IntPtr.Zero)
					id_getErrorCallback = JNIEnv.GetMethodID (class_ref, "getErrorCallback", "()Lcom/koushikdutta/async/http/socketio/ErrorCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IErrorCallback> (JNIEnv.CallObjectMethod  (Handle, id_getErrorCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IErrorCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCallback", "()Lcom/koushikdutta/async/http/socketio/ErrorCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='setErrorCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.ErrorCallback']]"
			[Register ("setErrorCallback", "(Lcom/koushikdutta/async/http/socketio/ErrorCallback;)V", "GetSetErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_Handler")]
			set {
				if (id_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_ == IntPtr.Zero)
					id_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_ = JNIEnv.GetMethodID (class_ref, "setErrorCallback", "(Lcom/koushikdutta/async/http/socketio/ErrorCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setErrorCallback_Lcom_koushikdutta_async_http_socketio_ErrorCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorCallback", "(Lcom/koushikdutta/async/http/socketio/ErrorCallback;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExceptionCallback;
#pragma warning disable 0169
		static Delegate GetGetExceptionCallbackHandler ()
		{
			if (cb_getExceptionCallback == null)
				cb_getExceptionCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExceptionCallback);
			return cb_getExceptionCallback;
		}

		static IntPtr n_GetExceptionCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExceptionCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_;
#pragma warning disable 0169
		static Delegate GetSetExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_Handler ()
		{
			if (cb_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_ == null)
				cb_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_);
			return cb_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_;
		}

		static void n_SetExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExceptionCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExceptionCallback;
		static IntPtr id_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback ExceptionCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getExceptionCallback' and count(parameter)=0]"
			[Register ("getExceptionCallback", "()Lcom/koushikdutta/async/http/socketio/ExceptionCallback;", "GetGetExceptionCallbackHandler")]
			get {
				if (id_getExceptionCallback == IntPtr.Zero)
					id_getExceptionCallback = JNIEnv.GetMethodID (class_ref, "getExceptionCallback", "()Lcom/koushikdutta/async/http/socketio/ExceptionCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback> (JNIEnv.CallObjectMethod  (Handle, id_getExceptionCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExceptionCallback", "()Lcom/koushikdutta/async/http/socketio/ExceptionCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='setExceptionCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.ExceptionCallback']]"
			[Register ("setExceptionCallback", "(Lcom/koushikdutta/async/http/socketio/ExceptionCallback;)V", "GetSetExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_Handler")]
			set {
				if (id_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_ == IntPtr.Zero)
					id_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_ = JNIEnv.GetMethodID (class_ref, "setExceptionCallback", "(Lcom/koushikdutta/async/http/socketio/ExceptionCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExceptionCallback_Lcom_koushikdutta_async_http_socketio_ExceptionCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExceptionCallback", "(Lcom/koushikdutta/async/http/socketio/ExceptionCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='isConnected' and count(parameter)=0]"
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

		static Delegate cb_getJSONCallback;
#pragma warning disable 0169
		static Delegate GetGetJSONCallbackHandler ()
		{
			if (cb_getJSONCallback == null)
				cb_getJSONCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSONCallback);
			return cb_getJSONCallback;
		}

		static IntPtr n_GetJSONCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSONCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_;
#pragma warning disable 0169
		static Delegate GetSetJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_Handler ()
		{
			if (cb_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_ == null)
				cb_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_);
			return cb_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_;
		}

		static void n_SetJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.JSONCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getJSONCallback;
		static IntPtr id_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback JSONCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getJSONCallback' and count(parameter)=0]"
			[Register ("getJSONCallback", "()Lcom/koushikdutta/async/http/socketio/JSONCallback;", "GetGetJSONCallbackHandler")]
			get {
				if (id_getJSONCallback == IntPtr.Zero)
					id_getJSONCallback = JNIEnv.GetMethodID (class_ref, "getJSONCallback", "()Lcom/koushikdutta/async/http/socketio/JSONCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback> (JNIEnv.CallObjectMethod  (Handle, id_getJSONCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSONCallback", "()Lcom/koushikdutta/async/http/socketio/JSONCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='setJSONCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.JSONCallback']]"
			[Register ("setJSONCallback", "(Lcom/koushikdutta/async/http/socketio/JSONCallback;)V", "GetSetJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_Handler")]
			set {
				if (id_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_ == IntPtr.Zero)
					id_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_ = JNIEnv.GetMethodID (class_ref, "setJSONCallback", "(Lcom/koushikdutta/async/http/socketio/JSONCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setJSONCallback_Lcom_koushikdutta_async_http_socketio_JSONCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJSONCallback", "(Lcom/koushikdutta/async/http/socketio/JSONCallback;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReconnectCallback;
#pragma warning disable 0169
		static Delegate GetGetReconnectCallbackHandler ()
		{
			if (cb_getReconnectCallback == null)
				cb_getReconnectCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReconnectCallback);
			return cb_getReconnectCallback;
		}

		static IntPtr n_GetReconnectCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReconnectCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_;
#pragma warning disable 0169
		static Delegate GetSetReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_Handler ()
		{
			if (cb_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_ == null)
				cb_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_);
			return cb_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_;
		}

		static void n_SetReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReconnectCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReconnectCallback;
		static IntPtr id_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback ReconnectCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getReconnectCallback' and count(parameter)=0]"
			[Register ("getReconnectCallback", "()Lcom/koushikdutta/async/http/socketio/ReconnectCallback;", "GetGetReconnectCallbackHandler")]
			get {
				if (id_getReconnectCallback == IntPtr.Zero)
					id_getReconnectCallback = JNIEnv.GetMethodID (class_ref, "getReconnectCallback", "()Lcom/koushikdutta/async/http/socketio/ReconnectCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback> (JNIEnv.CallObjectMethod  (Handle, id_getReconnectCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReconnectCallback", "()Lcom/koushikdutta/async/http/socketio/ReconnectCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='setReconnectCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.ReconnectCallback']]"
			[Register ("setReconnectCallback", "(Lcom/koushikdutta/async/http/socketio/ReconnectCallback;)V", "GetSetReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_Handler")]
			set {
				if (id_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_ == IntPtr.Zero)
					id_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_ = JNIEnv.GetMethodID (class_ref, "setReconnectCallback", "(Lcom/koushikdutta/async/http/socketio/ReconnectCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReconnectCallback_Lcom_koushikdutta_async_http_socketio_ReconnectCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReconnectCallback", "(Lcom/koushikdutta/async/http/socketio/ReconnectCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StringCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_;
#pragma warning disable 0169
		static Delegate GetSetStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_Handler ()
		{
			if (cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_ == null)
				cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_);
			return cb_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_;
		}

		static void n_SetStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback p0 = (global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StringCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStringCallback;
		static IntPtr id_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback StringCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getStringCallback' and count(parameter)=0]"
			[Register ("getStringCallback", "()Lcom/koushikdutta/async/http/socketio/StringCallback;", "GetGetStringCallbackHandler")]
			get {
				if (id_getStringCallback == IntPtr.Zero)
					id_getStringCallback = JNIEnv.GetMethodID (class_ref, "getStringCallback", "()Lcom/koushikdutta/async/http/socketio/StringCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback> (JNIEnv.CallObjectMethod  (Handle, id_getStringCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringCallback", "()Lcom/koushikdutta/async/http/socketio/StringCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='setStringCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.socketio.StringCallback']]"
			[Register ("setStringCallback", "(Lcom/koushikdutta/async/http/socketio/StringCallback;)V", "GetSetStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_Handler")]
			set {
				if (id_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_ == IntPtr.Zero)
					id_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_ = JNIEnv.GetMethodID (class_ref, "setStringCallback", "(Lcom/koushikdutta/async/http/socketio/StringCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStringCallback_Lcom_koushikdutta_async_http_socketio_StringCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStringCallback", "(Lcom/koushikdutta/async/http/socketio/StringCallback;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransport;
#pragma warning disable 0169
		static Delegate GetGetTransportHandler ()
		{
			if (cb_getTransport == null)
				cb_getTransport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransport);
			return cb_getTransport;
		}

		static IntPtr n_GetTransport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transport);
		}
#pragma warning restore 0169

		static IntPtr id_getTransport;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport Transport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='getTransport' and count(parameter)=0]"
			[Register ("getTransport", "()Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport;", "GetGetTransportHandler")]
			get {
				if (id_getTransport == IntPtr.Zero)
					id_getTransport = JNIEnv.GetMethodID (class_ref, "getTransport", "()Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (JNIEnv.CallObjectMethod  (Handle, id_getTransport), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.Transport.ISocketIOTransport> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransport", "()Lcom/koushikdutta/async/http/socketio/transport/SocketIOTransport;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Lcom_koushikdutta_async_http_socketio_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient'] and parameter[2][@type='com.koushikdutta.async.http.socketio.SocketIORequest'] and parameter[3][@type='com.koushikdutta.async.http.socketio.ConnectCallback']]"
		[Register ("connect", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Lcom/koushikdutta/async/http/socketio/SocketIORequest;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)Lcom/koushikdutta/async/future/Future;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.IFuture Connect (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0, global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest p1, global::Com.Koushikdutta.Async.Http.Socketio.IConnectCallback p2)
		{
			if (id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ == IntPtr.Zero)
				id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ = JNIEnv.GetStaticMethodID (class_ref, "connect", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Lcom/koushikdutta/async/http/socketio/SocketIORequest;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)Lcom/koushikdutta/async/future/Future;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Lcom_koushikdutta_async_http_socketio_ConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.http.socketio.ConnectCallback']]"
		[Register ("connect", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)Lcom/koushikdutta/async/future/Future;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.IFuture Connect (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0, string p1, global::Com.Koushikdutta.Async.Http.Socketio.IConnectCallback p2)
		{
			if (id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ == IntPtr.Zero)
				id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ = JNIEnv.GetStaticMethodID (class_ref, "connect", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_connect_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='disconnect' and count(parameter)=0]"
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

		static Delegate cb_emit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEmit_Ljava_lang_String_Handler ()
		{
			if (cb_emit_Ljava_lang_String_ == null)
				cb_emit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Emit_Ljava_lang_String_);
			return cb_emit_Ljava_lang_String_;
		}

		static void n_Emit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Emit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("emit", "(Ljava/lang/String;)V", "GetEmit_Ljava_lang_String_Handler")]
		public virtual unsafe void Emit (string p0)
		{
			if (id_emit_Ljava_lang_String_ == IntPtr.Zero)
				id_emit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "emit", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emit_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetEmit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_Emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Emit (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("emit", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetEmit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler")]
		public virtual unsafe void Emit (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
		{
			if (id_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "emit", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emit_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_emit_Ljava_lang_String_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetEmit_Ljava_lang_String_Lorg_json_JSONArray_Handler ()
		{
			if (cb_emit_Ljava_lang_String_Lorg_json_JSONArray_ == null)
				cb_emit_Ljava_lang_String_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Emit_Ljava_lang_String_Lorg_json_JSONArray_);
			return cb_emit_Ljava_lang_String_Lorg_json_JSONArray_;
		}

		static void n_Emit_Ljava_lang_String_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Emit (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Ljava_lang_String_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray']]"
		[Register ("emit", "(Ljava/lang/String;Lorg/json/JSONArray;)V", "GetEmit_Ljava_lang_String_Lorg_json_JSONArray_Handler")]
		public virtual unsafe void Emit (string p0, global::Org.Json.JSONArray p1)
		{
			if (id_emit_Ljava_lang_String_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_emit_Ljava_lang_String_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "emit", "(Ljava/lang/String;Lorg/json/JSONArray;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emit_Ljava_lang_String_Lorg_json_JSONArray_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Ljava/lang/String;Lorg/json/JSONArray;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetEmit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_Emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p2 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Emit (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emit' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("emit", "(Ljava/lang/String;Lorg/json/JSONArray;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetEmit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler")]
		public virtual unsafe void Emit (string p0, global::Org.Json.JSONArray p1, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p2)
		{
			if (id_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "emit", "(Ljava/lang/String;Lorg/json/JSONArray;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emit_Ljava_lang_String_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Ljava/lang/String;Lorg/json/JSONArray;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_emit_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetEmit_Lorg_json_JSONObject_Handler ()
		{
			if (cb_emit_Lorg_json_JSONObject_ == null)
				cb_emit_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Emit_Lorg_json_JSONObject_);
			return cb_emit_Lorg_json_JSONObject_;
		}

		static void n_Emit_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Emit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emit' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("emit", "(Lorg/json/JSONObject;)V", "GetEmit_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Emit (global::Org.Json.JSONObject p0)
		{
			if (id_emit_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_emit_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "emit", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emit_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetEmit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_Emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Emit (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emit' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("emit", "(Lorg/json/JSONObject;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetEmit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler")]
		public virtual unsafe void Emit (global::Org.Json.JSONObject p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
		{
			if (id_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "emit", "(Lorg/json/JSONObject;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emit_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Lorg/json/JSONObject;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_emitEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEmitEvent_Ljava_lang_String_Handler ()
		{
			if (cb_emitEvent_Ljava_lang_String_ == null)
				cb_emitEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EmitEvent_Ljava_lang_String_);
			return cb_emitEvent_Ljava_lang_String_;
		}

		static void n_EmitEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmitEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_emitEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emitEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("emitEvent", "(Ljava/lang/String;)V", "GetEmitEvent_Ljava_lang_String_Handler")]
		public virtual unsafe void EmitEvent (string p0)
		{
			if (id_emitEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_emitEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "emitEvent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emitEvent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emitEvent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetEmitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EmitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_EmitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EmitEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='emitEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("emitEvent", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetEmitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler")]
		public virtual unsafe void EmitEvent (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
		{
			if (id_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "emitEvent", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_emitEvent_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emitEvent", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetOf_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_Handler ()
		{
			if (cb_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ == null)
				cb_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_);
			return cb_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_;
		}

		static void n_Of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IConnectCallback p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IConnectCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Of (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.ConnectCallback']]"
		[Register ("of", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)V", "GetOf_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_Handler")]
		public virtual unsafe void Of (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IConnectCallback p1)
		{
			if (id_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ == IntPtr.Zero)
				id_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "of", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_of_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_ConnectCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "of", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/ConnectCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reconnect;
#pragma warning disable 0169
		static Delegate GetReconnectHandler ()
		{
			if (cb_reconnect == null)
				cb_reconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reconnect);
			return cb_reconnect;
		}

		static void n_Reconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIOClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_reconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIOClient']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public virtual unsafe void Reconnect ()
		{
			if (id_reconnect == IntPtr.Zero)
				id_reconnect = JNIEnv.GetMethodID (class_ref, "reconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reconnect", "()V"));
			} finally {
			}
		}

	}
}
