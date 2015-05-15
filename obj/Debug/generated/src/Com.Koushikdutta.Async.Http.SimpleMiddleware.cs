using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/SimpleMiddleware", DoNotGenerateAcw=true)]
	public partial class SimpleMiddleware : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/SimpleMiddleware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleMiddleware); }
		}

		protected SimpleMiddleware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/constructor[@name='SimpleMiddleware' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleMiddleware ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleMiddleware)) {
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

		static Delegate cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_;
#pragma warning disable 0169
		static Delegate GetExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_Handler ()
		{
			if (cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ == null)
				cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_);
			return cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_;
		}

		static bool n_ExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExchangeHeaders (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='exchangeHeaders' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnExchangeHeaderData']]"
		[Register ("exchangeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData;)Z", "GetExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_Handler")]
		public virtual unsafe bool ExchangeHeaders (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData p0)
		{
			if (id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ == IntPtr.Zero)
				id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ = JNIEnv.GetMethodID (class_ref, "exchangeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "exchangeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_;
#pragma warning disable 0169
		static Delegate GetGetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Handler ()
		{
			if (cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ == null)
				cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_);
			return cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_;
		}

		static IntPtr n_GetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSocket (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='getSocket' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData']]"
		[Register ("getSocket", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;)Lcom/koushikdutta/async/future/Cancellable;", "GetGetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.ICancellable GetSocket (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0)
		{
			if (id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ == IntPtr.Zero)
				id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ = JNIEnv.GetMethodID (class_ref, "getSocket", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;)Lcom/koushikdutta/async/future/Cancellable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.Future.ICancellable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallObjectMethod  (Handle, id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocket", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;)Lcom/koushikdutta/async/future/Cancellable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_Handler ()
		{
			if (cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ == null)
				cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_);
			return cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_;
		}

		static void n_OnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBodyDecoder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='onBodyDecoder' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnBodyDataOnRequestSentData']]"
		[Register ("onBodyDecoder", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData;)V", "GetOnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_Handler")]
		public virtual unsafe void OnBodyDecoder (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData p0)
		{
			if (id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ == IntPtr.Zero)
				id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onBodyDecoder", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBodyDecoder", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_Handler ()
		{
			if (cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ == null)
				cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_);
			return cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_;
		}

		static void n_OnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHeadersReceived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='onHeadersReceived' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnHeadersReceivedDataOnRequestSentData']]"
		[Register ("onHeadersReceived", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData;)V", "GetOnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_Handler")]
		public virtual unsafe void OnHeadersReceived (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData p0)
		{
			if (id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ == IntPtr.Zero)
				id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onHeadersReceived", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHeadersReceived", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_;
#pragma warning disable 0169
		static Delegate GetOnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_Handler ()
		{
			if (cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ == null)
				cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_);
			return cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_;
		}

		static void n_OnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='onRequest' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnRequestData']]"
		[Register ("onRequest", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData;)V", "GetOnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_Handler")]
		public virtual unsafe void OnRequest (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData p0)
		{
			if (id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ == IntPtr.Zero)
				id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequest", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_Handler ()
		{
			if (cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ == null)
				cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_);
			return cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_;
		}

		static void n_OnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestSent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='onRequestSent' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnRequestSentData']]"
		[Register ("onRequestSent", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData;)V", "GetOnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_Handler")]
		public virtual unsafe void OnRequestSent (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData p0)
		{
			if (id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ == IntPtr.Zero)
				id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onRequestSent", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestSent", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_Handler ()
		{
			if (cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ == null)
				cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_);
			return cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_;
		}

		static void n_OnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.SimpleMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.SimpleMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponseComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='SimpleMiddleware']/method[@name='onResponseComplete' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnResponseCompleteDataOnRequestSentData']]"
		[Register ("onResponseComplete", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData;)V", "GetOnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_Handler")]
		public virtual unsafe void OnResponseComplete (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData p0)
		{
			if (id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ == IntPtr.Zero)
				id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onResponseComplete", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResponseComplete", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData;)V"), __args);
			} finally {
			}
		}

	}
}
