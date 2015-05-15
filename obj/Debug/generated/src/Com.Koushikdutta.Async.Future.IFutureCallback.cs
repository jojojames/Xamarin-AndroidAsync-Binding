using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Future {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='FutureCallback']"
	[Register ("com/koushikdutta/async/future/FutureCallback", "", "Com.Koushikdutta.Async.Future.IFutureCallbackInvoker")]
	public partial interface IFutureCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='FutureCallback']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='T']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;Ljava/lang/Object;)V", "GetOnCompleted_Ljava_lang_Exception_Ljava_lang_Object_Handler:Com.Koushikdutta.Async.Future.IFutureCallbackInvoker, AndroidAsyncBinding")]
		void OnCompleted (global::Java.Lang.Exception p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/future/FutureCallback", DoNotGenerateAcw=true)]
	internal class IFutureCallbackInvoker : global::Java.Lang.Object, IFutureCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/future/FutureCallback");
		IntPtr class_ref;

		public static IFutureCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFutureCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.future.FutureCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFutureCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFutureCallbackInvoker); }
		}

		static Delegate cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Exception_Ljava_lang_Object_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_ == null)
				cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_Ljava_lang_Object_);
			return cb_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_;
		}

		static void n_OnCompleted_Ljava_lang_Exception_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Future.IFutureCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFutureCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_;
		public unsafe void OnCompleted (global::Java.Lang.Exception p0, global::Java.Lang.Object p1)
		{
			if (id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_lang_Exception_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
