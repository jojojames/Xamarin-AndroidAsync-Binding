using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/Protocol", DoNotGenerateAcw=true)]
	public partial class Protocol : global::Java.Lang.Enum {


		static IntPtr HTTP_1_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/field[@name='HTTP_1_0']"
		[Register ("HTTP_1_0")]
		public static global::Com.Koushikdutta.Async.Http.Protocol Http10 {
			get {
				if (HTTP_1_0_jfieldId == IntPtr.Zero)
					HTTP_1_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_1_0", "Lcom/koushikdutta/async/http/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_1_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_1_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/field[@name='HTTP_1_1']"
		[Register ("HTTP_1_1")]
		public static global::Com.Koushikdutta.Async.Http.Protocol Http11 {
			get {
				if (HTTP_1_1_jfieldId == IntPtr.Zero)
					HTTP_1_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_1_1", "Lcom/koushikdutta/async/http/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_1_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HTTP_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/field[@name='HTTP_2']"
		[Register ("HTTP_2")]
		public static global::Com.Koushikdutta.Async.Http.Protocol Http2 {
			get {
				if (HTTP_2_jfieldId == IntPtr.Zero)
					HTTP_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_2", "Lcom/koushikdutta/async/http/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/field[@name='SPDY_3']"
		[Register ("SPDY_3")]
		public static global::Com.Koushikdutta.Async.Http.Protocol Spdy3 {
			get {
				if (SPDY_3_jfieldId == IntPtr.Zero)
					SPDY_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_3", "Lcom/koushikdutta/async/http/Protocol;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/Protocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Protocol); }
		}

		protected Protocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Protocol;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Protocol Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Protocol;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Protocol __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_needsSpdyConnection;
#pragma warning disable 0169
		static Delegate GetNeedsSpdyConnectionHandler ()
		{
			if (cb_needsSpdyConnection == null)
				cb_needsSpdyConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedsSpdyConnection);
			return cb_needsSpdyConnection;
		}

		static bool n_NeedsSpdyConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Protocol __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsSpdyConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_needsSpdyConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/method[@name='needsSpdyConnection' and count(parameter)=0]"
		[Register ("needsSpdyConnection", "()Z", "GetNeedsSpdyConnectionHandler")]
		public virtual unsafe bool NeedsSpdyConnection ()
		{
			if (id_needsSpdyConnection == IntPtr.Zero)
				id_needsSpdyConnection = JNIEnv.GetMethodID (class_ref, "needsSpdyConnection", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_needsSpdyConnection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "needsSpdyConnection", "()Z"));
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Protocol;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Protocol ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Protocol;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Protocol __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Protocol> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Protocol']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/koushikdutta/async/http/Protocol;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Protocol[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/koushikdutta/async/http/Protocol;");
			try {
				return (global::Com.Koushikdutta.Async.Http.Protocol[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Koushikdutta.Async.Http.Protocol));
			} finally {
			}
		}

	}
}
