using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncSocketMiddleware", DoNotGenerateAcw=true)]
	public partial class AsyncSocketMiddleware : global::Com.Koushikdutta.Async.Http.SimpleMiddleware {


		static IntPtr mClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/field[@name='mClient']"
		[Register ("mClient")]
		protected global::Com.Koushikdutta.Async.Http.AsyncHttpClient MClient {
			get {
				if (mClient_jfieldId == IntPtr.Zero)
					mClient_jfieldId = JNIEnv.GetFieldID (class_ref, "mClient", "Lcom/koushikdutta/async/http/AsyncHttpClient;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mClient_jfieldId == IntPtr.Zero)
					mClient_jfieldId = JNIEnv.GetFieldID (class_ref, "mClient", "Lcom/koushikdutta/async/http/AsyncHttpClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mClient_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware.ConnectionInfo']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncSocketMiddleware$ConnectionInfo", DoNotGenerateAcw=true)]
		public partial class ConnectionInfo : global::Java.Lang.Object {

			protected ConnectionInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware.IdleSocketHolder']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncSocketMiddleware$IdleSocketHolder", DoNotGenerateAcw=true)]
		public partial class IdleSocketHolder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncSocketMiddleware$IdleSocketHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IdleSocketHolder); }
			}

			protected IdleSocketHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_http_AsyncSocketMiddleware_Lcom_koushikdutta_async_AsyncSocket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware.IdleSocketHolder']/constructor[@name='AsyncSocketMiddleware.IdleSocketHolder' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.http.AsyncSocketMiddleware'] and parameter[2][@type='com.koushikdutta.async.AsyncSocket']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/http/AsyncSocketMiddleware;Lcom/koushikdutta/async/AsyncSocket;)V", "")]
			public unsafe IdleSocketHolder (global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __self, global::Com.Koushikdutta.Async.IAsyncSocket p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (IdleSocketHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/koushikdutta/async/AsyncSocket;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/koushikdutta/async/AsyncSocket;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_http_AsyncSocketMiddleware_Lcom_koushikdutta_async_AsyncSocket_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_http_AsyncSocketMiddleware_Lcom_koushikdutta_async_AsyncSocket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/AsyncSocketMiddleware;Lcom/koushikdutta/async/AsyncSocket;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncSocketMiddleware_Lcom_koushikdutta_async_AsyncSocket_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncSocketMiddleware_Lcom_koushikdutta_async_AsyncSocket_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncSocketMiddleware", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncSocketMiddleware); }
		}

		protected AsyncSocketMiddleware (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/constructor[@name='AsyncSocketMiddleware' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", "")]
		public unsafe AsyncSocketMiddleware (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AsyncSocketMiddleware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/AsyncHttpClient;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/constructor[@name='AsyncSocketMiddleware' and count(parameter)=3 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClient'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/lang/String;I)V", "")]
		public unsafe AsyncSocketMiddleware (global::Com.Koushikdutta.Async.Http.AsyncHttpClient p0, string p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AsyncSocketMiddleware)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/http/AsyncHttpClient;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_http_AsyncHttpClient_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getConnectAllAddresses;
#pragma warning disable 0169
		static Delegate GetGetConnectAllAddressesHandler ()
		{
			if (cb_getConnectAllAddresses == null)
				cb_getConnectAllAddresses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetConnectAllAddresses);
			return cb_getConnectAllAddresses;
		}

		static bool n_GetConnectAllAddresses (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectAllAddresses;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectAllAddresses_Z;
#pragma warning disable 0169
		static Delegate GetSetConnectAllAddresses_ZHandler ()
		{
			if (cb_setConnectAllAddresses_Z == null)
				cb_setConnectAllAddresses_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetConnectAllAddresses_Z);
			return cb_setConnectAllAddresses_Z;
		}

		static void n_SetConnectAllAddresses_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectAllAddresses = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectAllAddresses;
		static IntPtr id_setConnectAllAddresses_Z;
		public virtual unsafe bool ConnectAllAddresses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='getConnectAllAddresses' and count(parameter)=0]"
			[Register ("getConnectAllAddresses", "()Z", "GetGetConnectAllAddressesHandler")]
			get {
				if (id_getConnectAllAddresses == IntPtr.Zero)
					id_getConnectAllAddresses = JNIEnv.GetMethodID (class_ref, "getConnectAllAddresses", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getConnectAllAddresses);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectAllAddresses", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='setConnectAllAddresses' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setConnectAllAddresses", "(Z)V", "GetSetConnectAllAddresses_ZHandler")]
			set {
				if (id_setConnectAllAddresses_Z == IntPtr.Zero)
					id_setConnectAllAddresses_Z = JNIEnv.GetMethodID (class_ref, "setConnectAllAddresses", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setConnectAllAddresses_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectAllAddresses", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxConnectionCount;
#pragma warning disable 0169
		static Delegate GetGetMaxConnectionCountHandler ()
		{
			if (cb_getMaxConnectionCount == null)
				cb_getMaxConnectionCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxConnectionCount);
			return cb_getMaxConnectionCount;
		}

		static int n_GetMaxConnectionCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxConnectionCount;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxConnectionCount_I;
#pragma warning disable 0169
		static Delegate GetSetMaxConnectionCount_IHandler ()
		{
			if (cb_setMaxConnectionCount_I == null)
				cb_setMaxConnectionCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxConnectionCount_I);
			return cb_setMaxConnectionCount_I;
		}

		static void n_SetMaxConnectionCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxConnectionCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxConnectionCount;
		static IntPtr id_setMaxConnectionCount_I;
		public virtual unsafe int MaxConnectionCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='getMaxConnectionCount' and count(parameter)=0]"
			[Register ("getMaxConnectionCount", "()I", "GetGetMaxConnectionCountHandler")]
			get {
				if (id_getMaxConnectionCount == IntPtr.Zero)
					id_getMaxConnectionCount = JNIEnv.GetMethodID (class_ref, "getMaxConnectionCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxConnectionCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxConnectionCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='setMaxConnectionCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxConnectionCount", "(I)V", "GetSetMaxConnectionCount_IHandler")]
			set {
				if (id_setMaxConnectionCount_I == IntPtr.Zero)
					id_setMaxConnectionCount_I = JNIEnv.GetMethodID (class_ref, "setMaxConnectionCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxConnectionCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxConnectionCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_disableProxy;
#pragma warning disable 0169
		static Delegate GetDisableProxyHandler ()
		{
			if (cb_disableProxy == null)
				cb_disableProxy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableProxy);
			return cb_disableProxy;
		}

		static void n_DisableProxy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableProxy ();
		}
#pragma warning restore 0169

		static IntPtr id_disableProxy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='disableProxy' and count(parameter)=0]"
		[Register ("disableProxy", "()V", "GetDisableProxyHandler")]
		public virtual unsafe void DisableProxy ()
		{
			if (id_disableProxy == IntPtr.Zero)
				id_disableProxy = JNIEnv.GetMethodID (class_ref, "disableProxy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_disableProxy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableProxy", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableProxy_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetEnableProxy_Ljava_lang_String_IHandler ()
		{
			if (cb_enableProxy_Ljava_lang_String_I == null)
				cb_enableProxy_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_EnableProxy_Ljava_lang_String_I);
			return cb_enableProxy_Ljava_lang_String_I;
		}

		static void n_EnableProxy_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableProxy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_enableProxy_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='enableProxy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("enableProxy", "(Ljava/lang/String;I)V", "GetEnableProxy_Ljava_lang_String_IHandler")]
		public virtual unsafe void EnableProxy (string p0, int p1)
		{
			if (id_enableProxy_Ljava_lang_String_I == IntPtr.Zero)
				id_enableProxy_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "enableProxy", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_enableProxy_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableProxy", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSchemePort_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetSchemePort_Landroid_net_Uri_Handler ()
		{
			if (cb_getSchemePort_Landroid_net_Uri_ == null)
				cb_getSchemePort_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSchemePort_Landroid_net_Uri_);
			return cb_getSchemePort_Landroid_net_Uri_;
		}

		static int n_GetSchemePort_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSchemePort (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSchemePort_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='getSchemePort' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getSchemePort", "(Landroid/net/Uri;)I", "GetGetSchemePort_Landroid_net_Uri_Handler")]
		public virtual unsafe int GetSchemePort (global::Android.Net.Uri p0)
		{
			if (id_getSchemePort_Landroid_net_Uri_ == IntPtr.Zero)
				id_getSchemePort_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getSchemePort", "(Landroid/net/Uri;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getSchemePort_Landroid_net_Uri_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSchemePort", "(Landroid/net/Uri;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setIdleTimeoutMs_I;
#pragma warning disable 0169
		static Delegate GetSetIdleTimeoutMs_IHandler ()
		{
			if (cb_setIdleTimeoutMs_I == null)
				cb_setIdleTimeoutMs_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIdleTimeoutMs_I);
			return cb_setIdleTimeoutMs_I;
		}

		static void n_SetIdleTimeoutMs_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIdleTimeoutMs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIdleTimeoutMs_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='setIdleTimeoutMs' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIdleTimeoutMs", "(I)V", "GetSetIdleTimeoutMs_IHandler")]
		public virtual unsafe void SetIdleTimeoutMs (int p0)
		{
			if (id_setIdleTimeoutMs_I == IntPtr.Zero)
				id_setIdleTimeoutMs_I = JNIEnv.GetMethodID (class_ref, "setIdleTimeoutMs", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIdleTimeoutMs_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdleTimeoutMs", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetWrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_Handler ()
		{
			if (cb_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_ == null)
				cb_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr, IntPtr>) n_WrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_);
			return cb_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_;
		}

		static IntPtr n_WrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3, IntPtr native_p4)
		{
			global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncSocketMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IConnectCallback p4 = (global::Com.Koushikdutta.Async.Callback.IConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WrapCallback (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncSocketMiddleware']/method[@name='wrapCallback' and count(parameter)=5 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='com.koushikdutta.async.callback.ConnectCallback']]"
		[Register ("wrapCallback", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Landroid/net/Uri;IZLcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/callback/ConnectCallback;", "GetWrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_Handler")]
		protected virtual unsafe global::Com.Koushikdutta.Async.Callback.IConnectCallback WrapCallback (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0, global::Android.Net.Uri p1, int p2, bool p3, global::Com.Koushikdutta.Async.Callback.IConnectCallback p4)
		{
			if (id_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_ == IntPtr.Zero)
				id_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "wrapCallback", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Landroid/net/Uri;IZLcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/callback/ConnectCallback;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Com.Koushikdutta.Async.Callback.IConnectCallback __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (JNIEnv.CallObjectMethod  (Handle, id_wrapCallback_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Landroid_net_Uri_IZLcom_koushikdutta_async_callback_ConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrapCallback", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;Landroid/net/Uri;IZLcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/callback/ConnectCallback;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
