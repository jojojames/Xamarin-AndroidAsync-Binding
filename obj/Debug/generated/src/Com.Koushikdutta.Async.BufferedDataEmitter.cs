using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/BufferedDataEmitter", DoNotGenerateAcw=true)]
	public partial class BufferedDataEmitter : global::Java.Lang.Object, global::Com.Koushikdutta.Async.IDataEmitter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/BufferedDataEmitter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BufferedDataEmitter); }
		}

		protected BufferedDataEmitter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_DataEmitter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/constructor[@name='BufferedDataEmitter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataEmitter']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/DataEmitter;)V", "")]
		public unsafe BufferedDataEmitter (global::Com.Koushikdutta.Async.IDataEmitter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BufferedDataEmitter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/DataEmitter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/DataEmitter;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_DataEmitter_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_DataEmitter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/DataEmitter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_DataEmitter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_DataEmitter_, __args);
			} finally {
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataCallback;
		static IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='getDataCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='setDataCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.DataCallback']]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEndCallback;
		static IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='getEndCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		static IntPtr id_isChunked;
		public virtual unsafe bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='isChunked' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		static IntPtr id_isPaused;
		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='isPaused' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='getServer' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='charset' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='close' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='onDataAvailable' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='pause' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataEmitter']/method[@name='resume' and count(parameter)=0]"
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

	}
}
