using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='ByteBufferListInputStream']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/stream/ByteBufferListInputStream", DoNotGenerateAcw=true)]
	public partial class ByteBufferListInputStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/stream/ByteBufferListInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteBufferListInputStream); }
		}

		protected ByteBufferListInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='ByteBufferListInputStream']/constructor[@name='ByteBufferListInputStream' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/ByteBufferList;)V", "")]
		public unsafe ByteBufferListInputStream (global::Com.Koushikdutta.Async.ByteBufferList p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ByteBufferListInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/ByteBufferList;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/ByteBufferList;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/ByteBufferList;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_ByteBufferList_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_ByteBufferList_, __args);
			} finally {
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Stream.ByteBufferListInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Stream.ByteBufferListInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.stream']/class[@name='ByteBufferListInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_read);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
			} finally {
			}
		}

	}
}
