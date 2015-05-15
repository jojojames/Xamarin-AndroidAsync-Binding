using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Server {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']"
	[Register ("com/koushikdutta/async/http/server/AsyncHttpServerResponse", "", "Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker")]
	public partial interface IAsyncHttpServerResponse : global::Com.Koushikdutta.Async.IDataSink, global::Com.Koushikdutta.Async.Callback.ICompletedCallback {

		global::Com.Koushikdutta.Async.Http.Headers Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Lcom/koushikdutta/async/http/Headers;", "GetGetHeadersHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetGetSocketHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "GetCodeHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		int Code ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='code' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("code", "(I)Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;", "GetCode_IHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse Code (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void End ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;)V", "GetOnCompleted_Ljava_lang_Exception_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void OnCompleted (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='proxy' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpResponse']]"
		[Register ("proxy", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V", "GetProxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void Proxy (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='redirect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("redirect", "(Ljava/lang/String;)V", "GetRedirect_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void Redirect (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void Send (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='send' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void Send (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='send' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("send", "(Lorg/json/JSONObject;)V", "GetSend_Lorg_json_JSONObject_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void Send (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='sendFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("sendFile", "(Ljava/io/File;)V", "GetSendFile_Ljava_io_File_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void SendFile (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='sendStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("sendStream", "(Ljava/io/InputStream;J)V", "GetSendStream_Ljava_io_InputStream_JHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void SendStream (global::System.IO.Stream p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void SetContentType (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerResponse']/method[@name='writeHead' and count(parameter)=0]"
		[Register ("writeHead", "()V", "GetWriteHeadHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponseInvoker, AndroidAsyncBinding")]
		void WriteHead ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncHttpServerResponse", DoNotGenerateAcw=true)]
	internal class IAsyncHttpServerResponseInvoker : global::Java.Lang.Object, IAsyncHttpServerResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/server/AsyncHttpServerResponse");
		IntPtr class_ref;

		public static IAsyncHttpServerResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHttpServerResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.server.AsyncHttpServerResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHttpServerResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncHttpServerResponseInvoker); }
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		IntPtr id_getHeaders;
		public unsafe global::Com.Koushikdutta.Async.Http.Headers Headers {
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Lcom/koushikdutta/async/http/Headers;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSocket;
#pragma warning disable 0169
		static Delegate GetGetSocketHandler ()
		{
			if (cb_getSocket == null)
				cb_getSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocket);
			return cb_getSocket;
		}

		static IntPtr n_GetSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		IntPtr id_getSocket;
		public unsafe global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Lcom/koushikdutta/async/AsyncSocket;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallObjectMethod (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_code;
#pragma warning disable 0169
		static Delegate GetCodeHandler ()
		{
			if (cb_code == null)
				cb_code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Code);
			return cb_code;
		}

		static int n_Code (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code ();
		}
#pragma warning restore 0169

		IntPtr id_code;
		public unsafe int Code ()
		{
			if (id_code == IntPtr.Zero)
				id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
			return JNIEnv.CallIntMethod (Handle, id_code);
		}

		static Delegate cb_code_I;
#pragma warning disable 0169
		static Delegate GetCode_IHandler ()
		{
			if (cb_code_I == null)
				cb_code_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Code_I);
			return cb_code_I;
		}

		static IntPtr n_Code_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Code (p0));
		}
#pragma warning restore 0169

		IntPtr id_code_I;
		public unsafe global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse Code (int p0)
		{
			if (id_code_I == IntPtr.Zero)
				id_code_I = JNIEnv.GetMethodID (class_ref, "code", "(I)Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (JNIEnv.CallObjectMethod (Handle, id_code_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		IntPtr id_end;
		public unsafe void End ()
		{
			if (id_end == IntPtr.Zero)
				id_end = JNIEnv.GetMethodID (class_ref, "end", "()V");
			JNIEnv.CallVoidMethod (Handle, id_end);
		}

		static Delegate cb_onCompleted_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Exception_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Exception_ == null)
				cb_onCompleted_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_);
			return cb_onCompleted_Ljava_lang_Exception_;
		}

		static void n_OnCompleted_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Ljava_lang_Exception_;
		public unsafe void OnCompleted (global::Java.Lang.Exception p0)
		{
			if (id_onCompleted_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
#pragma warning disable 0169
		static Delegate GetProxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_Handler ()
		{
			if (cb_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ == null)
				cb_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_);
			return cb_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
		}

		static void n_Proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0 = (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Proxy (p0);
		}
#pragma warning restore 0169

		IntPtr id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
		public unsafe void Proxy (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0)
		{
			if (id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ == IntPtr.Zero)
				id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ = JNIEnv.GetMethodID (class_ref, "proxy", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_, __args);
		}

		static Delegate cb_redirect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRedirect_Ljava_lang_String_Handler ()
		{
			if (cb_redirect_Ljava_lang_String_ == null)
				cb_redirect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Redirect_Ljava_lang_String_);
			return cb_redirect_Ljava_lang_String_;
		}

		static void n_Redirect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Redirect (p0);
		}
#pragma warning restore 0169

		IntPtr id_redirect_Ljava_lang_String_;
		public unsafe void Redirect (string p0)
		{
			if (id_redirect_Ljava_lang_String_ == IntPtr.Zero)
				id_redirect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "redirect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_redirect_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_;
		public unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_send_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_send_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Send (string p0, string p1)
		{
			if (id_send_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_send_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_send_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSend_Lorg_json_JSONObject_Handler ()
		{
			if (cb_send_Lorg_json_JSONObject_ == null)
				cb_send_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lorg_json_JSONObject_);
			return cb_send_Lorg_json_JSONObject_;
		}

		static void n_Send_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		IntPtr id_send_Lorg_json_JSONObject_;
		public unsafe void Send (global::Org.Json.JSONObject p0)
		{
			if (id_send_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_send_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "send", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_send_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_sendFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSendFile_Ljava_io_File_Handler ()
		{
			if (cb_sendFile_Ljava_io_File_ == null)
				cb_sendFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFile_Ljava_io_File_);
			return cb_sendFile_Ljava_io_File_;
		}

		static void n_SendFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendFile (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendFile_Ljava_io_File_;
		public unsafe void SendFile (global::Java.IO.File p0)
		{
			if (id_sendFile_Ljava_io_File_ == IntPtr.Zero)
				id_sendFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "sendFile", "(Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_sendFile_Ljava_io_File_, __args);
		}

		static Delegate cb_sendStream_Ljava_io_InputStream_J;
#pragma warning disable 0169
		static Delegate GetSendStream_Ljava_io_InputStream_JHandler ()
		{
			if (cb_sendStream_Ljava_io_InputStream_J == null)
				cb_sendStream_Ljava_io_InputStream_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SendStream_Ljava_io_InputStream_J);
			return cb_sendStream_Ljava_io_InputStream_J;
		}

		static void n_SendStream_Ljava_io_InputStream_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendStream (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendStream_Ljava_io_InputStream_J;
		public unsafe void SendStream (global::System.IO.Stream p0, long p1)
		{
			if (id_sendStream_Ljava_io_InputStream_J == IntPtr.Zero)
				id_sendStream_Ljava_io_InputStream_J = JNIEnv.GetMethodID (class_ref, "sendStream", "(Ljava/io/InputStream;J)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_sendStream_Ljava_io_InputStream_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentType (p0);
		}
#pragma warning restore 0169

		IntPtr id_setContentType_Ljava_lang_String_;
		public unsafe void SetContentType (string p0)
		{
			if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_setContentType_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writeHead;
#pragma warning disable 0169
		static Delegate GetWriteHeadHandler ()
		{
			if (cb_writeHead == null)
				cb_writeHead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteHead);
			return cb_writeHead;
		}

		static void n_WriteHead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteHead ();
		}
#pragma warning restore 0169

		IntPtr id_writeHead;
		public unsafe void WriteHead ()
		{
			if (id_writeHead == IntPtr.Zero)
				id_writeHead = JNIEnv.GetMethodID (class_ref, "writeHead", "()V");
			JNIEnv.CallVoidMethod (Handle, id_writeHead);
		}

		static Delegate cb_getClosedCallback;
#pragma warning disable 0169
		static Delegate GetGetClosedCallbackHandler ()
		{
			if (cb_getClosedCallback == null)
				cb_getClosedCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClosedCallback);
			return cb_getClosedCallback;
		}

		static IntPtr n_GetClosedCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClosedCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_SetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getClosedCallback;
		IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			get {
				if (id_getClosedCallback == IntPtr.Zero)
					id_getClosedCallback = JNIEnv.GetMethodID (class_ref, "getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod (Handle, id_getClosedCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			}
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe bool IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isOpen);
			}
		}

		static Delegate cb_getServer;
#pragma warning disable 0169
		static Delegate GetGetServerHandler ()
		{
			if (cb_getServer == null)
				cb_getServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServer);
			return cb_getServer;
		}

		static IntPtr n_GetServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		IntPtr id_getServer;
		public unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/koushikdutta/async/AsyncServer;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallObjectMethod (Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWriteableCallback;
#pragma warning disable 0169
		static Delegate GetGetWriteableCallbackHandler ()
		{
			if (cb_getWriteableCallback == null)
				cb_getWriteableCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWriteableCallback);
			return cb_getWriteableCallback;
		}

		static IntPtr n_GetWriteableCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WriteableCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
#pragma warning disable 0169
		static Delegate GetSetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_Handler ()
		{
			if (cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ == null)
				cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_);
			return cb_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		}

		static void n_SetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getWriteableCallback;
		IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			get {
				if (id_getWriteableCallback == IntPtr.Zero)
					id_getWriteableCallback = JNIEnv.GetMethodID (class_ref, "getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (JNIEnv.CallObjectMethod (Handle, id_getWriteableCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ == IntPtr.Zero)
					id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ = JNIEnv.GetMethodID (class_ref, "setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_, __args);
			}
		}

		static Delegate cb_write_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_write_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_write_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_write_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static void n_Write_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		public unsafe void Write (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_write_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_write_Lcom_koushikdutta_async_ByteBufferList_, __args);
		}

	}

}
