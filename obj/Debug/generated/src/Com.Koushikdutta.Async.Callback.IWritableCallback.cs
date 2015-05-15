using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='WritableCallback']"
	[Register ("com/koushikdutta/async/callback/WritableCallback", "", "Com.Koushikdutta.Async.Callback.IWritableCallbackInvoker")]
	public partial interface IWritableCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='WritableCallback']/method[@name='onWriteable' and count(parameter)=0]"
		[Register ("onWriteable", "()V", "GetOnWriteableHandler:Com.Koushikdutta.Async.Callback.IWritableCallbackInvoker, AndroidAsyncBinding")]
		void OnWriteable ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/WritableCallback", DoNotGenerateAcw=true)]
	internal class IWritableCallbackInvoker : global::Java.Lang.Object, IWritableCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/callback/WritableCallback");
		IntPtr class_ref;

		public static IWritableCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWritableCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.callback.WritableCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWritableCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IWritableCallbackInvoker); }
		}

		static Delegate cb_onWriteable;
#pragma warning disable 0169
		static Delegate GetOnWriteableHandler ()
		{
			if (cb_onWriteable == null)
				cb_onWriteable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnWriteable);
			return cb_onWriteable;
		}

		static void n_OnWriteable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Callback.IWritableCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IWritableCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWriteable ();
		}
#pragma warning restore 0169

		IntPtr id_onWriteable;
		public unsafe void OnWriteable ()
		{
			if (id_onWriteable == IntPtr.Zero)
				id_onWriteable = JNIEnv.GetMethodID (class_ref, "onWriteable", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onWriteable);
		}

	}

}
