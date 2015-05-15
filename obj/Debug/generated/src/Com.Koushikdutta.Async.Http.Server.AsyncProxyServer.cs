using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncProxyServer']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncProxyServer", DoNotGenerateAcw=true)]
	public partial class AsyncProxyServer : global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/server/AsyncProxyServer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncProxyServer); }
		}

		protected AsyncProxyServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_AsyncServer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncProxyServer']/constructor[@name='AsyncProxyServer' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.AsyncServer']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/AsyncServer;)V", "")]
		public unsafe AsyncProxyServer (global::Com.Koushikdutta.Async.AsyncServer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsyncProxyServer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/AsyncServer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/AsyncServer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_AsyncServer_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_AsyncServer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/AsyncServer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_AsyncServer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_AsyncServer_, __args);
			} finally {
			}
		}

	}
}
