using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/HttpUtil", DoNotGenerateAcw=true)]
	public partial class HttpUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/HttpUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUtil); }
		}

		protected HttpUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']/constructor[@name='HttpUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpUtil)) {
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

		static IntPtr id_contentLength_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']/method[@name='contentLength' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("contentLength", "(Lcom/koushikdutta/async/http/Headers;)I", "")]
		public static unsafe int ContentLength (global::Com.Koushikdutta.Async.Http.Headers p0)
		{
			if (id_contentLength_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_contentLength_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "contentLength", "(Lcom/koushikdutta/async/http/Headers;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_contentLength_Lcom_koushikdutta_async_http_Headers_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBody_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']/method[@name='getBody' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.callback.CompletedCallback'] and parameter[3][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("getBody", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody GetBody (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1, global::Com.Koushikdutta.Async.Http.Headers p2)
		{
			if (id_getBody_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_getBody_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "getBody", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBody_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Lcom_koushikdutta_async_http_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBodyDecoder_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']/method[@name='getBodyDecoder' and count(parameter)=4 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.http.Protocol'] and parameter[3][@type='com.koushikdutta.async.http.Headers'] and parameter[4][@type='boolean']]"
		[Register ("getBodyDecoder", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/http/Protocol;Lcom/koushikdutta/async/http/Headers;Z)Lcom/koushikdutta/async/DataEmitter;", "")]
		public static unsafe global::Com.Koushikdutta.Async.IDataEmitter GetBodyDecoder (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.Http.Protocol p1, global::Com.Koushikdutta.Async.Http.Headers p2, bool p3)
		{
			if (id_getBodyDecoder_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_Z == IntPtr.Zero)
				id_getBodyDecoder_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_Z = JNIEnv.GetStaticMethodID (class_ref, "getBodyDecoder", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/http/Protocol;Lcom/koushikdutta/async/http/Headers;Z)Lcom/koushikdutta/async/DataEmitter;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Koushikdutta.Async.IDataEmitter __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBodyDecoder_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isKeepAlive_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']/method[@name='isKeepAlive' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.Protocol'] and parameter[2][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("isKeepAlive", "(Lcom/koushikdutta/async/http/Protocol;Lcom/koushikdutta/async/http/Headers;)Z", "")]
		public static unsafe bool IsKeepAlive (global::Com.Koushikdutta.Async.Http.Protocol p0, global::Com.Koushikdutta.Async.Http.Headers p1)
		{
			if (id_isKeepAlive_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_isKeepAlive_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "isKeepAlive", "(Lcom/koushikdutta/async/http/Protocol;Lcom/koushikdutta/async/http/Headers;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isKeepAlive_Lcom_koushikdutta_async_http_Protocol_Lcom_koushikdutta_async_http_Headers_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isKeepAlive_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='HttpUtil']/method[@name='isKeepAlive' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("isKeepAlive", "(Ljava/lang/String;Lcom/koushikdutta/async/http/Headers;)Z", "")]
		public static unsafe bool IsKeepAlive (string p0, global::Com.Koushikdutta.Async.Http.Headers p1)
		{
			if (id_isKeepAlive_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_isKeepAlive_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetStaticMethodID (class_ref, "isKeepAlive", "(Ljava/lang/String;Lcom/koushikdutta/async/http/Headers;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isKeepAlive_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
