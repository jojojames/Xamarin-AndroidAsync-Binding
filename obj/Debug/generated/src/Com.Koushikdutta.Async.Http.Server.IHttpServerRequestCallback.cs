using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Server {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='HttpServerRequestCallback']"
	[Register ("com/koushikdutta/async/http/server/HttpServerRequestCallback", "", "Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallbackInvoker")]
	public partial interface IHttpServerRequestCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.server']/interface[@name='HttpServerRequestCallback']/method[@name='onRequest' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.server.AsyncHttpServerRequest'] and parameter[2][@type='com.koushikdutta.async.http.server.AsyncHttpServerResponse']]"
		[Register ("onRequest", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V", "GetOnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_Handler:Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallbackInvoker, AndroidAsyncBinding")]
		void OnRequest (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/server/HttpServerRequestCallback", DoNotGenerateAcw=true)]
	internal class IHttpServerRequestCallbackInvoker : global::Java.Lang.Object, IHttpServerRequestCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/server/HttpServerRequestCallback");
		IntPtr class_ref;

		public static IHttpServerRequestCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpServerRequestCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.server.HttpServerRequestCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpServerRequestCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpServerRequestCallbackInvoker); }
		}

		static Delegate cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
#pragma warning disable 0169
		static Delegate GetOnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_Handler ()
		{
			if (cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == null)
				cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_);
			return cb_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		}

		static void n_OnRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IHttpServerRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p0 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p1 = (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRequest (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_;
		public unsafe void OnRequest (global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerRequest p0, global::Com.Koushikdutta.Async.Http.Server.IAsyncHttpServerResponse p1)
		{
			if (id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ == IntPtr.Zero)
				id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(Lcom/koushikdutta/async/http/server/AsyncHttpServerRequest;Lcom/koushikdutta/async/http/server/AsyncHttpServerResponse;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerRequest_Lcom_koushikdutta_async_http_server_AsyncHttpServerResponse_, __args);
		}

	}

}
