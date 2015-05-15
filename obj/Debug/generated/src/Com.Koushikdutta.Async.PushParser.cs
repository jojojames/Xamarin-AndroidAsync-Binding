using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser", DoNotGenerateAcw=true)]
	public partial class PushParser : global::Java.Lang.Object, global::Com.Koushikdutta.Async.Callback.IDataCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.ByteArrayWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$ByteArrayWaiter", DoNotGenerateAcw=true)]
		public partial class ByteArrayWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$ByteArrayWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ByteArrayWaiter); }
			}

			protected ByteArrayWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.ByteArrayWaiter']/constructor[@name='PushParser.ByteArrayWaiter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;byte[]&gt;']]"
			[Register (".ctor", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V", "")]
			public unsafe ByteArrayWaiter (int p0, global::Com.Koushikdutta.Async.PushParser.IParseCallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ByteArrayWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V", __args);
						return;
					}

					if (id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
						id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.ByteBufferListWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$ByteBufferListWaiter", DoNotGenerateAcw=true)]
		public partial class ByteBufferListWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$ByteBufferListWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ByteBufferListWaiter); }
			}

			protected ByteBufferListWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.ByteBufferListWaiter']/constructor[@name='PushParser.ByteBufferListWaiter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;com.koushikdutta.async.ByteBufferList&gt;']]"
			[Register (".ctor", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V", "")]
			public unsafe ByteBufferListWaiter (int p0, global::Com.Koushikdutta.Async.PushParser.IParseCallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ByteBufferListWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V", __args);
						return;
					}

					if (id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
						id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILcom_koushikdutta_async_PushParser_ParseCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.IntWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$IntWaiter", DoNotGenerateAcw=true)]
		public partial class IntWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$IntWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IntWaiter); }
			}

			protected IntWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.IntWaiter']/constructor[@name='PushParser.IntWaiter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;java.lang.Integer&gt;']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", "")]
			public unsafe IntWaiter (global::Com.Koushikdutta.Async.PushParser.IParseCallback p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (IntWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.LenByteArrayWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$LenByteArrayWaiter", DoNotGenerateAcw=true)]
		public partial class LenByteArrayWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$LenByteArrayWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LenByteArrayWaiter); }
			}

			protected LenByteArrayWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.LenByteArrayWaiter']/constructor[@name='PushParser.LenByteArrayWaiter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;byte[]&gt;']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", "")]
			public unsafe LenByteArrayWaiter (global::Com.Koushikdutta.Async.PushParser.IParseCallback p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LenByteArrayWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.LenByteBufferListWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$LenByteBufferListWaiter", DoNotGenerateAcw=true)]
		public partial class LenByteBufferListWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$LenByteBufferListWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LenByteBufferListWaiter); }
			}

			protected LenByteBufferListWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.LenByteBufferListWaiter']/constructor[@name='PushParser.LenByteBufferListWaiter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;com.koushikdutta.async.ByteBufferList&gt;']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", "")]
			public unsafe LenByteBufferListWaiter (global::Com.Koushikdutta.Async.PushParser.IParseCallback p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LenByteBufferListWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='PushParser.ParseCallback']"
		[Register ("com/koushikdutta/async/PushParser$ParseCallback", "", "Com.Koushikdutta.Async.PushParser/IParseCallbackInvoker")]
		public partial interface IParseCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/interface[@name='PushParser.ParseCallback']/method[@name='parsed' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("parsed", "(Ljava/lang/Object;)V", "GetParsed_Ljava_lang_Object_Handler:Com.Koushikdutta.Async.PushParser/IParseCallbackInvoker, AndroidAsyncBinding")]
			void Parsed (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$ParseCallback", DoNotGenerateAcw=true)]
		internal class IParseCallbackInvoker : global::Java.Lang.Object, IParseCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/PushParser$ParseCallback");
			IntPtr class_ref;

			public static IParseCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IParseCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.PushParser.ParseCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IParseCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IParseCallbackInvoker); }
			}

			static Delegate cb_parsed_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetParsed_Ljava_lang_Object_Handler ()
			{
				if (cb_parsed_Ljava_lang_Object_ == null)
					cb_parsed_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parsed_Ljava_lang_Object_);
				return cb_parsed_Ljava_lang_Object_;
			}

			static void n_Parsed_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.PushParser.IParseCallback __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser.IParseCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Parsed (p0);
			}
