using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpHead']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpHead", DoNotGenerateAcw=true)]
	public partial class AsyncHttpHead : global::Com.Koushikdutta.Async.Http.AsyncHttpRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpHead", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpHead); }
		}

		protected AsyncHttpHead (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_Uri_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpHead']/constructor[@name='AsyncHttpHead' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/net/Uri;)V", "")]
		public unsafe AsyncHttpHead (global::Android.Net.Uri p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsyncHttpHead)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_Uri_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_, __args);
			} finally {
			}
		}

	}
}
