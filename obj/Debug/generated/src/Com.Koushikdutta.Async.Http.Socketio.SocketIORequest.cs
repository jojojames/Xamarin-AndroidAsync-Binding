using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/SocketIORequest", DoNotGenerateAcw=true)]
	public partial class SocketIORequest : global::Com.Koushikdutta.Async.Http.AsyncHttpPost {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/SocketIORequest$Config", DoNotGenerateAcw=true)]
		public partial class Config : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/SocketIORequest$Config", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Config); }
			}

			protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/constructor[@name='SocketIORequest.Config' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Config ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Config)) {
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

			static Delegate cb_isRandomizeReconnectDelay;
#pragma warning disable 0169
			static Delegate GetIsRandomizeReconnectDelayHandler ()
			{
				if (cb_isRandomizeReconnectDelay == null)
					cb_isRandomizeReconnectDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRandomizeReconnectDelay);
				return cb_isRandomizeReconnectDelay;
			}

			static bool n_IsRandomizeReconnectDelay (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RandomizeReconnectDelay;
			}
#pragma warning restore 0169

			static Delegate cb_setRandomizeReconnectDelay_Z;
#pragma warning disable 0169
			static Delegate GetSetRandomizeReconnectDelay_ZHandler ()
			{
				if (cb_setRandomizeReconnectDelay_Z == null)
					cb_setRandomizeReconnectDelay_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRandomizeReconnectDelay_Z);
				return cb_setRandomizeReconnectDelay_Z;
			}

			static void n_SetRandomizeReconnectDelay_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RandomizeReconnectDelay = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isRandomizeReconnectDelay;
			static IntPtr id_setRandomizeReconnectDelay_Z;
			public virtual unsafe bool RandomizeReconnectDelay {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/method[@name='isRandomizeReconnectDelay' and count(parameter)=0]"
				[Register ("isRandomizeReconnectDelay", "()Z", "GetIsRandomizeReconnectDelayHandler")]
				get {
					if (id_isRandomizeReconnectDelay == IntPtr.Zero)
						id_isRandomizeReconnectDelay = JNIEnv.GetMethodID (class_ref, "isRandomizeReconnectDelay", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_isRandomizeReconnectDelay);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRandomizeReconnectDelay", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/method[@name='setRandomizeReconnectDelay' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setRandomizeReconnectDelay", "(Z)V", "GetSetRandomizeReconnectDelay_ZHandler")]
				set {
					if (id_setRandomizeReconnectDelay_Z == IntPtr.Zero)
						id_setRandomizeReconnectDelay_Z = JNIEnv.GetMethodID (class_ref, "setRandomizeReconnectDelay", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setRandomizeReconnectDelay_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRandomizeReconnectDelay", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getReconnectDelay;
#pragma warning disable 0169
			static Delegate GetGetReconnectDelayHandler ()
			{
				if (cb_getReconnectDelay == null)
					cb_getReconnectDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetReconnectDelay);
				return cb_getReconnectDelay;
			}

			static long n_GetReconnectDelay (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ReconnectDelay;
			}
#pragma warning restore 0169

			static Delegate cb_setReconnectDelay_J;
#pragma warning disable 0169
			static Delegate GetSetReconnectDelay_JHandler ()
			{
				if (cb_setReconnectDelay_J == null)
					cb_setReconnectDelay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetReconnectDelay_J);
				return cb_setReconnectDelay_J;
			}

			static void n_SetReconnectDelay_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ReconnectDelay = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getReconnectDelay;
			static IntPtr id_setReconnectDelay_J;
			public virtual unsafe long ReconnectDelay {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/method[@name='getReconnectDelay' and count(parameter)=0]"
				[Register ("getReconnectDelay", "()J", "GetGetReconnectDelayHandler")]
				get {
					if (id_getReconnectDelay == IntPtr.Zero)
						id_getReconnectDelay = JNIEnv.GetMethodID (class_ref, "getReconnectDelay", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod  (Handle, id_getReconnectDelay);
						else
							return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReconnectDelay", "()J"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/method[@name='setReconnectDelay' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setReconnectDelay", "(J)V", "GetSetReconnectDelay_JHandler")]
				set {
					if (id_setReconnectDelay_J == IntPtr.Zero)
						id_setReconnectDelay_J = JNIEnv.GetMethodID (class_ref, "setReconnectDelay", "(J)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setReconnectDelay_J, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReconnectDelay", "(J)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getReconnectDelayMax;
#pragma warning disable 0169
			static Delegate GetGetReconnectDelayMaxHandler ()
			{
				if (cb_getReconnectDelayMax == null)
					cb_getReconnectDelayMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetReconnectDelayMax);
				return cb_getReconnectDelayMax;
			}

			static long n_GetReconnectDelayMax (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ReconnectDelayMax;
			}
#pragma warning restore 0169

			static Delegate cb_setReconnectDelayMax_J;
#pragma warning disable 0169
			static Delegate GetSetReconnectDelayMax_JHandler ()
			{
				if (cb_setReconnectDelayMax_J == null)
					cb_setReconnectDelayMax_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetReconnectDelayMax_J);
				return cb_setReconnectDelayMax_J;
			}

			static void n_SetReconnectDelayMax_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ReconnectDelayMax = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getReconnectDelayMax;
			static IntPtr id_setReconnectDelayMax_J;
			public virtual unsafe long ReconnectDelayMax {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/method[@name='getReconnectDelayMax' and count(parameter)=0]"
				[Register ("getReconnectDelayMax", "()J", "GetGetReconnectDelayMaxHandler")]
				get {
					if (id_getReconnectDelayMax == IntPtr.Zero)
						id_getReconnectDelayMax = JNIEnv.GetMethodID (class_ref, "getReconnectDelayMax", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod  (Handle, id_getReconnectDelayMax);
						else
							return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReconnectDelayMax", "()J"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest.Config']/method[@name='setReconnectDelayMax' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setReconnectDelayMax", "(J)V", "GetSetReconnectDelayMax_JHandler")]
				set {
					if (id_setReconnectDelayMax_J == IntPtr.Zero)
						id_setReconnectDelayMax_J = JNIEnv.GetMethodID (class_ref, "setReconnectDelayMax", "(J)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_setReconnectDelayMax_J, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReconnectDelayMax", "(J)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/SocketIORequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketIORequest); }
		}

		protected SocketIORequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/constructor[@name='SocketIORequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SocketIORequest (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (SocketIORequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/constructor[@name='SocketIORequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SocketIORequest (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SocketIORequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Config_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/constructor[@name='SocketIORequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.koushikdutta.async.http.socketio.SocketIORequest.Config']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;)V", "")]
		public unsafe SocketIORequest (string p0, string p1, string p2, global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (SocketIORequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Config_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Config_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Config_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_SocketIORequest_Config_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/constructor[@name='SocketIORequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SocketIORequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (SocketIORequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getEndpoint;
#pragma warning disable 0169
		static Delegate GetGetEndpointHandler ()
		{
			if (cb_getEndpoint == null)
				cb_getEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpoint);
			return cb_getEndpoint;
		}

		static IntPtr n_GetEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Endpoint);
		}
#pragma warning restore 0169

		static IntPtr id_getEndpoint;
		public virtual unsafe string Endpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/method[@name='getEndpoint' and count(parameter)=0]"
			[Register ("getEndpoint", "()Ljava/lang/String;", "GetGetEndpointHandler")]
			get {
				if (id_getEndpoint == IntPtr.Zero)
					id_getEndpoint = JNIEnv.GetMethodID (class_ref, "getEndpoint", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEndpoint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndpoint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getQuery;
#pragma warning disable 0169
		static Delegate GetGetQueryHandler ()
		{
			if (cb_getQuery == null)
				cb_getQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuery);
			return cb_getQuery;
		}

		static IntPtr n_GetQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Query);
		}
#pragma warning restore 0169

		static IntPtr id_getQuery;
		public virtual unsafe string Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Ljava/lang/String;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuery", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetConfig ());
		}
#pragma warning restore 0169

		static IntPtr id_getConfig;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='SocketIORequest']/method[@name='getConfig' and count(parameter)=0]"
		[Register ("getConfig", "()Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;", "GetGetConfigHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config GetConfig ()
		{
			if (id_getConfig == IntPtr.Zero)
				id_getConfig = JNIEnv.GetMethodID (class_ref, "getConfig", "()Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (JNIEnv.CallObjectMethod  (Handle, id_getConfig), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.SocketIORequest.Config> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "()Lcom/koushikdutta/async/http/socketio/SocketIORequest$Config;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
