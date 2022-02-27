using UnityEngine;

public class SignalSenderTest : MonoBehaviour
{
	Signal1 signal1 = new Signal1();
	Signal2 signal2 = new Signal2() { param = 1 };

	[ContextMenu("Signal1")]
	public void Fire1() => SignalBus<Signal1>.Fire(signal1);

	[ContextMenu("Signal2")]
	public void Fire2() => SignalBus<Signal2>.Fire(signal2);
}

