using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ResultCallback']"
	[Register ("com/koushikdutta/async/callback/ResultCallback", "", "Com.Koushikdutta.Async.Callback.IResultCallbackInvoker")]
	public partial interface IResultCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ResultCallback']/method[@name='onCompleted' and count(parameter)=3 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='S'] and parameter[3][@type='T']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;Ljava/lang/Object;Ljava/lang/Object;)V", "GetOnCompleted_Ljava_lang_Exception_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Koushikdutta.Async.Callback.IResultCallbackInvoker, AndroidAsyncBinding")]
		void OnCompleted (global::Java.Lang.Exception p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/ResultCallback", DoNotGenerateAcw=true)]
	internal class IResultCallbackInvoker : global::Java.Lang.Object, IResultCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/callback/ResultCallback");
		IntPtr class_ref;

		public static IResultCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.callback.ResultCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IResultCallbackInvoker); }
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
			global::Com.Koushikdutta.Async.Callback.IResultCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
