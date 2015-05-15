using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncNetworkSocket", DoNotGenerateAcw=true)]
	public partial class AsyncNetworkSocket : global::Java.Lang.Object, global::Com.Koushikdutta.Async.IAsyncSocket {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/AsyncNetworkSocket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncNetworkSocket); }
		}

		protected AsyncNetworkSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClosedCallback;
		static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getClosedCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataCallback;
		static IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getDataCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='setDataCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.DataCallback']]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEndCallback;
		static IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getEndCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		static IntPtr id_isChunked;
		public virtual unsafe bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='isChunked' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='isOpen' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='isPaused' and count(parameter)=0]"
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

		static Delegate cb_getLocalPort;
#pragma warning disable 0169
		static Delegate GetGetLocalPortHandler ()
		{
			if (cb_getLocalPort == null)
				cb_getLocalPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocalPort);
			return cb_getLocalPort;
		}

		static int n_GetLocalPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalPort;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalPort;
		public virtual unsafe int LocalPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getLocalPort' and count(parameter)=0]"
			[Register ("getLocalPort", "()I", "GetGetLocalPortHandler")]
			get {
				if (id_getLocalPort == IntPtr.Zero)
					id_getLocalPort = JNIEnv.GetMethodID (class_ref, "getLocalPort", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLocalPort);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalPort", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteAddress;
#pragma warning disable 0169
		static Delegate GetGetRemoteAddressHandler ()
		{
			if (cb_getRemoteAddress == null)
				cb_getRemoteAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoteAddress);
			return cb_getRemoteAddress;
		}

		static IntPtr n_GetRemoteAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoteAddress);
		}
#pragma warning restore 0169

		static IntPtr id_getRemoteAddress;
		public virtual unsafe global::Java.Net.InetSocketAddress RemoteAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getRemoteAddress' and count(parameter)=0]"
			[Register ("getRemoteAddress", "()Ljava/net/InetSocketAddress;", "GetGetRemoteAddressHandler")]
			get {
				if (id_getRemoteAddress == IntPtr.Zero)
					id_getRemoteAddress = JNIEnv.GetMethodID (class_ref, "getRemoteAddress", "()Ljava/net/InetSocketAddress;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallObjectMethod  (Handle, id_getRemoteAddress), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemoteAddress", "()Ljava/net/InetSocketAddress;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getServer' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static IntPtr id_getSocket;
		public virtual unsafe global::Java.Lang.Object Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Ljava/lang/Object;", "GetGetSocketHandler")]
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocket", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteableCallback;
		static IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='getWriteableCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='setWriteableCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='charset' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_closeInternal;
#pragma warning disable 0169
		static Delegate GetCloseInternalHandler ()
		{
			if (cb_closeInternal == null)
				cb_closeInternal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseInternal);
			return cb_closeInternal;
		}

		static void n_CloseInternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseInternal ();
		}
#pragma warning restore 0169

		static IntPtr id_closeInternal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='closeInternal' and count(parameter)=0]"
		[Register ("closeInternal", "()V", "GetCloseInternalHandler")]
		public virtual unsafe void CloseInternal ()
		{
			if (id_closeInternal == IntPtr.Zero)
				id_closeInternal = JNIEnv.GetMethodID (class_ref, "closeInternal", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_closeInternal);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeInternal", "()V"));
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		static IntPtr id_end;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='end' and count(parameter)=0]"
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

		static Delegate cb_onDataWritable;
#pragma warning disable 0169
		static Delegate GetOnDataWritableHandler ()
		{
			if (cb_onDataWritable == null)
				cb_onDataWritable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDataWritable);
			return cb_onDataWritable;
		}

		static void n_OnDataWritable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataWritable ();
		}
#pragma warning restore 0169

		static IntPtr id_onDataWritable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='onDataWritable' and count(parameter)=0]"
		[Register ("onDataWritable", "()V", "GetOnDataWritableHandler")]
		public virtual unsafe void OnDataWritable ()
		{
			if (id_onDataWritable == IntPtr.Zero)
				id_onDataWritable = JNIEnv.GetMethodID (class_ref, "onDataWritable", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataWritable);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataWritable", "()V"));
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='pause' and count(parameter)=0]"
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

		static Delegate cb_reportClose_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetReportClose_Ljava_lang_Exception_Handler ()
		{
			if (cb_reportClose_Ljava_lang_Exception_ == null)
				cb_reportClose_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReportClose_Ljava_lang_Exception_);
			return cb_reportClose_Ljava_lang_Exception_;
		}

		static void n_ReportClose_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportClose (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reportClose_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='reportClose' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("reportClose", "(Ljava/lang/Exception;)V", "GetReportClose_Ljava_lang_Exception_Handler")]
		protected virtual unsafe void ReportClose (global::Java.Lang.Exception p0)
		{
			if (id_reportClose_Ljava_lang_Exception_ == IntPtr.Zero)
				id_reportClose_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "reportClose", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reportClose_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportClose", "(Ljava/lang/Exception;)V"), __args);
			} finally {
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='resume' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncNetworkSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncNetworkSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncNetworkSocket']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
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
