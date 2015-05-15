using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncSSLSocketWrapper", DoNotGenerateAcw=true)]
	public partial class AsyncSSLSocketWrapper : global::Java.Lang.Object, global::Com.Koushikdutta.Async.IAsyncSSLSocket, global::Com.Koushikdutta.Async.Wrapper.IAsyncSocketWrapper {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='AsyncSSLSocketWrapper.HandshakeCallback']"
		[Register ("com/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback", "", "Com.Koushikdutta.Async.AsyncSSLSocketWrapper/IHandshakeCallbackInvoker")]
		public partial interface IHandshakeCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='AsyncSSLSocketWrapper.HandshakeCallback']/method[@name='onHandshakeCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='com.koushikdutta.async.AsyncSSLSocket']]"
			[Register ("onHandshakeCompleted", "(Ljava/lang/Exception;Lcom/koushikdutta/async/AsyncSSLSocket;)V", "GetOnHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_Handler:Com.Koushikdutta.Async.AsyncSSLSocketWrapper/IHandshakeCallbackInvoker, AndroidAsyncBinding")]
			void OnHandshakeCompleted (global::Java.Lang.Exception p0, global::Com.Koushikdutta.Async.IAsyncSSLSocket p1);

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback", DoNotGenerateAcw=true)]
		internal class IHandshakeCallbackInvoker : global::Java.Lang.Object, IHandshakeCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback");
			IntPtr class_ref;

			public static IHandshakeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IHandshakeCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.AsyncSSLSocketWrapper.HandshakeCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IHandshakeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IHandshakeCallbackInvoker); }
			}

			static Delegate cb_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_;
#pragma warning disable 0169
			static Delegate GetOnHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_Handler ()
			{
				if (cb_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_ == null)
					cb_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_);
				return cb_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_;
			}

			static void n_OnHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.IAsyncSSLSocket p1 = (global::Com.Koushikdutta.Async.IAsyncSSLSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSSLSocket> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnHandshakeCompleted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_;
			public unsafe void OnHandshakeCompleted (global::Java.Lang.Exception p0, global::Com.Koushikdutta.Async.IAsyncSSLSocket p1)
			{
				if (id_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_ == IntPtr.Zero)
					id_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_ = JNIEnv.GetMethodID (class_ref, "onHandshakeCompleted", "(Ljava/lang/Exception;Lcom/koushikdutta/async/AsyncSSLSocket;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onHandshakeCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSSLSocket_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/AsyncSSLSocketWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncSSLSocketWrapper); }
		}

		protected AsyncSSLSocketWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClosedCallback;
		static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getClosedCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataCallback;
		static IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getDataCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='setDataCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.DataCallback']]"
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

		static Delegate cb_getDataEmitter;
#pragma warning disable 0169
		static Delegate GetGetDataEmitterHandler ()
		{
			if (cb_getDataEmitter == null)
				cb_getDataEmitter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataEmitter);
			return cb_getDataEmitter;
		}

		static IntPtr n_GetDataEmitter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataEmitter);
		}
#pragma warning restore 0169

		static IntPtr id_getDataEmitter;
		public virtual unsafe global::Com.Koushikdutta.Async.IDataEmitter DataEmitter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getDataEmitter' and count(parameter)=0]"
			[Register ("getDataEmitter", "()Lcom/koushikdutta/async/DataEmitter;", "GetGetDataEmitterHandler")]
			get {
				if (id_getDataEmitter == IntPtr.Zero)
					id_getDataEmitter = JNIEnv.GetMethodID (class_ref, "getDataEmitter", "()Lcom/koushikdutta/async/DataEmitter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (JNIEnv.CallObjectMethod  (Handle, id_getDataEmitter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataEmitter", "()Lcom/koushikdutta/async/DataEmitter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDefaultSSLContext;
		public static unsafe global::Javax.Net.Ssl.SSLContext DefaultSSLContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getDefaultSSLContext' and count(parameter)=0]"
			[Register ("getDefaultSSLContext", "()Ljavax/net/ssl/SSLContext;", "GetGetDefaultSSLContextHandler")]
			get {
				if (id_getDefaultSSLContext == IntPtr.Zero)
					id_getDefaultSSLContext = JNIEnv.GetStaticMethodID (class_ref, "getDefaultSSLContext", "()Ljavax/net/ssl/SSLContext;");
				try {
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLContext> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultSSLContext), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEndCallback;
		static IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getEndCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		static IntPtr id_getHost;
		public virtual unsafe string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				if (id_getHost == IntPtr.Zero)
					id_getHost = JNIEnv.GetMethodID (class_ref, "getHost", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		static IntPtr id_isChunked;
		public virtual unsafe bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='isChunked' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='isOpen' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='isPaused' and count(parameter)=0]"
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

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static IntPtr id_getPort;
		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPort);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPort", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSSLEngine;
#pragma warning disable 0169
		static Delegate GetGetSSLEngineHandler ()
		{
			if (cb_getSSLEngine == null)
				cb_getSSLEngine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSSLEngine);
			return cb_getSSLEngine;
		}

		static IntPtr n_GetSSLEngine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SSLEngine);
		}
