using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Body {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/body/Part", DoNotGenerateAcw=true)]
	public partial class Part : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/field[@name='CONTENT_DISPOSITION']"
		[Register ("CONTENT_DISPOSITION")]
		public const string ContentDisposition = (string) "Content-Disposition";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/body/Part", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Part); }
		}

		protected Part (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/constructor[@name='Part' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.Headers']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/Headers;)V", "")]
		public unsafe Part (global::Com.Koushikdutta.Async.Http.Headers p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Part)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/Headers;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/Headers;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/Headers;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_Headers_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_Headers_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_JLjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/constructor[@name='Part' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.util.List&lt;org.apache.http.NameValuePair&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;JLjava/util/List;)V", "")]
		public unsafe Part (string p0, long p1, global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Part)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JLjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JLjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JLjava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JLjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JLjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JLjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		static IntPtr id_setContentType_Ljava_lang_String_;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContentType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFilename;
#pragma warning disable 0169
		static Delegate GetGetFilenameHandler ()
		{
			if (cb_getFilename == null)
				cb_getFilename = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilename);
			return cb_getFilename;
		}

		static IntPtr n_GetFilename (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Filename);
		}
#pragma warning restore 0169

		static IntPtr id_getFilename;
		public virtual unsafe string Filename {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='getFilename' and count(parameter)=0]"
			[Register ("getFilename", "()Ljava/lang/String;", "GetGetFilenameHandler")]
			get {
				if (id_getFilename == IntPtr.Zero)
					id_getFilename = JNIEnv.GetMethodID (class_ref, "getFilename", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFilename), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilename", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFile;
#pragma warning disable 0169
		static Delegate GetIsFileHandler ()
		{
			if (cb_isFile == null)
				cb_isFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFile);
			return cb_isFile;
		}

		static bool n_IsFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFile;
		}
#pragma warning restore 0169

		static IntPtr id_isFile;
		public virtual unsafe bool IsFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='isFile' and count(parameter)=0]"
			[Register ("isFile", "()Z", "GetIsFileHandler")]
			get {
				if (id_isFile == IntPtr.Zero)
					id_isFile = JNIEnv.GetMethodID (class_ref, "isFile", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFile);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFile", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRawHeaders;
#pragma warning disable 0169
		static Delegate GetGetRawHeadersHandler ()
		{
			if (cb_getRawHeaders == null)
				cb_getRawHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawHeaders);
			return cb_getRawHeaders;
		}

		static IntPtr n_GetRawHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawHeaders);
		}
#pragma warning restore 0169

		static IntPtr id_getRawHeaders;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers RawHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='getRawHeaders' and count(parameter)=0]"
			[Register ("getRawHeaders", "()Lcom/koushikdutta/async/http/Headers;", "GetGetRawHeadersHandler")]
			get {
				if (id_getRawHeaders == IntPtr.Zero)
					id_getRawHeaders = JNIEnv.GetMethodID (class_ref, "getRawHeaders", "()Lcom/koushikdutta/async/http/Headers;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_getRawHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawHeaders", "()Lcom/koushikdutta/async/http/Headers;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Length);
			return cb_length;
		}

		static long n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()J", "GetLengthHandler")]
		public virtual unsafe long Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()J"));
			} finally {
			}
		}

		static Delegate cb_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_Handler ()
		{
			if (cb_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == null)
				cb_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_);
			return cb_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		}

		static void n_Write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Body.Part __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Body.Part> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p0 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.body']/class[@name='Part']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataSink'] and parameter[2][@type='com.koushikdutta.async.callback.CompletedCallback']]"
		[Register ("write", "(Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V", "GetWrite_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_Handler")]
		public virtual unsafe void Write (global::Com.Koushikdutta.Async.IDataSink p0, global::Com.Koushikdutta.Async.Callback.ICompletedCallback p1)
		{
			if (id_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ == IntPtr.Zero)
				id_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_write_Lcom_koushikdutta_async_DataSink_Lcom_koushikdutta_async_callback_CompletedCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/koushikdutta/async/DataSink;Lcom/koushikdutta/async/callback/CompletedCallback;)V"), __args);
			} finally {
			}
		}

	}
}
