using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='FileDataSink']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/stream/FileDataSink", DoNotGenerateAcw=true)]
	public partial class FileDataSink : global::Com.Koushikdutta.Async.Stream.OutputStreamDataSink {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/stream/FileDataSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileDataSink); }
		}

		protected FileDataSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_AsyncServer_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='FileDataSink']/constructor[@name='FileDataSink' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.AsyncServer'] and parameter[2][@type='java.io.File']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/AsyncServer;Ljava/io/File;)V", "")]
		public unsafe FileDataSink (global::Com.Koushikdutta.Async.AsyncServer p0, global::Java.IO.File p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FileDataSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/AsyncServer;Ljava/io/File;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/AsyncServer;Ljava/io/File;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_AsyncServer_Ljava_io_File_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_AsyncServer_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/AsyncServer;Ljava/io/File;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_AsyncServer_Ljava_io_File_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_AsyncServer_Ljava_io_File_, __args);
			} finally {
			}
		}

	}
}
