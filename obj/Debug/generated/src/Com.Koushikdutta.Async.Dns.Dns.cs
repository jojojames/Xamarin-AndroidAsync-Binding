using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Dns {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/dns/Dns", DoNotGenerateAcw=true)]
	public partial class Dns : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/dns/Dns", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dns); }
		}

		protected Dns (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']/constructor[@name='Dns' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dns ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Dns)) {
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

		static IntPtr id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']/method[@name='lookup' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.AsyncServer'] and parameter[2][@type='java.lang.String']]"
		[Register ("lookup", "(Lcom/koushikdutta/async/AsyncServer;Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.IFuture Lookup (global::Com.Koushikdutta.Async.AsyncServer p0, string p1)
		{
			if (id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_ == IntPtr.Zero)
				id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(Lcom/koushikdutta/async/AsyncServer;Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_ZLcom_koushikdutta_async_future_FutureCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']/method[@name='lookup' and count(parameter)=4 and parameter[1][@type='com.koushikdutta.async.AsyncServer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='com.koushikdutta.async.future.FutureCallback&lt;com.koushikdutta.async.dns.DnsResponse&gt;']]"
		[Register ("lookup", "(Lcom/koushikdutta/async/AsyncServer;Ljava/lang/String;ZLcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Future;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.IFuture Lookup (global::Com.Koushikdutta.Async.AsyncServer p0, string p1, bool p2, global::Com.Koushikdutta.Async.Future.IFutureCallback p3)
		{
			if (id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_ZLcom_koushikdutta_async_future_FutureCallback_ == IntPtr.Zero)
				id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_ZLcom_koushikdutta_async_future_FutureCallback_ = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(Lcom/koushikdutta/async/AsyncServer;Ljava/lang/String;ZLcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_ZLcom_koushikdutta_async_future_FutureCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_lookup_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']/method[@name='lookup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lookup", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.IFuture Lookup (string p0)
		{
			if (id_lookup_Ljava_lang_String_ == IntPtr.Zero)
				id_lookup_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "lookup", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_lookup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_multicastLookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']/method[@name='multicastLookup' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.AsyncServer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.future.FutureCallback&lt;com.koushikdutta.async.dns.DnsResponse&gt;']]"
		[Register ("multicastLookup", "(Lcom/koushikdutta/async/AsyncServer;Ljava/lang/String;Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Cancellable;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.ICancellable MulticastLookup (global::Com.Koushikdutta.Async.AsyncServer p0, string p1, global::Com.Koushikdutta.Async.Future.IFutureCallback p2)
		{
			if (id_multicastLookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_ == IntPtr.Zero)
				id_multicastLookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_ = JNIEnv.GetStaticMethodID (class_ref, "multicastLookup", "(Lcom/koushikdutta/async/AsyncServer;Ljava/lang/String;Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Cancellable;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Com.Koushikdutta.Async.Future.ICancellable __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_multicastLookup_Lcom_koushikdutta_async_AsyncServer_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_multicastLookup_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='Dns']/method[@name='multicastLookup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.future.FutureCallback&lt;com.koushikdutta.async.dns.DnsResponse&gt;']]"
		[Register ("multicastLookup", "(Ljava/lang/String;Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Cancellable;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Future.ICancellable MulticastLookup (string p0, global::Com.Koushikdutta.Async.Future.IFutureCallback p1)
		{
			if (id_multicastLookup_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_ == IntPtr.Zero)
				id_multicastLookup_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_ = JNIEnv.GetStaticMethodID (class_ref, "multicastLookup", "(Ljava/lang/String;Lcom/koushikdutta/async/future/FutureCallback;)Lcom/koushikdutta/async/future/Cancellable;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Koushikdutta.Async.Future.ICancellable __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_multicastLookup_Ljava_lang_String_Lcom_koushikdutta_async_future_FutureCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
