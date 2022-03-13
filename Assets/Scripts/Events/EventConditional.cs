using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class EventConditional : MonoBehaviour
{
	public Condition condition = new Condition();
	public UnityEvent onTrue, onFalse;

	public void DoCheck() => Check();
	public bool Check()
	{
		bool result = condition.Check;
		Debug.Log("Event condition result is " + result);
		(result ? onTrue : onFalse)?.Invoke();
		return result;
	}
}

public enum ConditionType { Value, NotValue, And, Or, True, False }

public class Condition
{
	public ConditionType type;
	[Tooltip("Used for types 'And' and 'Or'")]
	public List<Condition> subConditions = new List<Condition>();
	[Tooltip("Used for types 'Value' and 'NotValue'")]
	public Func<bool> value;

	public Condition() => type = ConditionType.True;

	public bool Check => type switch
	{
		ConditionType.Value => value.Invoke(),
		ConditionType.NotValue => !value.Invoke(),
		ConditionType.And => subConditions.Count > 0 && subConditions.All(x => x.Check),
		ConditionType.Or => subConditions.Any(x => x.Check),
		ConditionType.True => true,
		ConditionType.False => false,
		_ => false,
	};
}