using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware", DoNotGenerateAcw=true)]
	public partial class ResponseCacheMiddleware : global::Com.Koushikdutta.Async.Http.SimpleMiddleware {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/field[@name='CACHE']"
		[Register ("CACHE")]
		public const string Cache = (string) "cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/field[@name='CONDITIONAL_CACHE']"
		[Register ("CONDITIONAL_CACHE")]
		public const string ConditionalCache = (string) "conditional-cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/field[@name='ENTRY_BODY']"
		[Register ("ENTRY_BODY")]
		public const int EntryBody = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/field[@name='ENTRY_COUNT']"
		[Register ("ENTRY_COUNT")]
		public const int EntryCount = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/field[@name='ENTRY_METADATA']"
		[Register ("ENTRY_METADATA")]
		public const int EntryMetadata = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/field[@name='SERVED_FROM']"
		[Register ("SERVED_FROM")]
		public const string ServedFrom = (string) "X-Served-From";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.CacheData']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$CacheData", DoNotGenerateAcw=true)]
		public partial class CacheData : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$CacheData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CacheData); }
			}

			protected CacheData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.CacheData']/constructor[@name='ResponseCacheMiddleware.CacheData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CacheData ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CacheData)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.Entry']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$Entry", DoNotGenerateAcw=true)]
		public sealed partial class Entry : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$Entry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Entry); }
			}

			internal Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.Entry']/constructor[@name='ResponseCacheMiddleware.Entry' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public unsafe Entry (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (Entry)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_matches_Landroid_net_Uri_Ljava_lang_String_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.Entry']/method[@name='matches' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
			[Register ("matches", "(Landroid/net/Uri;Ljava/lang/String;Ljava/util/Map;)Z", "")]
			public unsafe bool Matches (global::Android.Net.Uri p0, string p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2)
			{
				if (id_matches_Landroid_net_Uri_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_matches_Landroid_net_Uri_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "matches", "(Landroid/net/Uri;Ljava/lang/String;Ljava/util/Map;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_matches_Landroid_net_Uri_Ljava_lang_String_Ljava_util_Map_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.EntryCacheResponse']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$EntryCacheResponse", DoNotGenerateAcw=true)]
		public partial class EntryCacheResponse : global::Java.Net.CacheResponse {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$EntryCacheResponse", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EntryCacheResponse); }
			}

			protected EntryCacheResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Entry_Ljava_io_FileInputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.EntryCacheResponse']/constructor[@name='ResponseCacheMiddleware.EntryCacheResponse' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.cache.ResponseCacheMiddleware.Entry'] and parameter[2][@type='java.io.FileInputStream']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware$Entry;Ljava/io/FileInputStream;)V", "")]
			public unsafe EntryCacheResponse (global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware.Entry p0, global::System.IO.Stream p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (EntryCacheResponse)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware$Entry;Ljava/io/FileInputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware$Entry;Ljava/io/FileInputStream;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Entry_Ljava_io_FileInputStream_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Entry_Ljava_io_FileInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware$Entry;Ljava/io/FileInputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Entry_Ljava_io_FileInputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Entry_Ljava_io_FileInputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_getBody;
#pragma warning disable 0169
			static Delegate GetGetBodyHandler ()
			{
				if (cb_getBody == null)
					cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
				return cb_getBody;
			}

			static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware.EntryCacheResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware.EntryCacheResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Body);
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			public override unsafe global::System.IO.Stream Body {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.EntryCacheResponse']/method[@name='getBody' and count(parameter)=0]"
				[Register ("getBody", "()Ljava/io/FileInputStream;", "GetGetBodyHandler")]
				get {
					if (id_getBody == IntPtr.Zero)
						id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/io/FileInputStream;");
					try {

						if (GetType () == ThresholdType)
							return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/io/FileInputStream;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getHeaders;
#pragma warning disable 0169
			static Delegate GetGetHeadersHandler ()
			{
				if (cb_getHeaders == null)
					cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
				return cb_getHeaders;
			}

			static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware.EntryCacheResponse __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware.EntryCacheResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.Headers);
			}
#pragma warning restore 0169

			static IntPtr id_getHeaders;
			public override unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> Headers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.EntryCacheResponse']/method[@name='getHeaders' and count(parameter)=0]"
				[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
				get {
					if (id_getHeaders == IntPtr.Zero)
						id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
					try {

						if (GetType () == ThresholdType)
							return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.EntryEditor']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$EntryEditor", DoNotGenerateAcw=true)]
		public partial class EntryEditor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware$EntryEditor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EntryEditor); }
			}

			protected EntryEditor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware.EntryEditor']/constructor[@name='ResponseCacheMiddleware.EntryEditor' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.cache.ResponseCacheMiddleware'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware;Ljava/lang/String;)V", "")]
			public unsafe EntryEditor (global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __self, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (EntryEditor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_cache_ResponseCacheMiddleware_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/cache/ResponseCacheMiddleware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseCacheMiddleware); }
		}

		protected ResponseCacheMiddleware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCacheHitCount;
