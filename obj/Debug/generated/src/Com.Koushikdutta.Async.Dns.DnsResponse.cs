using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Dns {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/dns/DnsResponse", DoNotGenerateAcw=true)]
	public partial class DnsResponse : global::Java.Lang.Object {


		static IntPtr addresses_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']/field[@name='addresses']"
		[Register ("addresses")]
		public global::System.Collections.IList Addresses {
			get {
				if (addresses_jfieldId == IntPtr.Zero)
					addresses_jfieldId = JNIEnv.GetFieldID (class_ref, "addresses", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, addresses_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (addresses_jfieldId == IntPtr.Zero)
					addresses_jfieldId = JNIEnv.GetFieldID (class_ref, "addresses", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, addresses_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr names_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']/field[@name='names']"
		[Register ("names")]
		public global::System.Collections.IList Names {
			get {
				if (names_jfieldId == IntPtr.Zero)
					names_jfieldId = JNIEnv.GetFieldID (class_ref, "names", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, names_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (names_jfieldId == IntPtr.Zero)
					names_jfieldId = JNIEnv.GetFieldID (class_ref, "names", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, names_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr source_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']/field[@name='source']"
		[Register ("source")]
		public global::Java.Net.InetSocketAddress Source {
			get {
				if (source_jfieldId == IntPtr.Zero)
					source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Ljava/net/InetSocketAddress;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, source_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (source_jfieldId == IntPtr.Zero)
					source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Ljava/net/InetSocketAddress;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, source_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr txt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']/field[@name='txt']"
		[Register ("txt")]
		public global::Com.Koushikdutta.Async.Http.Multimap Txt {
			get {
				if (txt_jfieldId == IntPtr.Zero)
					txt_jfieldId = JNIEnv.GetFieldID (class_ref, "txt", "Lcom/koushikdutta/async/http/Multimap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, txt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (txt_jfieldId == IntPtr.Zero)
					txt_jfieldId = JNIEnv.GetFieldID (class_ref, "txt", "Lcom/koushikdutta/async/http/Multimap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, txt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/dns/DnsResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DnsResponse); }
		}

		protected DnsResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']/constructor[@name='DnsResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DnsResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DnsResponse)) {
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

		static IntPtr id_parse_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.dns']/class[@name='DnsResponse']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("parse", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/dns/DnsResponse;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Dns.DnsResponse Parse (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_parse_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_parse_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/dns/DnsResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Koushikdutta.Async.Dns.DnsResponse __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Dns.DnsResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lcom_koushikdutta_async_ByteBufferList_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
