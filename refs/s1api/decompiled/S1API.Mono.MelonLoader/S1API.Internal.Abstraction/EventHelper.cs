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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (!SubscribedActions.ContainsKey(listener))
		{
			UnityAction val = new UnityAction(listener.Invoke);
			unityEvent.AddListener(val);
			SubscribedActions.Add(listener, (Delegate)(object)val);
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
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
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
		if ((object)value != null)
		{
			UnityAction val = (UnityAction)(object)((value is UnityAction) ? value : null);
			if (val != null)
			{
				unityEvent.RemoveListener(val);
			}
		}
	}

	public static void AddListener<T>(Action<T> listener, UnityEvent<T> unityEvent)
	{
		if (listener != null && unityEvent != null && !SubscribedGenericActions.ContainsKey(listener))
		{
			UnityAction<T> val = listener.Invoke;
			unityEvent.AddListener(val);
			SubscribedGenericActions.Add(listener, (Delegate)(object)val);
		}
	}

	public static void RemoveListener<T>(Action<T> listener, UnityEvent<T> unityEvent)
	{
		if (listener != null && unityEvent != null && SubscribedGenericActions.TryGetValue(listener, out Delegate value))
		{
			if (value is UnityAction<T> val)
			{
				unityEvent.RemoveListener(val);
			}
			SubscribedGenericActions.Remove(listener);
		}
	}
}