#pragma warning restore 0169

		static IntPtr id_getSSLEngine;
		public virtual unsafe global::Javax.Net.Ssl.SSLEngine SSLEngine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getSSLEngine' and count(parameter)=0]"
			[Register ("getSSLEngine", "()Ljavax/net/ssl/SSLEngine;", "GetGetSSLEngineHandler")]
			get {
				if (id_getSSLEngine == IntPtr.Zero)
					id_getSSLEngine = JNIEnv.GetMethodID (class_ref, "getSSLEngine", "()Ljavax/net/ssl/SSLEngine;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (JNIEnv.CallObjectMethod  (Handle, id_getSSLEngine), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLEngine", "()Ljavax/net/ssl/SSLEngine;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getServer' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static IntPtr id_getSocket;
		public virtual unsafe global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getSocket' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteableCallback;
		static IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getWriteableCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='setWriteableCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='charset' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='close' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		static IntPtr id_end;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='end' and count(parameter)=0]"
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

		static Delegate cb_getPeerCertificates;
#pragma warning disable 0169
		static Delegate GetGetPeerCertificatesHandler ()
		{
			if (cb_getPeerCertificates == null)
				cb_getPeerCertificates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeerCertificates);
			return cb_getPeerCertificates;
		}

		static IntPtr n_GetPeerCertificates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPeerCertificates ());
		}
#pragma warning restore 0169

		static IntPtr id_getPeerCertificates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='getPeerCertificates' and count(parameter)=0]"
		[Register ("getPeerCertificates", "()[Ljava/security/cert/X509Certificate;", "GetGetPeerCertificatesHandler")]
		public virtual unsafe global::Java.Security.Cert.X509Certificate[] GetPeerCertificates ()
		{
			if (id_getPeerCertificates == IntPtr.Zero)
				id_getPeerCertificates = JNIEnv.GetMethodID (class_ref, "getPeerCertificates", "()[Ljava/security/cert/X509Certificate;");
			try {

				if (GetType () == ThresholdType)
					return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPeerCertificates), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				else
					return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeerCertificates", "()[Ljava/security/cert/X509Certificate;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
			} finally {
			}
		}

		static IntPtr id_handshake_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_String_ILjavax_net_ssl_SSLEngine_arrayLjavax_net_ssl_TrustManager_Ljavax_net_ssl_HostnameVerifier_ZLcom_koushikdutta_async_AsyncSSLSocketWrapper_HandshakeCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='handshake' and count(parameter)=8 and parameter[1][@type='com.koushikdutta.async.AsyncSocket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='javax.net.ssl.SSLEngine'] and parameter[5][@type='javax.net.ssl.TrustManager[]'] and parameter[6][@type='javax.net.ssl.HostnameVerifier'] and parameter[7][@type='boolean'] and parameter[8][@type='com.koushikdutta.async.AsyncSSLSocketWrapper.HandshakeCallback']]"
		[Register ("handshake", "(Lcom/koushikdutta/async/AsyncSocket;Ljava/lang/String;ILjavax/net/ssl/SSLEngine;[Ljavax/net/ssl/TrustManager;Ljavax/net/ssl/HostnameVerifier;ZLcom/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback;)V", "")]
		public static unsafe void Handshake (global::Com.Koushikdutta.Async.IAsyncSocket p0, string p1, int p2, global::Javax.Net.Ssl.SSLEngine p3, global::Javax.Net.Ssl.ITrustManager[] p4, global::Javax.Net.Ssl.IHostnameVerifier p5, bool p6, global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper.IHandshakeCallback p7)
		{
			if (id_handshake_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_String_ILjavax_net_ssl_SSLEngine_arrayLjavax_net_ssl_TrustManager_Ljavax_net_ssl_HostnameVerifier_ZLcom_koushikdutta_async_AsyncSSLSocketWrapper_HandshakeCallback_ == IntPtr.Zero)
				id_handshake_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_String_ILjavax_net_ssl_SSLEngine_arrayLjavax_net_ssl_TrustManager_Ljavax_net_ssl_HostnameVerifier_ZLcom_koushikdutta_async_AsyncSSLSocketWrapper_HandshakeCallback_ = JNIEnv.GetStaticMethodID (class_ref, "handshake", "(Lcom/koushikdutta/async/AsyncSocket;Ljava/lang/String;ILjavax/net/ssl/SSLEngine;[Ljavax/net/ssl/TrustManager;Ljavax/net/ssl/HostnameVerifier;ZLcom/koushikdutta/async/AsyncSSLSocketWrapper$HandshakeCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handshake_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_String_ILjavax_net_ssl_SSLEngine_arrayLjavax_net_ssl_TrustManager_Ljavax_net_ssl_HostnameVerifier_ZLcom_koushikdutta_async_AsyncSSLSocketWrapper_HandshakeCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_onDataAvailable;
#pragma warning disable 0169
		static Delegate GetOnDataAvailableHandler ()
		{
			if (cb_onDataAvailable == null)
				cb_onDataAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDataAvailable);
			return cb_onDataAvailable;
		}

		static void n_OnDataAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='onDataAvailable' and count(parameter)=0]"
		[Register ("onDataAvailable", "()V", "GetOnDataAvailableHandler")]
		public virtual unsafe void OnDataAvailable ()
		{
			if (id_onDataAvailable == IntPtr.Zero)
				id_onDataAvailable = JNIEnv.GetMethodID (class_ref, "onDataAvailable", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataAvailable);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataAvailable", "()V"));
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='pause' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='resume' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLSocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLSocketWrapper']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
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
