using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSemaphore']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncSemaphore", DoNotGenerateAcw=true)]
	public partial class AsyncSemaphore : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/AsyncSemaphore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncSemaphore); }
		}

		protected AsyncSemaphore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSemaphore']/constructor[@name='AsyncSemaphore' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncSemaphore ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncSemaphore)) {
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

		static Delegate cb_acquire;
#pragma warning disable 0169
		static Delegate GetAcquireHandler ()
		{
			if (cb_acquire == null)
				cb_acquire = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Acquire);
			return cb_acquire;
		}

		static void n_Acquire (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSemaphore __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Acquire ();
		}
#pragma warning restore 0169

		static IntPtr id_acquire;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSemaphore']/method[@name='acquire' and count(parameter)=0]"
		[Register ("acquire", "()V", "GetAcquireHandler")]
		public virtual unsafe void Acquire ()
		{
			if (id_acquire == IntPtr.Zero)
				id_acquire = JNIEnv.GetMethodID (class_ref, "acquire", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_acquire);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acquire", "()V"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncSemaphore __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSemaphore']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_tryAcquire_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetTryAcquire_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_tryAcquire_JLjava_util_concurrent_TimeUnit_ == null)
				cb_tryAcquire_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_TryAcquire_JLjava_util_concurrent_TimeUnit_);
			return cb_tryAcquire_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_TryAcquire_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.AsyncSemaphore __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncSemaphore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TryAcquire (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_tryAcquire_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncSemaphore']/method[@name='tryAcquire' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z", "GetTryAcquire_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe bool TryAcquire (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_tryAcquire_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_tryAcquire_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_tryAcquire_JLjava_util_concurrent_TimeUnit_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryAcquire", "(JLjava/util/concurrent/TimeUnit;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
