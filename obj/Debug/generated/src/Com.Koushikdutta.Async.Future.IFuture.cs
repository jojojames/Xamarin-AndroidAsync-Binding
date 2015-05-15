using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Future {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Future']"
	[Register ("com/koushikdutta/async/future/Future", "", "Com.Koushikdutta.Async.Future.IFutureInvoker")]
	public partial interface IFuture : global::Com.Koushikdutta.Async.Future.ICancellable, global::Java.Util.Concurrent.IFuture {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Future']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.future.FutureCallback&lt;T&gt;']]"
		[Register ("setCallback", "(Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Future;", "GetSetCallback_Lcom_koushikdutta_async_future_FutureCallback_Handler:Com.Koushikdutta.Async.Future.IFutureInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Future.IFuture SetCallback (global::Com.Koushikdutta.Async.Future.IFutureCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Future']/method[@name='then' and count(parameter)=1 and parameter[1][@type='C']]"
		[Register ("then", "(Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/FutureCallback;", "GetThen_Lcom_koushikdutta_async_future_FutureCallback_Handler:Com.Koushikdutta.Async.Future.IFutureInvoker, AndroidAsyncBinding")]
		global::Java.Lang.Object Then (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Future']/method[@name='tryGet' and count(parameter)=0]"
		[Register ("tryGet", "()Ljava/lang/Object;", "GetTryGetHandler:Com.Koushikdutta.Async.Future.IFutureInvoker, AndroidAsyncBinding")]
		global::Java.Lang.Object TryGet ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.future']/interface[@name='Future']/method[@name='tryGetException' and count(parameter)=0]"
		[Register ("tryGetException", "()Ljava/lang/Exception;", "GetTryGetExceptionHandler:Com.Koushikdutta.Async.Future.IFutureInvoker, AndroidAsyncBinding")]
		global::Java.Lang.Exception TryGetException ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/future/Future", DoNotGenerateAcw=true)]
	internal class IFutureInvoker : global::Java.Lang.Object, IFuture {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/future/Future");
		IntPtr class_ref;

		public static IFuture GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFuture> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.future.Future"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFutureInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFutureInvoker); }
		}

		static Delegate cb_setCallback_Lcom_koushikdutta_async_future_FutureCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_koushikdutta_async_future_FutureCallback_Handler ()
		{
			if (cb_setCallback_Lcom_koushikdutta_async_future_FutureCallback_ == null)
				cb_setCallback_Lcom_koushikdutta_async_future_FutureCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_koushikdutta_async_future_FutureCallback_);
			return cb_setCallback_Lcom_koushikdutta_async_future_FutureCallback_;
		}

		static IntPtr n_SetCallback_Lcom_koushikdutta_async_future_FutureCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Future.IFutureCallback p0 = (global::Com.Koushikdutta.Async.Future.IFutureCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFutureCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setCallback_Lcom_koushikdutta_async_future_FutureCallback_;
		public unsafe global::Com.Koushikdutta.Async.Future.IFuture SetCallback (global::Com.Koushikdutta.Async.Future.IFutureCallback p0)
		{
			if (id_setCallback_Lcom_koushikdutta_async_future_FutureCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_koushikdutta_async_future_FutureCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Future;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod (Handle, id_setCallback_Lcom_koushikdutta_async_future_FutureCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_then_Lcom_koushikdutta_async_future_FutureCallback_;
#pragma warning disable 0169
		static Delegate GetThen_Lcom_koushikdutta_async_future_FutureCallback_Handler ()
		{
			if (cb_then_Lcom_koushikdutta_async_future_FutureCallback_ == null)
				cb_then_Lcom_koushikdutta_async_future_FutureCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Then_Lcom_koushikdutta_async_future_FutureCallback_);
			return cb_then_Lcom_koushikdutta_async_future_FutureCallback_;
		}

		static IntPtr n_Then_Lcom_koushikdutta_async_future_FutureCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Then (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_then_Lcom_koushikdutta_async_future_FutureCallback_;
		public unsafe global::Java.Lang.Object Then (global::Java.Lang.Object p0)
		{
			if (id_then_Lcom_koushikdutta_async_future_FutureCallback_ == IntPtr.Zero)
				id_then_Lcom_koushikdutta_async_future_FutureCallback_ = JNIEnv.GetMethodID (class_ref, "then", "(Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/FutureCallback;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_then_Lcom_koushikdutta_async_future_FutureCallback_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_tryGet;
#pragma warning disable 0169
		static Delegate GetTryGetHandler ()
		{
			if (cb_tryGet == null)
				cb_tryGet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TryGet);
			return cb_tryGet;
		}

		static IntPtr n_TryGet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TryGet ());
		}
#pragma warning restore 0169

		IntPtr id_tryGet;
		public unsafe global::Java.Lang.Object TryGet ()
		{
			if (id_tryGet == IntPtr.Zero)
				id_tryGet = JNIEnv.GetMethodID (class_ref, "tryGet", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_tryGet), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_tryGetException;
#pragma warning disable 0169
		static Delegate GetTryGetExceptionHandler ()
		{
			if (cb_tryGetException == null)
				cb_tryGetException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TryGetException);
			return cb_tryGetException;
		}

		static IntPtr n_TryGetException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TryGetException ());
		}
#pragma warning restore 0169

		IntPtr id_tryGetException;
		public unsafe global::Java.Lang.Exception TryGetException ()
		{
			if (id_tryGetException == IntPtr.Zero)
				id_tryGetException = JNIEnv.GetMethodID (class_ref, "tryGetException", "()Ljava/lang/Exception;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (JNIEnv.CallObjectMethod (Handle, id_tryGetException), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (mayInterruptIfRunning);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Z;
		public unsafe global::System.Boolean Cancel (bool mayInterruptIfRunning)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (mayInterruptIfRunning);
			return JNIEnv.CallBooleanMethod (Handle, id_cancel_Z, __args);
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			global::Com.Koushikdutta.Async.Future.IFuture __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object Get (long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (timeout);
			__args [1] = new JValue (unit);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_get_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
