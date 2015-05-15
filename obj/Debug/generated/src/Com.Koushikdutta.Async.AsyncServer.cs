using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer", DoNotGenerateAcw=true)]
	public partial class AsyncServer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/field[@name='LOGTAG']"
		[Register ("LOGTAG")]
		public const string Logtag = (string) "NIO";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.AsyncSelectorException']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer$AsyncSelectorException", DoNotGenerateAcw=true)]
		public partial class AsyncSelectorException : global::Java.IO.IOException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/AsyncServer$AsyncSelectorException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AsyncSelectorException); }
			}

			protected AsyncSelectorException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Exception_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.AsyncSelectorException']/constructor[@name='AsyncServer.AsyncSelectorException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
			public unsafe AsyncSelectorException (global::Java.Lang.Exception p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (AsyncSelectorException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Exception;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Exception;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Exception_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Exception;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Exception_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Exception_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.NamedThreadFactory']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer$NamedThreadFactory", DoNotGenerateAcw=true)]
		public partial class NamedThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/AsyncServer$NamedThreadFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NamedThreadFactory); }
			}

			protected NamedThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
			{
				if (cb_newThread_Ljava_lang_Runnable_ == null)
					cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
				return cb_newThread_Ljava_lang_Runnable_;
			}

			static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Koushikdutta.Async.AsyncServer.NamedThreadFactory __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer.NamedThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_newThread_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.NamedThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
			public virtual unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable p0)
			{
				if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Thread __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.ObjectHolder']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer$ObjectHolder", DoNotGenerateAcw=true)]
		public partial class ObjectHolder : global::Java.Lang.Object {

			protected ObjectHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.RunnableWrapper']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer$RunnableWrapper", DoNotGenerateAcw=true)]
		public partial class RunnableWrapper : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/AsyncServer$RunnableWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RunnableWrapper); }
			}

			protected RunnableWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Koushikdutta.Async.AsyncServer.RunnableWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer.RunnableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.RunnableWrapper']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduled']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer$Scheduled", DoNotGenerateAcw=true)]
		public partial class Scheduled : global::Java.Lang.Object {


			static IntPtr runnable_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduled']/field[@name='runnable']"
			[Register ("runnable")]
			public global::Java.Lang.IRunnable Runnable {
				get {
					if (runnable_jfieldId == IntPtr.Zero)
						runnable_jfieldId = JNIEnv.GetFieldID (class_ref, "runnable", "Ljava/lang/Runnable;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, runnable_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (runnable_jfieldId == IntPtr.Zero)
						runnable_jfieldId = JNIEnv.GetFieldID (class_ref, "runnable", "Ljava/lang/Runnable;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, runnable_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr time_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduled']/field[@name='time']"
			[Register ("time")]
			public long Time {
				get {
					if (time_jfieldId == IntPtr.Zero)
						time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
					return JNIEnv.GetLongField (Handle, time_jfieldId);
				}
				set {
					if (time_jfieldId == IntPtr.Zero)
						time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
					try {
						JNIEnv.SetField (Handle, time_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/AsyncServer$Scheduled", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Scheduled); }
			}

			protected Scheduled (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Runnable_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduled']/constructor[@name='AsyncServer.Scheduled' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
			[Register (".ctor", "(Ljava/lang/Runnable;J)V", "")]
			public unsafe Scheduled (global::Java.Lang.IRunnable p0, long p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Scheduled)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Runnable;J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Runnable;J)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Runnable_J == IntPtr.Zero)
						id_ctor_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Runnable;J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Runnable_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Runnable_J, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduler']"
		[global::Android.Runtime.Register ("com/koushikdutta/async/AsyncServer$Scheduler", DoNotGenerateAcw=true)]
		public partial class Scheduler : global::Java.Lang.Object, global::Java.Util.IComparator {


			static IntPtr INSTANCE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduler']/field[@name='INSTANCE']"
			[Register ("INSTANCE")]
			public static global::Com.Koushikdutta.Async.AsyncServer.Scheduler Instance {
				get {
					if (INSTANCE_jfieldId == IntPtr.Zero)
						INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/koushikdutta/async/AsyncServer$Scheduler;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer.Scheduler> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (INSTANCE_jfieldId == IntPtr.Zero)
						INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/koushikdutta/async/AsyncServer$Scheduler;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetStaticField (class_ref, INSTANCE_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/koushikdutta/async/AsyncServer$Scheduler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Scheduler); }
			}

			protected Scheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Koushikdutta.Async.AsyncServer.Scheduler __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer.Scheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer.Scheduler']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/AsyncServer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncServer); }
		}

		protected AsyncServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/constructor[@name='AsyncServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AsyncServer (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (AsyncServer)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/constructor[@name='AsyncServer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncServer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncServer)) {
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

		static Delegate cb_getAffinity;
#pragma warning disable 0169
		static Delegate GetGetAffinityHandler ()
		{
			if (cb_getAffinity == null)
				cb_getAffinity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAffinity);
			return cb_getAffinity;
		}

		static IntPtr n_GetAffinity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Affinity);
		}
#pragma warning restore 0169

		static IntPtr id_getAffinity;
		public virtual unsafe global::Java.Lang.Thread Affinity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='getAffinity' and count(parameter)=0]"
			[Register ("getAffinity", "()Ljava/lang/Thread;", "GetGetAffinityHandler")]
			get {
				if (id_getAffinity == IntPtr.Zero)
					id_getAffinity = JNIEnv.GetMethodID (class_ref, "getAffinity", "()Ljava/lang/Thread;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_getAffinity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAffinity", "()Ljava/lang/Thread;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentThreadServer;
		public static unsafe global::Com.Koushikdutta.Async.AsyncServer CurrentThreadServer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='getCurrentThreadServer' and count(parameter)=0]"
			[Register ("getCurrentThreadServer", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetCurrentThreadServerHandler")]
			get {
				if (id_getCurrentThreadServer == IntPtr.Zero)
					id_getCurrentThreadServer = JNIEnv.GetStaticMethodID (class_ref, "getCurrentThreadServer", "()Lcom/koushikdutta/async/AsyncServer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentThreadServer), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDefault;
		public static unsafe global::Com.Koushikdutta.Async.AsyncServer Default {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='getDefault' and count(parameter)=0]"
			[Register ("getDefault", "()Lcom/koushikdutta/async/AsyncServer;", "GetGetDefaultHandler")]
			get {
				if (id_getDefault == IntPtr.Zero)
					id_getDefault = JNIEnv.GetStaticMethodID (class_ref, "getDefault", "()Lcom/koushikdutta/async/AsyncServer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefault), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAffinityThread;
#pragma warning disable 0169
		static Delegate GetIsAffinityThreadHandler ()
		{
			if (cb_isAffinityThread == null)
				cb_isAffinityThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAffinityThread);
			return cb_isAffinityThread;
		}

		static bool n_IsAffinityThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAffinityThread;
		}
#pragma warning restore 0169

		static IntPtr id_isAffinityThread;
		public virtual unsafe bool IsAffinityThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='isAffinityThread' and count(parameter)=0]"
			[Register ("isAffinityThread", "()Z", "GetIsAffinityThreadHandler")]
			get {
				if (id_isAffinityThread == IntPtr.Zero)
					id_isAffinityThread = JNIEnv.GetMethodID (class_ref, "isAffinityThread", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAffinityThread);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAffinityThread", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isAffinityThreadOrStopped;
#pragma warning disable 0169
		static Delegate GetIsAffinityThreadOrStoppedHandler ()
		{
			if (cb_isAffinityThreadOrStopped == null)
				cb_isAffinityThreadOrStopped = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAffinityThreadOrStopped);
			return cb_isAffinityThreadOrStopped;
		}

		static bool n_IsAffinityThreadOrStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAffinityThreadOrStopped;
		}
#pragma warning restore 0169

		static IntPtr id_isAffinityThreadOrStopped;
		public virtual unsafe bool IsAffinityThreadOrStopped {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='isAffinityThreadOrStopped' and count(parameter)=0]"
			[Register ("isAffinityThreadOrStopped", "()Z", "GetIsAffinityThreadOrStoppedHandler")]
			get {
				if (id_isAffinityThreadOrStopped == IntPtr.Zero)
					id_isAffinityThreadOrStopped = JNIEnv.GetMethodID (class_ref, "isAffinityThreadOrStopped", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAffinityThreadOrStopped);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAffinityThreadOrStopped", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_connectDatagram_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetConnectDatagram_Ljava_lang_String_IHandler ()
		{
			if (cb_connectDatagram_Ljava_lang_String_I == null)
				cb_connectDatagram_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_ConnectDatagram_Ljava_lang_String_I);
			return cb_connectDatagram_Ljava_lang_String_I;
		}

		static IntPtr n_ConnectDatagram_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConnectDatagram (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connectDatagram_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='connectDatagram' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("connectDatagram", "(Ljava/lang/String;I)Lcom/koushikdutta/async/AsyncDatagramSocket;", "GetConnectDatagram_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncDatagramSocket ConnectDatagram (string p0, int p1)
		{
			if (id_connectDatagram_Ljava_lang_String_I == IntPtr.Zero)
				id_connectDatagram_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "connectDatagram", "(Ljava/lang/String;I)Lcom/koushikdutta/async/AsyncDatagramSocket;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.AsyncDatagramSocket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallObjectMethod  (Handle, id_connectDatagram_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectDatagram", "(Ljava/lang/String;I)Lcom/koushikdutta/async/AsyncDatagramSocket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connectDatagram_Ljava_net_SocketAddress_;
#pragma warning disable 0169
		static Delegate GetConnectDatagram_Ljava_net_SocketAddress_Handler ()
		{
			if (cb_connectDatagram_Ljava_net_SocketAddress_ == null)
				cb_connectDatagram_Ljava_net_SocketAddress_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectDatagram_Ljava_net_SocketAddress_);
			return cb_connectDatagram_Ljava_net_SocketAddress_;
		}

		static IntPtr n_ConnectDatagram_Ljava_net_SocketAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.SocketAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.SocketAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConnectDatagram (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connectDatagram_Ljava_net_SocketAddress_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='connectDatagram' and count(parameter)=1 and parameter[1][@type='java.net.SocketAddress']]"
		[Register ("connectDatagram", "(Ljava/net/SocketAddress;)Lcom/koushikdutta/async/AsyncDatagramSocket;", "GetConnectDatagram_Ljava_net_SocketAddress_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncDatagramSocket ConnectDatagram (global::Java.Net.SocketAddress p0)
		{
			if (id_connectDatagram_Ljava_net_SocketAddress_ == IntPtr.Zero)
				id_connectDatagram_Ljava_net_SocketAddress_ = JNIEnv.GetMethodID (class_ref, "connectDatagram", "(Ljava/net/SocketAddress;)Lcom/koushikdutta/async/AsyncDatagramSocket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Koushikdutta.Async.AsyncDatagramSocket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallObjectMethod  (Handle, id_connectDatagram_Ljava_net_SocketAddress_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectDatagram", "(Ljava/net/SocketAddress;)Lcom/koushikdutta/async/AsyncDatagramSocket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetConnectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_Handler ()
		{
			if (cb_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_ == null)
				cb_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_ConnectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_);
			return cb_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_;
		}

		static IntPtr n_ConnectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IConnectCallback p2 = (global::Com.Koushikdutta.Async.Callback.IConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConnectSocket (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='connectSocket' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.koushikdutta.async.callback.ConnectCallback']]"
		[Register ("connectSocket", "(Ljava/lang/String;ILcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/future/Cancellable;", "GetConnectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.ICancellable ConnectSocket (string p0, int p1, global::Com.Koushikdutta.Async.Callback.IConnectCallback p2)
		{
			if (id_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_ == IntPtr.Zero)
				id_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "connectSocket", "(Ljava/lang/String;ILcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/future/Cancellable;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Koushikdutta.Async.Future.ICancellable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallObjectMethod  (Handle, id_connectSocket_Ljava_lang_String_ILcom_koushikdutta_async_callback_ConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectSocket", "(Ljava/lang/String;ILcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/future/Cancellable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_;
#pragma warning disable 0169
		static Delegate GetConnectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_Handler ()
		{
			if (cb_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_ == null)
				cb_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_);
			return cb_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_;
		}

		static IntPtr n_ConnectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetSocketAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IConnectCallback p1 = (global::Com.Koushikdutta.Async.Callback.IConnectCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConnectSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='connectSocket' and count(parameter)=2 and parameter[1][@type='java.net.InetSocketAddress'] and parameter[2][@type='com.koushikdutta.async.callback.ConnectCallback']]"
		[Register ("connectSocket", "(Ljava/net/InetSocketAddress;Lcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/future/Cancellable;", "GetConnectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.ICancellable ConnectSocket (global::Java.Net.InetSocketAddress p0, global::Com.Koushikdutta.Async.Callback.IConnectCallback p1)
		{
			if (id_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_ == IntPtr.Zero)
				id_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_ = JNIEnv.GetMethodID (class_ref, "connectSocket", "(Ljava/net/InetSocketAddress;Lcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/future/Cancellable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.Future.ICancellable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallObjectMethod  (Handle, id_connectSocket_Ljava_net_InetSocketAddress_Lcom_koushikdutta_async_callback_ConnectCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectSocket", "(Ljava/net/InetSocketAddress;Lcom/koushikdutta/async/callback/ConnectCallback;)Lcom/koushikdutta/async/future/Cancellable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dump;
#pragma warning disable 0169
		static Delegate GetDumpHandler ()
		{
			if (cb_dump == null)
				cb_dump = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dump);
			return cb_dump;
		}

		static void n_Dump (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dump ();
		}
#pragma warning restore 0169

		static IntPtr id_dump;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='dump' and count(parameter)=0]"
		[Register ("dump", "()V", "GetDumpHandler")]
		public virtual unsafe void Dump ()
		{
			if (id_dump == IntPtr.Zero)
				id_dump = JNIEnv.GetMethodID (class_ref, "dump", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dump);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dump", "()V"));
			} finally {
			}
		}

		static Delegate cb_getAllByName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAllByName_Ljava_lang_String_Handler ()
		{
			if (cb_getAllByName_Ljava_lang_String_ == null)
				cb_getAllByName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllByName_Ljava_lang_String_);
			return cb_getAllByName_Ljava_lang_String_;
		}

		static IntPtr n_GetAllByName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAllByName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAllByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='getAllByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAllByName", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;", "GetGetAllByName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture GetAllByName (string p0)
		{
			if (id_getAllByName_Ljava_lang_String_ == IntPtr.Zero)
				id_getAllByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAllByName", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getAllByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllByName", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getByName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetByName_Ljava_lang_String_Handler ()
		{
			if (cb_getByName_Ljava_lang_String_ == null)
				cb_getByName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetByName_Ljava_lang_String_);
			return cb_getByName_Ljava_lang_String_;
		}

		static IntPtr n_GetByName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetByName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getByName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='getByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getByName", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;", "GetGetByName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.Future.IFuture GetByName (string p0)
		{
			if (id_getByName_Ljava_lang_String_ == IntPtr.Zero)
				id_getByName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getByName", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Koushikdutta.Async.Future.IFuture __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallObjectMethod  (Handle, id_getByName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.IFuture> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getByName", "(Ljava/lang/String;)Lcom/koushikdutta/async/future/Future;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_;
#pragma warning disable 0169
		static Delegate GetListen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_Handler ()
		{
			if (cb_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_ == null)
				cb_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_);
			return cb_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_;
		}

		static IntPtr n_Listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.IListenCallback p2 = (global::Com.Koushikdutta.Async.Callback.IListenCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IListenCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listen (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='listen' and count(parameter)=3 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int'] and parameter[3][@type='com.koushikdutta.async.callback.ListenCallback']]"
		[Register ("listen", "(Ljava/net/InetAddress;ILcom/koushikdutta/async/callback/ListenCallback;)Lcom/koushikdutta/async/AsyncServerSocket;", "GetListen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_Handler")]
		public virtual unsafe global::Com.Koushikdutta.Async.IAsyncServerSocket Listen (global::Java.Net.InetAddress p0, int p1, global::Com.Koushikdutta.Async.Callback.IListenCallback p2)
		{
			if (id_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_ == IntPtr.Zero)
				id_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_ = JNIEnv.GetMethodID (class_ref, "listen", "(Ljava/net/InetAddress;ILcom/koushikdutta/async/callback/ListenCallback;)Lcom/koushikdutta/async/AsyncServerSocket;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Koushikdutta.Async.IAsyncServerSocket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (JNIEnv.CallObjectMethod  (Handle, id_listen_Ljava_net_InetAddress_ILcom_koushikdutta_async_callback_ListenCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncServerSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listen", "(Ljava/net/InetAddress;ILcom/koushikdutta/async/callback/ListenCallback;)Lcom/koushikdutta/async/AsyncServerSocket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDataReceived_I;
#pragma warning disable 0169
		static Delegate GetOnDataReceived_IHandler ()
		{
			if (cb_onDataReceived_I == null)
				cb_onDataReceived_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDataReceived_I);
			return cb_onDataReceived_I;
		}

		static void n_OnDataReceived_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataReceived (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDataReceived_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='onDataReceived' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDataReceived", "(I)V", "GetOnDataReceived_IHandler")]
		protected virtual unsafe void OnDataReceived (int p0)
		{
			if (id_onDataReceived_I == IntPtr.Zero)
				id_onDataReceived_I = JNIEnv.GetMethodID (class_ref, "onDataReceived", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataReceived_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataReceived", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDataSent_I;
#pragma warning disable 0169
		static Delegate GetOnDataSent_IHandler ()
		{
			if (cb_onDataSent_I == null)
				cb_onDataSent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDataSent_I);
			return cb_onDataSent_I;
		}

		static void n_OnDataSent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataSent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDataSent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='onDataSent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDataSent", "(I)V", "GetOnDataSent_IHandler")]
		protected virtual unsafe void OnDataSent (int p0)
		{
			if (id_onDataSent_I == IntPtr.Zero)
				id_onDataSent_I = JNIEnv.GetMethodID (class_ref, "onDataSent", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataSent_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataSent", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openDatagram;
#pragma warning disable 0169
		static Delegate GetOpenDatagramHandler ()
		{
			if (cb_openDatagram == null)
				cb_openDatagram = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenDatagram);
			return cb_openDatagram;
		}

		static IntPtr n_OpenDatagram (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenDatagram ());
		}
#pragma warning restore 0169

		static IntPtr id_openDatagram;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='openDatagram' and count(parameter)=0]"
		[Register ("openDatagram", "()Lcom/koushikdutta/async/AsyncDatagramSocket;", "GetOpenDatagramHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncDatagramSocket OpenDatagram ()
		{
			if (id_openDatagram == IntPtr.Zero)
				id_openDatagram = JNIEnv.GetMethodID (class_ref, "openDatagram", "()Lcom/koushikdutta/async/AsyncDatagramSocket;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallObjectMethod  (Handle, id_openDatagram), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDatagram", "()Lcom/koushikdutta/async/AsyncDatagramSocket;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_openDatagram_Ljava_net_SocketAddress_Z;
#pragma warning disable 0169
		static Delegate GetOpenDatagram_Ljava_net_SocketAddress_ZHandler ()
		{
			if (cb_openDatagram_Ljava_net_SocketAddress_Z == null)
				cb_openDatagram_Ljava_net_SocketAddress_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_OpenDatagram_Ljava_net_SocketAddress_Z);
			return cb_openDatagram_Ljava_net_SocketAddress_Z;
		}

		static IntPtr n_OpenDatagram_Ljava_net_SocketAddress_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.SocketAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.SocketAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenDatagram (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openDatagram_Ljava_net_SocketAddress_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='openDatagram' and count(parameter)=2 and parameter[1][@type='java.net.SocketAddress'] and parameter[2][@type='boolean']]"
		[Register ("openDatagram", "(Ljava/net/SocketAddress;Z)Lcom/koushikdutta/async/AsyncDatagramSocket;", "GetOpenDatagram_Ljava_net_SocketAddress_ZHandler")]
		public virtual unsafe global::Com.Koushikdutta.Async.AsyncDatagramSocket OpenDatagram (global::Java.Net.SocketAddress p0, bool p1)
		{
			if (id_openDatagram_Ljava_net_SocketAddress_Z == IntPtr.Zero)
				id_openDatagram_Ljava_net_SocketAddress_Z = JNIEnv.GetMethodID (class_ref, "openDatagram", "(Ljava/net/SocketAddress;Z)Lcom/koushikdutta/async/AsyncDatagramSocket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Koushikdutta.Async.AsyncDatagramSocket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallObjectMethod  (Handle, id_openDatagram_Ljava_net_SocketAddress_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncDatagramSocket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDatagram", "(Ljava/net/SocketAddress;Z)Lcom/koushikdutta/async/AsyncDatagramSocket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_post_Landroid_os_Handler_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='post' and count(parameter)=2 and parameter[1][@type='android.os.Handler'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("post", "(Landroid/os/Handler;Ljava/lang/Runnable;)V", "")]
		public static unsafe void Post (global::Android.OS.Handler p0, global::Java.Lang.IRunnable p1)
		{
			if (id_post_Landroid_os_Handler_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_post_Landroid_os_Handler_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "post", "(Landroid/os/Handler;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_post_Landroid_os_Handler_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static Delegate cb_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetPost_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_Handler ()
		{
			if (cb_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ == null)
				cb_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_);
			return cb_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_;
		}

		static IntPtr n_Post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0 = (global::Com.Koushikdutta.Async.Callback.ICompletedCallback)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='post' and count(parameter)=2 and parameter[1][@type='com.koushikdutta.async.callback.CompletedCallback'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("post", "(Lcom/koushikdutta/async/callback/CompletedCallback;Ljava/lang/Exception;)Ljava/lang/Object;", "GetPost_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_Handler")]
		public virtual unsafe global::Java.Lang.Object Post (global::Com.Koushikdutta.Async.Callback.ICompletedCallback p0, global::Java.Lang.Exception p1)
		{
			if (id_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ == IntPtr.Zero)
				id_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/koushikdutta/async/callback/CompletedCallback;Ljava/lang/Exception;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_post_Lcom_koushikdutta_async_callback_CompletedCallback_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Lcom/koushikdutta/async/callback/CompletedCallback;Ljava/lang/Exception;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_post_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_Runnable_Handler ()
		{
			if (cb_post_Ljava_lang_Runnable_ == null)
				cb_post_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Post_Ljava_lang_Runnable_);
			return cb_post_Ljava_lang_Runnable_;
		}

		static IntPtr n_Post_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_post_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("post", "(Ljava/lang/Runnable;)Ljava/lang/Object;", "GetPost_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::Java.Lang.Object Post (global::Java.Lang.IRunnable p0)
		{
			if (id_post_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_post_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/Runnable;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_post_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Ljava/lang/Runnable;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_postDelayed_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetPostDelayed_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_postDelayed_Ljava_lang_Runnable_J == null)
				cb_postDelayed_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_PostDelayed_Ljava_lang_Runnable_J);
			return cb_postDelayed_Ljava_lang_Runnable_J;
		}

		static IntPtr n_PostDelayed_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostDelayed (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postDelayed_Ljava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='postDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("postDelayed", "(Ljava/lang/Runnable;J)Ljava/lang/Object;", "GetPostDelayed_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe global::Java.Lang.Object PostDelayed (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_postDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_postDelayed_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postDelayed", "(Ljava/lang/Runnable;J)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_postDelayed_Ljava_lang_Runnable_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postDelayed", "(Ljava/lang/Runnable;J)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeAllCallbacks_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveAllCallbacks_Ljava_lang_Object_Handler ()
		{
			if (cb_removeAllCallbacks_Ljava_lang_Object_ == null)
				cb_removeAllCallbacks_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAllCallbacks_Ljava_lang_Object_);
			return cb_removeAllCallbacks_Ljava_lang_Object_;
		}

		static void n_RemoveAllCallbacks_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllCallbacks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeAllCallbacks_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='removeAllCallbacks' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeAllCallbacks", "(Ljava/lang/Object;)V", "GetRemoveAllCallbacks_Ljava_lang_Object_Handler")]
		public virtual unsafe void RemoveAllCallbacks (global::Java.Lang.Object p0)
		{
			if (id_removeAllCallbacks_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeAllCallbacks_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeAllCallbacks", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllCallbacks_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllCallbacks", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_run_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRun_Ljava_lang_Runnable_Handler ()
		{
			if (cb_run_Ljava_lang_Runnable_ == null)
				cb_run_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Run_Ljava_lang_Runnable_);
			return cb_run_Ljava_lang_Runnable_;
		}

		static void n_Run_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0);
		}
#pragma warning restore 0169

		static IntPtr id_run_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='run' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("run", "(Ljava/lang/Runnable;)V", "GetRun_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void Run (global::Java.Lang.IRunnable p0)
		{
			if (id_run_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_run_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "run", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.AsyncServer __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.AsyncServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='AsyncServer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
