using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpRequest", DoNotGenerateAcw=true)]
	public partial class AsyncHttpRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/field[@name='DEFAULT_TIMEOUT']"
		[Register ("DEFAULT_TIMEOUT")]
		public const int DefaultTimeout = (int) 30000;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpRequest$HttpRequestWrapper", DoNotGenerateAcw=true)]
		public partial class HttpRequestWrapper : global::Java.Lang.Object, global::Org.Apache.Http.IHttpRequest {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpRequest$HttpRequestWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpRequestWrapper); }
			}

			protected HttpRequestWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_http_AsyncHttpRequest_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/constructor[@name='AsyncHttpRequest.HttpRequestWrapper' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpRequest']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;)V", "")]
			public unsafe HttpRequestWrapper (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (HttpRequestWrapper)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/AsyncHttpRequest;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/AsyncHttpRequest;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_http_AsyncHttpRequest_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_http_AsyncHttpRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpRequest_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpRequest_, __args);
				} finally {
				}
			}

			static Delegate cb_getParams;
#pragma warning disable 0169
			static Delegate GetGetParamsHandler ()
			{
				if (cb_getParams == null)
					cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
				return cb_getParams;
			}

			static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Params);
			}
#pragma warning restore 0169

			static Delegate cb_setParams_Lorg_apache_http_params_HttpParams_;
