using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
	Signal1 signal1 = new Signal1();
	Signal2 signal2 = new Signal2() { param = 1 };
	Signal3 signal3 = new Signal3() { param = "Hola" };

	[ContextMenu("Signal1")]
	public void Fire1() => SignalBus<Signal1>.Fire(signal1);

	[ContextMenu("Signal2")]
	public void Fire2() => SignalBus<Signal2>.Fire(signal2);

	[ContextMenu("Signal3")]
	public void Fire3() => SignalBus<Signal3>.Fire(signal3);

}

