using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Parser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.parser']/class[@name='StringParser']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/parser/StringParser", DoNotGenerateAcw=true)]
	public partial class StringParser : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Parser.IAsyncParser {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/parser/StringParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringParser); }
		}

		protected StringParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.parser']/class[@name='StringParser']/constructor[@name='StringParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StringParser)) {
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

		static IntPtr id_ctor_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.parser']/class[@name='StringParser']/constructor[@name='StringParser' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/nio/charset/Charset;)V", "")]
		public unsafe StringParser (global::Java.Nio.Charset.Charset p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (StringParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/charset/Charset;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/charset/Charset;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_charset_Charset_ == IntPtr.Zero)
					id_ctor_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/charset/Charset;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_charset_Charset_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_charset_Charset_, __args);
			} finally {
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Parser.StringParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Parser.StringParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Java.Lang.Reflect.IType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.parser']/class[@name='StringParser']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/reflect/Type;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/reflect/Type;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/reflect/Type;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_parse_Lcom_koushikdutta_async_DataEmitter_;
#pragma warning disable 0169
		static Delegate GetParse_Lcom_koushikdutta_async_DataEmitter_Handler ()
		{
			if (cb_parse_Lcom_koushikdutta_async_DataEmitter_ == null)
				cb_parse_Lcom_koushikdutta_async_DataEmitter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Lcom_koushikdutta_async_DataEmitter_);
			return cb_parse_Lcom_koushikdutta_async_DataEmitter_;
		}

		static IntPtr n_Parse_Lcom_koushikdutta_async_DataEmitter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Parser.StringParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Parser.StringParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Lcom_koushikdutta_async_DataEmitter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.parser']/class[@name='StringParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataEmitter']]"
		[Register ("parse", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/future/Future;", "GetParse_Lcom_koushikdutta_async_DataEmitter_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture Parse (global::Com.Koushikdutta.Async.IDataEmitter p0)
		{
			if (id_parse_Lcom_koushikdutta_async_DataEmitter_ == IntPtr.Zero)
				id_parse_Lcom_koushikdutta_async_DataEmitter_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/future/Future;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_parse_Lcom_koushikdutta_async_DataEmitter_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_Write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Parser.StringParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Parser.StringParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p0 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.parser']/class[@name='StringParser']/method[@name='write' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.DataSink'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("write", "(Lcom/koushikdutta/async/DataSink;Ljava/lang/String;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetWrite_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
		public virtual unsafe void Write (global::Com.Koushikdutta.Async.IDataSink p0, string p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/DataSink;Ljava/lang/String;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_String_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/koushikdutta/async/DataSink;Ljava/lang/String;Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Koushikdutta.Async.Parser.IAsyncParser
		global::Com.Koushikdutta.Async.Future.IFuture global::Com.Koushikdutta.Async.Parser.IAsyncParser.Parse (global::Com.Koushikdutta.Async.IDataEmitter p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Koushikdutta.Async.Future.IFuture>(Parse (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Koushikdutta.Async.Parser.IAsyncParser
		void global::Com.Koushikdutta.Async.Parser.IAsyncParser.Write (global::Com.Koushikdutta.Async.IDataSink p0, global::Java.Lang.Object p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			Write (p0, p1.ToString (), p2);
		}

	}
}
