using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.callback']/class[@name='DataCallback.NullDataCallback']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/DataCallback$NullDataCallback", DoNotGenerateAcw=true)]
	public partial class DataCallbackNullDataCallback : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Callback.IDataCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/callback/DataCallback$NullDataCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataCallbackNullDataCallback); }
		}

		protected DataCallbackNullDataCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.callback']/class[@name='DataCallback.NullDataCallback']/constructor[@name='DataCallback.NullDataCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataCallbackNullDataCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DataCallbackNullDataCallback)) {
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
			global::Com.Koushikdutta.Async.Callback.DataCallbackNullDataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.DataCallbackNullDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/class[@name='DataCallback.NullDataCallback']/method[@name='onDataAvailable' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='DataCallback']"
	[Register ("com/koushikdutta/async/callback/DataCallback", "", "Com.Koushikdutta.Async.Callback.IDataCallbackInvoker")]
	public partial interface IDataCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='DataCallback']/method[@name='onDataAvailable' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V", "GetOnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_Handler:Com.Koushikdutta.Async.Callback.IDataCallbackInvoker, AndroidAsyncBinding")]
		void OnDataAvailable (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.ByteBufferList p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/DataCallback", DoNotGenerateAcw=true)]
	internal class IDataCallbackInvoker : global::Java.Lang.Object, IDataCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/callback/DataCallback");
		IntPtr class_ref;

		public static IDataCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.callback.DataCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDataCallbackInvoker); }
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
			global::Com.Koushikdutta.Async.Callback.IDataCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		public unsafe void OnDataAvailable (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.ByteBufferList p1)
		{
			if (id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_, __args);
		}

	}

}
