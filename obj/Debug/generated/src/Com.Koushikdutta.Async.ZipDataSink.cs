using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ZipDataSink']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/ZipDataSink", DoNotGenerateAcw=true)]
	public partial class ZipDataSink : global::Com.Koushikdutta.Async.FilteredDataSink {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/ZipDataSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZipDataSink); }
		}

		protected ZipDataSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_DataSink_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ZipDataSink']/constructor[@name='ZipDataSink' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/DataSink;)V", "")]
		public unsafe ZipDataSink (global::Com.Koushikdutta.Async.IDataSink p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ZipDataSink)) {
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

		static Delegate cb_closeEntry;
#pragma warning disable 0169
		static Delegate GetCloseEntryHandler ()
		{
			if (cb_closeEntry == null)
				cb_closeEntry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseEntry);
			return cb_closeEntry;
		}

		static void n_CloseEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ZipDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ZipDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseEntry ();
		}
#pragma warning restore 0169

		static IntPtr id_closeEntry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ZipDataSink']/method[@name='closeEntry' and count(parameter)=0]"
		[Register ("closeEntry", "()V", "GetCloseEntryHandler")]
		public virtual unsafe void CloseEntry ()
		{
			if (id_closeEntry == IntPtr.Zero)
				id_closeEntry = JNIEnv.GetMethodID (class_ref, "closeEntry", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_closeEntry);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeEntry", "()V"));
			} finally {
			}
		}

		static Delegate cb_putNextEntry_Ljava_util_zip_ZipEntry_;
#pragma warning disable 0169
		static Delegate GetPutNextEntry_Ljava_util_zip_ZipEntry_Handler ()
		{
			if (cb_putNextEntry_Ljava_util_zip_ZipEntry_ == null)
				cb_putNextEntry_Ljava_util_zip_ZipEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutNextEntry_Ljava_util_zip_ZipEntry_);
			return cb_putNextEntry_Ljava_util_zip_ZipEntry_;
		}

		static void n_PutNextEntry_Ljava_util_zip_ZipEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ZipDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ZipDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Zip.ZipEntry p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutNextEntry (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putNextEntry_Ljava_util_zip_ZipEntry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ZipDataSink']/method[@name='putNextEntry' and count(parameter)=1 and parameter[1][@type='java.util.zip.ZipEntry']]"
		[Register ("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", "GetPutNextEntry_Ljava_util_zip_ZipEntry_Handler")]
		public virtual unsafe void PutNextEntry (global::Java.Util.Zip.ZipEntry p0)
		{
			if (id_putNextEntry_Ljava_util_zip_ZipEntry_ == IntPtr.Zero)
				id_putNextEntry_Ljava_util_zip_ZipEntry_ = JNIEnv.GetMethodID (class_ref, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_putNextEntry_Ljava_util_zip_ZipEntry_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putNextEntry", "(Ljava/util/zip/ZipEntry;)V"), __args);
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
			global::Com.Koushikdutta.Async.ZipDataSink __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ZipDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Report (p0);
		}
#pragma warning restore 0169

		static IntPtr id_report_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ZipDataSink']/method[@name='report' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
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

	}
}
