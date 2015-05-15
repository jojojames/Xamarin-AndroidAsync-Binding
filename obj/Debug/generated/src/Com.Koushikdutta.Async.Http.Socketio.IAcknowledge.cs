using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='Acknowledge']"
	[Register ("com/koushikdutta/async/http/socketio/Acknowledge", "", "Com.Koushikdutta.Async.Http.Socketio.IAcknowledgeInvoker")]
	public partial interface IAcknowledge : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='Acknowledge']/method[@name='acknowledge' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("acknowledge", "(Lorg/json/JSONArray;)V", "GetAcknowledge_Lorg_json_JSONArray_Handler:Com.Koushikdutta.Async.Http.Socketio.IAcknowledgeInvoker, AndroidAsyncBinding")]
		void Acknowledge (global::Org.Json.JSONArray p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/Acknowledge", DoNotGenerateAcw=true)]
	internal class IAcknowledgeInvoker : global::Java.Lang.Object, IAcknowledge {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/Acknowledge");
		IntPtr class_ref;

		public static IAcknowledge GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAcknowledge> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.Acknowledge"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAcknowledgeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAcknowledgeInvoker); }
		}

		static Delegate cb_acknowledge_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetAcknowledge_Lorg_json_JSONArray_Handler ()
		{
			if (cb_acknowledge_Lorg_json_JSONArray_ == null)
				cb_acknowledge_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Acknowledge_Lorg_json_JSONArray_);
			return cb_acknowledge_Lorg_json_JSONArray_;
		}

		static void n_Acknowledge_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Acknowledge (p0);
		}
#pragma warning restore 0169

		IntPtr id_acknowledge_Lorg_json_JSONArray_;
		public unsafe void Acknowledge (global::Org.Json.JSONArray p0)
		{
			if (id_acknowledge_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_acknowledge_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "acknowledge", "(Lorg/json/JSONArray;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_acknowledge_Lorg_json_JSONArray_, __args);
		}

	}

}
