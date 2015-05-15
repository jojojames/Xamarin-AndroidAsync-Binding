using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.callback']/interface[@name='RequestCallback']"
	[Register ("com/koushikdutta/async/http/callback/RequestCallback", "", "Com.Koushikdutta.Async.Http.Callback.IRequestCallbackInvoker")]
	public partial interface IRequestCallback : global::Com.Koushikdutta.Async.Callback.IResultCallback {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.callback']/interface[@name='RequestCallback']/method[@name='onConnect' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpResponse']]"
		[Register ("onConnect", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V", "GetOnConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_Handler:Com.Koushikdutta.Async.Http.Callback.IRequestCallbackInvoker, AndroidAsyncBinding")]
		void OnConnect (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.callback']/interface[@name='RequestCallback']/method[@name='onProgress' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpResponse'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onProgress", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;JJ)V", "GetOnProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJHandler:Com.Koushikdutta.Async.Http.Callback.IRequestCallbackInvoker, AndroidAsyncBinding")]
		void OnProgress (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/callback/RequestCallback", DoNotGenerateAcw=true)]
	internal class IRequestCallbackInvoker : global::Java.Lang.Object, IRequestCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/callback/RequestCallback");
		IntPtr class_ref;

		public static IRequestCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRequestCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.callback.RequestCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRequestCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRequestCallbackInvoker); }
		}

		static Delegate cb_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
#pragma warning disable 0169
		static Delegate GetOnConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_Handler ()
		{
			if (cb_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_ == null)
				cb_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_);
			return cb_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
		}

		static void n_OnConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Callback.IRequestCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Callback.IRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0 = (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_;
		public unsafe void OnConnect (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0)
		{
			if (id_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_ == IntPtr.Zero)
				id_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_ = JNIEnv.GetMethodID (class_ref, "onConnect", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onConnect_Lcom_koushikdutta_async_http_AsyncHttpResponse_, __args);
		}

		static Delegate cb_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ;
#pragma warning disable 0169
		static Delegate GetOnProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJHandler ()
		{
			if (cb_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ == null)
				cb_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long>) n_OnProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ);
			return cb_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ;
		}

		static void n_OnProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			global::Com.Koushikdutta.Async.Http.Callback.IRequestCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Callback.IRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0 = (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ;
		public unsafe void OnProgress (global::Com.Koushikdutta.Async.Http.IAsyncHttpResponse p0, long p1, long p2)
		{
			if (id_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ == IntPtr.Zero)
				id_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ = JNIEnv.GetMethodID (class_ref, "onProgress", "(Lcom/koushikdutta/async/http/AsyncHttpResponse;JJ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_onProgress_Lcom_koushikdutta_async_http_AsyncHttpResponse_JJ, __args);
		}

		static Delegate cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_OnCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Http.Callback.IRequestCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Callback.IRequestCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void OnCompleted (global::Java.Lang.Exception p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
