using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='FileUtility']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/util/FileUtility", DoNotGenerateAcw=true)]
	public partial class FileUtility : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/util/FileUtility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtility); }
		}

		protected FileUtility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='FileUtility']/constructor[@name='FileUtility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtility ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FileUtility)) {
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

		static IntPtr id_deleteDirectory_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='FileUtility']/method[@name='deleteDirectory' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("deleteDirectory", "(Ljava/io/File;)Z", "")]
		public static unsafe bool DeleteDirectory (global::Java.IO.File p0)
		{
			if (id_deleteDirectory_Ljava_io_File_ == IntPtr.Zero)
				id_deleteDirectory_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "deleteDirectory", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_deleteDirectory_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
