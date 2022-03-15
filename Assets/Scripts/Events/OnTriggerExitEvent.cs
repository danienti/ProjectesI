using UnityEngine;
using UnityEngine.Events;
public class OnTriggerExitEvent : MonoBehaviour
{
	[SerializeField] string targetTag;
	[SerializeField] LayerMask layerMask = ~0;
	public UnityEvent onTriggerExit;
	public UnityEvent<Collider> onTriggerExitWithCollider;

	public bool oneShot;
	public bool skipEvents;

	private void OnTriggerExit(Collider other)
	{
		if (skipEvents) return;

		if ((targetTag == string.Empty || other.CompareTag(targetTag)) && HasLayer(layerMask, other.gameObject.layer))
		{
			if (oneShot)
				skipEvents = true;

			onTriggerExit?.Invoke();
			onTriggerExitWithCollider?.Invoke(other);
		}
	}

	public static bool HasLayer(LayerMask layerMask, int layer)
	{
		return layerMask == (layerMask | (1 << layer));
	}
}
