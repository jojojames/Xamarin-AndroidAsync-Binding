using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='Charsets']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/util/Charsets", DoNotGenerateAcw=true)]
	public partial class Charsets : global::Java.Lang.Object {


		static IntPtr US_ASCII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='Charsets']/field[@name='US_ASCII']"
		[Register ("US_ASCII")]
		public static global::Java.Nio.Charset.Charset UsAscii {
			get {
				if (US_ASCII_jfieldId == IntPtr.Zero)
					US_ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "US_ASCII", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, US_ASCII_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='Charsets']/field[@name='UTF_8']"
		[Register ("UTF_8")]
		public static global::Java.Nio.Charset.Charset Utf8 {
			get {
				if (UTF_8_jfieldId == IntPtr.Zero)
					UTF_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF_8", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/util/Charsets", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Charsets); }
		}

		protected Charsets (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='Charsets']/constructor[@name='Charsets' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Charsets ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Charsets)) {
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

	}
}
