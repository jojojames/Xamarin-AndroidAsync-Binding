using System;

namespace Com.Koushikdutta.Async.Future {

    public partial interface IFuture {
        new bool IsCancelled { get; }
        new bool IsDone { get; }
    }
}

