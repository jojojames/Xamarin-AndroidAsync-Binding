using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Filter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.filter']/class[@name='ChunkedOutputFilter']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/filter/ChunkedOutputFilter", DoNotGenerateAcw=true)]
	public partial class ChunkedOutputFilter : global::Com.Koushikdutta.Async.FilteredDataSink {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/filter/ChunkedOutputFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChunkedOutputFilter); }
		}

		protected ChunkedOutputFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_DataSink_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.filter']/class[@name='ChunkedOutputFilter']/constructor[@name='ChunkedOutputFilter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/DataSink;)V", "")]
		public unsafe ChunkedOutputFilter (global::Com.Koushikdutta.Async.IDataSink p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ChunkedOutputFilter)) {
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

	}
}
