using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='ExceptionCallback']"
	[Register ("com/koushikdutta/async/http/socketio/ExceptionCallback", "", "Com.Koushikdutta.Async.Http.Socketio.IExceptionCallbackInvoker")]
	public partial interface IExceptionCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='ExceptionCallback']/method[@name='onException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onException", "(Ljava/lang/Exception;)V", "GetOnException_Ljava_lang_Exception_Handler:Com.Koushikdutta.Async.Http.Socketio.IExceptionCallbackInvoker, AndroidAsyncBinding")]
		void OnException (global::Java.Lang.Exception p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/ExceptionCallback", DoNotGenerateAcw=true)]
	internal class IExceptionCallbackInvoker : global::Java.Lang.Object, IExceptionCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/ExceptionCallback");
		IntPtr class_ref;

		public static IExceptionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExceptionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.ExceptionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExceptionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IExceptionCallbackInvoker); }
		}

		static Delegate cb_onException_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnException_Ljava_lang_Exception_Handler ()
		{
			if (cb_onException_Ljava_lang_Exception_ == null)
				cb_onException_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnException_Ljava_lang_Exception_);
			return cb_onException_Ljava_lang_Exception_;
		}

		static void n_OnException_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IExceptionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnException (p0);
		}
#pragma warning restore 0169

		IntPtr id_onException_Ljava_lang_Exception_;
		public unsafe void OnException (global::Java.Lang.Exception p0)
		{
			if (id_onException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onException_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onException", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onException_Ljava_lang_Exception_, __args);
		}

	}

}