#pragma warning restore 0169

			IntPtr id_parsed_Ljava_lang_Object_;
			public unsafe void Parsed (global::Java.Lang.Object p0)
			{
				if (id_parsed_Ljava_lang_Object_ == IntPtr.Zero)
					id_parsed_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "parsed", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_parsed_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.TapWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$TapWaiter", DoNotGenerateAcw=true)]
		public partial class TapWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$TapWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TapWaiter); }
			}

			protected TapWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_koushikdutta_async_PushParser_Lcom_koushikdutta_async_TapCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.TapWaiter']/constructor[@name='PushParser.TapWaiter' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.PushParser'] and parameter[2][@type='com.koushikdutta.async.TapCallback']]"
			[Register (".ctor", "(Lcom/koushikdutta/async/PushParser;Lcom/koushikdutta/async/TapCallback;)V", "")]
			public unsafe TapWaiter (global::Com.Koushikdutta.Async.PushParser __self, global::Com.Koushikdutta.Async.ITapCallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (TapWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/koushikdutta/async/TapCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/koushikdutta/async/TapCallback;)V", __args);
						return;
					}

					if (id_ctor_Lcom_koushikdutta_async_PushParser_Lcom_koushikdutta_async_TapCallback_ == IntPtr.Zero)
						id_ctor_Lcom_koushikdutta_async_PushParser_Lcom_koushikdutta_async_TapCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/PushParser;Lcom/koushikdutta/async/TapCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_Lcom_koushikdutta_async_TapCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_PushParser_Lcom_koushikdutta_async_TapCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.UntilWaiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$UntilWaiter", DoNotGenerateAcw=true)]
		public partial class UntilWaiter : global::Com.Koushikdutta.Async.PushParser.Waiter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$UntilWaiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UntilWaiter); }
			}

			protected UntilWaiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_BLcom_koushikdutta_async_callback_DataCallback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.UntilWaiter']/constructor[@name='PushParser.UntilWaiter' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='com.koushikdutta.async.callback.DataCallback']]"
			[Register (".ctor", "(BLcom/koushikdutta/async/callback/DataCallback;)V", "")]
			public unsafe UntilWaiter (sbyte p0, global::Com.Koushikdutta.Async.Callback.IDataCallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (UntilWaiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(BLcom/koushikdutta/async/callback/DataCallback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(BLcom/koushikdutta/async/callback/DataCallback;)V", __args);
						return;
					}

					if (id_ctor_BLcom_koushikdutta_async_callback_DataCallback_ == IntPtr.Zero)
						id_ctor_BLcom_koushikdutta_async_callback_DataCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(BLcom/koushikdutta/async/callback/DataCallback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BLcom_koushikdutta_async_callback_DataCallback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_BLcom_koushikdutta_async_callback_DataCallback_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.Waiter']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$Waiter", DoNotGenerateAcw=true)]
		public abstract partial class Waiter : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/PushParser$Waiter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Waiter); }
			}

			protected Waiter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser.Waiter']/constructor[@name='PushParser.Waiter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Waiter (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Waiter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
						return;
					}

					if (id_ctor_I == IntPtr.Zero)
						id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/koushikdutta/async/PushParser$Waiter", DoNotGenerateAcw=true)]
		internal partial class WaiterInvoker : Waiter {

			public WaiterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (WaiterInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/PushParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushParser); }
		}

		protected PushParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_koushikdutta_async_DataEmitter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/constructor[@name='PushParser' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataEmitter']]"
		[Register (".ctor", "(Lcom/koushikdutta/async/DataEmitter;)V", "")]
		public unsafe PushParser (global::Com.Koushikdutta.Async.IDataEmitter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PushParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/koushikdutta/async/DataEmitter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/koushikdutta/async/DataEmitter;)V", __args);
					return;
				}

				if (id_ctor_Lcom_koushikdutta_async_DataEmitter_ == IntPtr.Zero)
					id_ctor_Lcom_koushikdutta_async_DataEmitter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/koushikdutta/async/DataEmitter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_koushikdutta_async_DataEmitter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_koushikdutta_async_DataEmitter_, __args);
			} finally {
			}
		}

		static Delegate cb_noop;
