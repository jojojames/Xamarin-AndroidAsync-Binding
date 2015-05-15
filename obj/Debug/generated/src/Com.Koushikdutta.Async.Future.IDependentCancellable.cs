using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Future {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='DependentCancellable']"
	[Register ("com/koushikdutta/async/future/DependentCancellable", "", "Com.Koushikdutta.Async.Future.IDependentCancellableInvoker")]
	public partial interface IDependentCancellable : global::Com.Koushikdutta.Async.Future.ICancellable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='DependentCancellable']/method[@name='setParent' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.future.Cancellable']]"
		[Register ("setParent", "(Lcom/koushikdutta/async/future/Cancellable;)Lcom/koushikdutta/async/future/DependentCancellable;", "GetSetParent_Lcom_koushikdutta_async_future_Cancellable_Handler:Com.Koushikdutta.Async.Future.IDependentCancellableInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Future.IDependentCancellable SetParent (global::Com.Koushikdutta.Async.Future.ICancellable p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/future/DependentCancellable", DoNotGenerateAcw=true)]
	internal class IDependentCancellableInvoker : global::Java.Lang.Object, IDependentCancellable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/future/DependentCancellable");
		IntPtr class_ref;

		public static IDependentCancellable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDependentCancellable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.future.DependentCancellable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDependentCancellableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDependentCancellableInvoker); }
		}

		static Delegate cb_setParent_Lcom_koushikdutta_async_future_Cancellable_;
#pragma warning disable 0169
		static Delegate GetSetParent_Lcom_koushikdutta_async_future_Cancellable_Handler ()
		{
			if (cb_setParent_Lcom_koushikdutta_async_future_Cancellable_ == null)
				cb_setParent_Lcom_koushikdutta_async_future_Cancellable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParent_Lcom_koushikdutta_async_future_Cancellable_);
			return cb_setParent_Lcom_koushikdutta_async_future_Cancellable_;
		}

		static IntPtr n_SetParent_Lcom_koushikdutta_async_future_Cancellable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Future.IDependentCancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IDependentCancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Future.ICancellable p0 = (global::Com.Koushikdutta.Async.Future.ICancellable)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetParent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setParent_Lcom_koushikdutta_async_future_Cancellable_;
		public unsafe global::Com.Koushikdutta.Async.Future.IDependentCancellable SetParent (global::Com.Koushikdutta.Async.Future.ICancellable p0)
		{
			if (id_setParent_Lcom_koushikdutta_async_future_Cancellable_ == IntPtr.Zero)
				id_setParent_Lcom_koushikdutta_async_future_Cancellable_ = JNIEnv.GetMethodID (class_ref, "setParent", "(Lcom/koushikdutta/async/future/Cancellable;)Lcom/koushikdutta/async/future/DependentCancellable;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Future.IDependentCancellable __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IDependentCancellable> (JNIEnv.CallObjectMethod (Handle, id_setParent_Lcom_koushikdutta_async_future_Cancellable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Koushikdutta.Async.Future.IDependentCancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IDependentCancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Future.IDependentCancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IDependentCancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Future.IDependentCancellable __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IDependentCancellable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
