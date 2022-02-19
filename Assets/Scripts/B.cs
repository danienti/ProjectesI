using UnityEngine;

public class B : MonoBehaviour
{
	private void Awake()
	{
		SignalBus<Signal1>.Subscribe(ReceiveSignal1);
		SignalBus<Signal2>.Subscribe(ReceiveSignal2);
		SignalBus<Signal3>.Subscribe(ReceiveSignal3);
		SignalBus<ISignalA>.Subscribe(ReceiveInterfaceA);
	}

	public void ReceiveSignal1(Signal1 a) => Debug.Log("Recibida señal 1");
	public void ReceiveSignal2(Signal2 a) => Debug.Log($"Recibida señal 2 con param {a.param}");
	public void ReceiveSignal3(Signal3 a) => Debug.Log($"Recibida señal 3 con param {a.param}");
	public void ReceiveInterfaceA(ISignalA a) => Debug.Log($"Recibida interfaz A con param {a.interfaceParam}");

	void Subscribe()
	{

	}

	void Unsubscribe()
	{

	}
}
