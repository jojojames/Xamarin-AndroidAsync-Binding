using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/spdy/AsyncSpdyConnection", DoNotGenerateAcw=true)]
	public partial class AsyncSpdyConnection : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/spdy/AsyncSpdyConnection$SpdySocket", DoNotGenerateAcw=true)]
		public partial class SpdySocket : global::Java.Lang.Object, global::Com.Koushikdutta.Async.IAsyncSocket {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/spdy/AsyncSpdyConnection$SpdySocket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpdySocket); }
			}

			protected SpdySocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ClosedCallback = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getClosedCallback;
			static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
			public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='getClosedCallback' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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

			static Delegate cb_getConnection;
#pragma warning disable 0169
			static Delegate GetGetConnectionHandler ()
			{
				if (cb_getConnection == null)
					cb_getConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnection);
				return cb_getConnection;
			}

			static IntPtr n_GetConnection (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Connection);
			}
#pragma warning restore 0169

			static IntPtr id_getConnection;
			public virtual unsafe global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection Connection {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='getConnection' and count(parameter)=0]"
				[Register ("getConnection", "()Lcom/koushikdutta/async/http/spdy/AsyncSpdyConnection;", "GetGetConnectionHandler")]
				get {
					if (id_getConnection == IntPtr.Zero)
						id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Lcom/koushikdutta/async/http/spdy/AsyncSpdyConnection;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (JNIEnv.CallObjectMethod  (Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnection", "()Lcom/koushikdutta/async/http/spdy/AsyncSpdyConnection;")), JniHandleOwnership.TransferLocalRef);
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.DataCallback = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getDataCallback;
			static IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
			public virtual unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='getDataCallback' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='setDataCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.DataCallback']]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.EndCallback = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getEndCallback;
			static IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
			public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='getEndCallback' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsChunked;
			}
#pragma warning restore 0169

			static IntPtr id_isChunked;
			public virtual unsafe bool IsChunked {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='isChunked' and count(parameter)=0]"
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

			static Delegate cb_isLocallyInitiated;
#pragma warning disable 0169
			static Delegate GetIsLocallyInitiatedHandler ()
			{
				if (cb_isLocallyInitiated == null)
					cb_isLocallyInitiated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocallyInitiated);
				return cb_isLocallyInitiated;
			}

			static bool n_IsLocallyInitiated (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsLocallyInitiated;
			}
#pragma warning restore 0169

			static IntPtr id_isLocallyInitiated;
			public virtual unsafe bool IsLocallyInitiated {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='isLocallyInitiated' and count(parameter)=0]"
				[Register ("isLocallyInitiated", "()Z", "GetIsLocallyInitiatedHandler")]
				get {
					if (id_isLocallyInitiated == IntPtr.Zero)
						id_isLocallyInitiated = JNIEnv.GetMethodID (class_ref, "isLocallyInitiated", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isLocallyInitiated);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocallyInitiated", "()Z"));
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsOpen;
			}
#pragma warning restore 0169

			static IntPtr id_isOpen;
			public virtual unsafe bool IsOpen {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='isOpen' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsPaused;
			}
#pragma warning restore 0169

			static IntPtr id_isPaused;
			public virtual unsafe bool IsPaused {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='isPaused' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Server);
			}
#pragma warning restore 0169

			static IntPtr id_getServer;
			public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='getServer' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WriteableCallback = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getWriteableCallback;
			static IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
			public virtual unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='getWriteableCallback' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='setWriteableCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
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

			static Delegate cb_addBytesToWriteWindow_J;
#pragma warning disable 0169
			static Delegate GetAddBytesToWriteWindow_JHandler ()
			{
				if (cb_addBytesToWriteWindow_J == null)
					cb_addBytesToWriteWindow_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_AddBytesToWriteWindow_J);
				return cb_addBytesToWriteWindow_J;
			}

			static void n_AddBytesToWriteWindow_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AddBytesToWriteWindow (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addBytesToWriteWindow_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='addBytesToWriteWindow' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("addBytesToWriteWindow", "(J)V", "GetAddBytesToWriteWindow_JHandler")]
			public virtual unsafe void AddBytesToWriteWindow (long p0)
			{
				if (id_addBytesToWriteWindow_J == IntPtr.Zero)
					id_addBytesToWriteWindow_J = JNIEnv.GetMethodID (class_ref, "addBytesToWriteWindow", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_addBytesToWriteWindow_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBytesToWriteWindow", "(J)V"), __args);
				} finally {
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Charset ());
			}
#pragma warning restore 0169

			static IntPtr id_charset;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='charset' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='close' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.End ();
			}
#pragma warning restore 0169

			static IntPtr id_end;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='end' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Pause ();
			}
#pragma warning restore 0169

			static IntPtr id_pause;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='pause' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Resume ();
			}
#pragma warning restore 0169

			static IntPtr id_resume;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='resume' and count(parameter)=0]"
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
				global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection.SpdySocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Write (p0);
			}
#pragma warning restore 0169

			static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection.SpdySocket']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/spdy/AsyncSpdyConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncSpdyConnection); }
		}

		protected AsyncSpdyConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_Protocol_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/constructor[@name='AsyncSpdyConnection' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.AsyncSocket'] and parameter[2][@type='com.koushikdutta.async.http.Protocol']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/Protocol;)V", "")]
		public unsafe AsyncSpdyConnection (global::Com.Koushikdutta.Async.IAsyncSocket p0, global::Com.Koushikdutta.Async.Http.Protocol p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AsyncSpdyConnection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/Protocol;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/Protocol;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_Protocol_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_Protocol_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/http/Protocol;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_Protocol_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_http_Protocol_, __args);
			} finally {
			}
		}

		static Delegate cb_ackSettings;
