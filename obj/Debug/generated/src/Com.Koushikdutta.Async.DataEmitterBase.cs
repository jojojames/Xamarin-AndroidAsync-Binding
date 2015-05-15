using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/DataEmitterBase", DoNotGenerateAcw=true)]
	public abstract partial class DataEmitterBase : global::Java.Lang.Object, global::Com.Koushikdutta.Async.IDataEmitter {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/DataEmitterBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataEmitterBase); }
		}

		protected DataEmitterBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/constructor[@name='DataEmitterBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataEmitterBase ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataEmitterBase)) {
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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataCallback;
		static IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='getDataCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='setDataCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.DataCallback']]"
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

		static IntPtr id_getEndCallback;
		static IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='getEndCallback' and count(parameter)=0]"
			[Register ("getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;", "GetGetEndCallbackHandler")]
			get {
				if (id_getEndCallback == IntPtr.Zero)
					id_getEndCallback = JNIEnv.GetMethodID (class_ref, "getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod  (Handle, id_getEndCallback), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='setEndCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
			[Register ("setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
			set {
				if (id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		static IntPtr id_charset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='charset' and count(parameter)=0]"
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

		static Delegate cb_report_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetReport_Ljava_lang_Exception_Handler ()
		{
			if (cb_report_Ljava_lang_Exception_ == null)
				cb_report_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Report_Ljava_lang_Exception_);
			return cb_report_Ljava_lang_Exception_;
		}

		static void n_Report_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Report (p0);
		}
#pragma warning restore 0169

		static IntPtr id_report_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='report' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("report", "(Ljava/lang/Exception;)V", "GetReport_Ljava_lang_Exception_Handler")]
		protected virtual unsafe void Report (global::Java.Lang.Exception p0)
		{
			if (id_report_Ljava_lang_Exception_ == IntPtr.Zero)
				id_report_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "report", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_report_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "report", "(Ljava/lang/Exception;)V"), __args);
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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public abstract void Pause ();

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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public abstract void Resume ();

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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		public abstract bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='isChunked' and count(parameter)=0]"
			[Register ("isChunked", "()Z", "GetIsChunkedHandler")] get;
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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		public abstract bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")] get;
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
			global::Com.Koushikdutta.Async.DataEmitterBase __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		public abstract global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetServerHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/DataEmitterBase", DoNotGenerateAcw=true)]
	internal partial class DataEmitterBaseInvoker : DataEmitterBase {

		public DataEmitterBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataEmitterBaseInvoker); }
		}

		static IntPtr id_isChunked;
		public override unsafe bool IsChunked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='isChunked' and count(parameter)=0]"
			[Register ("isChunked", "()Z", "GetIsChunkedHandler")]
			get {
				if (id_isChunked == IntPtr.Zero)
					id_isChunked = JNIEnv.GetMethodID (class_ref, "isChunked", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isChunked);
				} finally {
				}
			}
		}

		static IntPtr id_isPaused;
		public override unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isPaused);
				} finally {
				}
			}
		}

		static IntPtr id_getServer;
		public override unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetServerHandler")]
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/koushikdutta/async/AsyncServer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallObjectMethod  (Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_pause);
			} finally {
			}
		}

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterBase']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public override unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_resume);
			} finally {
			}
		}

	}

}
