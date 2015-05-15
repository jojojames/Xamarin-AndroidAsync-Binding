using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLException']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncSSLException", DoNotGenerateAcw=true)]
	public partial class AsyncSSLException : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/AsyncSSLException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncSSLException); }
		}

		protected AsyncSSLException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLException']/constructor[@name='AsyncSSLException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe AsyncSSLException (global::Java.Lang.Throwable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsyncSSLException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static Delegate cb_getIgnore;
#pragma warning disable 0169
		static Delegate GetGetIgnoreHandler ()
		{
			if (cb_getIgnore == null)
				cb_getIgnore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIgnore);
			return cb_getIgnore;
		}

		static bool n_GetIgnore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSSLException __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ignore;
		}
#pragma warning restore 0169

		static Delegate cb_setIgnore_Z;
#pragma warning disable 0169
		static Delegate GetSetIgnore_ZHandler ()
		{
			if (cb_setIgnore_Z == null)
				cb_setIgnore_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIgnore_Z);
			return cb_setIgnore_Z;
		}

		static void n_SetIgnore_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Koushikdutta.Async.AsyncSSLException __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSSLException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ignore = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIgnore;
		static IntPtr id_setIgnore_Z;
		public virtual unsafe bool Ignore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLException']/method[@name='getIgnore' and count(parameter)=0]"
			[Register ("getIgnore", "()Z", "GetGetIgnoreHandler")]
			get {
				if (id_getIgnore == IntPtr.Zero)
					id_getIgnore = JNIEnv.GetMethodID (class_ref, "getIgnore", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getIgnore);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIgnore", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSSLException']/method[@name='setIgnore' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIgnore", "(Z)V", "GetSetIgnore_ZHandler")]
			set {
				if (id_setIgnore_Z == IntPtr.Zero)
					id_setIgnore_Z = JNIEnv.GetMethodID (class_ref, "setIgnore", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIgnore_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIgnore", "(Z)V"), __args);
				} finally {
				}
			}
		}

	}
}
