using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/AsyncHttpServerResponseImpl", DoNotGenerateAcw=true)]
	public partial class AsyncHttpServerResponseImpl : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/server/AsyncHttpServerResponseImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpServerResponseImpl); }
		}

		protected AsyncHttpServerResponseImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClosedCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClosedCallback;
		static IntPtr id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.ICompletedCallback ClosedCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='getClosedCallback' and count(parameter)=0]"
			[Register ("getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;", "GetGetClosedCallbackHandler")]
			get {
				if (id_getClosedCallback == IntPtr.Zero)
					id_getClosedCallback = JNIEnv.GetMethodID (class_ref, "getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallObjectMethod  (Handle, id_getClosedCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClosedCallback", "()Lcom/koushikdutta/async/callback/CompletedCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='setClosedCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback']]"
			[Register ("setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetSetClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
			set {
				if (id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
					id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setClosedCallback_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClosedCallback", "(Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='getHeaders' and count(parameter)=0]"
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncServer Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetServerHandler")]
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/koushikdutta/async/AsyncServer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallObjectMethod  (Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServer", "()Lcom/koushikdutta/async/AsyncServer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static IntPtr id_getSocket;
		public virtual unsafe global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetGetSocketHandler")]
			get {
				if (id_getSocket == IntPtr.Zero)
					id_getSocket = JNIEnv.GetMethodID (class_ref, "getSocket", "()Lcom/koushikdutta/async/AsyncSocket;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallObjectMethod  (Handle, id_getSocket), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocket", "()Lcom/koushikdutta/async/AsyncSocket;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IWritableCallback p0 = (global::Com.Koushikdutta.Async.Callback.IWritableCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteableCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteableCallback;
		static IntPtr id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.Callback.IWritableCallback WriteableCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='getWriteableCallback' and count(parameter)=0]"
			[Register ("getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;", "GetGetWriteableCallbackHandler")]
			get {
				if (id_getWriteableCallback == IntPtr.Zero)
					id_getWriteableCallback = JNIEnv.GetMethodID (class_ref, "getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (JNIEnv.CallObjectMethod  (Handle, id_getWriteableCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteableCallback", "()Lcom/koushikdutta/async/callback/WritableCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='setWriteableCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
			[Register ("setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V", "GetSetWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_Handler")]
			set {
				if (id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ == IntPtr.Zero)
					id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_ = JNIEnv.GetMethodID (class_ref, "setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWriteableCallback_Lcom_koushikdutta_async_callback_WritableCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWriteableCallback", "(Lcom/koushikdutta/async/callback/WritableCallback;)V"), __args);
				} finally {
				}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code ();
		}
#pragma warning restore 0169

		static IntPtr id_code;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "GetCodeHandler")]
		public virtual unsafe int Code ()
		{
			if (id_code == IntPtr.Zero)
				id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_code);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "code", "()I"));
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Code (p0));
		}
#pragma warning restore 0169

		static IntPtr id_code_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='code' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("code", "(I)Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;", "GetCode_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse Code (int p0)
		{
			if (id_code_I == IntPtr.Zero)
				id_code_I = JNIEnv.GetMethodID (class_ref, "code", "(I)Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (JNIEnv.CallObjectMethod  (Handle, id_code_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "code", "(I)Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		static IntPtr id_end;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		public virtual unsafe void End ()
		{
			if (id_end == IntPtr.Zero)
				id_end = JNIEnv.GetMethodID (class_ref, "end", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_end);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "end", "()V"));
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCompleted_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;)V", "GetOnCompleted_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnCompleted (global::Java.Lang.Exception p0)
		{
			if (id_onCompleted_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCompleted_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompleted", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onEnd;
#pragma warning disable 0169
		static Delegate GetOnEndHandler ()
		{
			if (cb_onEnd == null)
				cb_onEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnEnd);
			return cb_onEnd;
		}

		static void n_OnEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_onEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='onEnd' and count(parameter)=0]"
		[Register ("onEnd", "()V", "GetOnEndHandler")]
		protected virtual unsafe void OnEnd ()
		{
			if (id_onEnd == IntPtr.Zero)
				id_onEnd = JNIEnv.GetMethodID (class_ref, "onEnd", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onEnd", "()V"));
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0 = (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Proxy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='proxy' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpResponse']]"
		[Register ("proxy", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V", "GetProxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_Handler")]
		public virtual unsafe void Proxy (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0)
		{
			if (id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ == IntPtr.Zero)
				id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_ = JNIEnv.GetMethodID (class_ref, "proxy", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_proxy_Lcom_koushikdutta_async_http_AsyncHttpResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proxy", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V"), __args);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Redirect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_redirect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='redirect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("redirect", "(Ljava/lang/String;)V", "GetRedirect_Ljava_lang_String_Handler")]
		public virtual unsafe void Redirect (string p0)
		{
			if (id_redirect_Ljava_lang_String_ == IntPtr.Zero)
				id_redirect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "redirect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_redirect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "redirect", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_report_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetReport_Ljava_lang_Exception_Handler ()
		{
			if (cb_report_Ljava_lang_Exception_ == null)
				cb_report_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Report_Ljava_lang_Exception_);
			return cb_report_Ljava_lang_Exception_;
		}

		static void n_Report_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Report (p0);
		}
#pragma warning restore 0169

		static IntPtr id_report_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='report' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("report", "(Ljava/lang/Exception;)V", "GetReport_Ljava_lang_Exception_Handler")]
		protected virtual unsafe void Report (global::Java.Lang.Exception p0)
		{
			if (id_report_Ljava_lang_Exception_ == IntPtr.Zero)
				id_report_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "report", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_report_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "report", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='send' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string p0, string p1)
		{
			if (id_send_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("send", "(Lorg/json/JSONObject;)V", "GetSend_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Send (global::Org.Json.JSONObject p0)
		{
			if (id_send_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_send_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "send", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='sendFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("sendFile", "(Ljava/io/File;)V", "GetSendFile_Ljava_io_File_Handler")]
		public virtual unsafe void SendFile (global::Java.IO.File p0)
		{
			if (id_sendFile_Ljava_io_File_ == IntPtr.Zero)
				id_sendFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "sendFile", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendFile_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendFile", "(Ljava/io/File;)V"), __args);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendStream_Ljava_io_InputStream_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='sendStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register ("sendStream", "(Ljava/io/InputStream;J)V", "GetSendStream_Ljava_io_InputStream_JHandler")]
		public virtual unsafe void SendStream (global::System.IO.Stream p0, long p1)
		{
			if (id_sendStream_Ljava_io_InputStream_J == IntPtr.Zero)
				id_sendStream_Ljava_io_InputStream_J = JNIEnv.GetMethodID (class_ref, "sendStream", "(Ljava/io/InputStream;J)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_sendStream_Ljava_io_InputStream_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStream", "(Ljava/io/InputStream;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetContentType (string p0)
		{
			if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setContentType_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='write' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("write", "(Lcom/koushikdutta/async/ByteBufferList;)V", "GetWrite_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe void Write (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_write_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_ByteBufferList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/koushikdutta/async/ByteBufferList;)V"), __args);
			} finally {
			}
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
			global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.AsyncHttpServerResponseImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteHead ();
		}
#pragma warning restore 0169

		static IntPtr id_writeHead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/class[@name='AsyncHttpServerResponseImpl']/method[@name='writeHead' and count(parameter)=0]"
		[Register ("writeHead", "()V", "GetWriteHeadHandler")]
		public virtual unsafe void WriteHead ()
		{
			if (id_writeHead == IntPtr.Zero)
				id_writeHead = JNIEnv.GetMethodID (class_ref, "writeHead", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeHead);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeHead", "()V"));
			} finally {
			}
		}

	}
}
