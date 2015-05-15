using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncDatagramSocket']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncDatagramSocket", DoNotGenerateAcw=true)]
	public partial class AsyncDatagramSocket : global::Com.Koushikdutta.Async.AsyncNetworkSocket {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/AsyncDatagramSocket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncDatagramSocket); }
		}

		protected AsyncDatagramSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncDatagramSocket']/constructor[@name='AsyncDatagramSocket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncDatagramSocket ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncDatagramSocket)) {
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

		static Delegate cb_connect_Ljava_net_InetSocketAddress_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_net_InetSocketAddress_Handler ()
		{
			if (cb_connect_Ljava_net_InetSocketAddress_ == null)
				cb_connect_Ljava_net_InetSocketAddress_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_net_InetSocketAddress_);
			return cb_connect_Ljava_net_InetSocketAddress_;
		}

		static void n_Connect_Ljava_net_InetSocketAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncDatagramSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_net_InetSocketAddress_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncDatagramSocket']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.net.InetSocketAddress']]"
		[Register ("connect", "(Ljava/net/InetSocketAddress;)V", "GetConnect_Ljava_net_InetSocketAddress_Handler")]
		public virtual unsafe void Connect (global::Java.Net.InetSocketAddress p0)
		{
			if (id_connect_Ljava_net_InetSocketAddress_ == IntPtr.Zero)
				id_connect_Ljava_net_InetSocketAddress_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/net/InetSocketAddress;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_connect_Ljava_net_InetSocketAddress_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/net/InetSocketAddress;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncDatagramSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncDatagramSocket']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_send_Ljava_lang_String_ILjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_ILjava_nio_ByteBuffer_Handler ()
		{
			if (cb_send_Ljava_lang_String_ILjava_nio_ByteBuffer_ == null)
				cb_send_Ljava_lang_String_ILjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Send_Ljava_lang_String_ILjava_nio_ByteBuffer_);
			return cb_send_Ljava_lang_String_ILjava_nio_ByteBuffer_;
		}

		static void n_Send_Ljava_lang_String_ILjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.AsyncDatagramSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_ILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncDatagramSocket']/method[@name='send' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("send", "(Ljava/lang/String;ILjava/nio/ByteBuffer;)V", "GetSend_Ljava_lang_String_ILjava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Send (string p0, int p1, global::Java.Nio.ByteBuffer p2)
		{
			if (id_send_Ljava_lang_String_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;ILjava/nio/ByteBuffer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_ILjava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;ILjava/nio/ByteBuffer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_ == null)
				cb_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_);
			return cb_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_;
		}

		static void n_Send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.AsyncDatagramSocket __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncDatagramSocket']/method[@name='send' and count(parameter)=2 and parameter[1][@type='java.net.InetSocketAddress'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("send", "(Ljava/net/InetSocketAddress;Ljava/nio/ByteBuffer;)V", "GetSend_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Send (global::Java.Net.InetSocketAddress p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/net/InetSocketAddress;Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_net_InetSocketAddress_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/net/InetSocketAddress;Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
