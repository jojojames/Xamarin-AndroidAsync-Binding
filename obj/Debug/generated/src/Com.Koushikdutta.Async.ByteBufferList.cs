using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/ByteBufferList", DoNotGenerateAcw=true)]
	public partial class ByteBufferList : global::Java.Lang.Object {


		static IntPtr EMPTY_BYTEBUFFER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/field[@name='EMPTY_BYTEBUFFER']"
		[Register ("EMPTY_BYTEBUFFER")]
		public static global::Java.Nio.ByteBuffer EmptyBytebuffer {
			get {
				if (EMPTY_BYTEBUFFER_jfieldId == IntPtr.Zero)
					EMPTY_BYTEBUFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_BYTEBUFFER", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_BYTEBUFFER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAX_ITEM_SIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/field[@name='MAX_ITEM_SIZE']"
		[Register ("MAX_ITEM_SIZE")]
		public static int MaxItemSize {
			get {
				if (MAX_ITEM_SIZE_jfieldId == IntPtr.Zero)
					MAX_ITEM_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_ITEM_SIZE", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_ITEM_SIZE_jfieldId);
			}
			set {
				if (MAX_ITEM_SIZE_jfieldId == IntPtr.Zero)
					MAX_ITEM_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_ITEM_SIZE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, MAX_ITEM_SIZE_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList.Reclaimer']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/ByteBufferList$Reclaimer", DoNotGenerateAcw=true)]
		public partial class Reclaimer : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/ByteBufferList$Reclaimer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Reclaimer); }
			}

			protected Reclaimer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.ByteBufferList.Reclaimer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList.Reclaimer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList.Reclaimer']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
			public virtual unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == null)
					cb_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_);
				return cb_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
			}

			static int n_Compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Koushikdutta.Async.ByteBufferList.Reclaimer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList.Reclaimer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList.Reclaimer']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
			[Register ("compare", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "GetCompare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int Compare (global::Java.Nio.ByteBuffer p0, global::Java.Nio.ByteBuffer p1)
			{
				if (id_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_nio_ByteBuffer_Ljava_nio_ByteBuffer_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/ByteBufferList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteBufferList); }
		}

		protected ByteBufferList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/constructor[@name='ByteBufferList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteBufferList ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ByteBufferList)) {
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

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/constructor[@name='ByteBufferList' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ByteBufferList (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ByteBufferList)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_arrayLjava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/constructor[@name='ByteBufferList' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer...']]"
		[Register (".ctor", "([Ljava/nio/ByteBuffer;)V", "")]
		public unsafe ByteBufferList (params global:: Java.Nio.ByteBuffer[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ByteBufferList)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_arrayLjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayLjava_nio_ByteBuffer_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		static IntPtr id_getAll;
		public virtual unsafe global::Java.Nio.ByteBuffer All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/nio/ByteBuffer;", "GetGetAllHandler")]
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAll", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getByteChar;
#pragma warning disable 0169
		static Delegate GetGetByteCharHandler ()
		{
			if (cb_getByteChar == null)
				cb_getByteChar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetByteChar);
			return cb_getByteChar;
		}

		static char n_GetByteChar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ByteChar;
		}
#pragma warning restore 0169

		static IntPtr id_getByteChar;
		public virtual unsafe char ByteChar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getByteChar' and count(parameter)=0]"
			[Register ("getByteChar", "()C", "GetGetByteCharHandler")]
			get {
				if (id_getByteChar == IntPtr.Zero)
					id_getByteChar = JNIEnv.GetMethodID (class_ref, "getByteChar", "()C");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallCharMethod  (Handle, id_getByteChar);
					else
						return JNIEnv.CallNonvirtualCharMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByteChar", "()C"));
				} finally {
				}
			}
		}

		static Delegate cb_hasRemaining;
#pragma warning disable 0169
		static Delegate GetHasRemainingHandler ()
		{
			if (cb_hasRemaining == null)
				cb_hasRemaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasRemaining);
			return cb_hasRemaining;
		}

		static bool n_HasRemaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasRemaining;
		}
