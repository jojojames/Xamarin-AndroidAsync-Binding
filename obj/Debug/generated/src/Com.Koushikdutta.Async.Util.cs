using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Util)) {
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

		static IntPtr id_emitAllData_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='emitAllData' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("emitAllData", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V", "")]
		public static unsafe void EmitAllData (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.ByteBufferList p1)
		{
			if (id_emitAllData_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_emitAllData_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetStaticMethodID (class_ref, "emitAllData", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_emitAllData_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_, __args);
			} finally {
			}
		}

		static IntPtr id_end_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='end' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("end", "(Lcom/koushikdutta/async/DataEmitter;Ljava/lang/Exception;)V", "")]
		public static unsafe void End (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Java.Lang.Exception p1)
		{
			if (id_end_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Exception_ == IntPtr.Zero)
				id_end_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "end", "(Lcom/koushikdutta/async/DataEmitter;Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_end_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_end_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='end' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("end", "(Lcom/koushikdutta/async/callback/CompletedCallback;Ljava/lang/Exception;)V", "")]
		public static unsafe void End (global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0, global::Java.Lang.Exception p1)
		{
			if (id_end_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ == IntPtr.Zero)
				id_end_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "end", "(Lcom/koushikdutta/async/callback/CompletedCallback;Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_end_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_getWrappedDataEmitter_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='getWrappedDataEmitter' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='java.lang.Class']]"
		[Register ("getWrappedDataEmitter", "(Lcom/koushikdutta/async/DataEmitter;Ljava/lang/Class;)Lcom/koushikdutta/async/DataEmitter;", "")]
		public static unsafe global::Com.Koushikdutta.Async.IDataEmitter GetWrappedDataEmitter (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Java.Lang.Class p1)
		{
			if (id_getWrappedDataEmitter_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Class_ == IntPtr.Zero)
				id_getWrappedDataEmitter_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getWrappedDataEmitter", "(Lcom/koushikdutta/async/DataEmitter;Ljava/lang/Class;)Lcom/koushikdutta/async/DataEmitter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Koushikdutta.Async.IDataEmitter __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWrappedDataEmitter_Lcom_koushikdutta_async_DataEmitter_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getWrappedSocket_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='getWrappedSocket' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.AsyncSocket'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getWrappedSocket", "(Lcom/koushikdutta/async/AsyncSocket;Ljava/lang/Class;)Lcom/koushikdutta/async/AsyncSocket;", "")]
		public static unsafe global::Java.Lang.Object GetWrappedSocket (global::Com.Koushikdutta.Async.IAsyncSocket p0, global::Java.Lang.Class p1)
		{
			if (id_getWrappedSocket_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_Class_ == IntPtr.Zero)
				id_getWrappedSocket_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "getWrappedSocket", "(Lcom/koushikdutta/async/AsyncSocket;Ljava/lang/Class;)Lcom/koushikdutta/async/AsyncSocket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWrappedSocket_Lcom_koushikdutta_async_AsyncSocket_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pump_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='pump' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.DataSink'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("pump", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void Pump (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.IDataSink p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_pump_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_pump_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "pump", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pump_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pump_Ljava_io_File_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='pump' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.koushikdutta.async.DataSink'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("pump", "(Ljava/io/File;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void Pump (global::Java.IO.File p0, global::Com.Koushikdutta.Async.IDataSink p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_pump_Ljava_io_File_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_pump_Ljava_io_File_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "pump", "(Ljava/io/File;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pump_Ljava_io_File_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_pump_Ljava_io_InputStream_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='pump' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='com.koushikdutta.async.DataSink'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("pump", "(Ljava/io/InputStream;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void Pump (global::System.IO.Stream p0, global::Com.Koushikdutta.Async.IDataSink p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_pump_Ljava_io_InputStream_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_pump_Ljava_io_InputStream_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "pump", "(Ljava/io/InputStream;Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pump_Ljava_io_InputStream_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_pump_Ljava_io_InputStream_JLcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='pump' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long'] and parameter[3][@type='com.koushikdutta.async.DataSink'] and parameter[4][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("pump", "(Ljava/io/InputStream;JLcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void Pump (global::System.IO.Stream p0, long p1, global::Com.Koushikdutta.Async.IDataSink p2, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p3)
		{
			if (id_pump_Ljava_io_InputStream_JLcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_pump_Ljava_io_InputStream_JLcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "pump", "(Ljava/io/InputStream;JLcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_pump_Ljava_io_InputStream_JLcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_stream_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='stream' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.AsyncSocket'] and parameter[2][@type='com.koushikdutta.async.AsyncSocket'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("stream", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void Stream (global::Com.Koushikdutta.Async.IAsyncSocket p0, global::Com.Koushikdutta.Async.IAsyncSocket p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_stream_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_stream_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "stream", "(Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/AsyncSocket;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stream_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_AsyncSocket_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_writable_Lcom_koushikdutta_async_DataSink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='writable' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
		[Register ("writable", "(Lcom/koushikdutta/async/DataSink;)V", "")]
		public static unsafe void Writable (global::Com.Koushikdutta.Async.IDataSink p0)
		{
			if (id_writable_Lcom_koushikdutta_async_DataSink_ == IntPtr.Zero)
				id_writable_Lcom_koushikdutta_async_DataSink_ = JNIEnv.GetStaticMethodID (class_ref, "writable", "(Lcom/koushikdutta/async/DataSink;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writable_Lcom_koushikdutta_async_DataSink_, __args);
			} finally {
			}
		}

		static IntPtr id_writable_Lcom_koushikdutta_async_callback_WritableCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='writable' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.callback.WritableCallback']]"
		[Register ("writable", "(Lcom/koushikdutta/async/callback/WritableCallback;)V", "")]
		public static unsafe void Writable (global::Com.Koushikdutta.Async.Callback.IWritableCallback p0)
		{
			if (id_writable_Lcom_koushikdutta_async_callback_WritableCallback_ == IntPtr.Zero)
				id_writable_Lcom_koushikdutta_async_callback_WritableCallback_ = JNIEnv.GetStaticMethodID (class_ref, "writable", "(Lcom/koushikdutta/async/callback/WritableCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writable_Lcom_koushikdutta_async_callback_WritableCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_writeAll_Lcom_koushikdutta_async_DataSink_arrayBLcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='writeAll' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.DataSink'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("writeAll", "(Lcom/koushikdutta/async/DataSink;[BLcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void WriteAll (global::Com.Koushikdutta.Async.IDataSink p0, byte[] p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_writeAll_Lcom_koushikdutta_async_DataSink_arrayBLcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_writeAll_Lcom_koushikdutta_async_DataSink_arrayBLcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "writeAll", "(Lcom/koushikdutta/async/DataSink;[BLcom/koushikdutta/async/callback/CompletedCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeAll_Lcom_koushikdutta_async_DataSink_arrayBLcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_writeAll_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_ByteBufferList_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='Util']/method[@name='writeAll' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.DataSink'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("writeAll", "(Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/ByteBufferList;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "")]
		public static unsafe void WriteAll (global::Com.Koushikdutta.Async.IDataSink p0, global::Com.Koushikdutta.Async.ByteBufferList p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_writeAll_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_ByteBufferList_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_writeAll_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_ByteBufferList_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "writeAll", "(Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/ByteBufferList;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeAll_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_ByteBufferList_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			} finally {
			}
		}

	}
}