#pragma warning disable 0169
		static Delegate GetNoopHandler ()
		{
			if (cb_noop == null)
				cb_noop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Noop);
			return cb_noop;
		}

		static IntPtr n_Noop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Noop ());
		}
#pragma warning restore 0169

		static IntPtr id_noop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='noop' and count(parameter)=0]"
		[Register ("noop", "()Lcom/koushikdutta/async/PushParser;", "GetNoopHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser Noop ()
		{
			if (id_noop == IntPtr.Zero)
				id_noop = JNIEnv.GetMethodID (class_ref, "noop", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_noop), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "noop", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p1 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDataAvailable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDataAvailable_Lcom_koushikdutta_async_DataEmitter_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='onDataAvailable' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.DataEmitter'] and parameter[2][@type='com.koushikdutta.async.ByteBufferList']]"
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

		static Delegate cb_readByte;
#pragma warning disable 0169
		static Delegate GetReadByteHandler ()
		{
			if (cb_readByte == null)
				cb_readByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadByte);
			return cb_readByte;
		}

		static IntPtr n_ReadByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadByte ());
		}
#pragma warning restore 0169

		static IntPtr id_readByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readByte' and count(parameter)=0]"
		[Register ("readByte", "()Lcom/koushikdutta/async/PushParser;", "GetReadByteHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadByte ()
		{
			if (id_readByte == IntPtr.Zero)
				id_readByte = JNIEnv.GetMethodID (class_ref, "readByte", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readByte), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByte", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readByteArray_I;
#pragma warning disable 0169
		static Delegate GetReadByteArray_IHandler ()
		{
			if (cb_readByteArray_I == null)
				cb_readByteArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReadByteArray_I);
			return cb_readByteArray_I;
		}

		static IntPtr n_ReadByteArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadByteArray (p0));
		}
