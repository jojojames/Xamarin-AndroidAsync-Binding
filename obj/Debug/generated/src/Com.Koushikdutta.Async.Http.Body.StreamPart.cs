using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Body {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StreamPart']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/body/StreamPart", DoNotGenerateAcw=true)]
	public abstract partial class StreamPart : global::Com.Koushikdutta.Async.Http.Body.Part {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/body/StreamPart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamPart); }
		}

		protected StreamPart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JLjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StreamPart']/constructor[@name='StreamPart' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.util.List&lt;org.apache.http.NameValuePair&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;JLjava/util/List;)V", "")]
		public unsafe StreamPart (string p0, long p1, global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (StreamPart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JLjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JLjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JLjava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JLjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JLjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JLjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.StreamPart __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StreamPart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		protected abstract global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StreamPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/body/StreamPart", DoNotGenerateAcw=true)]
	internal partial class StreamPartInvoker : StreamPart {

		public StreamPartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamPartInvoker); }
		}

		static IntPtr id_getInputStream;
		protected override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StreamPart']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
