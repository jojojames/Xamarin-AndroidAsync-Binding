using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/Headers", DoNotGenerateAcw=true)]
	public partial class Headers : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/Headers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Headers); }
		}

		protected Headers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/constructor[@name='Headers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Headers ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Headers)) {
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

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/constructor[@name='Headers' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe Headers (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (Headers)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMultiMap;
#pragma warning disable 0169
		static Delegate GetGetMultiMapHandler ()
		{
			if (cb_getMultiMap == null)
				cb_getMultiMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMultiMap);
			return cb_getMultiMap;
		}

		static IntPtr n_GetMultiMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MultiMap);
		}
#pragma warning restore 0169

		static IntPtr id_getMultiMap;
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Multimap MultiMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='getMultiMap' and count(parameter)=0]"
			[Register ("getMultiMap", "()Lcom/koushikdutta/async/http/Multimap;", "GetGetMultiMapHandler")]
			get {
				if (id_getMultiMap == IntPtr.Zero)
					id_getMultiMap = JNIEnv.GetMethodID (class_ref, "getMultiMap", "()Lcom/koushikdutta/async/http/Multimap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallObjectMethod  (Handle, id_getMultiMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Multimap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiMap", "()Lcom/koushikdutta/async/http/Multimap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Add_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;", "GetAdd_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers Add (string p0, string p1)
		{
			if (id_add_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_add_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addAll_Lcom_koushikdutta_async_http_Headers_;
#pragma warning disable 0169
		static Delegate GetAddAll_Lcom_koushikdutta_async_http_Headers_Handler ()
		{
			if (cb_addAll_Lcom_koushikdutta_async_http_Headers_ == null)
				cb_addAll_Lcom_koushikdutta_async_http_Headers_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAll_Lcom_koushikdutta_async_http_Headers_);
			return cb_addAll_Lcom_koushikdutta_async_http_Headers_;
		}

		static IntPtr n_AddAll_Lcom_koushikdutta_async_http_Headers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Headers p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Lcom_koushikdutta_async_http_Headers_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("addAll", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/Headers;", "GetAddAll_Lcom_koushikdutta_async_http_Headers_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers AddAll (global::Com.Koushikdutta.Async.Http.Headers p0)
		{
			if (id_addAll_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_addAll_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/Headers;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Lcom_koushikdutta_async_http_Headers_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addAll_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_addAll_Ljava_lang_String_Ljava_util_List_ == null)
				cb_addAll_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAll_Ljava_lang_String_Ljava_util_List_);
			return cb_addAll_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_AddAll_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<string> p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAll (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addAll", "(Ljava/lang/String;Ljava/util/List;)Lcom/koushikdutta/async/http/Headers;", "GetAddAll_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers AddAll (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_addAll_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_addAll_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/lang/String;Ljava/util/List;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Ljava/lang/String;Ljava/util/List;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addAll_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_util_Map_Handler ()
		{
			if (cb_addAll_Ljava_util_Map_ == null)
				cb_addAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAll_Ljava_util_Map_);
			return cb_addAll_Ljava_util_Map_;
		}

		static IntPtr n_AddAll_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("addAll", "(Ljava/util/Map;)Lcom/koushikdutta/async/http/Headers;", "GetAddAll_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers AddAll (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0)
		{
			if (id_addAll_Ljava_util_Map_ == IntPtr.Zero)
				id_addAll_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/util/Map;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_addAll_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Ljava/util/Map;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addLine_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddLine_Ljava_lang_String_Handler ()
		{
			if (cb_addLine_Ljava_lang_String_ == null)
				cb_addLine_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLine_Ljava_lang_String_);
			return cb_addLine_Ljava_lang_String_;
		}

		static IntPtr n_AddLine_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLine (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addLine_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='addLine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addLine", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;", "GetAddLine_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers AddLine (string p0)
		{
			if (id_addLine_Ljava_lang_String_ == IntPtr.Zero)
				id_addLine_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addLine", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_addLine_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLine", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAll_Ljava_lang_String_Handler ()
		{
			if (cb_getAll_Ljava_lang_String_ == null)
				cb_getAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAll_Ljava_lang_String_);
			return cb_getAll_Ljava_lang_String_;
		}

		static IntPtr n_GetAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAll_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='getAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAll", "(Ljava/lang/String;)Ljava/util/List;", "GetGetAll_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetAll (string p0)
		{
			if (id_getAll_Ljava_lang_String_ == IntPtr.Zero)
				id_getAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAll", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<string> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAll", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Headers Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Koushikdutta.Async.Http.Headers __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static IntPtr n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Ljava/lang/String;", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe string Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_String_Handler ()
		{
			if (cb_removeAll_Ljava_lang_String_ == null)
				cb_removeAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_String_);
			return cb_removeAll_Ljava_lang_String_;
		}

		static IntPtr n_RemoveAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.RemoveAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAll", "(Ljava/lang/String;)Ljava/util/List;", "GetRemoveAll_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> RemoveAll (string p0)
		{
			if (id_removeAll_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<string> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_removeAll_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_util_Collection_Handler ()
		{
			if (cb_removeAll_Ljava_util_Collection_ == null)
				cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_util_Collection_);
			return cb_removeAll_Ljava_util_Collection_;
		}

		static IntPtr n_RemoveAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<string> p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register ("removeAll", "(Ljava/util/Collection;)Lcom/koushikdutta/async/http/Headers;", "GetRemoveAll_Ljava_util_Collection_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers RemoveAll (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_removeAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_removeAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/util/Collection;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_removeAll_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/util/Collection;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_String_);
			return cb_set_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Set_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;", "GetSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Headers Set (string p0, string p1)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Koushikdutta.Async.Http.Headers __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod  (Handle, id_set_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Ljava/lang/String;)Lcom/koushikdutta/async/http/Headers;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_toHeaderArray;
#pragma warning disable 0169
		static Delegate GetToHeaderArrayHandler ()
		{
			if (cb_toHeaderArray == null)
				cb_toHeaderArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToHeaderArray);
			return cb_toHeaderArray;
		}

		static IntPtr n_ToHeaderArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToHeaderArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toHeaderArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='toHeaderArray' and count(parameter)=0]"
		[Register ("toHeaderArray", "()[Lorg/apache/http/Header;", "GetToHeaderArrayHandler")]
		public virtual unsafe global::Org.Apache.Http.IHeader[] ToHeaderArray ()
		{
			if (id_toHeaderArray == IntPtr.Zero)
				id_toHeaderArray = JNIEnv.GetMethodID (class_ref, "toHeaderArray", "()[Lorg/apache/http/Header;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toHeaderArray), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
				else
					return (global::Org.Apache.Http.IHeader[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toHeaderArray", "()[Lorg/apache/http/Header;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Apache.Http.IHeader));
			} finally {
			}
		}

		static Delegate cb_toPrefixString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToPrefixString_Ljava_lang_String_Handler ()
		{
			if (cb_toPrefixString_Ljava_lang_String_ == null)
				cb_toPrefixString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPrefixString_Ljava_lang_String_);
			return cb_toPrefixString_Ljava_lang_String_;
		}

		static IntPtr n_ToPrefixString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToPrefixString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toPrefixString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='toPrefixString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toPrefixString", "(Ljava/lang/String;)Ljava/lang/String;", "GetToPrefixString_Ljava_lang_String_Handler")]
		public virtual unsafe string ToPrefixString (string p0)
		{
			if (id_toPrefixString_Ljava_lang_String_ == IntPtr.Zero)
				id_toPrefixString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "toPrefixString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toPrefixString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toPrefixString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toStringBuilder;
#pragma warning disable 0169
		static Delegate GetToStringBuilderHandler ()
		{
			if (cb_toStringBuilder == null)
				cb_toStringBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToStringBuilder);
			return cb_toStringBuilder;
		}

		static IntPtr n_ToStringBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Headers __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToStringBuilder ());
		}
#pragma warning restore 0169

		static IntPtr id_toStringBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='Headers']/method[@name='toStringBuilder' and count(parameter)=0]"
		[Register ("toStringBuilder", "()Ljava/lang/StringBuilder;", "GetToStringBuilderHandler")]
		public virtual unsafe global::Java.Lang.StringBuilder ToStringBuilder ()
		{
			if (id_toStringBuilder == IntPtr.Zero)
				id_toStringBuilder = JNIEnv.GetMethodID (class_ref, "toStringBuilder", "()Ljava/lang/StringBuilder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallObjectMethod  (Handle, id_toStringBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toStringBuilder", "()Ljava/lang/StringBuilder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