#pragma warning disable 0169
			static Delegate GetSetParams_Lorg_apache_http_params_HttpParams_Handler ()
			{
				if (cb_setParams_Lorg_apache_http_params_HttpParams_ == null)
					cb_setParams_Lorg_apache_http_params_HttpParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParams_Lorg_apache_http_params_HttpParams_);
				return cb_setParams_Lorg_apache_http_params_HttpParams_;
			}

			static void n_SetParams_Lorg_apache_http_params_HttpParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.Params.IHttpParams p0 = (global::Org.Apache.Http.Params.IHttpParams)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Params.IHttpParams> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Params = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getParams;
			static IntPtr id_setParams_Lorg_apache_http_params_HttpParams_;
			public virtual unsafe global::Org.Apache.Http.Params.IHttpParams Params {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getParams' and count(parameter)=0]"
				[Register ("getParams", "()Lorg/apache/http/params/HttpParams;", "GetGetParamsHandler")]
				get {
					if (id_getParams == IntPtr.Zero)
						id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Lorg/apache/http/params/HttpParams;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Params.IHttpParams> (JNIEnv.CallObjectMethod  (Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Params.IHttpParams> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParams", "()Lorg/apache/http/params/HttpParams;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='setParams' and count(parameter)=1 and parameter[1][@type='org.apache.http.params.HttpParams']]"
				[Register ("setParams", "(Lorg/apache/http/params/HttpParams;)V", "GetSetParams_Lorg_apache_http_params_HttpParams_Handler")]
				set {
					if (id_setParams_Lorg_apache_http_params_HttpParams_ == IntPtr.Zero)
						id_setParams_Lorg_apache_http_params_HttpParams_ = JNIEnv.GetMethodID (class_ref, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setParams_Lorg_apache_http_params_HttpParams_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getProtocolVersion;
#pragma warning disable 0169
			static Delegate GetGetProtocolVersionHandler ()
			{
				if (cb_getProtocolVersion == null)
					cb_getProtocolVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProtocolVersion);
				return cb_getProtocolVersion;
			}

			static IntPtr n_GetProtocolVersion (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ProtocolVersion);
			}
#pragma warning restore 0169

			static IntPtr id_getProtocolVersion;
			public virtual unsafe global::Org.Apache.Http.ProtocolVersion ProtocolVersion {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getProtocolVersion' and count(parameter)=0]"
				[Register ("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", "GetGetProtocolVersionHandler")]
				get {
					if (id_getProtocolVersion == IntPtr.Zero)
						id_getProtocolVersion = JNIEnv.GetMethodID (class_ref, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.ProtocolVersion> (JNIEnv.CallObjectMethod  (Handle, id_getProtocolVersion), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.ProtocolVersion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRequestLine;
#pragma warning disable 0169
			static Delegate GetGetRequestLineHandler ()
			{
				if (cb_getRequestLine == null)
					cb_getRequestLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestLine);
				return cb_getRequestLine;
			}

			static IntPtr n_GetRequestLine (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RequestLine);
			}
#pragma warning restore 0169

			static IntPtr id_getRequestLine;
			public virtual unsafe global::Org.Apache.Http.IRequestLine RequestLine {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getRequestLine' and count(parameter)=0]"
				[Register ("getRequestLine", "()Lorg/apache/http/RequestLine;", "GetGetRequestLineHandler")]
				get {
					if (id_getRequestLine == IntPtr.Zero)
						id_getRequestLine = JNIEnv.GetMethodID (class_ref, "getRequestLine", "()Lorg/apache/http/RequestLine;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IRequestLine> (JNIEnv.CallObjectMethod  (Handle, id_getRequestLine), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IRequestLine> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestLine", "()Lorg/apache/http/RequestLine;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
				return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.AddHeader (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void AddHeader (string p0, string p1)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_addHeader_Lorg_apache_http_Header_;
#pragma warning disable 0169
			static Delegate GetAddHeader_Lorg_apache_http_Header_Handler ()
			{
				if (cb_addHeader_Lorg_apache_http_Header_ == null)
					cb_addHeader_Lorg_apache_http_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHeader_Lorg_apache_http_Header_);
				return cb_addHeader_Lorg_apache_http_Header_;
			}

			static void n_AddHeader_Lorg_apache_http_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.IHeader p0 = (global::Org.Apache.Http.IHeader)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddHeader (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addHeader_Lorg_apache_http_Header_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='addHeader' and count(parameter)=1 and parameter[1][@type='org.apache.http.Header']]"
			[Register ("addHeader", "(Lorg/apache/http/Header;)V", "GetAddHeader_Lorg_apache_http_Header_Handler")]
			public virtual unsafe void AddHeader (global::Org.Apache.Http.IHeader p0)
			{
				if (id_addHeader_Lorg_apache_http_Header_ == IntPtr.Zero)
					id_addHeader_Lorg_apache_http_Header_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Lorg/apache/http/Header;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_addHeader_Lorg_apache_http_Header_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Lorg/apache/http/Header;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_containsHeader_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetContainsHeader_Ljava_lang_String_Handler ()
			{
				if (cb_containsHeader_Ljava_lang_String_ == null)
					cb_containsHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsHeader_Ljava_lang_String_);
				return cb_containsHeader_Ljava_lang_String_;
			}

			static bool n_ContainsHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ContainsHeader (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_containsHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='containsHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("containsHeader", "(Ljava/lang/String;)Z", "GetContainsHeader_Ljava_lang_String_Handler")]
			public virtual unsafe bool ContainsHeader (string p0)
			{
				if (id_containsHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_containsHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "containsHeader", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsHeader_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsHeader", "(Ljava/lang/String;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getAllHeaders;
#pragma warning disable 0169
			static Delegate GetGetAllHeadersHandler ()
			{
				if (cb_getAllHeaders == null)
					cb_getAllHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllHeaders);
				return cb_getAllHeaders;
			}

			static IntPtr n_GetAllHeaders (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetAllHeaders ());
			}
#pragma warning restore 0169

			static IntPtr id_getAllHeaders;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getAllHeaders' and count(parameter)=0]"
			[Register ("getAllHeaders", "()[Lorg/apache/http/Header;", "GetGetAllHeadersHandler")]
			public virtual unsafe global::Org.Apache.Http.IHeader[] GetAllHeaders ()
			{
				if (id_getAllHeaders == IntPtr.Zero)
					id_getAllHeaders = JNIEnv.GetMethodID (class_ref, "getAllHeaders", "()[Lorg/apache/http/Header;");
				try {

					if (GetType () == ThresholdType)
						return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllHeaders), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
					else
						return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllHeaders", "()[Lorg/apache/http/Header;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
				} finally {
				}
			}

			static Delegate cb_getFirstHeader_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetFirstHeader_Ljava_lang_String_Handler ()
			{
				if (cb_getFirstHeader_Ljava_lang_String_ == null)
					cb_getFirstHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFirstHeader_Ljava_lang_String_);
				return cb_getFirstHeader_Ljava_lang_String_;
			}

			static IntPtr n_GetFirstHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFirstHeader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getFirstHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getFirstHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", "GetGetFirstHeader_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Http.IHeader GetFirstHeader (string p0)
			{
				if (id_getFirstHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_getFirstHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Org.Apache.Http.IHeader __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallObjectMethod  (Handle, id_getFirstHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getHeaders_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetHeaders_Ljava_lang_String_Handler ()
			{
				if (cb_getHeaders_Ljava_lang_String_ == null)
					cb_getHeaders_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeaders_Ljava_lang_String_);
				return cb_getHeaders_Ljava_lang_String_;
			}

			static IntPtr n_GetHeaders_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.GetHeaders (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getHeaders_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getHeaders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", "GetGetHeaders_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Http.IHeader[] GetHeaders (string p0)
			{
				if (id_getHeaders_Ljava_lang_String_ == IntPtr.Zero)
					id_getHeaders_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Org.Apache.Http.IHeader[] __ret;
					if (GetType () == ThresholdType)
						__ret = (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getHeaders_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
					else
						__ret = (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getLastHeader_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetLastHeader_Ljava_lang_String_Handler ()
			{
				if (cb_getLastHeader_Ljava_lang_String_ == null)
					cb_getLastHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLastHeader_Ljava_lang_String_);
				return cb_getLastHeader_Ljava_lang_String_;
			}

			static IntPtr n_GetLastHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLastHeader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getLastHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='getLastHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", "GetGetLastHeader_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Http.IHeader GetLastHeader (string p0)
			{
				if (id_getLastHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_getLastHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Org.Apache.Http.IHeader __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallObjectMethod  (Handle, id_getLastHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_headerIterator;
#pragma warning disable 0169
			static Delegate GetHeaderIteratorHandler ()
			{
				if (cb_headerIterator == null)
					cb_headerIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HeaderIterator);
				return cb_headerIterator;
			}

			static IntPtr n_HeaderIterator (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.HeaderIterator ());
			}
#pragma warning restore 0169

			static IntPtr id_headerIterator;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='headerIterator' and count(parameter)=0]"
			[Register ("headerIterator", "()Lorg/apache/http/HeaderIterator;", "GetHeaderIteratorHandler")]
			public virtual unsafe global::Org.Apache.Http.IHeaderIterator HeaderIterator ()
			{
				if (id_headerIterator == IntPtr.Zero)
					id_headerIterator = JNIEnv.GetMethodID (class_ref, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeaderIterator> (JNIEnv.CallObjectMethod  (Handle, id_headerIterator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeaderIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_headerIterator_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetHeaderIterator_Ljava_lang_String_Handler ()
			{
				if (cb_headerIterator_Ljava_lang_String_ == null)
					cb_headerIterator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HeaderIterator_Ljava_lang_String_);
				return cb_headerIterator_Ljava_lang_String_;
			}

			static IntPtr n_HeaderIterator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HeaderIterator (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_headerIterator_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='headerIterator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", "GetHeaderIterator_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Http.IHeaderIterator HeaderIterator (string p0)
			{
				if (id_headerIterator_Ljava_lang_String_ == IntPtr.Zero)
					id_headerIterator_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Org.Apache.Http.IHeaderIterator __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeaderIterator> (JNIEnv.CallObjectMethod  (Handle, id_headerIterator_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeaderIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_removeHeader_Lorg_apache_http_Header_;
#pragma warning disable 0169
			static Delegate GetRemoveHeader_Lorg_apache_http_Header_Handler ()
			{
				if (cb_removeHeader_Lorg_apache_http_Header_ == null)
					cb_removeHeader_Lorg_apache_http_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveHeader_Lorg_apache_http_Header_);
				return cb_removeHeader_Lorg_apache_http_Header_;
			}

			static void n_RemoveHeader_Lorg_apache_http_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.IHeader p0 = (global::Org.Apache.Http.IHeader)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RemoveHeader (p0);
			}
#pragma warning restore 0169

			static IntPtr id_removeHeader_Lorg_apache_http_Header_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='org.apache.http.Header']]"
			[Register ("removeHeader", "(Lorg/apache/http/Header;)V", "GetRemoveHeader_Lorg_apache_http_Header_Handler")]
			public virtual unsafe void RemoveHeader (global::Org.Apache.Http.IHeader p0)
			{
				if (id_removeHeader_Lorg_apache_http_Header_ == IntPtr.Zero)
					id_removeHeader_Lorg_apache_http_Header_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Lorg/apache/http/Header;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_removeHeader_Lorg_apache_http_Header_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeader", "(Lorg/apache/http/Header;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_removeHeaders_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemoveHeaders_Ljava_lang_String_Handler ()
			{
				if (cb_removeHeaders_Ljava_lang_String_ == null)
					cb_removeHeaders_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveHeaders_Ljava_lang_String_);
				return cb_removeHeaders_Ljava_lang_String_;
			}

			static void n_RemoveHeaders_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RemoveHeaders (p0);
			}
#pragma warning restore 0169

			static IntPtr id_removeHeaders_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='removeHeaders' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeaders", "(Ljava/lang/String;)V", "GetRemoveHeaders_Ljava_lang_String_Handler")]
			public virtual unsafe void RemoveHeaders (string p0)
			{
				if (id_removeHeaders_Ljava_lang_String_ == IntPtr.Zero)
					id_removeHeaders_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeHeaders", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_removeHeaders_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHeaders", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_setHeader_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeader_Ljava_lang_String_Ljava_lang_String_);
				return cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_SetHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.SetHeader (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void SetHeader (string p0, string p1)
			{
				if (id_setHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeader_Ljava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_setHeader_Lorg_apache_http_Header_;
#pragma warning disable 0169
			static Delegate GetSetHeader_Lorg_apache_http_Header_Handler ()
			{
				if (cb_setHeader_Lorg_apache_http_Header_ == null)
					cb_setHeader_Lorg_apache_http_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeader_Lorg_apache_http_Header_);
				return cb_setHeader_Lorg_apache_http_Header_;
			}

			static void n_SetHeader_Lorg_apache_http_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.IHeader p0 = (global::Org.Apache.Http.IHeader)global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetHeader (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setHeader_Lorg_apache_http_Header_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='setHeader' and count(parameter)=1 and parameter[1][@type='org.apache.http.Header']]"
			[Register ("setHeader", "(Lorg/apache/http/Header;)V", "GetSetHeader_Lorg_apache_http_Header_Handler")]
			public virtual unsafe void SetHeader (global::Org.Apache.Http.IHeader p0)
			{
				if (id_setHeader_Lorg_apache_http_Header_ == IntPtr.Zero)
					id_setHeader_Lorg_apache_http_Header_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Lorg/apache/http/Header;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeader_Lorg_apache_http_Header_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Lorg/apache/http/Header;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setHeaders_arrayLorg_apache_http_Header_;
#pragma warning disable 0169
			static Delegate GetSetHeaders_arrayLorg_apache_http_Header_Handler ()
			{
				if (cb_setHeaders_arrayLorg_apache_http_Header_ == null)
					cb_setHeaders_arrayLorg_apache_http_Header_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_arrayLorg_apache_http_Header_);
				return cb_setHeaders_arrayLorg_apache_http_Header_;
			}

			static void n_SetHeaders_arrayLorg_apache_http_Header_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest.HttpRequestWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Apache.Http.IHeader[] p0 = (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Apache.Http.IHeader));
				__this.SetHeaders (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_setHeaders_arrayLorg_apache_http_Header_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest.HttpRequestWrapper']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='org.apache.http.Header[]']]"
			[Register ("setHeaders", "([Lorg/apache/http/Header;)V", "GetSetHeaders_arrayLorg_apache_http_Header_Handler")]
			public virtual unsafe void SetHeaders (global::Org.Apache.Http.IHeader[] p0)
			{
				if (id_setHeaders_arrayLorg_apache_http_Header_ == IntPtr.Zero)
					id_setHeaders_arrayLorg_apache_http_Header_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "([Lorg/apache/http/Header;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeaders_arrayLorg_apache_http_Header_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaders", "([Lorg/apache/http/Header;)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpRequest); }
		}

		protected AsyncHttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/constructor[@name='AsyncHttpRequest' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/net/Uri;Ljava/lang/String;)V", "")]
		public unsafe AsyncHttpRequest (global::Android.Net.Uri p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (AsyncHttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_net_Uri_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/constructor[@name='AsyncHttpRequest' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.http.Headers']]"
		[Register (".ctor", "(Landroid/net/Uri;Ljava/lang/String;Lcom/koushikdutta/async/http/Headers;)V", "")]
		public unsafe AsyncHttpRequest (global::Android.Net.Uri p0, string p1, global::Com.Koushikdutta.Async.Http.Headers p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AsyncHttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/net/Uri;Ljava/lang/String;Lcom/koushikdutta/async/http/Headers;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/net/Uri;Ljava/lang/String;Lcom/koushikdutta/async/http/Headers;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_Uri_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Ljava/lang/String;Lcom/koushikdutta/async/http/Headers;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_net_Uri_Ljava_lang_String_Lcom_koushikdutta_async_http_Headers_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static Delegate cb_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_;
#pragma warning disable 0169
		static Delegate GetSetBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_Handler ()
		{
			if (cb_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_ == null)
				cb_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_);
			return cb_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_;
		}

		static void n_SetBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody p0 = (global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Body = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		static IntPtr id_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.body.AsyncHttpRequestBody']]"
			[Register ("setBody", "(Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;)V", "GetSetBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_Handler")]
			set {
				if (id_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_ == IntPtr.Zero)
					id_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_ = JNIEnv.GetMethodID (class_ref, "setBody", "(Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBody_Lcom_koushikdutta_async_http_body_AsyncHttpRequestBody_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBody", "(Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getDefaultUserAgent;
		protected static unsafe string DefaultUserAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getDefaultUserAgent' and count(parameter)=0]"
			[Register ("getDefaultUserAgent", "()Ljava/lang/String;", "GetGetDefaultUserAgentHandler")]
			get {
				if (id_getDefaultUserAgent == IntPtr.Zero)
					id_getDefaultUserAgent = JNIEnv.GetStaticMethodID (class_ref, "getDefaultUserAgent", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultUserAgent), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFollowRedirect;
#pragma warning disable 0169
		static Delegate GetGetFollowRedirectHandler ()
		{
			if (cb_getFollowRedirect == null)
				cb_getFollowRedirect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetFollowRedirect);
			return cb_getFollowRedirect;
		}

		static bool n_GetFollowRedirect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FollowRedirect;
		}
#pragma warning restore 0169

		static IntPtr id_getFollowRedirect;
		public virtual unsafe bool FollowRedirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getFollowRedirect' and count(parameter)=0]"
			[Register ("getFollowRedirect", "()Z", "GetGetFollowRedirectHandler")]
			get {
				if (id_getFollowRedirect == IntPtr.Zero)
					id_getFollowRedirect = JNIEnv.GetMethodID (class_ref, "getFollowRedirect", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getFollowRedirect);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFollowRedirect", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Lcom/koushikdutta/async/http/Headers;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Lcom/koushikdutta/async/http/Headers;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Lcom/koushikdutta/async/http/Headers;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLogLevel;
#pragma warning disable 0169
		static Delegate GetGetLogLevelHandler ()
		{
			if (cb_getLogLevel == null)
				cb_getLogLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLogLevel);
			return cb_getLogLevel;
		}

		static int n_GetLogLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getLogLevel;
		public virtual unsafe int LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()I", "GetGetLogLevelHandler")]
			get {
				if (id_getLogLevel == IntPtr.Zero)
					id_getLogLevel = JNIEnv.GetMethodID (class_ref, "getLogLevel", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLogLevel);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogLevel", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLogTag;
#pragma warning disable 0169
		static Delegate GetGetLogTagHandler ()
		{
			if (cb_getLogTag == null)
				cb_getLogTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogTag);
			return cb_getLogTag;
		}

		static IntPtr n_GetLogTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LogTag);
		}
#pragma warning restore 0169

		static IntPtr id_getLogTag;
		public virtual unsafe string LogTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getLogTag' and count(parameter)=0]"
			[Register ("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")]
			get {
				if (id_getLogTag == IntPtr.Zero)
					id_getLogTag = JNIEnv.GetMethodID (class_ref, "getLogTag", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLogTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		public virtual unsafe string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProxyHost;
#pragma warning disable 0169
		static Delegate GetGetProxyHostHandler ()
		{
			if (cb_getProxyHost == null)
				cb_getProxyHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProxyHost);
			return cb_getProxyHost;
		}

		static IntPtr n_GetProxyHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProxyHost);
		}
#pragma warning restore 0169

		static IntPtr id_getProxyHost;
		public virtual unsafe string ProxyHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getProxyHost' and count(parameter)=0]"
			[Register ("getProxyHost", "()Ljava/lang/String;", "GetGetProxyHostHandler")]
			get {
				if (id_getProxyHost == IntPtr.Zero)
					id_getProxyHost = JNIEnv.GetMethodID (class_ref, "getProxyHost", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getProxyHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProxyHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProxyPort;
#pragma warning disable 0169
		static Delegate GetGetProxyPortHandler ()
		{
			if (cb_getProxyPort == null)
				cb_getProxyPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProxyPort);
			return cb_getProxyPort;
		}

		static int n_GetProxyPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProxyPort;
		}
#pragma warning restore 0169

		static IntPtr id_getProxyPort;
		public virtual unsafe int ProxyPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getProxyPort' and count(parameter)=0]"
			[Register ("getProxyPort", "()I", "GetGetProxyPortHandler")]
			get {
				if (id_getProxyPort == IntPtr.Zero)
					id_getProxyPort = JNIEnv.GetMethodID (class_ref, "getProxyPort", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getProxyPort);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProxyPort", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRequestLine;
#pragma warning disable 0169
		static Delegate GetGetRequestLineHandler ()
		{
			if (cb_getRequestLine == null)
				cb_getRequestLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestLine);
			return cb_getRequestLine;
		}

		static IntPtr n_GetRequestLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestLine);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestLine;
		public virtual unsafe global::Org.Apache.Http.IRequestLine RequestLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getRequestLine' and count(parameter)=0]"
			[Register ("getRequestLine", "()Lorg/apache/http/RequestLine;", "GetGetRequestLineHandler")]
			get {
				if (id_getRequestLine == IntPtr.Zero)
					id_getRequestLine = JNIEnv.GetMethodID (class_ref, "getRequestLine", "()Lorg/apache/http/RequestLine;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IRequestLine> (JNIEnv.CallObjectMethod  (Handle, id_getRequestLine), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IRequestLine> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestLine", "()Lorg/apache/http/RequestLine;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUri;
#pragma warning disable 0169
		static Delegate GetGetUriHandler ()
		{
			if (cb_getUri == null)
				cb_getUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUri);
			return cb_getUri;
		}

		static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Uri);
		}
#pragma warning restore 0169

		static IntPtr id_getUri;
		public virtual unsafe global::Android.Net.Uri Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Landroid/net/Uri;", "GetGetUriHandler")]
			get {
				if (id_getUri == IntPtr.Zero)
					id_getUri = JNIEnv.GetMethodID (class_ref, "getUri", "()Landroid/net/Uri;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod  (Handle, id_getUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_asHttpRequest;
#pragma warning disable 0169
		static Delegate GetAsHttpRequestHandler ()
		{
			if (cb_asHttpRequest == null)
				cb_asHttpRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsHttpRequest);
			return cb_asHttpRequest;
		}

		static IntPtr n_AsHttpRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsHttpRequest ());
		}
#pragma warning restore 0169

		static IntPtr id_asHttpRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='asHttpRequest' and count(parameter)=0]"
		[Register ("asHttpRequest", "()Lorg/apache/http/HttpRequest;", "GetAsHttpRequestHandler")]
		public virtual unsafe global::Org.Apache.Http.IHttpRequest AsHttpRequest ()
		{
			if (id_asHttpRequest == IntPtr.Zero)
				id_asHttpRequest = JNIEnv.GetMethodID (class_ref, "asHttpRequest", "()Lorg/apache/http/HttpRequest;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_asHttpRequest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.IHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asHttpRequest", "()Lorg/apache/http/HttpRequest;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_Lorg_apache_http_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.apache.http.HttpRequest']]"
		[Register ("create", "(Lorg/apache/http/HttpRequest;)Lcom/koushikdutta/async/http/AsyncHttpRequest;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest Create (global::Org.Apache.Http.IHttpRequest p0)
		{
			if (id_create_Lorg_apache_http_HttpRequest_ == IntPtr.Zero)
				id_create_Lorg_apache_http_HttpRequest_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorg/apache/http/HttpRequest;)Lcom/koushikdutta/async/http/AsyncHttpRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorg_apache_http_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_disableProxy;
#pragma warning disable 0169
		static Delegate GetDisableProxyHandler ()
		{
			if (cb_disableProxy == null)
				cb_disableProxy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableProxy);
			return cb_disableProxy;
		}

		static void n_DisableProxy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableProxy ();
		}
#pragma warning restore 0169

		static IntPtr id_disableProxy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='disableProxy' and count(parameter)=0]"
		[Register ("disableProxy", "()V", "GetDisableProxyHandler")]
		public virtual unsafe void DisableProxy ()
		{
			if (id_disableProxy == IntPtr.Zero)
				id_disableProxy = JNIEnv.GetMethodID (class_ref, "disableProxy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableProxy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableProxy", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableProxy_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetEnableProxy_Ljava_lang_String_IHandler ()
		{
			if (cb_enableProxy_Ljava_lang_String_I == null)
				cb_enableProxy_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_EnableProxy_Ljava_lang_String_I);
			return cb_enableProxy_Ljava_lang_String_I;
		}

		static void n_EnableProxy_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableProxy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enableProxy_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='enableProxy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("enableProxy", "(Ljava/lang/String;I)V", "GetEnableProxy_Ljava_lang_String_IHandler")]
		public virtual unsafe void EnableProxy (string p0, int p1)
		{
			if (id_enableProxy_Ljava_lang_String_I == IntPtr.Zero)
				id_enableProxy_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "enableProxy", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableProxy_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableProxy", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogd_Ljava_lang_String_Handler ()
		{
			if (cb_logd_Ljava_lang_String_ == null)
				cb_logd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Logd_Ljava_lang_String_);
			return cb_logd_Ljava_lang_String_;
		}

		static void n_Logd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logd_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='logd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logd", "(Ljava/lang/String;)V", "GetLogd_Ljava_lang_String_Handler")]
		public virtual unsafe void Logd (string p0)
		{
			if (id_logd_Ljava_lang_String_ == IntPtr.Zero)
				id_logd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logd_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logd", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logd_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetLogd_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_logd_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_logd_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Logd_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_logd_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_Logd_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Logd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_logd_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='logd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("logd", "(Ljava/lang/String;Ljava/lang/Exception;)V", "GetLogd_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		public virtual unsafe void Logd (string p0, global::Java.Lang.Exception p1)
		{
			if (id_logd_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_logd_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "logd", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logd_Ljava_lang_String_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logd", "(Ljava/lang/String;Ljava/lang/Exception;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loge_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoge_Ljava_lang_String_Handler ()
		{
			if (cb_loge_Ljava_lang_String_ == null)
				cb_loge_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Loge_Ljava_lang_String_);
			return cb_loge_Ljava_lang_String_;
		}

		static void n_Loge_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Loge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loge_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='loge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loge", "(Ljava/lang/String;)V", "GetLoge_Ljava_lang_String_Handler")]
		public virtual unsafe void Loge (string p0)
		{
			if (id_loge_Ljava_lang_String_ == IntPtr.Zero)
				id_loge_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loge", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loge_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loge", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loge_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetLoge_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_loge_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_loge_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Loge_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_loge_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_Loge_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Loge (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loge_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='loge' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("loge", "(Ljava/lang/String;Ljava/lang/Exception;)V", "GetLoge_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		public virtual unsafe void Loge (string p0, global::Java.Lang.Exception p1)
		{
			if (id_loge_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_loge_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "loge", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loge_Ljava_lang_String_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loge", "(Ljava/lang/String;Ljava/lang/Exception;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogi_Ljava_lang_String_Handler ()
		{
			if (cb_logi_Ljava_lang_String_ == null)
				cb_logi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Logi_Ljava_lang_String_);
			return cb_logi_Ljava_lang_String_;
		}

		static void n_Logi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logi (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logi_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='logi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logi", "(Ljava/lang/String;)V", "GetLogi_Ljava_lang_String_Handler")]
		public virtual unsafe void Logi (string p0)
		{
			if (id_logi_Ljava_lang_String_ == IntPtr.Zero)
				id_logi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logi", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logi_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logi", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logv_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogv_Ljava_lang_String_Handler ()
		{
			if (cb_logv_Ljava_lang_String_ == null)
				cb_logv_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Logv_Ljava_lang_String_);
			return cb_logv_Ljava_lang_String_;
		}

		static void n_Logv_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logv (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logv_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='logv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logv", "(Ljava/lang/String;)V", "GetLogv_Ljava_lang_String_Handler")]
		public virtual unsafe void Logv (string p0)
		{
			if (id_logv_Ljava_lang_String_ == IntPtr.Zero)
				id_logv_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logv", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logv_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logv", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logw_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogw_Ljava_lang_String_Handler ()
		{
			if (cb_logw_Ljava_lang_String_ == null)
				cb_logw_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Logw_Ljava_lang_String_);
			return cb_logw_Ljava_lang_String_;
		}

		static void n_Logw_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logw_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='logw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logw", "(Ljava/lang/String;)V", "GetLogw_Ljava_lang_String_Handler")]
		public virtual unsafe void Logw (string p0)
		{
			if (id_logw_Ljava_lang_String_ == IntPtr.Zero)
				id_logw_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logw", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_logw_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logw", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_;
#pragma warning disable 0169
		static Delegate GetOnHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_Handler ()
		{
			if (cb_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_ == null)
				cb_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_);
			return cb_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_;
		}

		static void n_OnHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.AsyncSSLException p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandshakeException (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='onHandshakeException' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.AsyncSSLException']]"
		[Register ("onHandshakeException", "(Lcom/koushikdutta/async/AsyncSSLException;)V", "GetOnHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_Handler")]
		public virtual unsafe void OnHandshakeException (global::Com.Koushikdutta.Async.AsyncSSLException p0)
		{
			if (id_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_ == IntPtr.Zero)
				id_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_ = JNIEnv.GetMethodID (class_ref, "onHandshakeException", "(Lcom/koushikdutta/async/AsyncSSLException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onHandshakeException_Lcom_koushikdutta_async_AsyncSSLException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandshakeException", "(Lcom/koushikdutta/async/AsyncSSLException;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setDefaultHeaders_Lcom_koushikdutta_async_http_Headers_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setDefaultHeaders' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.Headers'] and parameter[2][@type='android.net.Uri']]"
		[Register ("setDefaultHeaders", "(Lcom/koushikdutta/async/http/Headers;Landroid/net/Uri;)V", "")]
		public static unsafe void SetDefaultHeaders (global::Com.Koushikdutta.Async.Http.Headers p0, global::Android.Net.Uri p1)
		{
			if (id_setDefaultHeaders_Lcom_koushikdutta_async_http_Headers_Landroid_net_Uri_ == IntPtr.Zero)
				id_setDefaultHeaders_Lcom_koushikdutta_async_http_Headers_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultHeaders", "(Lcom/koushikdutta/async/http/Headers;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultHeaders_Lcom_koushikdutta_async_http_Headers_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static Delegate cb_setFollowRedirect_Z;
#pragma warning disable 0169
		static Delegate GetSetFollowRedirect_ZHandler ()
		{
			if (cb_setFollowRedirect_Z == null)
				cb_setFollowRedirect_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetFollowRedirect_Z);
			return cb_setFollowRedirect_Z;
		}

		static IntPtr n_SetFollowRedirect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFollowRedirect (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setFollowRedirect_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setFollowRedirect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFollowRedirect", "(Z)Lcom/koushikdutta/async/http/AsyncHttpRequest;", "GetSetFollowRedirect_ZHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest SetFollowRedirect (bool p0)
		{
			if (id_setFollowRedirect_Z == IntPtr.Zero)
				id_setFollowRedirect_Z = JNIEnv.GetMethodID (class_ref, "setFollowRedirect", "(Z)Lcom/koushikdutta/async/http/AsyncHttpRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_setFollowRedirect_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFollowRedirect", "(Z)Lcom/koushikdutta/async/http/AsyncHttpRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SetHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;", "GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest SetHeader (string p0, string p1)
		{
			if (id_setHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_setHeader_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setLogging_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetLogging_Ljava_lang_String_IHandler ()
		{
			if (cb_setLogging_Ljava_lang_String_I == null)
				cb_setLogging_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetLogging_Ljava_lang_String_I);
			return cb_setLogging_Ljava_lang_String_I;
		}

		static void n_SetLogging_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogging (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLogging_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setLogging' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setLogging", "(Ljava/lang/String;I)V", "GetSetLogging_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetLogging (string p0, int p1)
		{
			if (id_setLogging_Ljava_lang_String_I == IntPtr.Zero)
				id_setLogging_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setLogging", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLogging_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogging", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setMethod_Ljava_lang_String_ == null)
				cb_setMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMethod_Ljava_lang_String_);
			return cb_setMethod_Ljava_lang_String_;
		}

		static IntPtr n_SetMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMethod (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMethod_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMethod", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;", "GetSetMethod_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest SetMethod (string p0)
		{
			if (id_setMethod_Ljava_lang_String_ == IntPtr.Zero)
				id_setMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMethod", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_setMethod_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMethod", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static IntPtr n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeout (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpRequest']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)Lcom/koushikdutta/async/http/AsyncHttpRequest;", "GetSetTimeout_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)Lcom/koushikdutta/async/http/AsyncHttpRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_setTimeout_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)Lcom/koushikdutta/async/http/AsyncHttpRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
