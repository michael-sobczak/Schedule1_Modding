using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace S1API.Internal.Abstraction;

public static class EventHelper
{
	internal static readonly Dictionary<Action, Delegate> SubscribedActions = new Dictionary<Action, Delegate>();

	private static readonly Dictionary<Delegate, Delegate> SubscribedGenericActions = new Dictionary<Delegate, Delegate>();

	internal static void AddListener(Action listener, Action<Action> subscribe)
	{
		if (!SubscribedActions.ContainsKey(listener))
		{
			subscribe(listener);
			SubscribedActions.Add(listener, listener);
		}
	}

	internal static void RemoveListener(Action listener, Action<Action> unsubscribe)
	{
		if (SubscribedActions.TryGetValue(listener, out Delegate _))
		{
			unsubscribe(listener);
			SubscribedActions.Remove(listener);
		}
	}

	public static void AddListener(Action listener, UnityEvent unityEvent)
	{
		if (!SubscribedActions.ContainsKey(listener))
		{
			Action action = listener.Invoke;
			unityEvent.AddListener(UnityAction.op_Implicit(action));
			SubscribedActions.Add(listener, action);
		}
	}

	public static void AddEventTrigger(EventTrigger trigger, EventTriggerType eventType, Action listener)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)trigger == (Object)null) && listener != null)
		{
			AddEventTrigger(trigger, eventType, (Action<BaseEventData>)delegate
			{
				listener();
			});
		}
	}

	public static void AddEventTrigger(EventTrigger trigger, EventTriggerType eventType, Action<BaseEventData> listener)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (!((Object)(object)trigger == (Object)null) && listener != null)
		{
			Entry val = new Entry
			{
				eventID = eventType
			};
			AddListener(listener, (UnityEvent<BaseEventData>)(object)val.callback);
			trigger.triggers.Add(val);
		}
	}

	public static void RemoveListener(Action listener, UnityEvent unityEvent)
	{
		SubscribedActions.TryGetValue(listener, out Delegate value);
		SubscribedActions.Remove(listener);
		if ((object)value != null && value is Action action)
		{
			unityEvent.RemoveListener(UnityAction.op_Implicit(action));
		}
	}

	public static void AddListener<T>(Action<T> listener, UnityEvent<T> unityEvent)
	{
		if (listener != null && unityEvent != null && !SubscribedGenericActions.ContainsKey(listener))
		{
			Action<T> action = listener.Invoke;
			unityEvent.AddListener(UnityAction<T>.op_Implicit(action));
			SubscribedGenericActions.Add(listener, action);
		}
	}

	public static void RemoveListener<T>(Action<T> listener, UnityEvent<T> unityEvent)
	{
		if (listener != null && unityEvent != null && SubscribedGenericActions.TryGetValue(listener, out Delegate value))
		{
			if (value is Action<T> action)
			{
				unityEvent.RemoveListener(UnityAction<T>.op_Implicit(action));
			}
			SubscribedGenericActions.Remove(listener);
		}
	}
}
