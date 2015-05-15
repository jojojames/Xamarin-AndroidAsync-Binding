using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Future {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Cancellable']"
	[Register ("com/koushikdutta/async/future/Cancellable", "", "Com.Koushikdutta.Async.Future.ICancellableInvoker")]
	public partial interface ICancellable : IJavaObject {

		bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Cancellable']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler:Com.Koushikdutta.Async.Future.ICancellableInvoker, AndroidAsyncBinding")] get;
		}

		bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Cancellable']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler:Com.Koushikdutta.Async.Future.ICancellableInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Cancellable']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()Z", "GetCancelHandler:Com.Koushikdutta.Async.Future.ICancellableInvoker, AndroidAsyncBinding")]
		bool Cancel ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/future/Cancellable", DoNotGenerateAcw=true)]
	internal class ICancellableInvoker : global::Java.Lang.Object, ICancellable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/future/Cancellable");
		IntPtr class_ref;

		public static ICancellable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICancellable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.future.Cancellable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICancellableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ICancellableInvoker); }
		}

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.ICancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		IntPtr id_isCancelled;
		public unsafe bool IsCancelled {
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCancelled);
			}
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.ICancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		IntPtr id_isDone;
		public unsafe bool IsDone {
			get {
				if (id_isDone == IntPtr.Zero)
					id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isDone);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Cancel);
			return cb_cancel;
		}

		static bool n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.ICancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe bool Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_cancel);
		}

	}

}