#pragma warning restore 0169

		static IntPtr id_readByteArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readByteArray", "(I)Lcom/koushikdutta/async/PushParser;", "GetReadByteArray_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadByteArray (int p0)
		{
			if (id_readByteArray_I == IntPtr.Zero)
				id_readByteArray_I = JNIEnv.GetMethodID (class_ref, "readByteArray", "(I)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readByteArray_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByteArray", "(I)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_;
#pragma warning disable 0169
		static Delegate GetReadByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_Handler ()
		{
			if (cb_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_ == null)
				cb_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_ReadByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_);
			return cb_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_;
		}

		static IntPtr n_ReadByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.PushParser.IParseCallback p1 = (global::Com.Koushikdutta.Async.PushParser.IParseCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser.IParseCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadByteArray (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readByteArray' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;byte[]&gt;']]"
		[Register ("readByteArray", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;", "GetReadByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadByteArray (int p0, global::Com.Koushikdutta.Async.PushParser.IParseCallback p1)
		{
			if (id_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
				id_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "readByteArray", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.PushParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readByteArray_ILcom_koushikdutta_async_PushParser_ParseCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByteArray", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readByteBufferList_I;
#pragma warning disable 0169
		static Delegate GetReadByteBufferList_IHandler ()
		{
			if (cb_readByteBufferList_I == null)
				cb_readByteBufferList_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReadByteBufferList_I);
			return cb_readByteBufferList_I;
		}

		static IntPtr n_ReadByteBufferList_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadByteBufferList (p0));
		}
#pragma warning restore 0169

		static IntPtr id_readByteBufferList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readByteBufferList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readByteBufferList", "(I)Lcom/koushikdutta/async/PushParser;", "GetReadByteBufferList_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadByteBufferList (int p0)
		{
			if (id_readByteBufferList_I == IntPtr.Zero)
				id_readByteBufferList_I = JNIEnv.GetMethodID (class_ref, "readByteBufferList", "(I)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readByteBufferList_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByteBufferList", "(I)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_;
#pragma warning disable 0169
		static Delegate GetReadByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_Handler ()
		{
			if (cb_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_ == null)
				cb_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_ReadByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_);
			return cb_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_;
		}

		static IntPtr n_ReadByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.PushParser.IParseCallback p1 = (global::Com.Koushikdutta.Async.PushParser.IParseCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser.IParseCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadByteBufferList (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readByteBufferList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;com.koushikdutta.async.ByteBufferList&gt;']]"
		[Register ("readByteBufferList", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;", "GetReadByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadByteBufferList (int p0, global::Com.Koushikdutta.Async.PushParser.IParseCallback p1)
		{
			if (id_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
				id_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "readByteBufferList", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.PushParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readByteBufferList_ILcom_koushikdutta_async_PushParser_ParseCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readByteBufferList", "(ILcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readInt;
#pragma warning disable 0169
		static Delegate GetReadIntHandler ()
		{
			if (cb_readInt == null)
				cb_readInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadInt);
			return cb_readInt;
		}

		static IntPtr n_ReadInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadInt ());
		}
#pragma warning restore 0169

		static IntPtr id_readInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()Lcom/koushikdutta/async/PushParser;", "GetReadIntHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadInt ()
		{
			if (id_readInt == IntPtr.Zero)
				id_readInt = JNIEnv.GetMethodID (class_ref, "readInt", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readInt), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readInt", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_;
#pragma warning disable 0169
		static Delegate GetReadInt_Lcom_koushikdutta_async_PushParser_ParseCallback_Handler ()
		{
			if (cb_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_ == null)
				cb_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadInt_Lcom_koushikdutta_async_PushParser_ParseCallback_);
			return cb_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_;
		}

		static IntPtr n_ReadInt_Lcom_koushikdutta_async_PushParser_ParseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.PushParser.IParseCallback p0 = (global::Com.Koushikdutta.Async.PushParser.IParseCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser.IParseCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadInt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readInt' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;java.lang.Integer&gt;']]"
		[Register ("readInt", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;", "GetReadInt_Lcom_koushikdutta_async_PushParser_ParseCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadInt (global::Com.Koushikdutta.Async.PushParser.IParseCallback p0)
		{
			if (id_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
				id_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "readInt", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.PushParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readInt_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readInt", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readLenByteArray;
#pragma warning disable 0169
		static Delegate GetReadLenByteArrayHandler ()
		{
			if (cb_readLenByteArray == null)
				cb_readLenByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadLenByteArray);
			return cb_readLenByteArray;
		}

		static IntPtr n_ReadLenByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadLenByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_readLenByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readLenByteArray' and count(parameter)=0]"
		[Register ("readLenByteArray", "()Lcom/koushikdutta/async/PushParser;", "GetReadLenByteArrayHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadLenByteArray ()
		{
			if (id_readLenByteArray == IntPtr.Zero)
				id_readLenByteArray = JNIEnv.GetMethodID (class_ref, "readLenByteArray", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readLenByteArray), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLenByteArray", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readLenByteBufferList;
#pragma warning disable 0169
		static Delegate GetReadLenByteBufferListHandler ()
		{
			if (cb_readLenByteBufferList == null)
				cb_readLenByteBufferList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadLenByteBufferList);
			return cb_readLenByteBufferList;
		}

		static IntPtr n_ReadLenByteBufferList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadLenByteBufferList ());
		}
#pragma warning restore 0169

		static IntPtr id_readLenByteBufferList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readLenByteBufferList' and count(parameter)=0]"
		[Register ("readLenByteBufferList", "()Lcom/koushikdutta/async/PushParser;", "GetReadLenByteBufferListHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadLenByteBufferList ()
		{
			if (id_readLenByteBufferList == IntPtr.Zero)
				id_readLenByteBufferList = JNIEnv.GetMethodID (class_ref, "readLenByteBufferList", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readLenByteBufferList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLenByteBufferList", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_;
#pragma warning disable 0169
		static Delegate GetReadLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_Handler ()
		{
			if (cb_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_ == null)
				cb_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_);
			return cb_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_;
		}

		static IntPtr n_ReadLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.PushParser.IParseCallback p0 = (global::Com.Koushikdutta.Async.PushParser.IParseCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser.IParseCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadLenByteBufferList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readLenByteBufferList' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.PushParser.ParseCallback&lt;com.koushikdutta.async.ByteBufferList&gt;']]"
		[Register ("readLenByteBufferList", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;", "GetReadLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadLenByteBufferList (global::Com.Koushikdutta.Async.PushParser.IParseCallback p0)
		{
			if (id_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_ == IntPtr.Zero)
				id_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_ = JNIEnv.GetMethodID (class_ref, "readLenByteBufferList", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.PushParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readLenByteBufferList_Lcom_koushikdutta_async_PushParser_ParseCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLenByteBufferList", "(Lcom/koushikdutta/async/PushParser$ParseCallback;)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_readLong;
#pragma warning disable 0169
		static Delegate GetReadLongHandler ()
		{
			if (cb_readLong == null)
				cb_readLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadLong);
			return cb_readLong;
		}

		static IntPtr n_ReadLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadLong ());
		}
#pragma warning restore 0169

		static IntPtr id_readLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readLong' and count(parameter)=0]"
		[Register ("readLong", "()Lcom/koushikdutta/async/PushParser;", "GetReadLongHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadLong ()
		{
			if (id_readLong == IntPtr.Zero)
				id_readLong = JNIEnv.GetMethodID (class_ref, "readLong", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readLong), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLong", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readShort;
#pragma warning disable 0169
		static Delegate GetReadShortHandler ()
		{
			if (cb_readShort == null)
				cb_readShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadShort);
			return cb_readShort;
		}

		static IntPtr n_ReadShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadShort ());
		}
#pragma warning restore 0169

		static IntPtr id_readShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()Lcom/koushikdutta/async/PushParser;", "GetReadShortHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadShort ()
		{
			if (id_readShort == IntPtr.Zero)
				id_readShort = JNIEnv.GetMethodID (class_ref, "readShort", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readShort), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readShort", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readString;
#pragma warning disable 0169
		static Delegate GetReadStringHandler ()
		{
			if (cb_readString == null)
				cb_readString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadString);
			return cb_readString;
		}

		static IntPtr n_ReadString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadString ());
		}
#pragma warning restore 0169

		static IntPtr id_readString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='readString' and count(parameter)=0]"
		[Register ("readString", "()Lcom/koushikdutta/async/PushParser;", "GetReadStringHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser ReadString ()
		{
			if (id_readString == IntPtr.Zero)
				id_readString = JNIEnv.GetMethodID (class_ref, "readString", "()Lcom/koushikdutta/async/PushParser;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_readString), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readString", "()Lcom/koushikdutta/async/PushParser;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOrder_Ljava_nio_ByteOrder_;
#pragma warning disable 0169
		static Delegate GetSetOrder_Ljava_nio_ByteOrder_Handler ()
		{
			if (cb_setOrder_Ljava_nio_ByteOrder_ == null)
				cb_setOrder_Ljava_nio_ByteOrder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOrder_Ljava_nio_ByteOrder_);
			return cb_setOrder_Ljava_nio_ByteOrder_;
		}

		static IntPtr n_SetOrder_Ljava_nio_ByteOrder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteOrder p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteOrder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOrder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setOrder_Ljava_nio_ByteOrder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='setOrder' and count(parameter)=1 and parameter[1][@type='java.nio.ByteOrder']]"
		[Register ("setOrder", "(Ljava/nio/ByteOrder;)Lcom/koushikdutta/async/PushParser;", "GetSetOrder_Ljava_nio_ByteOrder_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser SetOrder (global::Java.Nio.ByteOrder p0)
		{
			if (id_setOrder_Ljava_nio_ByteOrder_ == IntPtr.Zero)
				id_setOrder_Ljava_nio_ByteOrder_ = JNIEnv.GetMethodID (class_ref, "setOrder", "(Ljava/nio/ByteOrder;)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.PushParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_setOrder_Ljava_nio_ByteOrder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrder", "(Ljava/nio/ByteOrder;)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_tap_Lcom_koushikdutta_async_TapCallback_;
#pragma warning disable 0169
		static Delegate GetTap_Lcom_koushikdutta_async_TapCallback_Handler ()
		{
			if (cb_tap_Lcom_koushikdutta_async_TapCallback_ == null)
				cb_tap_Lcom_koushikdutta_async_TapCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Tap_Lcom_koushikdutta_async_TapCallback_);
			return cb_tap_Lcom_koushikdutta_async_TapCallback_;
		}

		static void n_Tap_Lcom_koushikdutta_async_TapCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ITapCallback p0 = (global::Com.Koushikdutta.Async.ITapCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ITapCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_tap_Lcom_koushikdutta_async_TapCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='tap' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.TapCallback']]"
		[Register ("tap", "(Lcom/koushikdutta/async/TapCallback;)V", "GetTap_Lcom_koushikdutta_async_TapCallback_Handler")]
		public virtual unsafe void Tap (global::Com.Koushikdutta.Async.ITapCallback p0)
		{
			if (id_tap_Lcom_koushikdutta_async_TapCallback_ == IntPtr.Zero)
				id_tap_Lcom_koushikdutta_async_TapCallback_ = JNIEnv.GetMethodID (class_ref, "tap", "(Lcom/koushikdutta/async/TapCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_tap_Lcom_koushikdutta_async_TapCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tap", "(Lcom/koushikdutta/async/TapCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_until_BLcom_koushikdutta_async_callback_DataCallback_;
#pragma warning disable 0169
		static Delegate GetUntil_BLcom_koushikdutta_async_callback_DataCallback_Handler ()
		{
			if (cb_until_BLcom_koushikdutta_async_callback_DataCallback_ == null)
				cb_until_BLcom_koushikdutta_async_callback_DataCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, IntPtr>) n_Until_BLcom_koushikdutta_async_callback_DataCallback_);
			return cb_until_BLcom_koushikdutta_async_callback_DataCallback_;
		}

		static IntPtr n_Until_BLcom_koushikdutta_async_callback_DataCallback_ (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.PushParser __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IDataCallback p1 = (global::Com.Koushikdutta.Async.Callback.IDataCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IDataCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Until (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_until_BLcom_koushikdutta_async_callback_DataCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='PushParser']/method[@name='until' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='com.koushikdutta.async.callback.DataCallback']]"
		[Register ("until", "(BLcom/koushikdutta/async/callback/DataCallback;)Lcom/koushikdutta/async/PushParser;", "GetUntil_BLcom_koushikdutta_async_callback_DataCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.PushParser Until (sbyte p0, global::Com.Koushikdutta.Async.Callback.IDataCallback p1)
		{
			if (id_until_BLcom_koushikdutta_async_callback_DataCallback_ == IntPtr.Zero)
				id_until_BLcom_koushikdutta_async_callback_DataCallback_ = JNIEnv.GetMethodID (class_ref, "until", "(BLcom/koushikdutta/async/callback/DataCallback;)Lcom/koushikdutta/async/PushParser;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.PushParser __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallObjectMethod  (Handle, id_until_BLcom_koushikdutta_async_callback_DataCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.PushParser> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "until", "(BLcom/koushikdutta/async/callback/DataCallback;)Lcom/koushikdutta/async/PushParser;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
