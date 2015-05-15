using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='LineEmitter']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/LineEmitter", DoNotGenerateAcw=true)]
	public partial class LineEmitter : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Callback.IDataCallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='LineEmitter.StringCallback']"
		[Register ("com/koushikdutta/async/LineEmitter$StringCallback", "", "Com.Koushikdutta.Async.LineEmitter/IStringCallbackInvoker")]
		public partial interface IStringCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='LineEmitter.StringCallback']/method[@name='onStringAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onStringAvailable", "(Ljava/lang/String;)V", "GetOnStringAvailable_Ljava_lang_String_Handler:Com.Koushikdutta.Async.LineEmitter/IStringCallbackInvoker, AndroidAsyncBinding")]
			void OnStringAvailable (string p0);

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/LineEmitter$StringCallback", DoNotGenerateAcw=true)]
		internal class IStringCallbackInvoker : global::Java.Lang.Object, IStringCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/LineEmitter$StringCallback");
			IntPtr class_ref;

			public static IStringCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStringCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.LineEmitter.StringCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStringCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IStringCallbackInvoker); }
			}

			static Delegate cb_onStringAvailable_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnStringAvailable_Ljava_lang_String_Handler ()
			{
				if (cb_onStringAvailable_Ljava_lang_String_ == null)
					cb_onStringAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStringAvailable_Ljava_lang_String_);
				return cb_onStringAvailable_Ljava_lang_String_;
			}

			static void n_OnStringAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.LineEmitter.IStringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter.IStringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStringAvailable (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStringAvailable_Ljava_lang_String_;
			public unsafe void OnStringAvailable (string p0)
			{
				if (id_onStringAvailable_Ljava_lang_String_ == IntPtr.Zero)
					id_onStringAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStringAvailable", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onStringAvailable_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/LineEmitter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LineEmitter); }
		}

		protected LineEmitter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='LineEmitter']/constructor[@name='LineEmitter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LineEmitter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (LineEmitter)) {
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

		static Delegate cb_getLineCallback;
#pragma warning disable 0169
		static Delegate GetGetLineCallbackHandler ()
		{
			if (cb_getLineCallback == null)
				cb_getLineCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLineCallback);
			return cb_getLineCallback;
		}

		static IntPtr n_GetLineCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.LineEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LineCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_;
#pragma warning disable 0169
		static Delegate GetSetLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_Handler ()
		{
			if (cb_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_ == null)
				cb_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_);
			return cb_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_;
		}

		static void n_SetLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.LineEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.LineEmitter.IStringCallback p0 = (global::Com.Koushikdutta.Async.LineEmitter.IStringCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter.IStringCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LineCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLineCallback;
		static IntPtr id_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_;
		public virtual unsafe global::Com.Koushikdutta.Async.LineEmitter.IStringCallback LineCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='LineEmitter']/method[@name='getLineCallback' and count(parameter)=0]"
			[Register ("getLineCallback", "()Lcom/koushikdutta/async/LineEmitter$StringCallback;", "GetGetLineCallbackHandler")]
			get {
				if (id_getLineCallback == IntPtr.Zero)
					id_getLineCallback = JNIEnv.GetMethodID (class_ref, "getLineCallback", "()Lcom/koushikdutta/async/LineEmitter$StringCallback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter.IStringCallback> (JNIEnv.CallObjectMethod  (Handle, id_getLineCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter.IStringCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineCallback", "()Lcom/koushikdutta/async/LineEmitter$StringCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='LineEmitter']/method[@name='setLineCallback' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.LineEmitter.StringCallback']]"
			[Register ("setLineCallback", "(Lcom/koushikdutta/async/LineEmitter$StringCallback;)V", "GetSetLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_Handler")]
			set {
				if (id_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_ == IntPtr.Zero)
					id_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_ = JNIEnv.GetMethodID (class_ref, "setLineCallback", "(Lcom/koushikdutta/async/LineEmitter$StringCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLineCallback_Lcom_koushikdutta_async_LineEmitter_StringCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineCallback", "(Lcom/koushikdutta/async/LineEmitter$StringCallback;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetOnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static void n_OnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.LineEmitter __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.LineEmitter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='LineEmitter']/method[@name='onDataAvailable' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V", "GetOnDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe void OnDataAvailable (global::Com.Koushikdutta.Async.IDataEmitter p0, global::Com.Koushikdutta.Async.ByteBufferList p1)
		{
			if (id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataAvailable", "(Lcom/koushikdutta/async/DataEmitter;Lcom/koushikdutta/async/ByteBufferList;)V"), __args);
			} finally {
			}
		}

	}
}
