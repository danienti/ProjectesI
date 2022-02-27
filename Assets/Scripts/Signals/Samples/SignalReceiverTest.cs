using UnityEngine;

public class SignalReceiverTest : MonoBehaviour
{
	private void Awake()
	{
		SignalBus<Signal1>.Subscribe(ReceiveSignal1);
		SignalBus<Signal2>.Subscribe(ReceiveSignal2);
	}

	public void ReceiveSignal1(Signal1 a) => Debug.Log("Recibida se�al 1");
	public void ReceiveSignal2(Signal2 a) => Debug.Log($"Recibida se�al 2 con param {a.param}");
}
