using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Future {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='FutureRunnable']"
	[Register ("com/koushikdutta/async/future/FutureRunnable", "", "Com.Koushikdutta.Async.Future.IFutureRunnableInvoker")]
	public partial interface IFutureRunnable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='FutureRunnable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()Ljava/lang/Object;", "GetRunHandler:Com.Koushikdutta.Async.Future.IFutureRunnableInvoker, AndroidAsyncBinding")]
		global::Java.Lang.Object Run ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/future/FutureRunnable", DoNotGenerateAcw=true)]
	internal class IFutureRunnableInvoker : global::Java.Lang.Object, IFutureRunnable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/future/FutureRunnable");
		IntPtr class_ref;

		public static IFutureRunnable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFutureRunnable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.future.FutureRunnable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFutureRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFutureRunnableInvoker); }
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static IntPtr n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.IFutureRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFutureRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Run ());
		}
#pragma warning restore 0169

		IntPtr id_run;
		public unsafe global::Java.Lang.Object Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_run), JniHandleOwnership.TransferLocalRef);
		}

	}

}
