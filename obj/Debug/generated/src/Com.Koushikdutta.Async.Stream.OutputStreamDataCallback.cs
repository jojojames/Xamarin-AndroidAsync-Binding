using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='OutputStreamDataCallback']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/stream/OutputStreamDataCallback", DoNotGenerateAcw=true)]
	public partial class OutputStreamDataCallback : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Callback.ICompletedCallback, global::Com.Koushikdutta.Async.Callback.IDataCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/stream/OutputStreamDataCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutputStreamDataCallback); }
		}

		protected OutputStreamDataCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='OutputStreamDataCallback']/constructor[@name='OutputStreamDataCallback' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
		public unsafe OutputStreamDataCallback (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (OutputStreamDataCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getOutputStream;
		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='OutputStreamDataCallback']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputStream", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='OutputStreamDataCallback']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_onCompleted_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Exception_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Exception_ == null)
				cb_onCompleted_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_);
			return cb_onCompleted_Ljava_lang_Exception_;
		}

		static void n_OnCompleted_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCompleted_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='OutputStreamDataCallback']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;)V", "GetOnCompleted_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnCompleted (global::Java.Lang.Exception p0)
		{
			if (id_onCompleted_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCompleted_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompleted", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetOnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static void n_OnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Stream.OutputStreamDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='OutputStreamDataCallback']/method[@name='onDataAvailable' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V", "GetOnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe void OnDataAvailable (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.ByteBufferList p1)
		{
			if (id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V"), __args);
			} finally {
			}
		}

	}
}
