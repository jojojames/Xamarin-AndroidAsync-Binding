using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']"
	[Register ("com/koushikdutta/async/http/AsyncHttpResponse", "", "Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker")]
	public partial interface IAsyncHttpResponse : global::Com.Koushikdutta.Async.IDataEmitter {

		global::Com.Koushikdutta.Async.Http.AsyncHttpRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/koushikdutta/async/http/AsyncHttpRequest;", "GetGetRequestHandler:Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "GetCodeHandler:Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker, AndroidAsyncBinding")]
		int Code ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']/method[@name='detachSocket' and count(parameter)=0]"
		[Register ("detachSocket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetDetachSocketHandler:Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.IAsyncSocket DetachSocket ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']/method[@name='headers' and count(parameter)=0]"
		[Register ("headers", "()Lcom/koushikdutta/async/http/Headers;", "GetHeadersHandler:Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.Headers Headers ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "GetMessageHandler:Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker, AndroidAsyncBinding")]
		string Message ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpResponse']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Ljava/lang/String;", "GetProtocolHandler:Com.Koushikdutta.Async.Http.IAsyncHttpResponseInvoker, AndroidAsyncBinding")]
		string Protocol ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpResponse", DoNotGenerateAcw=true)]
	internal class IAsyncHttpResponseInvoker : global::Java.Lang.Object, IAsyncHttpResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpResponse");
		IntPtr class_ref;

		public static IAsyncHttpResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHttpResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.AsyncHttpResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHttpResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncHttpResponseInvoker); }
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		IntPtr id_getRequest;
		public unsafe global::Com.Koushikdutta.Async.Http.AsyncHttpRequest Request {
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/koushikdutta/async/http/AsyncHttpRequest;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (JNIEnv.CallObjectMethod (Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_detachSocket;
#pragma warning disable 0169
		static Delegate GetDetachSocketHandler ()
		{
			if (cb_detachSocket == null)
				cb_detachSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DetachSocket);
			return cb_detachSocket;
		}

		static IntPtr n_DetachSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DetachSocket ());
		}
#pragma warning restore 0169

		IntPtr id_detachSocket;
		public unsafe global::Com.Koushikdutta.Async.IAsyncSocket DetachSocket ()
		{
			if (id_detachSocket == IntPtr.Zero)
				id_detachSocket = JNIEnv.GetMethodID (class_ref, "detachSocket", "()Lcom/koushikdutta/async/AsyncSocket;");
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallObjectMethod (Handle, id_detachSocket), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_headers;
#pragma warning disable 0169
		static Delegate GetHeadersHandler ()
		{
			if (cb_headers == null)
				cb_headers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Headers);
			return cb_headers;
		}

		static IntPtr n_Headers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Headers ());
		}
#pragma warning restore 0169

		IntPtr id_headers;
		public unsafe global::Com.Koushikdutta.Async.Http.Headers Headers ()
		{
			if (id_headers == IntPtr.Zero)
				id_headers = JNIEnv.GetMethodID (class_ref, "headers", "()Lcom/koushikdutta/async/http/Headers;");
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod (Handle, id_headers), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_message;
#pragma warning disable 0169
		static Delegate GetMessageHandler ()
		{
			if (cb_message == null)
				cb_message = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Message);
			return cb_message;
		}

		static IntPtr n_Message (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message ());
		}
#pragma warning restore 0169

		IntPtr id_message;
		public unsafe string Message ()
		{
			if (id_message == IntPtr.Zero)
				id_message = JNIEnv.GetMethodID (class_ref, "message", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_message), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_protocol;
#pragma warning disable 0169
		static Delegate GetProtocolHandler ()
		{
			if (cb_protocol == null)
				cb_protocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Protocol);
			return cb_protocol;
		}

		static IntPtr n_Protocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Protocol ());
		}
#pragma warning restore 0169

		IntPtr id_protocol;
		public unsafe string Protocol ()
		{
			if (id_protocol == IntPtr.Zero)
				id_protocol = JNIEnv.GetMethodID (class_ref, "protocol", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_protocol), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getDataCallback;
#pragma warning disable 0169
		static Delegate GetGetDataCallbackHandler ()
		{
			if (cb_getDataCallback == null)
				cb_getDataCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataCallback);
			return cb_getDataCallback;
		}

		static IntPtr n_GetDataCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
#pragma warning disable 0169
		static Delegate GetSetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_Handler ()
		{
			if (cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ == null)
				cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_);
			return cb_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		}

		static void n_SetDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p0 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDataCallback;
		IntPtr id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.IDataCallback DataCallback {
			get {
				if (id_getDataCallback == IntPtr.Zero)
					id_getDataCallback = JNIEnv.GetMethodID (class_ref, "getDataCallback", "()Lcom/koushikdutta/async/callback/DataCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (JNIEnv.CallObjectMethod (Handle, id_getDataCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ == IntPtr.Zero)
					id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_ = JNIEnv.GetMethodID (class_ref, "setDataCallback", "(Lcom/koushikdutta/async/callback/DataCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setDataCallback_Lcom_koushikdutta_async_callback_DataCallback_, __args);
			}
		}

		static Delegate cb_getEndCallback;
#pragma warning disable 0169
		static Delegate GetGetEndCallbackHandler ()
		{
			if (cb_getEndCallback == null)
				cb_getEndCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndCallback);
			return cb_getEndCallback;
		}

		static IntPtr n_GetEndCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetSetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_SetEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndCallback = p0;
		}
#pragma warning restore 0169

		IntPtr id_getEndCallback;
		IntPtr id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback EndCallback {
			get {
				if (id_getEndCallback == IntPtr.Zero)
					id_getEndCallback = JNIEnv.GetMethodID (class_ref, "getEndCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod (Handle, id_getEndCallback), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setEndCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setEndCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			}
		}

		static Delegate cb_isChunked;
#pragma warning disable 0169
		static Delegate GetIsChunkedHandler ()
		{
			if (cb_isChunked == null)
				cb_isChunked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChunked);
			return cb_isChunked;
		}

		static bool n_IsChunked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChunked;
		}
#pragma warning restore 0169

		IntPtr id_isChunked;
		public unsafe bool IsChunked {
			get {
				if (id_isChunked == IntPtr.Zero)
					id_isChunked = JNIEnv.GetMethodID (class_ref, "isChunked", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isChunked);
			}
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		IntPtr id_isPaused;
		public unsafe bool IsPaused {
			get {
				if (id_isPaused == IntPtr.Zero)
					id_isPaused = JNIEnv.GetMethodID (class_ref, "isPaused", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isPaused);
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
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_charset;
#pragma warning disable 0169
		static Delegate GetCharsetHandler ()
		{
			if (cb_charset == null)
				cb_charset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Charset);
			return cb_charset;
		}

		static IntPtr n_Charset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset ());
		}
#pragma warning restore 0169

		IntPtr id_charset;
		public unsafe string Charset ()
		{
			if (id_charset == IntPtr.Zero)
				id_charset = JNIEnv.GetMethodID (class_ref, "charset", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_charset), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (Handle, id_pause);
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		IntPtr id_resume;
		public unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			JNIEnv.CallVoidMethod (Handle, id_resume);
		}

	}

}
