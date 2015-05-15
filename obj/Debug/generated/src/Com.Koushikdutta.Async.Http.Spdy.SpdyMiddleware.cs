using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='SpdyMiddleware']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/spdy/SpdyMiddleware", DoNotGenerateAcw=true)]
	public partial class SpdyMiddleware : global::Com.Koushikdutta.Async.Http.AsyncSSLSocketMiddleware {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='SpdyMiddleware.NoSpdyException']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/spdy/SpdyMiddleware$NoSpdyException", DoNotGenerateAcw=true)]
		public partial class NoSpdyException : global::Java.Lang.Exception {

			protected NoSpdyException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/spdy/SpdyMiddleware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyMiddleware); }
		}

		protected SpdyMiddleware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='SpdyMiddleware']/constructor[@name='SpdyMiddleware' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", "")]
		public unsafe SpdyMiddleware (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SpdyMiddleware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_, __args);
			} finally {
			}
		}

		static Delegate cb_getSpdyEnabled;
#pragma warning disable 0169
		static Delegate GetGetSpdyEnabledHandler ()
		{
			if (cb_getSpdyEnabled == null)
				cb_getSpdyEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSpdyEnabled);
			return cb_getSpdyEnabled;
		}

		static bool n_GetSpdyEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpdyEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setSpdyEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSpdyEnabled_ZHandler ()
		{
			if (cb_setSpdyEnabled_Z == null)
				cb_setSpdyEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSpdyEnabled_Z);
			return cb_setSpdyEnabled_Z;
		}

		static void n_SetSpdyEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.SpdyMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpdyEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSpdyEnabled;
		static IntPtr id_setSpdyEnabled_Z;
		public virtual unsafe bool SpdyEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='SpdyMiddleware']/method[@name='getSpdyEnabled' and count(parameter)=0]"
			[Register ("getSpdyEnabled", "()Z", "GetGetSpdyEnabledHandler")]
			get {
				if (id_getSpdyEnabled == IntPtr.Zero)
					id_getSpdyEnabled = JNIEnv.GetMethodID (class_ref, "getSpdyEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getSpdyEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpdyEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='SpdyMiddleware']/method[@name='setSpdyEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSpdyEnabled", "(Z)V", "GetSetSpdyEnabled_ZHandler")]
			set {
				if (id_setSpdyEnabled_Z == IntPtr.Zero)
					id_setSpdyEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSpdyEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSpdyEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpdyEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

	}
}