#pragma warning disable 0169
		static Delegate GetAckSettingsHandler ()
		{
			if (cb_ackSettings == null)
				cb_ackSettings = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AckSettings);
			return cb_ackSettings;
		}

		static void n_AckSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AckSettings ();
		}
#pragma warning restore 0169

		static IntPtr id_ackSettings;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='ackSettings' and count(parameter)=0]"
		[Register ("ackSettings", "()V", "GetAckSettingsHandler")]
		public virtual unsafe void AckSettings ()
		{
			if (id_ackSettings == IntPtr.Zero)
				id_ackSettings = JNIEnv.GetMethodID (class_ref, "ackSettings", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ackSettings);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ackSettings", "()V"));
			} finally {
			}
		}

		static Delegate cb_data_ZILcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetData_ZILcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_data_ZILcom_koushikdutta_async_ByteBufferList_ == null)
				cb_data_ZILcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr>) n_Data_ZILcom_koushikdutta_async_ByteBufferList_);
			return cb_data_ZILcom_koushikdutta_async_ByteBufferList_;
		}

		static void n_Data_ZILcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p2 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Data (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_data_ZILcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='data' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("data", "(ZILcom/koushikdutta/async/ByteBufferList;)V", "GetData_ZILcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe void Data (bool p0, int p1, global::Com.Koushikdutta.Async.ByteBufferList p2)
		{
			if (id_data_ZILcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_data_ZILcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "data", "(ZILcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_data_ZILcom_koushikdutta_async_ByteBufferList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "data", "(ZILcom/koushikdutta/async/ByteBufferList;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_error_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_Exception_Handler ()
		{
			if (cb_error_Ljava_lang_Exception_ == null)
				cb_error_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Error_Ljava_lang_Exception_);
			return cb_error_Ljava_lang_Exception_;
		}

		static void n_Error_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0);
		}
#pragma warning restore 0169

		static IntPtr id_error_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("error", "(Ljava/lang/Exception;)V", "GetError_Ljava_lang_Exception_Handler")]
		public virtual unsafe void Error (global::Java.Lang.Exception p0)
		{
			if (id_error_Ljava_lang_Exception_ == IntPtr.Zero)
				id_error_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_error_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "error", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ping_ZII;
#pragma warning disable 0169
		static Delegate GetPing_ZIIHandler ()
		{
			if (cb_ping_ZII == null)
				cb_ping_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int>) n_Ping_ZII);
			return cb_ping_ZII;
		}

		static void n_Ping_ZII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ping (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ping_ZII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ping", "(ZII)V", "GetPing_ZIIHandler")]
		public virtual unsafe void Ping (bool p0, int p1, int p2)
		{
			if (id_ping_ZII == IntPtr.Zero)
				id_ping_ZII = JNIEnv.GetMethodID (class_ref, "ping", "(ZII)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ping_ZII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ping", "(ZII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_priority_IIIZ;
#pragma warning disable 0169
		static Delegate GetPriority_IIIZHandler ()
		{
			if (cb_priority_IIIZ == null)
				cb_priority_IIIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, bool>) n_Priority_IIIZ);
			return cb_priority_IIIZ;
		}

		static void n_Priority_IIIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Priority (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_priority_IIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='priority' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("priority", "(IIIZ)V", "GetPriority_IIIZHandler")]
		public virtual unsafe void Priority (int p0, int p1, int p2, bool p3)
		{
			if (id_priority_IIIZ == IntPtr.Zero)
				id_priority_IIIZ = JNIEnv.GetMethodID (class_ref, "priority", "(IIIZ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_priority_IIIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "priority", "(IIIZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendConnectionPreface;
#pragma warning disable 0169
		static Delegate GetSendConnectionPrefaceHandler ()
		{
			if (cb_sendConnectionPreface == null)
				cb_sendConnectionPreface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendConnectionPreface);
			return cb_sendConnectionPreface;
		}

		static void n_SendConnectionPreface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendConnectionPreface ();
		}
#pragma warning restore 0169

		static IntPtr id_sendConnectionPreface;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='sendConnectionPreface' and count(parameter)=0]"
		[Register ("sendConnectionPreface", "()V", "GetSendConnectionPrefaceHandler")]
		public virtual unsafe void SendConnectionPreface ()
		{
			if (id_sendConnectionPreface == IntPtr.Zero)
				id_sendConnectionPreface = JNIEnv.GetMethodID (class_ref, "sendConnectionPreface", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendConnectionPreface);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendConnectionPreface", "()V"));
			} finally {
			}
		}

		static Delegate cb_windowUpdate_IJ;
#pragma warning disable 0169
		static Delegate GetWindowUpdate_IJHandler ()
		{
			if (cb_windowUpdate_IJ == null)
				cb_windowUpdate_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long>) n_WindowUpdate_IJ);
			return cb_windowUpdate_IJ;
		}

		static void n_WindowUpdate_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.AsyncSpdyConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WindowUpdate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_windowUpdate_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='AsyncSpdyConnection']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("windowUpdate", "(IJ)V", "GetWindowUpdate_IJHandler")]
		public virtual unsafe void WindowUpdate (int p0, long p1)
		{
			if (id_windowUpdate_IJ == IntPtr.Zero)
				id_windowUpdate_IJ = JNIEnv.GetMethodID (class_ref, "windowUpdate", "(IJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_windowUpdate_IJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "windowUpdate", "(IJ)V"), __args);
			} finally {
			}
		}

	}
}
