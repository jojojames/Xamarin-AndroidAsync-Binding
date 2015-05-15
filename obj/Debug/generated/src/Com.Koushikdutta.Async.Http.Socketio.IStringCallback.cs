using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='StringCallback']"
	[Register ("com/koushikdutta/async/http/socketio/StringCallback", "", "Com.Koushikdutta.Async.Http.Socketio.IStringCallbackInvoker")]
	public partial interface IStringCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='StringCallback']/method[@name='onString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.Acknowledge']]"
		[Register ("onString", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V", "GetOnString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler:Com.Koushikdutta.Async.Http.Socketio.IStringCallbackInvoker, AndroidAsyncBinding")]
		void OnString (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/StringCallback", DoNotGenerateAcw=true)]
	internal class IStringCallbackInvoker : global::Java.Lang.Object, IStringCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/StringCallback");
		IntPtr class_ref;

		public static IStringCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStringCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.StringCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStringCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IStringCallbackInvoker); }
		}

		static Delegate cb_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
		static Delegate GetOnString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
		{
			if (cb_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
				cb_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
			return cb_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		}

		static void n_OnString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IStringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnString (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
		public unsafe void OnString (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
		{
			if (id_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
				id_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "onString", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onString_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
