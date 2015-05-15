using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/koushikdutta/async/callback",
						"com/koushikdutta/async/http",
					},
					new Converter<string, Type>[]{
						lookup_com_koushikdutta_async_callback_package,
						lookup_com_koushikdutta_async_http_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_koushikdutta_async_callback_mappings;
		static Type lookup_com_koushikdutta_async_callback_package (string klass)
		{
			if (package_com_koushikdutta_async_callback_mappings == null) {
				package_com_koushikdutta_async_callback_mappings = new string[]{
					"com/koushikdutta/async/callback/CompletedCallback$NullCompletedCallback:Com.Koushikdutta.Async.Callback.CompletedCallbackNullCompletedCallback",
					"com/koushikdutta/async/callback/DataCallback$NullDataCallback:Com.Koushikdutta.Async.Callback.DataCallbackNullDataCallback",
				};
			}

			return Lookup (package_com_koushikdutta_async_callback_mappings, klass);
		}

		static string[] package_com_koushikdutta_async_http_mappings;
		static Type lookup_com_koushikdutta_async_http_package (string klass)
		{
			if (package_com_koushikdutta_async_http_mappings == null) {
				package_com_koushikdutta_async_http_mappings = new string[]{
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$GetSocketData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareGetSocketData",
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnBodyDataOnRequestSentData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnBodyDataOnRequestSentData",
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnExchangeHeaderData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnExchangeHeaderData",
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnHeadersReceivedDataOnRequestSentData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnHeadersReceivedDataOnRequestSentData",
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestData",
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnRequestSentData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnRequestSentData",
					"com/koushikdutta/async/http/AsyncHttpClientMiddleware$OnResponseCompleteDataOnRequestSentData:Com.Koushikdutta.Async.Http.AsyncHttpClientMiddlewareOnResponseCompleteDataOnRequestSentData",
				};
			}

			return Lookup (package_com_koushikdutta_async_http_mappings, klass);
		}
	}
}
