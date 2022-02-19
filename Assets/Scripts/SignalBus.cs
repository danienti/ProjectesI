using System;

public static class SignalBus<T>
{
	public static Action<T> subscriptions;
	public static void Subscribe(Action<T> action) => subscriptions += action;
	public static void Unsubscribe(Action<T> action) => subscriptions -= action;
	public static void Fire(T signal) => subscriptions.Invoke(signal);
	public static void Dispose() => subscriptions = null;
}
