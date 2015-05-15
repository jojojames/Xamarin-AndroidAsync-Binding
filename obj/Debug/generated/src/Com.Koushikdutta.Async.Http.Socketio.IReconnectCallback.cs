using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='ReconnectCallback']"
	[Register ("com/koushikdutta/async/http/socketio/ReconnectCallback", "", "Com.Koushikdutta.Async.Http.Socketio.IReconnectCallbackInvoker")]
	public partial interface IReconnectCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='ReconnectCallback']/method[@name='onReconnect' and count(parameter)=0]"
		[Register ("onReconnect", "()V", "GetOnReconnectHandler:Com.Koushikdutta.Async.Http.Socketio.IReconnectCallbackInvoker, AndroidAsyncBinding")]
		void OnReconnect ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/ReconnectCallback", DoNotGenerateAcw=true)]
	internal class IReconnectCallbackInvoker : global::Java.Lang.Object, IReconnectCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/ReconnectCallback");
		IntPtr class_ref;

		public static IReconnectCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReconnectCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.ReconnectCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReconnectCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IReconnectCallbackInvoker); }
		}

		static Delegate cb_onReconnect;
#pragma warning disable 0169
		static Delegate GetOnReconnectHandler ()
		{
			if (cb_onReconnect == null)
				cb_onReconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReconnect);
			return cb_onReconnect;
		}

		static void n_OnReconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IReconnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReconnect ();
		}
#pragma warning restore 0169

		IntPtr id_onReconnect;
		public unsafe void OnReconnect ()
		{
			if (id_onReconnect == IntPtr.Zero)
				id_onReconnect = JNIEnv.GetMethodID (class_ref, "onReconnect", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onReconnect);
		}

	}

}