#pragma warning disable 0169
		static Delegate GetGetCacheHitCountHandler ()
		{
			if (cb_getCacheHitCount == null)
				cb_getCacheHitCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCacheHitCount);
			return cb_getCacheHitCount;
		}

		static int n_GetCacheHitCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheHitCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCacheHitCount;
		public virtual unsafe int CacheHitCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='getCacheHitCount' and count(parameter)=0]"
			[Register ("getCacheHitCount", "()I", "GetGetCacheHitCountHandler")]
			get {
				if (id_getCacheHitCount == IntPtr.Zero)
					id_getCacheHitCount = JNIEnv.GetMethodID (class_ref, "getCacheHitCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCacheHitCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheHitCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCacheStoreCount;
#pragma warning disable 0169
		static Delegate GetGetCacheStoreCountHandler ()
		{
			if (cb_getCacheStoreCount == null)
				cb_getCacheStoreCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCacheStoreCount);
			return cb_getCacheStoreCount;
		}

		static int n_GetCacheStoreCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheStoreCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCacheStoreCount;
		public virtual unsafe int CacheStoreCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='getCacheStoreCount' and count(parameter)=0]"
			[Register ("getCacheStoreCount", "()I", "GetGetCacheStoreCountHandler")]
			get {
				if (id_getCacheStoreCount == IntPtr.Zero)
					id_getCacheStoreCount = JNIEnv.GetMethodID (class_ref, "getCacheStoreCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCacheStoreCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheStoreCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCaching;
#pragma warning disable 0169
		static Delegate GetGetCachingHandler ()
		{
			if (cb_getCaching == null)
				cb_getCaching = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCaching);
			return cb_getCaching;
		}

		static bool n_GetCaching (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Caching;
		}
#pragma warning restore 0169

		static Delegate cb_setCaching_Z;
#pragma warning disable 0169
		static Delegate GetSetCaching_ZHandler ()
		{
			if (cb_setCaching_Z == null)
				cb_setCaching_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCaching_Z);
			return cb_setCaching_Z;
		}

		static void n_SetCaching_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Caching = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCaching;
		static IntPtr id_setCaching_Z;
		public virtual unsafe bool Caching {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='getCaching' and count(parameter)=0]"
			[Register ("getCaching", "()Z", "GetGetCachingHandler")]
			get {
				if (id_getCaching == IntPtr.Zero)
					id_getCaching = JNIEnv.GetMethodID (class_ref, "getCaching", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getCaching);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCaching", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='setCaching' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCaching", "(Z)V", "GetSetCaching_ZHandler")]
			set {
				if (id_setCaching_Z == IntPtr.Zero)
					id_setCaching_Z = JNIEnv.GetMethodID (class_ref, "setCaching", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCaching_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCaching", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConditionalCacheHitCount;
#pragma warning disable 0169
		static Delegate GetGetConditionalCacheHitCountHandler ()
		{
			if (cb_getConditionalCacheHitCount == null)
				cb_getConditionalCacheHitCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConditionalCacheHitCount);
			return cb_getConditionalCacheHitCount;
		}

		static int n_GetConditionalCacheHitCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConditionalCacheHitCount;
		}
#pragma warning restore 0169

		static IntPtr id_getConditionalCacheHitCount;
		public virtual unsafe int ConditionalCacheHitCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='getConditionalCacheHitCount' and count(parameter)=0]"
			[Register ("getConditionalCacheHitCount", "()I", "GetGetConditionalCacheHitCountHandler")]
			get {
				if (id_getConditionalCacheHitCount == IntPtr.Zero)
					id_getConditionalCacheHitCount = JNIEnv.GetMethodID (class_ref, "getConditionalCacheHitCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getConditionalCacheHitCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConditionalCacheHitCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkCount;
#pragma warning disable 0169
		static Delegate GetGetNetworkCountHandler ()
		{
			if (cb_getNetworkCount == null)
				cb_getNetworkCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNetworkCount);
			return cb_getNetworkCount;
		}

		static int n_GetNetworkCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkCount;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkCount;
		public virtual unsafe int NetworkCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='getNetworkCount' and count(parameter)=0]"
			[Register ("getNetworkCount", "()I", "GetGetNetworkCountHandler")]
			get {
				if (id_getNetworkCount == IntPtr.Zero)
					id_getNetworkCount = JNIEnv.GetMethodID (class_ref, "getNetworkCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNetworkCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_addCache_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_io_File_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='addCache' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient'] and parameter[2][@type='java.io.File'] and parameter[3][@type='long']]"
		[Register ("addCache", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/io/File;J)Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware;", "")]
		public static unsafe global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware AddCache (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0, global::Java.IO.File p1, long p2)
		{
			if (id_addCache_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_io_File_J == IntPtr.Zero)
				id_addCache_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_io_File_J = JNIEnv.GetStaticMethodID (class_ref, "addCache", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/io/File;J)Lcom/koushikdutta/async/http/cache/ResponseCacheMiddleware;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addCache_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_io_File_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Cache.ResponseCacheMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.cache']/class[@name='ResponseCacheMiddleware']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

	}
}
