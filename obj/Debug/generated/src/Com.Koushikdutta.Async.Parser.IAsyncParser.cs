using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Parser {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.parser']/interface[@name='AsyncParser']"
	[Register ("com/koushikdutta/async/parser/AsyncParser", "", "Com.Koushikdutta.Async.Parser.IAsyncParserInvoker")]
	public partial interface IAsyncParser : IJavaObject {

		global::Java.Lang.Reflect.IType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.parser']/interface[@name='AsyncParser']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/reflect/Type;", "GetGetTypeHandler:Com.Koushikdutta.Async.Parser.IAsyncParserInvoker, AndroidAsyncBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.parser']/interface[@name='AsyncParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataEmitter']]"
		[Register ("parse", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/future/Future;", "GetParse_Lcom_koushikdutta_async_DataEmitter_Handler:Com.Koushikdutta.Async.Parser.IAsyncParserInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Future.IFuture Parse (global::Com.Koushikdutta.Async.IDataEmitter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.parser']/interface[@name='AsyncParser']/method[@name='write' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.DataSink'] and parameter[2][@type='T'] and parameter[3][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("write", "(Lcom/koushikdutta/async/DataSink;Ljava/lang/Object;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetWrite_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_Handler:Com.Koushikdutta.Async.Parser.IAsyncParserInvoker, AndroidAsyncBinding")]
		void Write (global::Com.Koushikdutta.Async.IDataSink p0, global::Java.Lang.Object p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/parser/AsyncParser", DoNotGenerateAcw=true)]
	internal class IAsyncParserInvoker : global::Java.Lang.Object, IAsyncParser {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/parser/AsyncParser");
		IntPtr class_ref;

		public static IAsyncParser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncParser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.parser.AsyncParser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncParserInvoker); }
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
			global::Com.Koushikdutta.Async.Parser.IAsyncParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Parser.IAsyncParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Java.Lang.Reflect.IType Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/reflect/Type;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Koushikdutta.Async.Parser.IAsyncParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Parser.IAsyncParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_Lcom_koushikdutta_async_DataEmitter_;
		public unsafe global::Com.Koushikdutta.Async.Future.IFuture Parse (global::Com.Koushikdutta.Async.IDataEmitter p0)
		{
			if (id_parse_Lcom_koushikdutta_async_DataEmitter_ == IntPtr.Zero)
				id_parse_Lcom_koushikdutta_async_DataEmitter_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/future/Future;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Future.IFuture __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod (Handle, id_parse_Lcom_koushikdutta_async_DataEmitter_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_Write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.Parser.IAsyncParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Parser.IAsyncParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p0 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_;
		public unsafe void Write (global::Com.Koushikdutta.Async.IDataSink p0, global::Java.Lang.Object p1, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p2)
		{
			if (id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/DataSink;Ljava/lang/Object;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_write_Lcom_koushikdutta_async_DataSink_Ljava_lang_Object_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
