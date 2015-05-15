using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter.DataTracker']"
	[Register ("com/koushikdutta/async/DataTrackingEmitter$DataTracker", "", "Com.Koushikdutta.Async.IDataTrackingEmitterDataTrackerInvoker")]
	public partial interface IDataTrackingEmitterDataTracker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter.DataTracker']/method[@name='onData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onData", "(I)V", "GetOnData_IHandler:Com.Koushikdutta.Async.IDataTrackingEmitterDataTrackerInvoker, AndroidAsyncBinding")]
		void OnData (int p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/DataTrackingEmitter$DataTracker", DoNotGenerateAcw=true)]
	internal class IDataTrackingEmitterDataTrackerInvoker : global::Java.Lang.Object, IDataTrackingEmitterDataTracker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/DataTrackingEmitter$DataTracker");
		IntPtr class_ref;

		public static IDataTrackingEmitterDataTracker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataTrackingEmitterDataTracker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.DataTrackingEmitter.DataTracker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataTrackingEmitterDataTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDataTrackingEmitterDataTrackerInvoker); }
		}

		static Delegate cb_onData_I;
#pragma warning disable 0169
		static Delegate GetOnData_IHandler ()
		{
			if (cb_onData_I == null)
				cb_onData_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnData_I);
			return cb_onData_I;
		}

		static void n_OnData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnData (p0);
		}
#pragma warning restore 0169

		IntPtr id_onData_I;
		public unsafe void OnData (int p0)
		{
			if (id_onData_I == IntPtr.Zero)
				id_onData_I = JNIEnv.GetMethodID (class_ref, "onData", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onData_I, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter']"
	[Register ("com/koushikdutta/async/DataTrackingEmitter", "", "Com.Koushikdutta.Async.IDataTrackingEmitterInvoker")]
	public partial interface IDataTrackingEmitter : global::Com.Koushikdutta.Async.IDataEmitter {

		int BytesRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter']/method[@name='getBytesRead' and count(parameter)=0]"
			[Register ("getBytesRead", "()I", "GetGetBytesReadHandler:Com.Koushikdutta.Async.IDataTrackingEmitterInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker DataTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter']/method[@name='getDataTracker' and count(parameter)=0]"
			[Register ("getDataTracker", "()Lcom/koushikdutta/async/DataTrackingEmitter$DataTracker;", "GetGetDataTrackerHandler:Com.Koushikdutta.Async.IDataTrackingEmitterInvoker, AndroidAsyncBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter']/method[@name='setDataTracker' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataTrackingEmitter.DataTracker']]"
			[Register ("setDataTracker", "(Lcom/koushikdutta/async/DataTrackingEmitter$DataTracker;)V", "GetSetDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_Handler:Com.Koushikdutta.Async.IDataTrackingEmitterInvoker, AndroidAsyncBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='DataTrackingEmitter']/method[@name='setDataEmitter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataEmitter']]"
		[Register ("setDataEmitter", "(Lcom/koushikdutta/async/DataEmitter;)V", "GetSetDataEmitter_Lcom_koushikdutta_async_DataEmitter_Handler:Com.Koushikdutta.Async.IDataTrackingEmitterInvoker, AndroidAsyncBinding")]
		void SetDataEmitter (global::Com.Koushikdutta.Async.IDataEmitter p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/DataTrackingEmitter", DoNotGenerateAcw=true)]
	internal class IDataTrackingEmitterInvoker : global::Java.Lang.Object, IDataTrackingEmitter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/DataTrackingEmitter");
		IntPtr class_ref;

		public static IDataTrackingEmitter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataTrackingEmitter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.DataTrackingEmitter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataTrackingEmitterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDataTrackingEmitterInvoker); }
		}

		static Delegate cb_getBytesRead;
#pragma warning disable 0169
		static Delegate GetGetBytesReadHandler ()
		{
			if (cb_getBytesRead == null)
				cb_getBytesRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBytesRead);
			return cb_getBytesRead;
		}

		static int n_GetBytesRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesRead;
		}
#pragma warning restore 0169

		IntPtr id_getBytesRead;
		public unsafe int BytesRead {
			get {
				if (id_getBytesRead == IntPtr.Zero)
					id_getBytesRead = JNIEnv.GetMethodID (class_ref, "getBytesRead", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getBytesRead);
			}
		}

		static Delegate cb_getDataTracker;
#pragma warning disable 0169
		static Delegate GetGetDataTrackerHandler ()
		{
			if (cb_getDataTracker == null)
				cb_getDataTracker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataTracker);
			return cb_getDataTracker;
		}

		static IntPtr n_GetDataTracker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataTracker);
		}
#pragma warning restore 0169

		static Delegate cb_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_;
#pragma warning disable 0169
		static Delegate GetSetDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_Handler ()
		{
			if (cb_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_ == null)
				cb_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_);
			return cb_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_;
		}

		static void n_SetDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker p0 = (global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataTracker = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDataTracker;
		IntPtr id_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_;
		public unsafe global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker DataTracker {
			get {
				if (id_getDataTracker == IntPtr.Zero)
					id_getDataTracker = JNIEnv.GetMethodID (class_ref, "getDataTracker", "()Lcom/koushikdutta/async/DataTrackingEmitter$DataTracker;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitterDataTracker> (JNIEnv.CallObjectMethod (Handle, id_getDataTracker), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_ == IntPtr.Zero)
					id_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_ = JNIEnv.GetMethodID (class_ref, "setDataTracker", "(Lcom/koushikdutta/async/DataTrackingEmitter$DataTracker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setDataTracker_Lcom_koushikdutta_async_DataTrackingEmitter_DataTracker_, __args);
			}
		}

		static Delegate cb_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_;
#pragma warning disable 0169
		static Delegate GetSetDataEmitter_Lcom_koushikdutta_async_DataEmitter_Handler ()
		{
			if (cb_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_ == null)
				cb_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataEmitter_Lcom_koushikdutta_async_DataEmitter_);
			return cb_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_;
		}

		static void n_SetDataEmitter_Lcom_koushikdutta_async_DataEmitter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataEmitter (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_;
		public unsafe void SetDataEmitter (global::Com.Koushikdutta.Async.IDataEmitter p0)
		{
			if (id_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_ == IntPtr.Zero)
				id_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_ = JNIEnv.GetMethodID (class_ref, "setDataEmitter", "(Lcom/koushikdutta/async/DataEmitter;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setDataEmitter_Lcom_koushikdutta_async_DataEmitter_, __args);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.IDataTrackingEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataTrackingEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
