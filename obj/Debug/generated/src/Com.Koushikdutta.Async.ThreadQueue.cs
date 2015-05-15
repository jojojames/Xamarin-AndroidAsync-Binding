using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ThreadQueue']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/ThreadQueue", DoNotGenerateAcw=true)]
	public partial class ThreadQueue : global::Java.Util.LinkedList {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/ThreadQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadQueue); }
		}

		protected ThreadQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ThreadQueue']/constructor[@name='ThreadQueue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadQueue ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThreadQueue)) {
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

		static Delegate cb_add_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Runnable_Handler ()
		{
			if (cb_add_Ljava_lang_Runnable_ == null)
				cb_add_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Ljava_lang_Runnable_);
			return cb_add_Ljava_lang_Runnable_;
		}

		static bool n_Add_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ThreadQueue __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ThreadQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ThreadQueue']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("add", "(Ljava/lang/Runnable;)Z", "GetAdd_Ljava_lang_Runnable_Handler")]
		public virtual unsafe bool Add (global::Java.Lang.IRunnable p0)
		{
			if (id_add_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_add_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Runnable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_add_Ljava_lang_Runnable_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/Runnable;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
