using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='EventCallback']"
	[Register ("com/koushikdutta/async/http/socketio/EventCallback", "", "Com.Koushikdutta.Async.Http.Socketio.IEventCallbackInvoker")]
	public partial interface IEventCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='EventCallback']/method[@name='onEvent' and count(parameter)=2 and parameter[1][@type='org.json.JSONArray'] and parameter[2][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("onEvent", "(Lorg/json/JSONArray;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetOnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler:Com.Koushikdutta.Async.Http.Socketio.IEventCallbackInvoker, AndroidAsyncBinding")]
		void OnEvent (global::Org.Json.JSONArray p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/EventCallback", DoNotGenerateAcw=true)]
	internal class IEventCallbackInvoker : global::Java.Lang.Object, IEventCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/EventCallback");
		IntPtr class_ref;

		public static IEventCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.EventCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEventCallbackInvoker); }
		}

		static Delegate cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_OnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		public unsafe void OnEvent (global::Org.Json.JSONArray p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
		{
			if (id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lorg/json/JSONArray;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
		}

	}

}
