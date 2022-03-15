using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class EventConditional : MonoBehaviour
{
	public EventCondition eventCondition = new EventCondition();
	public UnityEvent onTrue, onFalse;

	public bool a;

	[ContextMenu("Check")]
	public bool Check()
	{
		bool result = eventCondition.Check;
		Debug.Log("Event condition result is " + result);
		(result ? onTrue : onFalse)?.Invoke();
		return result;
	}
}

public enum EventConditionType { Value, NotValue, And, Or, True, False }

[Serializable]
public class BoolCondition : SerializableCallback<bool> { }

[Serializable]
public class EventCondition
{
	public EventConditionType type;
	[Tooltip("Used for types 'And' and 'Or'")]
	public List<EventCondition> subConditions = new List<EventCondition>();
	[Tooltip("Used for types 'Value' and 'NotValue'")]
	public BoolCondition value;

	public EventCondition() => type = EventConditionType.True;

	public bool Check => type switch
	{
		EventConditionType.Value => value.Invoke(),
		EventConditionType.NotValue => !value.Invoke(),
		EventConditionType.And => subConditions.Count > 0 && subConditions.All(x => x.Check),
		EventConditionType.Or => subConditions.Any(x => x.Check),
		EventConditionType.True => true,
		EventConditionType.False => false,
		_ => false,
	};
}
