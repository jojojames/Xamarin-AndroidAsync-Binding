using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Body {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/body/StringBody", DoNotGenerateAcw=true)]
	public partial class StringBody : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/body/StringBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringBody); }
		}

		protected StringBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/constructor[@name='StringBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StringBody)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/constructor[@name='StringBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe StringBody (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (StringBody)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.StringBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StringBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.StringBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StringBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Get ());
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/String;", "GetGetHandler")]
		public virtual unsafe string Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_get), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.StringBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StringBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public virtual unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			} finally {
			}
		}

		static Delegate cb_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_Parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Body.StringBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StringBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("parse", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetParse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
		public virtual unsafe void Parse (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1)
		{
			if (id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readFullyOnRequest;
#pragma warning disable 0169
		static Delegate GetReadFullyOnRequestHandler ()
		{
			if (cb_readFullyOnRequest == null)
				cb_readFullyOnRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ReadFullyOnRequest);
			return cb_readFullyOnRequest;
		}

		static bool n_ReadFullyOnRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.StringBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StringBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadFullyOnRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_readFullyOnRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/method[@name='readFullyOnRequest' and count(parameter)=0]"
		[Register ("readFullyOnRequest", "()Z", "GetReadFullyOnRequestHandler")]
		public virtual unsafe bool ReadFullyOnRequest ()
		{
			if (id_readFullyOnRequest == IntPtr.Zero)
				id_readFullyOnRequest = JNIEnv.GetMethodID (class_ref, "readFullyOnRequest", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_readFullyOnRequest);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFullyOnRequest", "()Z"));
			} finally {
			}
		}

		static Delegate cb_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_Write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Body.StringBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.StringBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p1 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='StringBody']/method[@name='write' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpRequest'] and parameter[2][@type='com.koushikdutta.async.DataSink'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("write", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetWrite_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
		public virtual unsafe void Write (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0, global::Com.Koushikdutta.Async.IDataSink p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody
		global::Java.Lang.Object global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody.Get ()
		{
			return Get ().ToString ();
		}

	}
}
