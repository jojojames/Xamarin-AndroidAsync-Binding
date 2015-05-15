using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterReader']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/DataEmitterReader", DoNotGenerateAcw=true)]
	public partial class DataEmitterReader : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Callback.IDataCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/DataEmitterReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataEmitterReader); }
		}

		protected DataEmitterReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterReader']/constructor[@name='DataEmitterReader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataEmitterReader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataEmitterReader)) {
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
			global::Com.Koushikdutta.Async.DataEmitterReader __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterReader']/method[@name='onDataAvailable' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
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

		static Delegate cb_read_ILcom_koushikdutta_async_callback_DataCallback_;
#pragma warning disable 0169
		static Delegate GetRead_ILcom_koushikdutta_async_callback_DataCallback_Handler ()
		{
			if (cb_read_ILcom_koushikdutta_async_callback_DataCallback_ == null)
				cb_read_ILcom_koushikdutta_async_callback_DataCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Read_ILcom_koushikdutta_async_callback_DataCallback_);
			return cb_read_ILcom_koushikdutta_async_callback_DataCallback_;
		}

		static void n_Read_ILcom_koushikdutta_async_callback_DataCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.DataEmitterReader __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.DataEmitterReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p1 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_read_ILcom_koushikdutta_async_callback_DataCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='DataEmitterReader']/method[@name='read' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.koushikdutta.async.callback.DataCallback']]"
		[Register ("read", "(ILcom/koushikdutta/async/callback/DataCallback;)V", "GetRead_ILcom_koushikdutta_async_callback_DataCallback_Handler")]
		public virtual unsafe void Read (int p0, global::Com.Koushikdutta.Async.Callback.IDataCallback p1)
		{
			if (id_read_ILcom_koushikdutta_async_callback_DataCallback_ == IntPtr.Zero)
				id_read_ILcom_koushikdutta_async_callback_DataCallback_ = JNIEnv.GetMethodID (class_ref, "read", "(ILcom/koushikdutta/async/callback/DataCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_read_ILcom_koushikdutta_async_callback_DataCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(ILcom/koushikdutta/async/callback/DataCallback;)V"), __args);
			} finally {
			}
		}

	}
}
