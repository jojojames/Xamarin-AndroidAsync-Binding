using System;
using System.Collections.Generic;
using System.Diagnostics;
using Com.Koushikdutta.Async.Http;
using Com.Koushikdutta.Async.Callback;

namespace Emdroid {
	public class AndroidAsyncWebsocketConnection : WebsocketConnection {
		private static readonly string TAG = "E.h.AndroidAsyncWebsocketConnection" + " : ";

		private string WebSocketAddress { get; set; } = string.Empty;
		private List<KeyValuePair<string, string>> Headers { get; set; }
		private object Lock { get; set; } = new object ();

		private IWebSocket zz;
		protected IWebSocket Socket { 
			get { return zz; }
			set {
				if (zz != null) {
					RemoveCallbacksOnSocket (zz);
				}

				zz = value;
				zz.ClosedCallback = CloseCallbackImpl.From (this);
				zz.StringCallback = StringCallbackImpl.From (this);
				zz.PongCallback = PongCallbackImpl.From (this);
			}
		}

		public AndroidAsyncWebsocketConnection (string webSocketAddress, 
			List<KeyValuePair<string, string>> headers) {
			this.WebSocketAddress = webSocketAddress;
			this.Headers = headers;
		}

		public override void Connect () {
			lock (this.Lock) {
				try {
					// Workaround
					// https://github.com/koush/AndroidAsync/issues/340
					this.WebSocketAddress = this.WebSocketAddress.Replace ("wss", "https");
					AsyncHttpGet g = new AsyncHttpGet (this.WebSocketAddress);
					foreach (KeyValuePair<string, string> pair in this.Headers) {
						g.AddHeader (pair.Key, pair.Value);
					}

					AsyncHttpClient.DefaultInstance.Websocket (g, null, ConnectCallbackImpl.From (this));

				} catch (Exception e) {
					Debug.WriteLine (TAG + "cannot do connect operation {0}", e);
				}
			}
		}

		public override void Disconnect () {
			lock (this.Lock) {
				try {
					Dispose ();
				} catch (Exception e) {
					Debug.WriteLine (TAG + "cannot do disconnect operation {0}", e);
				}
			}
		}

		public override void Send (string message) {
			try {
				this.Socket.Send (message);
			} catch (Exception e) {
				Debug.WriteLine (TAG + "{0}", e);
			}
		}

		public override void Dispose () {
			try {
				IWebSocket socket = this.Socket;
				if (socket != null) {
					RemoveCallbacksOnSocket (socket);
					socket.Close ();
				}

				Debug.WriteLine (TAG + "disposed");
			} catch (Exception e) {
				Debug.WriteLine (TAG + "{0}", e);
			}
		}

		public void WebSocketOpened () {
			BroadcastSocketOpened ();
		}

		private void WebsocketError (Java.Lang.Exception p0) {
			if (p0 != null) {
				Debug.WriteLine (TAG + " WebsocketError " + p0);
			}
		}

		private void WebsocketMessageReceived (string message) {
			BroadcastMessageReceived (message);
		}

		private void RemoveCallbacksOnSocket (IWebSocket socket) {
			if (socket != null) {
				socket.ClosedCallback = null;
				socket.StringCallback = null;
				socket.PongCallback = null;
			}
		}

		private class PongCallbackImpl : Java.Lang.Object, IWebSocketPongCallback {
			AndroidAsyncWebsocketConnection This { get; set; }

			public static PongCallbackImpl From (AndroidAsyncWebsocketConnection connection) {
				PongCallbackImpl self = new PongCallbackImpl ();
				self.This = connection;
				return self;
			}

			public void OnPongReceived (string p0) {
				Debug.WriteLine ("AndroidAsyncWebsocketConnection : PongReceived " + p0);
			}
		}

		private class StringCallbackImpl : Java.Lang.Object, IWebSocketStringCallback {
			AndroidAsyncWebsocketConnection This { get; set; }

			public static StringCallbackImpl From (AndroidAsyncWebsocketConnection connection) {
				StringCallbackImpl self = new StringCallbackImpl ();
				self.This = connection;
				return self;
			}

			public void OnStringAvailable (string p0) {
				this.This.WebsocketMessageReceived (p0);
			}
		}

		private class CloseCallbackImpl : Java.Lang.Object, ICompletedCallback {
			AndroidAsyncWebsocketConnection This { get; set; }
			public static CloseCallbackImpl From (AndroidAsyncWebsocketConnection connection) {
				CloseCallbackImpl self = new CloseCallbackImpl ();
				self.This = connection;
				return self;
			}

			public void OnCompleted (Java.Lang.Exception p0) {
				this.This.WebsocketError (p0);
			}
		}

		private class ConnectCallbackImpl : Java.Lang.Object, AsyncHttpClient.IWebSocketConnectCallback {
			AndroidAsyncWebsocketConnection This { get; set; }

			public static ConnectCallbackImpl From (AndroidAsyncWebsocketConnection connection) {
				ConnectCallbackImpl self = new ConnectCallbackImpl ();
				self.This = connection;
				return self;
			}

			public void OnCompleted (Java.Lang.Exception p0, IWebSocket p1) {
				if (p0 == null) {
					this.This.Socket = p1;
					this.This.WebSocketOpened ();
				} else {
					this.This.WebsocketError (p0);
				}
			}
		}

	}
}
