using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http.Socketio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='EventEmitter']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/EventEmitter", DoNotGenerateAcw=true)]
	public partial class EventEmitter : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/interface[@name='EventEmitter.OnceCallback']"
		[Register ("com/koushikdutta/async/http/socketio/EventEmitter$OnceCallback", "", "Com.Koushikdutta.Async.Http.Socketio.EventEmitter/IOnceCallbackInvoker")]
		public partial interface IOnceCallback : global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback {

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/http/socketio/EventEmitter$OnceCallback", DoNotGenerateAcw=true)]
		internal class IOnceCallbackInvoker : global::Java.Lang.Object, IOnceCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/EventEmitter$OnceCallback");
			IntPtr class_ref;

			public static IOnceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnceCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.socketio.EventEmitter.OnceCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnceCallbackInvoker); }
			}

			static Delegate cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
#pragma warning disable 0169
			static Delegate GetOnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_Handler ()
			{
				if (cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == null)
					cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_);
				return cb_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
			}

			static void n_OnEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter.IOnceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter.IOnceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONArray p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnEvent (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_;
			public unsafe void OnEvent (global::Org.Json.JSONArray p0, global::Com.Koushikdutta.Async.Http.Socketio.IAcknowledge p1)
			{
				if (id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ == IntPtr.Zero)
					id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lorg/json/JSONArray;Lcom/koushikdutta/async/http/socketio/Acknowledge;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onEvent_Lorg_json_JSONArray_Lcom_koushikdutta_async_http_socketio_Acknowledge_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/socketio/EventEmitter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventEmitter); }
		}

		protected EventEmitter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='EventEmitter']/constructor[@name='EventEmitter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventEmitter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EventEmitter)) {
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

		static Delegate cb_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
#pragma warning disable 0169
		static Delegate GetAddListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler ()
		{
			if (cb_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == null)
				cb_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_);
			return cb_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		}

		static void n_AddListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='EventEmitter']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.EventCallback']]"
		[Register ("addListener", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V", "GetAddListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler")]
		public virtual unsafe void AddListener (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1)
		{
			if (id_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == IntPtr.Zero)
				id_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addListener", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
#pragma warning disable 0169
		static Delegate GetOn_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler ()
		{
			if (cb_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == null)
				cb_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_On_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_);
			return cb_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		}

		static void n_On_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.On (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='EventEmitter']/method[@name='on' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.EventCallback']]"
		[Register ("on", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V", "GetOn_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler")]
		public virtual unsafe void On (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1)
		{
			if (id_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == IntPtr.Zero)
				id_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNIEnv.GetMethodID (class_ref, "on", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_on_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "on", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
#pragma warning disable 0169
		static Delegate GetOnce_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler ()
		{
			if (cb_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == null)
				cb_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_);
			return cb_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		}

		static void n_Once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Once (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='EventEmitter']/method[@name='once' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.EventCallback']]"
		[Register ("once", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V", "GetOnce_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler")]
		public virtual unsafe void Once (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1)
		{
			if (id_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == IntPtr.Zero)
				id_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNIEnv.GetMethodID (class_ref, "once", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_once_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "once", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler ()
		{
			if (cb_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == null)
				cb_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_);
			return cb_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		}

		static void n_RemoveListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.EventEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1 = (global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http.socketio']/class[@name='EventEmitter']/method[@name='removeListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.koushikdutta.async.http.socketio.EventCallback']]"
		[Register ("removeListener", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V", "GetRemoveListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_Handler")]
		public virtual unsafe void RemoveListener (string p0, global::Com.Koushikdutta.Async.Http.Socketio.IEventCallback p1)
		{
			if (id_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ == IntPtr.Zero)
				id_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeListener_Ljava_lang_String_Lcom_koushikdutta_async_http_socketio_EventCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "(Ljava/lang/String;Lcom/koushikdutta/async/http/socketio/EventCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
