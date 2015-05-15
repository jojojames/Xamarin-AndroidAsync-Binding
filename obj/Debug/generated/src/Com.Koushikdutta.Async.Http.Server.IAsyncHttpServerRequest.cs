using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Server {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']"
	[Register ("com/koushikdutta/async/http/server/AsyncHttpServerRequest", "", "Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker")]
	public partial interface IAsyncHttpServerRequest : global::Com.Koushikdutta.Async.IDataEmitter {

		global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;", "GetGetBodyHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.Http.Headers Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Lcom/koushikdutta/async/http/Headers;", "GetGetHeadersHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

		global::Java.Util.Regex.Matcher Matcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getMatcher' and count(parameter)=0]"
			[Register ("getMatcher", "()Ljava/util/regex/Matcher;", "GetGetMatcherHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

		string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

		string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.Http.Multimap Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Lcom/koushikdutta/async/http/Multimap;", "GetGetQueryHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

		global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='AsyncHttpServerRequest']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetGetSocketHandler:Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequestInvoker, AndroidAsyncBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncHttpServerRequest", DoNotGenerateAcw=true)]
	internal class IAsyncHttpServerRequestInvoker : global::Java.Lang.Object, IAsyncHttpServerRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/server/AsyncHttpServerRequest");
		IntPtr class_ref;

		public static IAsyncHttpServerRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHttpServerRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.server.AsyncHttpServerRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHttpServerRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncHttpServerRequestInvoker); }
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		IntPtr id_getBody;
		public unsafe global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody Body {
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/koushikdutta/async/http/body/AsyncHttpRequestBody;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.IAsyncHttpRequestBody> (JNIEnv.CallObjectMethod (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getMatcher;
#pragma warning disable 0169
		static Delegate GetGetMatcherHandler ()
		{
			if (cb_getMatcher == null)
				cb_getMatcher = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatcher);
			return cb_getMatcher;
		}

		static IntPtr n_GetMatcher (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Matcher);
		}
#pragma warning restore 0169

		IntPtr id_getMatcher;
		public unsafe global::Java.Util.Regex.Matcher Matcher {
			get {
				if (id_getMatcher == IntPtr.Zero)
					id_getMatcher = JNIEnv.GetMethodID (class_ref, "getMatcher", "()Ljava/util/regex/Matcher;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Matcher> (JNIEnv.CallObjectMethod (Handle, id_getMatcher), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		IntPtr id_getMethod;
		public unsafe string Method {
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		IntPtr id_getPath;
		public unsafe string Path {
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getQuery;
#pragma warning disable 0169
		static Delegate GetGetQueryHandler ()
		{
			if (cb_getQuery == null)
				cb_getQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuery);
			return cb_getQuery;
		}

		static IntPtr n_GetQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Query);
		}
#pragma warning restore 0169

		IntPtr id_getQuery;
		public unsafe global::Com.Koushikdutta.Async.Http.Multimap Query {
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Lcom/koushikdutta/async/http/Multimap;");
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallObjectMethod (Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
