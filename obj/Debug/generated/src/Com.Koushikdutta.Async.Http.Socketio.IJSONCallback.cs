using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='JSONCallback']"
	[Register ("com/koushikdutta/async/http/socketio/JSONCallback", "", "Com.Koushikdutta.Async.Http.Socketio.IJSONCallbackInvoker")]
	public partial interface IJSONCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='JSONCallback']/method[@name='onJSON' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("onJSON", "(Lorg/json/JSONObject;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetOnJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler:Com.Koushikdutta.Async.Http.Socketio.IJSONCallbackInvoker, AndroidAsyncBinding")]
		void OnJSON (global::Org.Json.JSONObject p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/JSONCallback", DoNotGenerateAcw=true)]
	internal class IJSONCallbackInvoker : global::Java.Lang.Object, IJSONCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/JSONCallback");
		IntPtr class_ref;

		public static IJSONCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJSONCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.JSONCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJSONCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IJSONCallbackInvoker); }
		}

		static Delegate cb_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetOnJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_OnJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IJSONCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnJSON (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		public unsafe void OnJSON (global::Org.Json.JSONObject p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
		{
			if (id_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "onJSON", "(Lorg/json/JSONObject;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onJSON_Lorg_json_JSONObject_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
		}

	}

}
