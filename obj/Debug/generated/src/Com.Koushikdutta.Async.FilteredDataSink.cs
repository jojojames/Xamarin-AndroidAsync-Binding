using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='FilteredDataSink']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/FilteredDataSink", DoNotGenerateAcw=true)]
	public partial class FilteredDataSink : global::Com.Koushikdutta.Async.BufferedDataSink {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/FilteredDataSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilteredDataSink); }
		}

		protected FilteredDataSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_DataSink_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='FilteredDataSink']/constructor[@name='FilteredDataSink' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/DataSink;)V", "")]
		public unsafe FilteredDataSink (global::Com.Koushikdutta.Async.IDataSink p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FilteredDataSink)) {
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

		static Delegate cb_filter_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetFilter_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_filter_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_filter_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Filter_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_filter_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static IntPtr n_Filter_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.FilteredDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.FilteredDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Filter (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_filter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='FilteredDataSink']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("filter", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;", "GetFilter_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList Filter (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_filter_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_filter_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "filter", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.ByteBufferList __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_filter_Lcom_koushikdutta_async_ByteBufferList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filter", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='FilteredDataSink']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("write", "(Lcom/koushikdutta/async/ByteBufferList;)V", "")]
		public override sealed unsafe void Write (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_write_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_ByteBufferList_, __args);
			} finally {
			}
		}

	}
}
