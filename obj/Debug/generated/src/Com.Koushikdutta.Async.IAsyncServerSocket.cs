using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='AsyncServerSocket']"
	[Register ("com/koushikdutta/async/AsyncServerSocket", "", "Com.Koushikdutta.Async.IAsyncServerSocketInvoker")]
	public partial interface IAsyncServerSocket : IJavaObject {

		int LocalPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='AsyncServerSocket']/method[@name='getLocalPort' and count(parameter)=0]"
			[Register ("getLocalPort", "()I", "GetGetLocalPortHandler:Com.Koushikdutta.Async.IAsyncServerSocketInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='AsyncServerSocket']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Koushikdutta.Async.IAsyncServerSocketInvoker, AndroidAsyncBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServerSocket", DoNotGenerateAcw=true)]
	internal class IAsyncServerSocketInvoker : global::Java.Lang.Object, IAsyncServerSocket {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/AsyncServerSocket");
		IntPtr class_ref;

		public static IAsyncServerSocket GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncServerSocket> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.AsyncServerSocket"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncServerSocketInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncServerSocketInvoker); }
		}

		static Delegate cb_getLocalPort;
#pragma warning disable 0169
		static Delegate GetGetLocalPortHandler ()
		{
			if (cb_getLocalPort == null)
				cb_getLocalPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLocalPort);
			return cb_getLocalPort;
		}

		static int n_GetLocalPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.IAsyncServerSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalPort;
		}
#pragma warning restore 0169

		IntPtr id_getLocalPort;
		public unsafe int LocalPort {
			get {
				if (id_getLocalPort == IntPtr.Zero)
					id_getLocalPort = JNIEnv.GetMethodID (class_ref, "getLocalPort", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLocalPort);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.IAsyncServerSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (Handle, id_stop);
		}

	}

}
