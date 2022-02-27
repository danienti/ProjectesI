using System;

public static class SignalBus<T>
{
	public static Action<T> action;
	public static void Subscribe(Action<T> action) => SignalBus<T>.action += action;
	public static void Unsubscribe(Action<T> action) => SignalBus<T>.action -= action;
	public static void Fire(T signal) => action.Invoke(signal);
	public static void Dispose() => action = null;
}
