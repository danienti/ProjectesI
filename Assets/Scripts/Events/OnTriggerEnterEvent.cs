using UnityEngine;
using UnityEngine.Events;
public class OnTriggerEnterEvent : MonoBehaviour
{
	[SerializeField] string targetTag;
	[SerializeField] LayerMask layerMask = ~0;
	public UnityEvent onTriggerEnter;
	public UnityEvent<Collider> onTriggerEnterWithCollider;

	public bool oneShot;
	public bool skipEvents;

	private void OnTriggerEnter(Collider other)
	{
		if (skipEvents) return;

		if ((targetTag == string.Empty || other.CompareTag(targetTag)) && HasLayer(layerMask, other.gameObject.layer))
		{
			if (oneShot)
				skipEvents = true;

			onTriggerEnter?.Invoke();
			onTriggerEnterWithCollider?.Invoke(other);
		}
	}

	public static bool HasLayer(LayerMask layerMask, int layer)
	{
		return layerMask == (layerMask | (1 << layer));
	}
}
