using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Callback {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.callback']/class[@name='CompletedCallback.NullCompletedCallback']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/CompletedCallback$NullCompletedCallback", DoNotGenerateAcw=true)]
	public partial class CompletedCallbackNullCompletedCallback : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Callback.ICompletedCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/callback/CompletedCallback$NullCompletedCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompletedCallbackNullCompletedCallback); }
		}

		protected CompletedCallbackNullCompletedCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.callback']/class[@name='CompletedCallback.NullCompletedCallback']/constructor[@name='CompletedCallback.NullCompletedCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CompletedCallbackNullCompletedCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CompletedCallbackNullCompletedCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_onCompleted_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Exception_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Exception_ == null)
				cb_onCompleted_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_);
			return cb_onCompleted_Ljava_lang_Exception_;
		}

		static void n_OnCompleted_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Callback.CompletedCallbackNullCompletedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.CompletedCallbackNullCompletedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCompleted_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/class[@name='CompletedCallback.NullCompletedCallback']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;)V", "GetOnCompleted_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnCompleted (global::Java.Lang.Exception p0)
		{
			if (id_onCompleted_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCompleted_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompleted", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='CompletedCallback']"
	[Register ("com/koushikdutta/async/callback/CompletedCallback", "", "Com.Koushikdutta.Async.Callback.ICompletedCallbackInvoker")]
	public partial interface ICompletedCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='CompletedCallback']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onCompleted", "(Ljava/lang/Exception;)V", "GetOnCompleted_Ljava_lang_Exception_Handler:Com.Koushikdutta.Async.Callback.ICompletedCallbackInvoker, AndroidAsyncBinding")]
		void OnCompleted (global::Java.Lang.Exception p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/CompletedCallback", DoNotGenerateAcw=true)]
	internal class ICompletedCallbackInvoker : global::Java.Lang.Object, ICompletedCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/callback/CompletedCallback");
		IntPtr class_ref;

		public static ICompletedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICompletedCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.callback.CompletedCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICompletedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICompletedCallbackInvoker); }
		}

		static Delegate cb_onCompleted_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Ljava_lang_Exception_Handler ()
		{
			if (cb_onCompleted_Ljava_lang_Exception_ == null)
				cb_onCompleted_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompleted_Ljava_lang_Exception_);
			return cb_onCompleted_Ljava_lang_Exception_;
		}

		static void n_OnCompleted_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Ljava_lang_Exception_;
		public unsafe void OnCompleted (global::Java.Lang.Exception p0)
		{
			if (id_onCompleted_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onCompleted_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onCompleted_Ljava_lang_Exception_, __args);
		}

	}

}
