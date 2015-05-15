using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='TapCallback']"
	[Register ("com/koushikdutta/async/TapCallback", "", "Com.Koushikdutta.Async.ITapCallbackInvoker")]
	public partial interface ITapCallback : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/TapCallback", DoNotGenerateAcw=true)]
	internal class ITapCallbackInvoker : global::Java.Lang.Object, ITapCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/TapCallback");
		IntPtr class_ref;

		public static ITapCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITapCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.TapCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITapCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITapCallbackInvoker); }
		}

	}

}
