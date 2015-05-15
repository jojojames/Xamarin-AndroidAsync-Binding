using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/BufferedDataSink", DoNotGenerateAcw=true)]
	public partial class BufferedDataSink : global::Java.Lang.Object, global::Com.Koushikdutta.Async.IDataSink {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/BufferedDataSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BufferedDataSink); }
		}

		protected BufferedDataSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_DataSink_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/constructor[@name='BufferedDataSink' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/DataSink;)V", "")]
		public unsafe BufferedDataSink (global::Com.Koushikdutta.Async.IDataSink p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (BufferedDataSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/DataSink;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/DataSink;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_DataSink_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_DataSink_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/DataSink;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_DataSink_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_DataSink_, __args);
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClosedCallback;
		static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='getClosedCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
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

		static Delegate cb_getDataSink;
#pragma warning disable 0169
		static Delegate GetGetDataSinkHandler ()
		{
			if (cb_getDataSink == null)
				cb_getDataSink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSink);
			return cb_getDataSink;
		}

		static IntPtr n_GetDataSink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSink);
		}
#pragma warning restore 0169

		static Delegate cb_setDataSink_Lcom_koushikdutta_async_DataSink_;
#pragma warning disable 0169
		static Delegate GetSetDataSink_Lcom_koushikdutta_async_DataSink_Handler ()
		{
			if (cb_setDataSink_Lcom_koushikdutta_async_DataSink_ == null)
				cb_setDataSink_Lcom_koushikdutta_async_DataSink_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSink_Lcom_koushikdutta_async_DataSink_);
			return cb_setDataSink_Lcom_koushikdutta_async_DataSink_;
		}

		static void n_SetDataSink_Lcom_koushikdutta_async_DataSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p0 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSink;
		static IntPtr id_setDataSink_Lcom_koushikdutta_async_DataSink_;
		public virtual unsafe global::Com.Koushikdutta.Async.IDataSink DataSink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='getDataSink' and count(parameter)=0]"
			[Register ("getDataSink", "()Lcom/koushikdutta/async/DataSink;", "GetGetDataSinkHandler")]
			get {
				if (id_getDataSink == IntPtr.Zero)
					id_getDataSink = JNIEnv.GetMethodID (class_ref, "getDataSink", "()Lcom/koushikdutta/async/DataSink;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (JNIEnv.CallObjectMethod  (Handle, id_getDataSink), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSink", "()Lcom/koushikdutta/async/DataSink;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='setDataSink' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
			[Register ("setDataSink", "(Lcom/koushikdutta/async/DataSink;)V", "GetSetDataSink_Lcom_koushikdutta_async_DataSink_Handler")]
			set {
				if (id_setDataSink_Lcom_koushikdutta_async_DataSink_ == IntPtr.Zero)
					id_setDataSink_Lcom_koushikdutta_async_DataSink_ = JNIEnv.GetMethodID (class_ref, "setDataSink", "(Lcom/koushikdutta/async/DataSink;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDataSink_Lcom_koushikdutta_async_DataSink_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSink", "(Lcom/koushikdutta/async/DataSink;)V"), __args);
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBuffering;
		}
#pragma warning restore 0169

		static IntPtr id_isBuffering;
		public virtual unsafe bool IsBuffering {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='isBuffering' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='isOpen' and count(parameter)=0]"
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

		static Delegate cb_getMaxBuffer;
#pragma warning disable 0169
		static Delegate GetGetMaxBufferHandler ()
		{
			if (cb_getMaxBuffer == null)
				cb_getMaxBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxBuffer);
			return cb_getMaxBuffer;
		}

		static int n_GetMaxBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxBuffer;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxBuffer_I;
#pragma warning disable 0169
		static Delegate GetSetMaxBuffer_IHandler ()
		{
			if (cb_setMaxBuffer_I == null)
				cb_setMaxBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxBuffer_I);
			return cb_setMaxBuffer_I;
		}

		static void n_SetMaxBuffer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxBuffer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxBuffer;
		static IntPtr id_setMaxBuffer_I;
		public virtual unsafe int MaxBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='getMaxBuffer' and count(parameter)=0]"
			[Register ("getMaxBuffer", "()I", "GetGetMaxBufferHandler")]
			get {
				if (id_getMaxBuffer == IntPtr.Zero)
					id_getMaxBuffer = JNIEnv.GetMethodID (class_ref, "getMaxBuffer", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxBuffer);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxBuffer", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='setMaxBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxBuffer", "(I)V", "GetSetMaxBuffer_IHandler")]
			set {
				if (id_setMaxBuffer_I == IntPtr.Zero)
					id_setMaxBuffer_I = JNIEnv.GetMethodID (class_ref, "setMaxBuffer", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxBuffer_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxBuffer", "(I)V"), __args);
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='getServer' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteableCallback;
		static IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='getWriteableCallback' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='setWriteableCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		static IntPtr id_end;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='end' and count(parameter)=0]"
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

		static Delegate cb_remaining;
#pragma warning disable 0169
		static Delegate GetRemainingHandler ()
		{
			if (cb_remaining == null)
				cb_remaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Remaining);
			return cb_remaining;
		}

		static int n_Remaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remaining ();
		}
#pragma warning restore 0169

		static IntPtr id_remaining;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='remaining' and count(parameter)=0]"
		[Register ("remaining", "()I", "GetRemainingHandler")]
		public virtual unsafe int Remaining ()
		{
			if (id_remaining == IntPtr.Zero)
				id_remaining = JNIEnv.GetMethodID (class_ref, "remaining", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_remaining);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remaining", "()I"));
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
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
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

		static Delegate cb_write_Lcom_koushikdutta_async_ByteBufferList_Z;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_ByteBufferList_ZHandler ()
		{
			if (cb_write_Lcom_koushikdutta_async_ByteBufferList_Z == null)
				cb_write_Lcom_koushikdutta_async_ByteBufferList_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Write_Lcom_koushikdutta_async_ByteBufferList_Z);
			return cb_write_Lcom_koushikdutta_async_ByteBufferList_Z;
		}

		static void n_Write_Lcom_koushikdutta_async_ByteBufferList_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Koushikdutta.Async.BufferedDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.BufferedDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='BufferedDataSink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.ByteBufferList'] and parameter[2][@type='boolean']]"
		[Register ("write", "(Lcom/koushikdutta/async/ByteBufferList;Z)V", "GetWrite_Lcom_koushikdutta_async_ByteBufferList_ZHandler")]
		protected virtual unsafe void Write (global::Com.Koushikdutta.Async.ByteBufferList p0, bool p1)
		{
			if (id_write_Lcom_koushikdutta_async_ByteBufferList_Z == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_ByteBufferList_Z = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/ByteBufferList;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_ByteBufferList_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/koushikdutta/async/ByteBufferList;Z)V"), __args);
			} finally {
			}
		}

	}
}
