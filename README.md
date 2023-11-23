# MinAsyncBridge

Miminum set of the async/await portability libraries, as well as ValueTuple and MVVM.
Forked from https://github.com/OrangeCube/MinimumAsyncBridge and attempts to provide .NET Framework 2.0, 3.0, and 4.0 support.

## Usage

NuGet packages:

- [MinThreadingBridge](https://www.nuget.org/packages/MinThreadingBridge/)
  - contains: `CancellationToken`, `IProgress<T>`, ...
- [MinAsyncBridge](https://www.nuget.org/packages/MinAsyncBridge/)
  - contains: `Task`, `Task<TResult>`, `TaskCompletionSource<TResult>`, `TaskAwaiter`, ...
- [MinMvvmBridge](https://www.nuget.org/packages/MinMvvmBridge/)
  - contains: `INotifyCollectionChanged`, `ObservableCollection<T>`, `CallerMemberNameAttribute`, ...
- [MinValueTupleBridge](https://www.nuget.org/packages/MinValueTupleBridge/)
  - contains: `ValueTuple`, `ValueTuple<>`, ...
- [MinTasksExtensionsBridge](https://www.nuget.org/packages/MinTasksExtensionsBridge/)
  - contains: `ValueTask`, `ValueTaskAwaiter`, ...

These packages provide:

- Back-porting implementation for .NET Framework 2.0, 3.0, 3.5, 4.0
- Type forwarding for .NET 4.5 or later

## Known problem

The debuggability of the `Task` in the MinAsyncBridge is poorer than original `Task`.
Stack trace information is lost because the back-port does not have `System.Runtime.ExceptionServices.ExceptionDispatchInfo`,
which is impossible without runtime support.
