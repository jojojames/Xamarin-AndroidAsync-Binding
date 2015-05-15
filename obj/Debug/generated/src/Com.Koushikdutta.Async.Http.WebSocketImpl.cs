using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/WebSocketImpl", DoNotGenerateAcw=true)]
	public partial class WebSocketImpl : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.IWebSocket {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/WebSocketImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketImpl); }
		}

		protected WebSocketImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/constructor[@name='WebSocketImpl' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.server.AsyncHttpServerRequest'] and parameter[2][@type='com.koushikdutta.async.http.server.AsyncHttpServerResponse']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V", "")]
		public unsafe WebSocketImpl (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (WebSocketImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_koushikdutta_async_AsyncSocket_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/constructor[@name='WebSocketImpl' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.AsyncSocket']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/AsyncSocket;)V", "")]
		public unsafe WebSocketImpl (global::Com.Koushikdutta.Async.IAsyncSocket p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WebSocketImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/AsyncSocket;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/AsyncSocket;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_AsyncSocket_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_AsyncSocket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/AsyncSocket;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_AsyncSocket_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_AsyncSocket_, __args);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClosedCallback;
		static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getClosedCallback' and count(parameter)=0]"
			[Register ("getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;", "GetGetClosedCallbackHandler")]
			get {
				if (id_getClosedCallback == IntPtr.Zero)
					id_getClosedCallback = JNIEnv.GetMethodID (class_ref, "getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod  (Handle, id_getClosedCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
			[Register ("setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
			set {
				if (id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataCallback;
		static IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getDataCallback' and count(parameter)=0]"
			[Register ("getDataCallback", "()Lcom/koushikdutta/async/callback/DataCallback;", "GetGetDataCallbackHandler")]
			get {
				if (id_getDataCallback == IntPtr.Zero)
					id_getDataCallback = JNIEnv.GetMethodID (class_ref, "getDataCallback", "()Lcom/koushikdutta/async/callback/DataCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (JNIEnv.CallObjectMethod  (Handle, id_getDataCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataCallback", "()Lcom/koushikdutta/async/callback/DataCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='setDataCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.DataCallback']]"
			[Register ("setDataCallback", "(Lcom/koushikdutta/async/callback/DataCallback;)V", "GetSetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_Handler")]
			set {
				if (id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ == IntPtr.Zero)
					id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ = JNIEnv.GetMethodID (class_ref, "setDataCallback", "(Lcom/koushikdutta/async/callback/DataCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataCallback", "(Lcom/koushikdutta/async/callback/DataCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEndCallback;
		static IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getEndCallback' and count(parameter)=0]"
			[Register ("getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;", "GetGetEndCallbackHandler")]
			get {
				if (id_getEndCallback == IntPtr.Zero)
					id_getEndCallback = JNIEnv.GetMethodID (class_ref, "getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod  (Handle, id_getEndCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
			[Register ("setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
			set {
				if (id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
				} finally {
				}
			}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBuffering;
		}
#pragma warning restore 0169

		static IntPtr id_isBuffering;
		public virtual unsafe bool IsBuffering {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='isBuffering' and count(parameter)=0]"
			[Register ("isBuffering", "()Z", "GetIsBufferingHandler")]
			get {
				if (id_isBuffering == IntPtr.Zero)
					id_isBuffering = JNIEnv.GetMethodID (class_ref, "isBuffering", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isBuffering);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBuffering", "()Z"));
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		static IntPtr id_isChunked;
		public virtual unsafe bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='isChunked' and count(parameter)=0]"
			[Register ("isChunked", "()Z", "GetIsChunkedHandler")]
			get {
				if (id_isChunked == IntPtr.Zero)
					id_isChunked = JNIEnv.GetMethodID (class_ref, "isChunked", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isChunked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChunked", "()Z"));
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPaused", "()Z"));
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback p0 = (global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PongCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPongCallback;
		static IntPtr id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback PongCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getPongCallback' and count(parameter)=0]"
			[Register ("getPongCallback", "()Lcom/koushikdutta/async/http/WebSocket$PongCallback;", "GetGetPongCallbackHandler")]
			get {
				if (id_getPongCallback == IntPtr.Zero)
					id_getPongCallback = JNIEnv.GetMethodID (class_ref, "getPongCallback", "()Lcom/koushikdutta/async/http/WebSocket$PongCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback> (JNIEnv.CallObjectMethod  (Handle, id_getPongCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketPongCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPongCallback", "()Lcom/koushikdutta/async/http/WebSocket$PongCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='setPongCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.WebSocket.PongCallback']]"
			[Register ("setPongCallback", "(Lcom/koushikdutta/async/http/WebSocket$PongCallback;)V", "GetSetPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_Handler")]
			set {
				if (id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ == IntPtr.Zero)
					id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_ = JNIEnv.GetMethodID (class_ref, "setPongCallback", "(Lcom/koushikdutta/async/http/WebSocket$PongCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPongCallback_Lcom_koushikdutta_async_http_WebSocket_PongCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPongCallback", "(Lcom/koushikdutta/async/http/WebSocket$PongCallback;)V"), __args);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getServer' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static IntPtr id_getSocket;
		public virtual unsafe global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetGetSocketHandler")]
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Lcom/koushikdutta/async/AsyncSocket;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallObjectMethod  (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocket", "()Lcom/koushikdutta/async/AsyncSocket;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback p0 = (global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StringCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStringCallback;
		static IntPtr id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback StringCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getStringCallback' and count(parameter)=0]"
			[Register ("getStringCallback", "()Lcom/koushikdutta/async/http/WebSocket$StringCallback;", "GetGetStringCallbackHandler")]
			get {
				if (id_getStringCallback == IntPtr.Zero)
					id_getStringCallback = JNIEnv.GetMethodID (class_ref, "getStringCallback", "()Lcom/koushikdutta/async/http/WebSocket$StringCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback> (JNIEnv.CallObjectMethod  (Handle, id_getStringCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocketStringCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringCallback", "()Lcom/koushikdutta/async/http/WebSocket$StringCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='setStringCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.WebSocket.StringCallback']]"
			[Register ("setStringCallback", "(Lcom/koushikdutta/async/http/WebSocket$StringCallback;)V", "GetSetStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_Handler")]
			set {
				if (id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ == IntPtr.Zero)
					id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_ = JNIEnv.GetMethodID (class_ref, "setStringCallback", "(Lcom/koushikdutta/async/http/WebSocket$StringCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStringCallback_Lcom_koushikdutta_async_http_WebSocket_StringCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStringCallback", "(Lcom/koushikdutta/async/http/WebSocket$StringCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteableCallback;
		static IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='getWriteableCallback' and count(parameter)=0]"
			[Register ("getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;", "GetGetWriteableCallbackHandler")]
			get {
				if (id_getWriteableCallback == IntPtr.Zero)
					id_getWriteableCallback = JNIEnv.GetMethodID (class_ref, "getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (JNIEnv.CallObjectMethod  (Handle, id_getWriteableCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='setWriteableCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
			[Register ("setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V", "GetSetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_Handler")]
			set {
				if (id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ == IntPtr.Zero)
					id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ = JNIEnv.GetMethodID (class_ref, "setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_addWebSocketUpgradeHeaders_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='addWebSocketUpgradeHeaders' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpRequest'] and parameter[2][@type='java.lang.String']]"
		[Register ("addWebSocketUpgradeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Ljava/lang/String;)V", "")]
		public static unsafe void AddWebSocketUpgradeHeaders (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0, string p1)
		{
			if (id_addWebSocketUpgradeHeaders_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_ == IntPtr.Zero)
				id_addWebSocketUpgradeHeaders_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addWebSocketUpgradeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addWebSocketUpgradeHeaders_Lcom_koushikdutta_async_http_AsyncHttpRequest_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='charset' and count(parameter)=0]"
		[Register ("charset", "()Ljava/lang/String;", "GetCharsetHandler")]
		public virtual unsafe string Charset ()
		{
			if (id_charset == IntPtr.Zero)
				id_charset = JNIEnv.GetMethodID (class_ref, "charset", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_charset), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "charset", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		static IntPtr id_end;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		public virtual unsafe void End ()
		{
			if (id_end == IntPtr.Zero)
				id_end = JNIEnv.GetMethodID (class_ref, "end", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_end);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "end", "()V"));
			} finally {
			}
		}

		static IntPtr id_finishHandshake_Lcom_koushikdutta_async_http_Headers_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='finishHandshake' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.Headers'] and parameter[2][@type='com.koushikdutta.async.http.AsyncHttpResponse']]"
		[Register ("finishHandshake", "(Lcom/koushikdutta/async/http/Headers;Lcom/koushikdutta/async/http/AsyncHttpResponse;)Lcom/koushikdutta/async/http/WebSocket;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.IWebSocket FinishHandshake (global::Com.Koushikdutta.Async.Http.Headers p0, global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p1)
		{
			if (id_finishHandshake_Lcom_koushikdutta_async_http_Headers_Lcom_koushikdutta_async_http_AsyncHttpResponse_ == IntPtr.Zero)
				id_finishHandshake_Lcom_koushikdutta_async_http_Headers_Lcom_koushikdutta_async_http_AsyncHttpResponse_ = JNIEnv.GetStaticMethodID (class_ref, "finishHandshake", "(Lcom/koushikdutta/async/http/Headers;Lcom/koushikdutta/async/http/AsyncHttpResponse;)Lcom/koushikdutta/async/http/WebSocket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Koushikdutta.Async.Http.IWebSocket __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IWebSocket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_finishHandshake_Lcom_koushikdutta_async_http_Headers_Lcom_koushikdutta_async_http_AsyncHttpResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Ping (p0);
		}
#pragma warning restore 0169

		static IntPtr id_ping_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='ping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ping", "(Ljava/lang/String;)V", "GetPing_Ljava_lang_String_Handler")]
		public virtual unsafe void Ping (string p0)
		{
			if (id_ping_Ljava_lang_String_ == IntPtr.Zero)
				id_ping_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ping", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ping_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ping", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("send", "([B)V", "GetSend_arrayBHandler")]
		public virtual unsafe void Send (byte[] p0)
		{
			if (id_send_arrayB == IntPtr.Zero)
				id_send_arrayB = JNIEnv.GetMethodID (class_ref, "send", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='send' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("send", "([BII)V", "GetSend_arrayBIIHandler")]
		public virtual unsafe void Send (byte[] p0, int p1, int p2)
		{
			if (id_send_arrayBII == IntPtr.Zero)
				id_send_arrayBII = JNIEnv.GetMethodID (class_ref, "send", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_arrayBII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "([BII)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Koushikdutta.Async.Http.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='WebSocketImpl']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("write", "(Lcom/koushikdutta/async/ByteBufferList;)V", "GetWrite_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe void Write (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_write_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_ByteBufferList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V"), __args);
			} finally {
			}
		}

	}
}
