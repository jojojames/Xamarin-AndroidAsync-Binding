using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Callback {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ConnectCallback']"
	[Register ("com/koushikdutta/async/callback/ConnectCallback", "", "Com.Koushikdutta.Async.Callback.IConnectCallbackInvoker")]
	public partial interface IConnectCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.callback']/interface[@name='ConnectCallback']/method[@name='onConnectCompleted' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='com.koushikdutta.async.AsyncSocket']]"
		[Register ("onConnectCompleted", "(Ljava/lang/Exception;Lcom/koushikdutta/async/AsyncSocket;)V", "GetOnConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_Handler:Com.Koushikdutta.Async.Callback.IConnectCallbackInvoker, AndroidAsyncBinding")]
		void OnConnectCompleted (global::Java.Lang.Exception p0, global::Com.Koushikdutta.Async.IAsyncSocket p1);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/callback/ConnectCallback", DoNotGenerateAcw=true)]
	internal class IConnectCallbackInvoker : global::Java.Lang.Object, IConnectCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/callback/ConnectCallback");
		IntPtr class_ref;

		public static IConnectCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.callback.ConnectCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IConnectCallbackInvoker); }
		}

		static Delegate cb_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_;
#pragma warning disable 0169
		static Delegate GetOnConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_Handler ()
		{
			if (cb_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_ == null)
				cb_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_);
			return cb_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_;
		}

		static void n_OnConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Callback.IConnectCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IAsyncSocket p1 = (global::Com.Koushikdutta.Async.IAsyncSocket)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_;
		public unsafe void OnConnectCompleted (global::Java.Lang.Exception p0, global::Com.Koushikdutta.Async.IAsyncSocket p1)
		{
			if (id_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_ == IntPtr.Zero)
				id_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_ = JNIEnv.GetMethodID (class_ref, "onConnectCompleted", "(Ljava/lang/Exception;Lcom/koushikdutta/async/AsyncSocket;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onConnectCompleted_Ljava_lang_Exception_Lcom_koushikdutta_async_AsyncSocket_, __args);
		}

	}

}
