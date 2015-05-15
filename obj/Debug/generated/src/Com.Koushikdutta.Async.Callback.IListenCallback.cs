using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ListenCallback']"
	[Register ("com/koushikdutta/async/callback/ListenCallback", "", "Com.Koushikdutta.Async.Callback.IListenCallbackInvoker")]
	public partial interface IListenCallback : global::Com.Koushikdutta.Async.Callback.ICompletedCallback {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ListenCallback']/method[@name='onAccepted' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.AsyncSocket']]"
		[Register ("onAccepted", "(Lcom/koushikdutta/async/AsyncSocket;)V", "GetOnAccepted_Lcom_koushikdutta_async_AsyncSocket_Handler:Com.Koushikdutta.Async.Callback.IListenCallbackInvoker, AndroidAsyncBinding")]
		void OnAccepted (global::Com.Koushikdutta.Async.IAsyncSocket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ListenCallback']/method[@name='onListening' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.AsyncServerSocket']]"
		[Register ("onListening", "(Lcom/koushikdutta/async/AsyncServerSocket;)V", "GetOnListening_Lcom_koushikdutta_async_AsyncServerSocket_Handler:Com.Koushikdutta.Async.Callback.IListenCallbackInvoker, AndroidAsyncBinding")]
		void OnListening (global::Com.Koushikdutta.Async.IAsyncServerSocket p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/ListenCallback", DoNotGenerateAcw=true)]
	internal class IListenCallbackInvoker : global::Java.Lang.Object, IListenCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/callback/ListenCallback");
		IntPtr class_ref;

		public static IListenCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IListenCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.callback.ListenCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IListenCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IListenCallbackInvoker); }
		}

		static Delegate cb_onAccepted_Lcom_koushikdutta_async_AsyncSocket_;
#pragma warning disable 0169
		static Delegate GetOnAccepted_Lcom_koushikdutta_async_AsyncSocket_Handler ()
		{
			if (cb_onAccepted_Lcom_koushikdutta_async_AsyncSocket_ == null)
				cb_onAccepted_Lcom_koushikdutta_async_AsyncSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccepted_Lcom_koushikdutta_async_AsyncSocket_);
			return cb_onAccepted_Lcom_koushikdutta_async_AsyncSocket_;
		}

		static void n_OnAccepted_Lcom_koushikdutta_async_AsyncSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Callback.IListenCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IListenCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IAsyncSocket p0 = (global::Com.Koushikdutta.Async.IAsyncSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccepted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAccepted_Lcom_koushikdutta_async_AsyncSocket_;
		public unsafe void OnAccepted (global::Com.Koushikdutta.Async.IAsyncSocket p0)
		{
			if (id_onAccepted_Lcom_koushikdutta_async_AsyncSocket_ == IntPtr.Zero)
				id_onAccepted_Lcom_koushikdutta_async_AsyncSocket_ = JNIEnv.GetMethodID (class_ref, "onAccepted", "(Lcom/koushikdutta/async/AsyncSocket;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onAccepted_Lcom_koushikdutta_async_AsyncSocket_, __args);
		}

		static Delegate cb_onListening_Lcom_koushikdutta_async_AsyncServerSocket_;
#pragma warning disable 0169
		static Delegate GetOnListening_Lcom_koushikdutta_async_AsyncServerSocket_Handler ()
		{
			if (cb_onListening_Lcom_koushikdutta_async_AsyncServerSocket_ == null)
				cb_onListening_Lcom_koushikdutta_async_AsyncServerSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnListening_Lcom_koushikdutta_async_AsyncServerSocket_);
			return cb_onListening_Lcom_koushikdutta_async_AsyncServerSocket_;
		}

		static void n_OnListening_Lcom_koushikdutta_async_AsyncServerSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Callback.IListenCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IListenCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IAsyncServerSocket p0 = (global::Com.Koushikdutta.Async.IAsyncServerSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnListening (p0);
		}
#pragma warning restore 0169

		IntPtr id_onListening_Lcom_koushikdutta_async_AsyncServerSocket_;
		public unsafe void OnListening (global::Com.Koushikdutta.Async.IAsyncServerSocket p0)
		{
			if (id_onListening_Lcom_koushikdutta_async_AsyncServerSocket_ == IntPtr.Zero)
				id_onListening_Lcom_koushikdutta_async_AsyncServerSocket_ = JNIEnv.GetMethodID (class_ref, "onListening", "(Lcom/koushikdutta/async/AsyncServerSocket;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onListening_Lcom_koushikdutta_async_AsyncServerSocket_, __args);
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
			global::Com.Koushikdutta.Async.Callback.IListenCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IListenCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