#pragma warning restore 0169

		static IntPtr id_hasRemaining;
		public virtual unsafe bool HasRemaining {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='hasRemaining' and count(parameter)=0]"
			[Register ("hasRemaining", "()Z", "GetHasRemainingHandler")]
			get {
				if (id_hasRemaining == IntPtr.Zero)
					id_hasRemaining = JNIEnv.GetMethodID (class_ref, "hasRemaining", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasRemaining);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasRemaining", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getInt;
#pragma warning disable 0169
		static Delegate GetGetIntHandler ()
		{
			if (cb_getInt == null)
				cb_getInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInt);
			return cb_getInt;
		}

		static int n_GetInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Int;
		}
#pragma warning restore 0169

		static IntPtr id_getInt;
		public virtual unsafe int Int {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getInt' and count(parameter)=0]"
			[Register ("getInt", "()I", "GetGetIntHandler")]
			get {
				if (id_getInt == IntPtr.Zero)
					id_getInt = JNIEnv.GetMethodID (class_ref, "getInt", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getInt);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLong;
#pragma warning disable 0169
		static Delegate GetGetLongHandler ()
		{
			if (cb_getLong == null)
				cb_getLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLong);
			return cb_getLong;
		}

		static long n_GetLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Long;
		}
#pragma warning restore 0169

		static IntPtr id_getLong;
		public virtual unsafe long Long {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getLong' and count(parameter)=0]"
			[Register ("getLong", "()J", "GetGetLongHandler")]
			get {
				if (id_getLong == IntPtr.Zero)
					id_getLong = JNIEnv.GetMethodID (class_ref, "getLong", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getLong);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getShort;
#pragma warning disable 0169
		static Delegate GetGetShortHandler ()
		{
			if (cb_getShort == null)
				cb_getShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetShort);
			return cb_getShort;
		}

		static short n_GetShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Short;
		}
