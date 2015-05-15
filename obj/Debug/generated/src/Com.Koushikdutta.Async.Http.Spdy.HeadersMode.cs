using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/spdy/HeadersMode", DoNotGenerateAcw=true)]
	public sealed partial class HeadersMode : global::Java.Lang.Enum {


		static IntPtr HTTP_20_HEADERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/field[@name='HTTP_20_HEADERS']"
		[Register ("HTTP_20_HEADERS")]
		public static global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode Http20Headers {
			get {
				if (HTTP_20_HEADERS_jfieldId == IntPtr.Zero)
					HTTP_20_HEADERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_20_HEADERS", "Lcom/koushikdutta/async/http/spdy/HeadersMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_20_HEADERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY_HEADERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/field[@name='SPDY_HEADERS']"
		[Register ("SPDY_HEADERS")]
		public static global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode SpdyHeaders {
			get {
				if (SPDY_HEADERS_jfieldId == IntPtr.Zero)
					SPDY_HEADERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_HEADERS", "Lcom/koushikdutta/async/http/spdy/HeadersMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_HEADERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY_REPLY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/field[@name='SPDY_REPLY']"
		[Register ("SPDY_REPLY")]
		public static global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode SpdyReply {
			get {
				if (SPDY_REPLY_jfieldId == IntPtr.Zero)
					SPDY_REPLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_REPLY", "Lcom/koushikdutta/async/http/spdy/HeadersMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_REPLY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPDY_SYN_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/field[@name='SPDY_SYN_STREAM']"
		[Register ("SPDY_SYN_STREAM")]
		public static global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode SpdySynStream {
			get {
				if (SPDY_SYN_STREAM_jfieldId == IntPtr.Zero)
					SPDY_SYN_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPDY_SYN_STREAM", "Lcom/koushikdutta/async/http/spdy/HeadersMode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPDY_SYN_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/spdy/HeadersMode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeadersMode); }
		}

		internal HeadersMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_failIfHeadersAbsent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/method[@name='failIfHeadersAbsent' and count(parameter)=0]"
		[Register ("failIfHeadersAbsent", "()Z", "")]
		public unsafe bool FailIfHeadersAbsent ()
		{
			if (id_failIfHeadersAbsent == IntPtr.Zero)
				id_failIfHeadersAbsent = JNIEnv.GetMethodID (class_ref, "failIfHeadersAbsent", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_failIfHeadersAbsent);
			} finally {
			}
		}

		static IntPtr id_failIfHeadersPresent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/method[@name='failIfHeadersPresent' and count(parameter)=0]"
		[Register ("failIfHeadersPresent", "()Z", "")]
		public unsafe bool FailIfHeadersPresent ()
		{
			if (id_failIfHeadersPresent == IntPtr.Zero)
				id_failIfHeadersPresent = JNIEnv.GetMethodID (class_ref, "failIfHeadersPresent", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_failIfHeadersPresent);
			} finally {
			}
		}

		static IntPtr id_failIfStreamAbsent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/method[@name='failIfStreamAbsent' and count(parameter)=0]"
		[Register ("failIfStreamAbsent", "()Z", "")]
		public unsafe bool FailIfStreamAbsent ()
		{
			if (id_failIfStreamAbsent == IntPtr.Zero)
				id_failIfStreamAbsent = JNIEnv.GetMethodID (class_ref, "failIfStreamAbsent", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_failIfStreamAbsent);
			} finally {
			}
		}

		static IntPtr id_failIfStreamPresent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/method[@name='failIfStreamPresent' and count(parameter)=0]"
		[Register ("failIfStreamPresent", "()Z", "")]
		public unsafe bool FailIfStreamPresent ()
		{
			if (id_failIfStreamPresent == IntPtr.Zero)
				id_failIfStreamPresent = JNIEnv.GetMethodID (class_ref, "failIfStreamPresent", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_failIfStreamPresent);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/spdy/HeadersMode;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/spdy/HeadersMode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.spdy']/class[@name='HeadersMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/koushikdutta/async/http/spdy/HeadersMode;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/koushikdutta/async/http/spdy/HeadersMode;");
			try {
				return (global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Koushikdutta.Async.Http.Spdy.HeadersMode));
			} finally {
			}
		}

	}
}
