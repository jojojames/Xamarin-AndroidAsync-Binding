using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Body {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']"
	[Register ("com/koushikdutta/async/http/body/AsyncHttpRequestBody", "", "Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker")]
	public partial interface IAsyncHttpRequestBody : IJavaObject {

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler:Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker, AndroidAsyncBinding")]
		global::Java.Lang.Object Get ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler:Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker, AndroidAsyncBinding")]
		int Length ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("parse", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetParse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_Handler:Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker, AndroidAsyncBinding")]
		void Parse (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']/method[@name='readFullyOnRequest' and count(parameter)=0]"
		[Register ("readFullyOnRequest", "()Z", "GetReadFullyOnRequestHandler:Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker, AndroidAsyncBinding")]
		bool ReadFullyOnRequest ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/interface[@name='AsyncHttpRequestBody']/method[@name='write' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpRequest'] and parameter[2][@type='com.koushikdutta.async.DataSink'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("write", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetWrite_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_Handler:Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBodyInvoker, AndroidAsyncBinding")]
		void Write (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0, global::Com.Koushikdutta.Async.IDataSink p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/body/AsyncHttpRequestBody", DoNotGenerateAcw=true)]
	internal class IAsyncHttpRequestBodyInvoker : global::Java.Lang.Object, IAsyncHttpRequestBody {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/body/AsyncHttpRequestBody");
		IntPtr class_ref;

		public static IAsyncHttpRequestBody GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHttpRequestBody> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.body.AsyncHttpRequestBody"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHttpRequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncHttpRequestBodyInvoker); }
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
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_get), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		IntPtr id_length;
		public unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			return JNIEnv.CallIntMethod (Handle, id_length);
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
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Parse (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe void Parse (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1)
		{
			if (id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_parse_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
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
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadFullyOnRequest ();
		}
#pragma warning restore 0169

		IntPtr id_readFullyOnRequest;
		public unsafe bool ReadFullyOnRequest ()
		{
			if (id_readFullyOnRequest == IntPtr.Zero)
				id_readFullyOnRequest = JNIEnv.GetMethodID (class_ref, "readFullyOnRequest", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_readFullyOnRequest);
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
			global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p1 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe void Write (global::Com.Koushikdutta.Async.Http.AsyncHttpRequest p0, global::Com.Koushikdutta.Async.IDataSink p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/http/AsyncHttpRequest;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_write_Lcom_koushikdutta_async_http_AsyncHttpRequest_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
		}

	}

}
