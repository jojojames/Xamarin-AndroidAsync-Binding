using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/SelectorWrapper", DoNotGenerateAcw=true)]
	public partial class SelectorWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/SelectorWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SelectorWrapper); }
		}

		protected SelectorWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_Selector_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/constructor[@name='SelectorWrapper' and count(parameter)=1 and parameter[1][@type='java.nio.channels.Selector']]"
		[Register (".ctor", "(Ljava/nio/channels/Selector;)V", "")]
		public unsafe SelectorWrapper (global::Java.Nio.Channels.Selector p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SelectorWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/channels/Selector;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/channels/Selector;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_Selector_ == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_Selector_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/Selector;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_Selector_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_channels_Selector_, __args);
			} finally {
			}
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelector;
#pragma warning disable 0169
		static Delegate GetGetSelectorHandler ()
		{
			if (cb_getSelector == null)
				cb_getSelector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelector);
			return cb_getSelector;
		}

		static IntPtr n_GetSelector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Selector);
		}
#pragma warning restore 0169

		static IntPtr id_getSelector;
		public virtual unsafe global::Java.Nio.Channels.Selector Selector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='getSelector' and count(parameter)=0]"
			[Register ("getSelector", "()Ljava/nio/channels/Selector;", "GetGetSelectorHandler")]
			get {
				if (id_getSelector == IntPtr.Zero)
					id_getSelector = JNIEnv.GetMethodID (class_ref, "getSelector", "()Ljava/nio/channels/Selector;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.Selector> (JNIEnv.CallObjectMethod  (Handle, id_getSelector), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.Selector> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelector", "()Ljava/nio/channels/Selector;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_keys;
#pragma warning disable 0169
		static Delegate GetKeysHandler ()
		{
			if (cb_keys == null)
				cb_keys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Keys);
			return cb_keys;
		}

		static IntPtr n_Keys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Nio.Channels.SelectionKey>.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		static IntPtr id_keys;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Ljava/util/Set;", "GetKeysHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Nio.Channels.SelectionKey> Keys ()
		{
			if (id_keys == IntPtr.Zero)
				id_keys = JNIEnv.GetMethodID (class_ref, "keys", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Java.Nio.Channels.SelectionKey>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_keys), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Java.Nio.Channels.SelectionKey>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keys", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_select;
#pragma warning disable 0169
		static Delegate GetSelectHandler ()
		{
			if (cb_select == null)
				cb_select = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Select);
			return cb_select;
		}

		static void n_Select (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Select ();
		}
#pragma warning restore 0169

		static IntPtr id_select;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='select' and count(parameter)=0]"
		[Register ("select", "()V", "GetSelectHandler")]
		public virtual unsafe void Select ()
		{
			if (id_select == IntPtr.Zero)
				id_select = JNIEnv.GetMethodID (class_ref, "select", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_select);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "()V"));
			} finally {
			}
		}

		static Delegate cb_select_J;
#pragma warning disable 0169
		static Delegate GetSelect_JHandler ()
		{
			if (cb_select_J == null)
				cb_select_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Select_J);
			return cb_select_J;
		}

		static void n_Select_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Select (p0);
		}
#pragma warning restore 0169

		static IntPtr id_select_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='select' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("select", "(J)V", "GetSelect_JHandler")]
		public virtual unsafe void Select (long p0)
		{
			if (id_select_J == IntPtr.Zero)
				id_select_J = JNIEnv.GetMethodID (class_ref, "select", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_select_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "select", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_selectNow;
#pragma warning disable 0169
		static Delegate GetSelectNowHandler ()
		{
			if (cb_selectNow == null)
				cb_selectNow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SelectNow);
			return cb_selectNow;
		}

		static int n_SelectNow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectNow ();
		}
#pragma warning restore 0169

		static IntPtr id_selectNow;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='selectNow' and count(parameter)=0]"
		[Register ("selectNow", "()I", "GetSelectNowHandler")]
		public virtual unsafe int SelectNow ()
		{
			if (id_selectNow == IntPtr.Zero)
				id_selectNow = JNIEnv.GetMethodID (class_ref, "selectNow", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_selectNow);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectNow", "()I"));
			} finally {
			}
		}

		static Delegate cb_selectedKeys;
#pragma warning disable 0169
		static Delegate GetSelectedKeysHandler ()
		{
			if (cb_selectedKeys == null)
				cb_selectedKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SelectedKeys);
			return cb_selectedKeys;
		}

		static IntPtr n_SelectedKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Nio.Channels.SelectionKey>.ToLocalJniHandle (__this.SelectedKeys ());
		}
#pragma warning restore 0169

		static IntPtr id_selectedKeys;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='selectedKeys' and count(parameter)=0]"
		[Register ("selectedKeys", "()Ljava/util/Set;", "GetSelectedKeysHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Nio.Channels.SelectionKey> SelectedKeys ()
		{
			if (id_selectedKeys == IntPtr.Zero)
				id_selectedKeys = JNIEnv.GetMethodID (class_ref, "selectedKeys", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Java.Nio.Channels.SelectionKey>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_selectedKeys), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Java.Nio.Channels.SelectionKey>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectedKeys", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_wakeupOnce;
#pragma warning disable 0169
		static Delegate GetWakeupOnceHandler ()
		{
			if (cb_wakeupOnce == null)
				cb_wakeupOnce = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WakeupOnce);
			return cb_wakeupOnce;
		}

		static void n_WakeupOnce (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.SelectorWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.SelectorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WakeupOnce ();
		}
#pragma warning restore 0169

		static IntPtr id_wakeupOnce;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async']/class[@name='SelectorWrapper']/method[@name='wakeupOnce' and count(parameter)=0]"
		[Register ("wakeupOnce", "()V", "GetWakeupOnceHandler")]
		public virtual unsafe void WakeupOnce ()
		{
			if (id_wakeupOnce == IntPtr.Zero)
				id_wakeupOnce = JNIEnv.GetMethodID (class_ref, "wakeupOnce", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_wakeupOnce);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wakeupOnce", "()V"));
			} finally {
			}
		}

	}
}
