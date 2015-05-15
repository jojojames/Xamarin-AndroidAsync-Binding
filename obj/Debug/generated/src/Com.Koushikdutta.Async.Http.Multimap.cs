using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/Multimap", DoNotGenerateAcw=true)]
	public partial class Multimap : global::Java.Util.LinkedHashMap, global::Java.Lang.IIterable {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='Multimap.StringDecoder']"
		[Register ("com/koushikdutta/async/http/Multimap$StringDecoder", "", "Com.Koushikdutta.Async.Http.Multimap/IStringDecoderInvoker")]
		public partial interface IStringDecoder : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='Multimap.StringDecoder']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("decode", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecode_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.Multimap/IStringDecoderInvoker, AndroidAsyncBinding")]
			string Decode (string p0);

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/http/Multimap$StringDecoder", DoNotGenerateAcw=true)]
		internal class IStringDecoderInvoker : global::Java.Lang.Object, IStringDecoder {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/Multimap$StringDecoder");
			IntPtr class_ref;

			public static IStringDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStringDecoder> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.Multimap.StringDecoder"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStringDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IStringDecoderInvoker); }
			}

			static Delegate cb_decode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDecode_Ljava_lang_String_Handler ()
			{
				if (cb_decode_Ljava_lang_String_ == null)
					cb_decode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_lang_String_);
				return cb_decode_Ljava_lang_String_;
			}

			static IntPtr n_Decode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.Http.Multimap.IStringDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap.IStringDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.Decode (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_decode_Ljava_lang_String_;
			public unsafe string Decode (string p0)
			{
				if (id_decode_Ljava_lang_String_ == IntPtr.Zero)
					id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_decode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/Multimap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Multimap); }
		}

		protected Multimap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/constructor[@name='Multimap' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.apache.http.NameValuePair&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe Multimap (global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Multimap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_Multimap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/constructor[@name='Multimap' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.Multimap']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/Multimap;)V", "")]
		public unsafe Multimap (global::Com.Koushikdutta.Async.Http.Multimap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Multimap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/Multimap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/Multimap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_Multimap_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_Multimap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/Multimap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_Multimap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_Multimap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/constructor[@name='Multimap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Multimap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Multimap)) {
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

		static Delegate cb_add_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Add_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Multimap __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAdd_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Add (string p0, string p1)
		{
			if (id_add_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Multimap __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Multimap __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newList;
#pragma warning disable 0169
		static Delegate GetNewListHandler ()
		{
			if (cb_newList == null)
				cb_newList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewList);
			return cb_newList;
		}

		static IntPtr n_NewList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Multimap __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.NewList ());
		}
#pragma warning restore 0169

		static IntPtr id_newList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='newList' and count(parameter)=0]"
		[Register ("newList", "()Ljava/util/List;", "GetNewListHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<string> NewList ()
		{
			if (id_newList == IntPtr.Zero)
				id_newList = JNIEnv.GetMethodID (class_ref, "newList", "()Ljava/util/List;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_newList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_Ljava_lang_String_ZLcom_koushikdutta_async_http_Multimap_StringDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='parse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='com.koushikdutta.async.http.Multimap.StringDecoder']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/lang/String;ZLcom/koushikdutta/async/http/Multimap$StringDecoder;)Lcom/koushikdutta/async/http/Multimap;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Multimap Parse (string p0, string p1, bool p2, global::Com.Koushikdutta.Async.Http.Multimap.IStringDecoder p3)
		{
			if (id_parse_Ljava_lang_String_Ljava_lang_String_ZLcom_koushikdutta_async_http_Multimap_StringDecoder_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_lang_String_ZLcom_koushikdutta_async_http_Multimap_StringDecoder_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/lang/String;ZLcom/koushikdutta/async/http/Multimap$StringDecoder;)Lcom/koushikdutta/async/http/Multimap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Koushikdutta.Async.Http.Multimap __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_Ljava_lang_String_ZLcom_koushikdutta_async_http_Multimap_StringDecoder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_parseCommaDelimited_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='parseCommaDelimited' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseCommaDelimited", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Multimap ParseCommaDelimited (string p0)
		{
			if (id_parseCommaDelimited_Ljava_lang_String_ == IntPtr.Zero)
				id_parseCommaDelimited_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseCommaDelimited", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Multimap __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseCommaDelimited_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseQuery_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='parseQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseQuery", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Multimap ParseQuery (string p0)
		{
			if (id_parseQuery_Ljava_lang_String_ == IntPtr.Zero)
				id_parseQuery_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseQuery", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Multimap __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseQuery_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseSemicolonDelimited_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='parseSemicolonDelimited' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseSemicolonDelimited", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Multimap ParseSemicolonDelimited (string p0)
		{
			if (id_parseSemicolonDelimited_Ljava_lang_String_ == IntPtr.Zero)
				id_parseSemicolonDelimited_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseSemicolonDelimited", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Multimap __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseSemicolonDelimited_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseUrlEncoded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='parseUrlEncoded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUrlEncoded", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Multimap ParseUrlEncoded (string p0)
		{
			if (id_parseUrlEncoded_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUrlEncoded_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUrlEncoded", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Multimap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Multimap __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUrlEncoded_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Multimap __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Multimap']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