#pragma warning restore 0169

		static IntPtr id_getShort;
		public virtual unsafe short Short {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getShort' and count(parameter)=0]"
			[Register ("getShort", "()S", "GetGetShortHandler")]
			get {
				if (id_getShort == IntPtr.Zero)
					id_getShort = JNIEnv.GetMethodID (class_ref, "getShort", "()S");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod  (Handle, id_getShort);
					else
						return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShort", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_add_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_add_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_add_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static IntPtr n_Add_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("add", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;", "GetAdd_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList Add (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_add_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_add_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.ByteBufferList __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_add_Lcom_koushikdutta_async_ByteBufferList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_add_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_add_Ljava_nio_ByteBuffer_ == null)
				cb_add_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_nio_ByteBuffer_);
			return cb_add_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_Add_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("add", "(Ljava/nio/ByteBuffer;)Lcom/koushikdutta/async/ByteBufferList;", "GetAdd_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList Add (global::Java.Nio.ByteBuffer p0)
		{
			if (id_add_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_add_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/nio/ByteBuffer;)Lcom/koushikdutta/async/ByteBufferList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.ByteBufferList __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_add_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/nio/ByteBuffer;)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addAll_arrayLcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetAddAll_arrayLcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_addAll_arrayLcom_koushikdutta_async_ByteBufferList_ == null)
				cb_addAll_arrayLcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAll_arrayLcom_koushikdutta_async_ByteBufferList_);
			return cb_addAll_arrayLcom_koushikdutta_async_ByteBufferList_;
		}

		static IntPtr n_AddAll_arrayLcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList[] p0 = (global::Com.Koushikdutta.Async.ByteBufferList[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Koushikdutta.Async.ByteBufferList));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAll (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_arrayLcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList...']]"
		[Register ("addAll", "([Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;", "GetAddAll_arrayLcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList AddAll (params global:: Com.Koushikdutta.Async.ByteBufferList[] p0)
		{
			if (id_addAll_arrayLcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_addAll_arrayLcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "addAll", "([Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.ByteBufferList __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_addAll_arrayLcom_koushikdutta_async_ByteBufferList_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "([Lcom/koushikdutta/async/ByteBufferList;)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addAll_arrayLjava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetAddAll_arrayLjava_nio_ByteBuffer_Handler ()
		{
			if (cb_addAll_arrayLjava_nio_ByteBuffer_ == null)
				cb_addAll_arrayLjava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAll_arrayLjava_nio_ByteBuffer_);
			return cb_addAll_arrayLjava_nio_ByteBuffer_;
		}

		static IntPtr n_AddAll_arrayLjava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer[] p0 = (global::Java.Nio.ByteBuffer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.ByteBuffer));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAll (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_arrayLjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer...']]"
		[Register ("addAll", "([Ljava/nio/ByteBuffer;)Lcom/koushikdutta/async/ByteBufferList;", "GetAddAll_arrayLjava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList AddAll (params global:: Java.Nio.ByteBuffer[] p0)
		{
			if (id_addAll_arrayLjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_addAll_arrayLjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "addAll", "([Ljava/nio/ByteBuffer;)Lcom/koushikdutta/async/ByteBufferList;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.ByteBufferList __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_addAll_arrayLjava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "([Ljava/nio/ByteBuffer;)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addFirst_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetAddFirst_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_addFirst_Ljava_nio_ByteBuffer_ == null)
				cb_addFirst_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFirst_Ljava_nio_ByteBuffer_);
			return cb_addFirst_Ljava_nio_ByteBuffer_;
		}

		static void n_AddFirst_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFirst (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFirst_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='addFirst' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("addFirst", "(Ljava/nio/ByteBuffer;)V", "GetAddFirst_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void AddFirst (global::Java.Nio.ByteBuffer p0)
		{
			if (id_addFirst_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_addFirst_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "addFirst", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addFirst_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFirst", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Get);
			return cb_get;
		}

		static sbyte n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get ();
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()B", "GetGetHandler")]
		public virtual unsafe sbyte Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()B");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallByteMethod  (Handle, id_get);
				else
					return JNIEnv.CallNonvirtualByteMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()B"));
			} finally {
			}
		}

		static Delegate cb_get_arrayB;
#pragma warning disable 0169
		static Delegate GetGet_arrayBHandler ()
		{
			if (cb_get_arrayB == null)
				cb_get_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Get_arrayB);
			return cb_get_arrayB;
		}

		static void n_Get_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Get (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("get", "([B)V", "GetGet_arrayBHandler")]
		public virtual unsafe void Get (byte[] p0)
		{
			if (id_get_arrayB == IntPtr.Zero)
				id_get_arrayB = JNIEnv.GetMethodID (class_ref, "get", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_get_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_get_arrayBII;
#pragma warning disable 0169
		static Delegate GetGet_arrayBIIHandler ()
		{
			if (cb_get_arrayBII == null)
				cb_get_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Get_arrayBII);
			return cb_get_arrayBII;
		}

		static void n_Get_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Get (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='get' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("get", "([BII)V", "GetGet_arrayBIIHandler")]
		public virtual unsafe void Get (byte[] p0, int p1, int p2)
		{
			if (id_get_arrayBII == IntPtr.Zero)
				id_get_arrayBII = JNIEnv.GetMethodID (class_ref, "get", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_get_arrayBII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "([BII)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_get_Lcom_koushikdutta_async_ByteBufferList_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_koushikdutta_async_ByteBufferList_Handler ()
		{
			if (cb_get_Lcom_koushikdutta_async_ByteBufferList_ == null)
				cb_get_Lcom_koushikdutta_async_ByteBufferList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Get_Lcom_koushikdutta_async_ByteBufferList_);
			return cb_get_Lcom_koushikdutta_async_ByteBufferList_;
		}

		static void n_Get_Lcom_koushikdutta_async_ByteBufferList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0);
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_koushikdutta_async_ByteBufferList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.ByteBufferList']]"
		[Register ("get", "(Lcom/koushikdutta/async/ByteBufferList;)V", "GetGet_Lcom_koushikdutta_async_ByteBufferList_Handler")]
		public virtual unsafe void Get (global::Com.Koushikdutta.Async.ByteBufferList p0)
		{
			if (id_get_Lcom_koushikdutta_async_ByteBufferList_ == IntPtr.Zero)
				id_get_Lcom_koushikdutta_async_ByteBufferList_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/koushikdutta/async/ByteBufferList;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_get_Lcom_koushikdutta_async_ByteBufferList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/koushikdutta/async/ByteBufferList;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get_Lcom_koushikdutta_async_ByteBufferList_I;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_koushikdutta_async_ByteBufferList_IHandler ()
		{
			if (cb_get_Lcom_koushikdutta_async_ByteBufferList_I == null)
				cb_get_Lcom_koushikdutta_async_ByteBufferList_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Get_Lcom_koushikdutta_async_ByteBufferList_I);
			return cb_get_Lcom_koushikdutta_async_ByteBufferList_I;
		}

		static void n_Get_Lcom_koushikdutta_async_ByteBufferList_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.ByteBufferList p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_koushikdutta_async_ByteBufferList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='get' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.ByteBufferList'] and parameter[2][@type='int']]"
		[Register ("get", "(Lcom/koushikdutta/async/ByteBufferList;I)V", "GetGet_Lcom_koushikdutta_async_ByteBufferList_IHandler")]
		public virtual unsafe void Get (global::Com.Koushikdutta.Async.ByteBufferList p0, int p1)
		{
			if (id_get_Lcom_koushikdutta_async_ByteBufferList_I == IntPtr.Zero)
				id_get_Lcom_koushikdutta_async_ByteBufferList_I = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/koushikdutta/async/ByteBufferList;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_get_Lcom_koushikdutta_async_ByteBufferList_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/koushikdutta/async/ByteBufferList;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/koushikdutta/async/ByteBufferList;", "GetGet_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/koushikdutta/async/ByteBufferList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAllArray;
#pragma warning disable 0169
		static Delegate GetGetAllArrayHandler ()
		{
			if (cb_getAllArray == null)
				cb_getAllArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllArray);
			return cb_getAllArray;
		}

		static IntPtr n_GetAllArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getAllArray' and count(parameter)=0]"
		[Register ("getAllArray", "()[Ljava/nio/ByteBuffer;", "GetGetAllArrayHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer[] GetAllArray ()
		{
			if (id_getAllArray == IntPtr.Zero)
				id_getAllArray = JNIEnv.GetMethodID (class_ref, "getAllArray", "()[Ljava/nio/ByteBuffer;");
			try {

				if (GetType () == ThresholdType)
					return (global::Java.Nio.ByteBuffer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Nio.ByteBuffer));
				else
					return (global::Java.Nio.ByteBuffer[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllArray", "()[Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Nio.ByteBuffer));
			} finally {
			}
		}

		static Delegate cb_getAllByteArray;
#pragma warning disable 0169
		static Delegate GetGetAllByteArrayHandler ()
		{
			if (cb_getAllByteArray == null)
				cb_getAllByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllByteArray);
			return cb_getAllByteArray;
		}

		static IntPtr n_GetAllByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getAllByteArray' and count(parameter)=0]"
		[Register ("getAllByteArray", "()[B", "GetGetAllByteArrayHandler")]
		public virtual unsafe byte[] GetAllByteArray ()
		{
			if (id_getAllByteArray == IntPtr.Zero)
				id_getAllByteArray = JNIEnv.GetMethodID (class_ref, "getAllByteArray", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getAllByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getBytes_I;
#pragma warning disable 0169
		static Delegate GetGetBytes_IHandler ()
		{
			if (cb_getBytes_I == null)
				cb_getBytes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBytes_I);
			return cb_getBytes_I;
		}

		static IntPtr n_GetBytes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytes", "(I)[B", "GetGetBytes_IHandler")]
		public virtual unsafe byte[] GetBytes (int p0)
		{
			if (id_getBytes_I == IntPtr.Zero)
				id_getBytes_I = JNIEnv.GetMethodID (class_ref, "getBytes", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBytes_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_obtain_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='obtain' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("obtain", "(I)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer Obtain (int p0)
		{
			if (id_obtain_I == IntPtr.Zero)
				id_obtain_I = JNIEnv.GetStaticMethodID (class_ref, "obtain", "(I)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtain_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_obtainArray_arrayLjava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='obtainArray' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer[]'] and parameter[2][@type='int']]"
		[Register ("obtainArray", "([Ljava/nio/ByteBuffer;I)V", "")]
		public static unsafe void ObtainArray (global::Java.Nio.ByteBuffer[] p0, int p1)
		{
			if (id_obtainArray_arrayLjava_nio_ByteBuffer_I == IntPtr.Zero)
				id_obtainArray_arrayLjava_nio_ByteBuffer_I = JNIEnv.GetStaticMethodID (class_ref, "obtainArray", "([Ljava/nio/ByteBuffer;I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_obtainArray_arrayLjava_nio_ByteBuffer_I, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_order;
#pragma warning disable 0169
		static Delegate GetOrderHandler ()
		{
			if (cb_order == null)
				cb_order = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Order);
			return cb_order;
		}

		static IntPtr n_Order (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Order ());
		}
#pragma warning restore 0169

		static IntPtr id_order;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='order' and count(parameter)=0]"
		[Register ("order", "()Ljava/nio/ByteOrder;", "GetOrderHandler")]
		public virtual unsafe global::Java.Nio.ByteOrder Order ()
		{
			if (id_order == IntPtr.Zero)
				id_order = JNIEnv.GetMethodID (class_ref, "order", "()Ljava/nio/ByteOrder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteOrder> (JNIEnv.CallObjectMethod  (Handle, id_order), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteOrder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "order", "()Ljava/nio/ByteOrder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_order_Ljava_nio_ByteOrder_;
#pragma warning disable 0169
		static Delegate GetOrder_Ljava_nio_ByteOrder_Handler ()
		{
			if (cb_order_Ljava_nio_ByteOrder_ == null)
				cb_order_Ljava_nio_ByteOrder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Order_Ljava_nio_ByteOrder_);
			return cb_order_Ljava_nio_ByteOrder_;
		}

		static IntPtr n_Order_Ljava_nio_ByteOrder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteOrder p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteOrder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Order (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_order_Ljava_nio_ByteOrder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='order' and count(parameter)=1 and parameter[1][@type='java.nio.ByteOrder']]"
		[Register ("order", "(Ljava/nio/ByteOrder;)Lcom/koushikdutta/async/ByteBufferList;", "GetOrder_Ljava_nio_ByteOrder_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList Order (global::Java.Nio.ByteOrder p0)
		{
			if (id_order_Ljava_nio_ByteOrder_ == IntPtr.Zero)
				id_order_Ljava_nio_ByteOrder_ = JNIEnv.GetMethodID (class_ref, "order", "(Ljava/nio/ByteOrder;)Lcom/koushikdutta/async/ByteBufferList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.ByteBufferList __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_order_Ljava_nio_ByteOrder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "order", "(Ljava/nio/ByteOrder;)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_peekBytes_I;
#pragma warning disable 0169
		static Delegate GetPeekBytes_IHandler ()
		{
			if (cb_peekBytes_I == null)
				cb_peekBytes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PeekBytes_I);
			return cb_peekBytes_I;
		}

		static IntPtr n_PeekBytes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.PeekBytes (p0));
		}
#pragma warning restore 0169

		static IntPtr id_peekBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='peekBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("peekBytes", "(I)[B", "GetPeekBytes_IHandler")]
		public virtual unsafe byte[] PeekBytes (int p0)
		{
			if (id_peekBytes_I == IntPtr.Zero)
				id_peekBytes_I = JNIEnv.GetMethodID (class_ref, "peekBytes", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_peekBytes_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekBytes", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_peekInt;
#pragma warning disable 0169
		static Delegate GetPeekIntHandler ()
		{
			if (cb_peekInt == null)
				cb_peekInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_PeekInt);
			return cb_peekInt;
		}

		static int n_PeekInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeekInt ();
		}
#pragma warning restore 0169

		static IntPtr id_peekInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='peekInt' and count(parameter)=0]"
		[Register ("peekInt", "()I", "GetPeekIntHandler")]
		public virtual unsafe int PeekInt ()
		{
			if (id_peekInt == IntPtr.Zero)
				id_peekInt = JNIEnv.GetMethodID (class_ref, "peekInt", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_peekInt);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekInt", "()I"));
			} finally {
			}
		}

		static Delegate cb_peekLong;
#pragma warning disable 0169
		static Delegate GetPeekLongHandler ()
		{
			if (cb_peekLong == null)
				cb_peekLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_PeekLong);
			return cb_peekLong;
		}

		static long n_PeekLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeekLong ();
		}
#pragma warning restore 0169

		static IntPtr id_peekLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='peekLong' and count(parameter)=0]"
		[Register ("peekLong", "()J", "GetPeekLongHandler")]
		public virtual unsafe long PeekLong ()
		{
			if (id_peekLong == IntPtr.Zero)
				id_peekLong = JNIEnv.GetMethodID (class_ref, "peekLong", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_peekLong);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekLong", "()J"));
			} finally {
			}
		}

		static Delegate cb_peekShort;
#pragma warning disable 0169
		static Delegate GetPeekShortHandler ()
		{
			if (cb_peekShort == null)
				cb_peekShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_PeekShort);
			return cb_peekShort;
		}

		static short n_PeekShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeekShort ();
		}
#pragma warning restore 0169

		static IntPtr id_peekShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='peekShort' and count(parameter)=0]"
		[Register ("peekShort", "()S", "GetPeekShortHandler")]
		public virtual unsafe short PeekShort ()
		{
			if (id_peekShort == IntPtr.Zero)
				id_peekShort = JNIEnv.GetMethodID (class_ref, "peekShort", "()S");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallShortMethod  (Handle, id_peekShort);
				else
					return JNIEnv.CallNonvirtualShortMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekShort", "()S"));
			} finally {
			}
		}

		static Delegate cb_peekString;
#pragma warning disable 0169
		static Delegate GetPeekStringHandler ()
		{
			if (cb_peekString == null)
				cb_peekString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekString);
			return cb_peekString;
		}

		static IntPtr n_PeekString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PeekString ());
		}
#pragma warning restore 0169

		static IntPtr id_peekString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='peekString' and count(parameter)=0]"
		[Register ("peekString", "()Ljava/lang/String;", "GetPeekStringHandler")]
		public virtual unsafe string PeekString ()
		{
			if (id_peekString == IntPtr.Zero)
				id_peekString = JNIEnv.GetMethodID (class_ref, "peekString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_peekString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekString_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetPeekString_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_peekString_Ljava_nio_charset_Charset_ == null)
				cb_peekString_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PeekString_Ljava_nio_charset_Charset_);
			return cb_peekString_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_PeekString_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PeekString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_peekString_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='peekString' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("peekString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetPeekString_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string PeekString (global::Java.Nio.Charset.Charset p0)
		{
			if (id_peekString_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_peekString_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "peekString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_peekString_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadString ());
		}
#pragma warning restore 0169

		static IntPtr id_readString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='readString' and count(parameter)=0]"
		[Register ("readString", "()Ljava/lang/String;", "GetReadStringHandler")]
		public virtual unsafe string ReadString ()
		{
			if (id_readString == IntPtr.Zero)
				id_readString = JNIEnv.GetMethodID (class_ref, "readString", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readString_Ljava_nio_charset_Charset_;
#pragma warning disable 0169
		static Delegate GetReadString_Ljava_nio_charset_Charset_Handler ()
		{
			if (cb_readString_Ljava_nio_charset_Charset_ == null)
				cb_readString_Ljava_nio_charset_Charset_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadString_Ljava_nio_charset_Charset_);
			return cb_readString_Ljava_nio_charset_Charset_;
		}

		static IntPtr n_ReadString_Ljava_nio_charset_Charset_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Charset.Charset p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readString_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;", "GetReadString_Ljava_nio_charset_Charset_Handler")]
		public virtual unsafe string ReadString (global::Java.Nio.Charset.Charset p0)
		{
			if (id_readString_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_readString_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_readString_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readString", "(Ljava/nio/charset/Charset;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_reclaim_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='reclaim' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("reclaim", "(Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void Reclaim (global::Java.Nio.ByteBuffer p0)
		{
			if (id_reclaim_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_reclaim_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "reclaim", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reclaim_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

		static Delegate cb_remaining;
#pragma warning disable 0169
		static Delegate GetRemainingHandler ()
		{
			if (cb_remaining == null)
				cb_remaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Remaining);
			return cb_remaining;
		}

		static int n_Remaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remaining ();
		}
#pragma warning restore 0169

		static IntPtr id_remaining;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='remaining' and count(parameter)=0]"
		[Register ("remaining", "()I", "GetRemainingHandler")]
		public virtual unsafe int Remaining ()
		{
			if (id_remaining == IntPtr.Zero)
				id_remaining = JNIEnv.GetMethodID (class_ref, "remaining", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_remaining);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remaining", "()I"));
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static IntPtr n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove ());
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()Ljava/nio/ByteBuffer;", "GetRemoveHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()Ljava/nio/ByteBuffer;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_remove), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setMaxItemSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='setMaxItemSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxItemSize", "(I)V", "")]
		public static unsafe void SetMaxItemSize (int p0)
		{
			if (id_setMaxItemSize_I == IntPtr.Zero)
				id_setMaxItemSize_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxItemSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxItemSize_I, __args);
			} finally {
			}
		}

		static IntPtr id_setMaxPoolSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='setMaxPoolSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxPoolSize", "(I)V", "")]
		public static unsafe void SetMaxPoolSize (int p0)
		{
			if (id_setMaxPoolSize_I == IntPtr.Zero)
				id_setMaxPoolSize_I = JNIEnv.GetStaticMethodID (class_ref, "setMaxPoolSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMaxPoolSize_I, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_skip_I;
#pragma warning disable 0169
		static Delegate GetSkip_IHandler ()
		{
			if (cb_skip_I == null)
				cb_skip_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Skip_I);
			return cb_skip_I;
		}

		static IntPtr n_Skip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Skip (p0));
		}
#pragma warning restore 0169

		static IntPtr id_skip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)Lcom/koushikdutta/async/ByteBufferList;", "GetSkip_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.ByteBufferList Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)Lcom/koushikdutta/async/ByteBufferList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallObjectMethod  (Handle, id_skip_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "(I)Lcom/koushikdutta/async/ByteBufferList;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_spewString;
#pragma warning disable 0169
		static Delegate GetSpewStringHandler ()
		{
			if (cb_spewString == null)
				cb_spewString = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SpewString);
			return cb_spewString;
		}

		static void n_SpewString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpewString ();
		}
#pragma warning restore 0169

		static IntPtr id_spewString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='spewString' and count(parameter)=0]"
		[Register ("spewString", "()V", "GetSpewStringHandler")]
		public virtual unsafe void SpewString ()
		{
			if (id_spewString == IntPtr.Zero)
				id_spewString = JNIEnv.GetMethodID (class_ref, "spewString", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_spewString);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "spewString", "()V"));
			} finally {
			}
		}

		static Delegate cb_trim;
#pragma warning disable 0169
		static Delegate GetTrimHandler ()
		{
			if (cb_trim == null)
				cb_trim = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Trim);
			return cb_trim;
		}

		static void n_Trim (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.ByteBufferList __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.ByteBufferList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Trim ();
		}
#pragma warning restore 0169

		static IntPtr id_trim;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='trim' and count(parameter)=0]"
		[Register ("trim", "()V", "GetTrimHandler")]
		public virtual unsafe void Trim ()
		{
			if (id_trim == IntPtr.Zero)
				id_trim = JNIEnv.GetMethodID (class_ref, "trim", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_trim);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trim", "()V"));
			} finally {
			}
		}

		static IntPtr id_writeOutputStream_Ljava_io_OutputStream_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='ByteBufferList']/method[@name='writeOutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("writeOutputStream", "(Ljava/io/OutputStream;Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void WriteOutputStream (global::System.IO.Stream p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_writeOutputStream_Ljava_io_OutputStream_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_writeOutputStream_Ljava_io_OutputStream_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "writeOutputStream", "(Ljava/io/OutputStream;Ljava/nio/ByteBuffer;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeOutputStream_Ljava_io_OutputStream_Ljava_nio_ByteBuffer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
