using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Koushikdutta.Async.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.GetSocketData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareGetSocketData : global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData {


		static IntPtr connectCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.GetSocketData']/field[@name='connectCallback']"
		[Register ("connectCallback")]
		public global::Com.Koushikdutta.Async.Callback.IConnectCallback ConnectCallback {
			get {
				if (connectCallback_jfieldId == IntPtr.Zero)
					connectCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "connectCallback", "Lcom/koushikdutta/async/callback/ConnectCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, connectCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.IConnectCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (connectCallback_jfieldId == IntPtr.Zero)
					connectCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "connectCallback", "Lcom/koushikdutta/async/callback/ConnectCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, connectCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr protocol_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.GetSocketData']/field[@name='protocol']"
		[Register ("protocol")]
		public string Protocol {
			get {
				if (protocol_jfieldId == IntPtr.Zero)
					protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, protocol_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (protocol_jfieldId == IntPtr.Zero)
					protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, protocol_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr socketCancellable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.GetSocketData']/field[@name='socketCancellable']"
		[Register ("socketCancellable")]
		public global::Com.Koushikdutta.Async.Future.ICancellable SocketCancellable {
			get {
				if (socketCancellable_jfieldId == IntPtr.Zero)
					socketCancellable_jfieldId = JNIEnv.GetFieldID (class_ref, "socketCancellable", "Lcom/koushikdutta/async/future/Cancellable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, socketCancellable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (socketCancellable_jfieldId == IntPtr.Zero)
					socketCancellable_jfieldId = JNIEnv.GetFieldID (class_ref, "socketCancellable", "Lcom/koushikdutta/async/future/Cancellable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, socketCancellable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareGetSocketData); }
		}

		protected AsyncHttpClientMiddlewareGetSocketData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.GetSocketData']/constructor[@name='AsyncHttpClientMiddleware.GetSocketData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareGetSocketData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareGetSocketData)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnBodyDataOnRequestSentData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData : global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData {


		static IntPtr bodyEmitter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnBodyDataOnRequestSentData']/field[@name='bodyEmitter']"
		[Register ("bodyEmitter")]
		public global::Com.Koushikdutta.Async.IDataEmitter BodyEmitter {
			get {
				if (bodyEmitter_jfieldId == IntPtr.Zero)
					bodyEmitter_jfieldId = JNIEnv.GetFieldID (class_ref, "bodyEmitter", "Lcom/koushikdutta/async/DataEmitter;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, bodyEmitter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bodyEmitter_jfieldId == IntPtr.Zero)
					bodyEmitter_jfieldId = JNIEnv.GetFieldID (class_ref, "bodyEmitter", "Lcom/koushikdutta/async/DataEmitter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, bodyEmitter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData); }
		}

		protected AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnBodyDataOnRequestSentData']/constructor[@name='AsyncHttpClientMiddleware.OnBodyDataOnRequestSentData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareOnExchangeHeaderData : global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData {


		static IntPtr receiveHeadersCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData']/field[@name='receiveHeadersCallback']"
		[Register ("receiveHeadersCallback")]
		public global::Com.Koushikdutta.Async.Callback.ICompletedCallback ReceiveHeadersCallback {
			get {
				if (receiveHeadersCallback_jfieldId == IntPtr.Zero)
					receiveHeadersCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveHeadersCallback", "Lcom/koushikdutta/async/callback/CompletedCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, receiveHeadersCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (receiveHeadersCallback_jfieldId == IntPtr.Zero)
					receiveHeadersCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "receiveHeadersCallback", "Lcom/koushikdutta/async/callback/CompletedCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, receiveHeadersCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr response_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData']/field[@name='response']"
		[Register ("response")]
		public global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Response {
			get {
				if (response_jfieldId == IntPtr.Zero)
					response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, response_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (response_jfieldId == IntPtr.Zero)
					response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, response_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sendHeadersCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData']/field[@name='sendHeadersCallback']"
		[Register ("sendHeadersCallback")]
		public global::Com.Koushikdutta.Async.Callback.ICompletedCallback SendHeadersCallback {
			get {
				if (sendHeadersCallback_jfieldId == IntPtr.Zero)
					sendHeadersCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "sendHeadersCallback", "Lcom/koushikdutta/async/callback/CompletedCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sendHeadersCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Callback.ICompletedCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sendHeadersCallback_jfieldId == IntPtr.Zero)
					sendHeadersCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "sendHeadersCallback", "Lcom/koushikdutta/async/callback/CompletedCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, sendHeadersCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr socket_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData']/field[@name='socket']"
		[Register ("socket")]
		public global::Com.Koushikdutta.Async.IAsyncSocket Socket {
			get {
				if (socket_jfieldId == IntPtr.Zero)
					socket_jfieldId = JNIEnv.GetFieldID (class_ref, "socket", "Lcom/koushikdutta/async/AsyncSocket;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, socket_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (socket_jfieldId == IntPtr.Zero)
					socket_jfieldId = JNIEnv.GetFieldID (class_ref, "socket", "Lcom/koushikdutta/async/AsyncSocket;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, socket_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareOnExchangeHeaderData); }
		}

		protected AsyncHttpClientMiddlewareOnExchangeHeaderData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData']/constructor[@name='AsyncHttpClientMiddleware.OnExchangeHeaderData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareOnExchangeHeaderData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareOnExchangeHeaderData)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnHeadersReceivedDataOnRequestSentData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData : global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData); }
		}

		protected AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnHeadersReceivedDataOnRequestSentData']/constructor[@name='AsyncHttpClientMiddleware.OnHeadersReceivedDataOnRequestSentData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnRequestData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareOnRequestData : global::Java.Lang.Object {


		static IntPtr request_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnRequestData']/field[@name='request']"
		[Register ("request")]
		public global::Com.Koushikdutta.Async.Http.AsyncHttpRequest Request {
			get {
				if (request_jfieldId == IntPtr.Zero)
					request_jfieldId = JNIEnv.GetFieldID (class_ref, "request", "Lcom/koushikdutta/async/http/AsyncHttpRequest;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, request_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpRequest> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (request_jfieldId == IntPtr.Zero)
					request_jfieldId = JNIEnv.GetFieldID (class_ref, "request", "Lcom/koushikdutta/async/http/AsyncHttpRequest;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, request_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareOnRequestData); }
		}

		protected AsyncHttpClientMiddlewareOnRequestData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnRequestData']/constructor[@name='AsyncHttpClientMiddleware.OnRequestData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareOnRequestData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareOnRequestData)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnRequestSentData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareOnRequestSentData : global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareOnRequestSentData); }
		}

		protected AsyncHttpClientMiddlewareOnRequestSentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnRequestSentData']/constructor[@name='AsyncHttpClientMiddleware.OnRequestSentData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareOnRequestSentData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareOnRequestSentData)) {
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnResponseCompleteDataOnRequestSentData']"
	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData : global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData {


		static IntPtr exception_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnResponseCompleteDataOnRequestSentData']/field[@name='exception']"
		[Register ("exception")]
		public global::Java.Lang.Exception Exception {
			get {
				if (exception_jfieldId == IntPtr.Zero)
					exception_jfieldId = JNIEnv.GetFieldID (class_ref, "exception", "Ljava/lang/Exception;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, exception_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (exception_jfieldId == IntPtr.Zero)
					exception_jfieldId = JNIEnv.GetFieldID (class_ref, "exception", "Ljava/lang/Exception;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, exception_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData); }
		}

		protected AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.koushikdutta.async.http']/class[@name='AsyncHttpClientMiddleware.OnResponseCompleteDataOnRequestSentData']/constructor[@name='AsyncHttpClientMiddleware.OnResponseCompleteDataOnRequestSentData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData)) {
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']"
	[Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead", "", "Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker")]
	public partial interface IAsyncHttpClientMiddlewareResponseHead : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='code' and count(parameter)=0]"
		[Register ("code", "()I", "GetCodeHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		int Code ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='code' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("code", "(I)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;", "GetCode_IHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Code (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='emitter' and count(parameter)=0]"
		[Register ("emitter", "()Lcom/koushikdutta/async/DataEmitter;", "GetEmitterHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.IDataEmitter Emitter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='emitter' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataEmitter']]"
		[Register ("emitter", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;", "GetEmitter_Lcom_koushikdutta_async_DataEmitter_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Emitter (global::Com.Koushikdutta.Async.IDataEmitter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='headers' and count(parameter)=0]"
		[Register ("headers", "()Lcom/koushikdutta/async/http/Headers;", "GetHeadersHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.Headers Headers ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='headers' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.Headers']]"
		[Register ("headers", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;", "GetHeaders_Lcom_koushikdutta_async_http_Headers_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Headers (global::Com.Koushikdutta.Async.Http.Headers p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "GetMessageHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		string Message ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='message' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("message", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;", "GetMessage_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Message (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='protocol' and count(parameter)=0]"
		[Register ("protocol", "()Ljava/lang/String;", "GetProtocolHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		string Protocol ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='protocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("protocol", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;", "GetProtocol_Ljava_lang_String_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Protocol (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='sink' and count(parameter)=0]"
		[Register ("sink", "()Lcom/koushikdutta/async/DataSink;", "GetSinkHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.IDataSink Sink ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='sink' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.DataSink']]"
		[Register ("sink", "(Lcom/koushikdutta/async/DataSink;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;", "GetSink_Lcom_koushikdutta_async_DataSink_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Sink (global::Com.Koushikdutta.Async.IDataSink p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware.ResponseHead']/method[@name='socket' and count(parameter)=0]"
		[Register ("socket", "()Lcom/koushikdutta/async/AsyncSocket;", "GetSocketHandler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHeadInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.IAsyncSocket Socket ();

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead", DoNotGenerateAcw=true)]
	internal class IAsyncHttpClientMiddlewareResponseHeadInvoker : global::Java.Lang.Object, IAsyncHttpClientMiddlewareResponseHead {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead");
		IntPtr class_ref;

		public static IAsyncHttpClientMiddlewareResponseHead GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHttpClientMiddlewareResponseHead> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.AsyncHttpClientMiddleware.ResponseHead"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHttpClientMiddlewareResponseHeadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncHttpClientMiddlewareResponseHeadInvoker); }
		}

		static Delegate cb_code;
#pragma warning disable 0169
		static Delegate GetCodeHandler ()
		{
			if (cb_code == null)
				cb_code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Code);
			return cb_code;
		}

		static int n_Code (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code ();
		}
#pragma warning restore 0169

		IntPtr id_code;
		public unsafe int Code ()
		{
			if (id_code == IntPtr.Zero)
				id_code = JNIEnv.GetMethodID (class_ref, "code", "()I");
			return JNIEnv.CallIntMethod (Handle, id_code);
		}

		static Delegate cb_code_I;
#pragma warning disable 0169
		static Delegate GetCode_IHandler ()
		{
			if (cb_code_I == null)
				cb_code_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Code_I);
			return cb_code_I;
		}

		static IntPtr n_Code_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Code (p0));
		}
#pragma warning restore 0169

		IntPtr id_code_I;
		public unsafe global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Code (int p0)
		{
			if (id_code_I == IntPtr.Zero)
				id_code_I = JNIEnv.GetMethodID (class_ref, "code", "(I)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (JNIEnv.CallObjectMethod (Handle, id_code_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_emitter;
#pragma warning disable 0169
		static Delegate GetEmitterHandler ()
		{
			if (cb_emitter == null)
				cb_emitter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Emitter);
			return cb_emitter;
		}

		static IntPtr n_Emitter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Emitter ());
		}
#pragma warning restore 0169

		IntPtr id_emitter;
		public unsafe global::Com.Koushikdutta.Async.IDataEmitter Emitter ()
		{
			if (id_emitter == IntPtr.Zero)
				id_emitter = JNIEnv.GetMethodID (class_ref, "emitter", "()Lcom/koushikdutta/async/DataEmitter;");
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (JNIEnv.CallObjectMethod (Handle, id_emitter), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_emitter_Lcom_koushikdutta_async_DataEmitter_;
#pragma warning disable 0169
		static Delegate GetEmitter_Lcom_koushikdutta_async_DataEmitter_Handler ()
		{
			if (cb_emitter_Lcom_koushikdutta_async_DataEmitter_ == null)
				cb_emitter_Lcom_koushikdutta_async_DataEmitter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Emitter_Lcom_koushikdutta_async_DataEmitter_);
			return cb_emitter_Lcom_koushikdutta_async_DataEmitter_;
		}

		static IntPtr n_Emitter_Lcom_koushikdutta_async_DataEmitter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataEmitter p0 = (global::Com.Koushikdutta.Async.IDataEmitter)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataEmitter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Emitter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_emitter_Lcom_koushikdutta_async_DataEmitter_;
		public unsafe global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Emitter (global::Com.Koushikdutta.Async.IDataEmitter p0)
		{
			if (id_emitter_Lcom_koushikdutta_async_DataEmitter_ == IntPtr.Zero)
				id_emitter_Lcom_koushikdutta_async_DataEmitter_ = JNIEnv.GetMethodID (class_ref, "emitter", "(Lcom/koushikdutta/async/DataEmitter;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (JNIEnv.CallObjectMethod (Handle, id_emitter_Lcom_koushikdutta_async_DataEmitter_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_headers;
#pragma warning disable 0169
		static Delegate GetHeadersHandler ()
		{
			if (cb_headers == null)
				cb_headers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Headers);
			return cb_headers;
		}

		static IntPtr n_Headers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Headers ());
		}
#pragma warning restore 0169

		IntPtr id_headers;
		public unsafe global::Com.Koushikdutta.Async.Http.Headers Headers ()
		{
			if (id_headers == IntPtr.Zero)
				id_headers = JNIEnv.GetMethodID (class_ref, "headers", "()Lcom/koushikdutta/async/http/Headers;");
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (JNIEnv.CallObjectMethod (Handle, id_headers), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_headers_Lcom_koushikdutta_async_http_Headers_;
#pragma warning disable 0169
		static Delegate GetHeaders_Lcom_koushikdutta_async_http_Headers_Handler ()
		{
			if (cb_headers_Lcom_koushikdutta_async_http_Headers_ == null)
				cb_headers_Lcom_koushikdutta_async_http_Headers_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Headers_Lcom_koushikdutta_async_http_Headers_);
			return cb_headers_Lcom_koushikdutta_async_http_Headers_;
		}

		static IntPtr n_Headers_Lcom_koushikdutta_async_http_Headers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.Headers p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.Headers> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Headers (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_headers_Lcom_koushikdutta_async_http_Headers_;
		public unsafe global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Headers (global::Com.Koushikdutta.Async.Http.Headers p0)
		{
			if (id_headers_Lcom_koushikdutta_async_http_Headers_ == IntPtr.Zero)
				id_headers_Lcom_koushikdutta_async_http_Headers_ = JNIEnv.GetMethodID (class_ref, "headers", "(Lcom/koushikdutta/async/http/Headers;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (JNIEnv.CallObjectMethod (Handle, id_headers_Lcom_koushikdutta_async_http_Headers_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_message;
#pragma warning disable 0169
		static Delegate GetMessageHandler ()
		{
			if (cb_message == null)
				cb_message = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Message);
			return cb_message;
		}

		static IntPtr n_Message (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message ());
		}
#pragma warning restore 0169

		IntPtr id_message;
		public unsafe string Message ()
		{
			if (id_message == IntPtr.Zero)
				id_message = JNIEnv.GetMethodID (class_ref, "message", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_message), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_message_Ljava_lang_String_ == null)
				cb_message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Message_Ljava_lang_String_);
			return cb_message_Ljava_lang_String_;
		}

		static IntPtr n_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Message (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_message_Ljava_lang_String_;
		public unsafe global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Message (string p0)
		{
			if (id_message_Ljava_lang_String_ == IntPtr.Zero)
				id_message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "message", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (JNIEnv.CallObjectMethod (Handle, id_message_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_protocol;
#pragma warning disable 0169
		static Delegate GetProtocolHandler ()
		{
			if (cb_protocol == null)
				cb_protocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Protocol);
			return cb_protocol;
		}

		static IntPtr n_Protocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Protocol ());
		}
#pragma warning restore 0169

		IntPtr id_protocol;
		public unsafe string Protocol ()
		{
			if (id_protocol == IntPtr.Zero)
				id_protocol = JNIEnv.GetMethodID (class_ref, "protocol", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_protocol), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_protocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_protocol_Ljava_lang_String_ == null)
				cb_protocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Protocol_Ljava_lang_String_);
			return cb_protocol_Ljava_lang_String_;
		}

		static IntPtr n_Protocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Protocol (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_protocol_Ljava_lang_String_;
		public unsafe global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Protocol (string p0)
		{
			if (id_protocol_Ljava_lang_String_ == IntPtr.Zero)
				id_protocol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "protocol", "(Ljava/lang/String;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (JNIEnv.CallObjectMethod (Handle, id_protocol_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_sink;
#pragma warning disable 0169
		static Delegate GetSinkHandler ()
		{
			if (cb_sink == null)
				cb_sink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sink);
			return cb_sink;
		}

		static IntPtr n_Sink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sink ());
		}
#pragma warning restore 0169

		IntPtr id_sink;
		public unsafe global::Com.Koushikdutta.Async.IDataSink Sink ()
		{
			if (id_sink == IntPtr.Zero)
				id_sink = JNIEnv.GetMethodID (class_ref, "sink", "()Lcom/koushikdutta/async/DataSink;");
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (JNIEnv.CallObjectMethod (Handle, id_sink), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_sink_Lcom_koushikdutta_async_DataSink_;
#pragma warning disable 0169
		static Delegate GetSink_Lcom_koushikdutta_async_DataSink_Handler ()
		{
			if (cb_sink_Lcom_koushikdutta_async_DataSink_ == null)
				cb_sink_Lcom_koushikdutta_async_DataSink_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sink_Lcom_koushikdutta_async_DataSink_);
			return cb_sink_Lcom_koushikdutta_async_DataSink_;
		}

		static IntPtr n_Sink_Lcom_koushikdutta_async_DataSink_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.IDataSink p0 = (global::Com.Koushikdutta.Async.IDataSink)global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IDataSink> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sink (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sink_Lcom_koushikdutta_async_DataSink_;
		public unsafe global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead Sink (global::Com.Koushikdutta.Async.IDataSink p0)
		{
			if (id_sink_Lcom_koushikdutta_async_DataSink_ == IntPtr.Zero)
				id_sink_Lcom_koushikdutta_async_DataSink_ = JNIEnv.GetMethodID (class_ref, "sink", "(Lcom/koushikdutta/async/DataSink;)Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$ResponseHead;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (JNIEnv.CallObjectMethod (Handle, id_sink_Lcom_koushikdutta_async_DataSink_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_socket;
#pragma warning disable 0169
		static Delegate GetSocketHandler ()
		{
			if (cb_socket == null)
				cb_socket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Socket);
			return cb_socket;
		}

		static IntPtr n_Socket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareResponseHead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket ());
		}
#pragma warning restore 0169

		IntPtr id_socket;
		public unsafe global::Com.Koushikdutta.Async.IAsyncSocket Socket ()
		{
			if (id_socket == IntPtr.Zero)
				id_socket = JNIEnv.GetMethodID (class_ref, "socket", "()Lcom/koushikdutta/async/AsyncSocket;");
			return global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.IAsyncSocket> (JNIEnv.CallObjectMethod (Handle, id_socket), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']"
	[Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware", "", "Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker")]
	public partial interface IAsyncHttpClientMiddleware : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='exchangeHeaders' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnExchangeHeaderData']]"
		[Register ("exchangeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData;)Z", "GetExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		bool ExchangeHeaders (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='getSocket' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.GetSocketData']]"
		[Register ("getSocket", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;)Lcom/koushikdutta/async/future/Cancellable;", "GetGetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		global::Com.Koushikdutta.Async.Future.ICancellable GetSocket (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='onBodyDecoder' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnBodyDataOnRequestSentData']]"
		[Register ("onBodyDecoder", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData;)V", "GetOnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		void OnBodyDecoder (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='onHeadersReceived' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnHeadersReceivedDataOnRequestSentData']]"
		[Register ("onHeadersReceived", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData;)V", "GetOnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		void OnHeadersReceived (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='onRequest' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnRequestData']]"
		[Register ("onRequest", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData;)V", "GetOnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		void OnRequest (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='onRequestSent' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnRequestSentData']]"
		[Register ("onRequestSent", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData;)V", "GetOnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		void OnRequestSent (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.koushikdutta.async.http']/interface[@name='AsyncHttpClientMiddleware']/method[@name='onResponseComplete' and count(parameter)=1 and parameter[1][@type='com.koushikdutta.async.http.AsyncHttpClientMiddleware.OnResponseCompleteDataOnRequestSentData']]"
		[Register ("onResponseComplete", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData;)V", "GetOnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_Handler:Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddlewareInvoker, AndroidAsyncBinding")]
		void OnResponseComplete (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData p0);

	}

	[global::Android.Runtime.Register ("com/koushikdutta/async/http/AsyncHttpClientMiddleware", DoNotGenerateAcw=true)]
	internal class IAsyncHttpClientMiddlewareInvoker : global::Java.Lang.Object, IAsyncHttpClientMiddleware {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/koushikdutta/async/http/AsyncHttpClientMiddleware");
		IntPtr class_ref;

		public static IAsyncHttpClientMiddleware GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHttpClientMiddleware> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.koushikdutta.async.http.AsyncHttpClientMiddleware"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHttpClientMiddlewareInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAsyncHttpClientMiddlewareInvoker); }
		}

		static Delegate cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_;
#pragma warning disable 0169
		static Delegate GetExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_Handler ()
		{
			if (cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ == null)
				cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_);
			return cb_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_;
		}

		static bool n_ExchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExchangeHeaders (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_;
		public unsafe bool ExchangeHeaders (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData p0)
		{
			if (id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ == IntPtr.Zero)
				id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_ = JNIEnv.GetMethodID (class_ref, "exchangeHeaders", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_exchangeHeaders_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnExchangeHeaderData_, __args);
			return __ret;
		}

		static Delegate cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_;
#pragma warning disable 0169
		static Delegate GetGetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_Handler ()
		{
			if (cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ == null)
				cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_);
			return cb_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_;
		}

		static IntPtr n_GetSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSocket (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_;
		public unsafe global::Com.Koushikdutta.Async.Future.ICancellable GetSocket (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData p0)
		{
			if (id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ == IntPtr.Zero)
				id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_ = JNIEnv.GetMethodID (class_ref, "getSocket", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData;)Lcom/koushikdutta/async/future/Cancellable;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Koushikdutta.Async.Future.ICancellable __ret = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Future.ICancellable> (JNIEnv.CallObjectMethod (Handle, id_getSocket_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_GetSocketData_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_Handler ()
		{
			if (cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ == null)
				cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_);
			return cb_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_;
		}

		static void n_OnBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBodyDecoder (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_;
		public unsafe void OnBodyDecoder (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData p0)
		{
			if (id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ == IntPtr.Zero)
				id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onBodyDecoder", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onBodyDecoder_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnBodyDataOnRequestSentData_, __args);
		}

		static Delegate cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_Handler ()
		{
			if (cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ == null)
				cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_);
			return cb_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_;
		}

		static void n_OnHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHeadersReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_;
		public unsafe void OnHeadersReceived (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData p0)
		{
			if (id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ == IntPtr.Zero)
				id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onHeadersReceived", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onHeadersReceived_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnHeadersReceivedDataOnRequestSentData_, __args);
		}

		static Delegate cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_;
#pragma warning disable 0169
		static Delegate GetOnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_Handler ()
		{
			if (cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ == null)
				cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_);
			return cb_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_;
		}

		static void n_OnRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequest (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_;
		public unsafe void OnRequest (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData p0)
		{
			if (id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ == IntPtr.Zero)
				id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_ = JNIEnv.GetMethodID (class_ref, "onRequest", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRequest_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestData_, __args);
		}

		static Delegate cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_Handler ()
		{
			if (cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ == null)
				cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_);
			return cb_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_;
		}

		static void n_OnRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestSent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_;
		public unsafe void OnRequestSent (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData p0)
		{
			if (id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ == IntPtr.Zero)
				id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onRequestSent", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onRequestSent_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnRequestSentData_, __args);
		}

		static Delegate cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_;
#pragma warning disable 0169
		static Delegate GetOnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_Handler ()
		{
			if (cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ == null)
				cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_);
			return cb_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_;
		}

		static void n_OnResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware __this = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.IAsyncHttpClientMiddleware> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData p0 = global::Java.Lang.Object.GetObject<global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponseComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_;
		public unsafe void OnResponseComplete (global::Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData p0)
		{
			if (id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ == IntPtr.Zero)
				id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_ = JNIEnv.GetMethodID (class_ref, "onResponseComplete", "(Lcom/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onResponseComplete_Lcom_koushikdutta_async_http_AsyncHttpClientMiddleware_OnResponseCompleteDataOnRequestSentData_, __args);
		}

	}

}
