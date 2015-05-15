using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/util/StreamUtility", DoNotGenerateAcw=true)]
	public partial class StreamUtility : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/util/StreamUtility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamUtility); }
		}

		protected StreamUtility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/constructor[@name='StreamUtility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StreamUtility ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StreamUtility)) {
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

		static IntPtr id_closeQuietly_arrayLjava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable...']]"
		[Register ("closeQuietly", "([Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (params global:: Java.IO.ICloseable[] p0)
		{
			if (id_closeQuietly_arrayLjava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_arrayLjava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "([Ljava/io/Closeable;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_arrayLjava_io_Closeable_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='copyStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "")]
		public static unsafe void CopyStream (global::System.IO.Stream p0, global::System.IO.Stream p1)
		{
			if (id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copyStream", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_copyStream_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_eat_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='eat' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("eat", "(Ljava/io/InputStream;)V", "")]
		public static unsafe void Eat (global::System.IO.Stream p0)
		{
			if (id_eat_Ljava_io_InputStream_ == IntPtr.Zero)
				id_eat_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "eat", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_eat_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fastChannelCopy_Ljava_nio_channels_ReadableByteChannel_Ljava_nio_channels_WritableByteChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='fastChannelCopy' and count(parameter)=2 and parameter[1][@type='java.nio.channels.ReadableByteChannel'] and parameter[2][@type='java.nio.channels.WritableByteChannel']]"
		[Register ("fastChannelCopy", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/channels/WritableByteChannel;)V", "")]
		public static unsafe void FastChannelCopy (global::Java.Nio.Channels.IReadableByteChannel p0, global::Java.Nio.Channels.IWritableByteChannel p1)
		{
			if (id_fastChannelCopy_Ljava_nio_channels_ReadableByteChannel_Ljava_nio_channels_WritableByteChannel_ == IntPtr.Zero)
				id_fastChannelCopy_Ljava_nio_channels_ReadableByteChannel_Ljava_nio_channels_WritableByteChannel_ = JNIEnv.GetStaticMethodID (class_ref, "fastChannelCopy", "(Ljava/nio/channels/ReadableByteChannel;Ljava/nio/channels/WritableByteChannel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fastChannelCopy_Ljava_nio_channels_ReadableByteChannel_Ljava_nio_channels_WritableByteChannel_, __args);
			} finally {
			}
		}

		static IntPtr id_readFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='readFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readFile", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string ReadFile (global::Java.IO.File p0)
		{
			if (id_readFile_Ljava_io_File_ == IntPtr.Zero)
				id_readFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readFile", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFile_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='readFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readFile", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReadFile (string p0)
		{
			if (id_readFile_Ljava_lang_String_ == IntPtr.Zero)
				id_readFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readFile", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readToEnd_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='readToEnd' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readToEnd", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ReadToEnd (global::System.IO.Stream p0)
		{
			if (id_readToEnd_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readToEnd_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readToEnd", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readToEnd_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readToEndAsArray_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='readToEndAsArray' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readToEndAsArray", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] ReadToEndAsArray (global::System.IO.Stream p0)
		{
			if (id_readToEndAsArray_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readToEndAsArray_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readToEndAsArray", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_readToEndAsArray_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_writeFile_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeFile", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public static unsafe void WriteFile (global::Java.IO.File p0, string p1)
		{
			if (id_writeFile_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_writeFile_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/io/File;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeFile_Ljava_io_File_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_writeFile_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.util']/class[@name='StreamUtility']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeFile", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void WriteFile (string p0, string p1)
		{
			if (id_writeFile_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writeFile_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeFile", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeFile_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
