using System;
using System.Collections.Generic;
using System.Reflection;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Cartel;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using UnityEngine;

namespace S1API.Cartel;

public sealed class Cartel
{
	private class EventWrapper
	{
		private readonly Action<CartelStatus, CartelStatus> _handler;

		public EventWrapper(Action<CartelStatus, CartelStatus> handler)
		{
			_handler = handler;
		}

		public void Handle(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			_handler?.Invoke(ConvertStatus(oldStatus), ConvertStatus(newStatus));
		}

		private static CartelStatus ConvertStatus(object status)
		{
			if (status == null)
			{
				return CartelStatus.Unknown;
			}
			int num = (int)status;
			if (1 == 0)
			{
			}
			CartelStatus result = num switch
			{
				0 => CartelStatus.Unknown, 
				1 => CartelStatus.Truced, 
				2 => CartelStatus.Hostile, 
				3 => CartelStatus.Defeated, 
				_ => CartelStatus.Unknown, 
			};
			if (1 == 0)
			{
			}
			return result;
		}
	}

	private static Cartel? _cachedInstance;

	private static Cartel? _lastS1Cartel;

	private static readonly Dictionary<Action<CartelStatus, CartelStatus>, Delegate> _eventDelegates = new Dictionary<Action<CartelStatus, CartelStatus>, Delegate>();

	internal readonly Cartel S1Cartel;

	public static Cartel? Instance
	{
		get
		{
			Cartel instance = NetworkSingleton<Cartel>.Instance;
			if ((Object)(object)instance == (Object)null)
			{
				_cachedInstance = null;
				_lastS1Cartel = null;
				return null;
			}
			if (_cachedInstance != null && (Object)(object)_lastS1Cartel == (Object)(object)instance)
			{
				return _cachedInstance;
			}
			_cachedInstance = new Cartel(instance);
			_lastS1Cartel = instance;
			return _cachedInstance;
		}
	}

	public CartelStatus Status => ConvertStatus(S1Cartel.Status);

	public int HoursSinceStatusChange => S1Cartel.HoursSinceStatusChange;

	public GoonManager? GoonPool
	{
		get
		{
			GoonPool goonPool = S1Cartel.GoonPool;
			if ((Object)(object)goonPool == (Object)null)
			{
				return null;
			}
			return new GoonManager(goonPool);
		}
	}

	public CartelInfluence? Influence
	{
		get
		{
			CartelInfluence influence = S1Cartel.Influence;
			if ((Object)(object)influence == (Object)null)
			{
				return null;
			}
			return new CartelInfluence(influence);
		}
	}

	public event Action<CartelStatus, CartelStatus> OnStatusChange
	{
		add
		{
			if (value != null)
			{
				EventInfo eventInfo = typeof(Cartel).GetEvent("OnStatusChange", BindingFlags.Instance | BindingFlags.Public);
				if (!(eventInfo == null))
				{
					Type typeFromHandle = typeof(ECartelStatus);
					Type type = typeof(Action<, >).MakeGenericType(typeFromHandle, typeFromHandle);
					EventWrapper firstArgument = new EventWrapper(value);
					MethodInfo method = typeof(EventWrapper).GetMethod("Handle", BindingFlags.Instance | BindingFlags.Public);
					Delegate obj = Delegate.CreateDelegate(type, firstArgument, method);
					Type type2 = typeof(Action<, >).MakeGenericType(typeFromHandle, typeFromHandle);
					MethodInfo method2 = typeof(DelegateSupport).GetMethod("ConvertDelegate", BindingFlags.Static | BindingFlags.Public);
					MethodInfo methodInfo = method2.MakeGenericMethod(type2);
					object obj2 = methodInfo.Invoke(null, new object[1] { obj });
					eventInfo.GetAddMethod()?.Invoke(S1Cartel, new object[1] { obj2 });
					_eventDelegates[value] = obj2 as Delegate;
				}
			}
		}
		remove
		{
			if (value != null && _eventDelegates.TryGetValue(value, out Delegate value2))
			{
				EventInfo eventInfo = typeof(Cartel).GetEvent("OnStatusChange", BindingFlags.Instance | BindingFlags.Public);
				if (eventInfo != null)
				{
					eventInfo.GetRemoveMethod()?.Invoke(S1Cartel, new object[1] { value2 });
				}
				_eventDelegates.Remove(value);
			}
		}
	}

	internal Cartel(Cartel cartel)
	{
		S1Cartel = cartel;
	}

	public void SetStatus(CartelStatus status, bool resetTimer = true)
	{
		S1Cartel.SetStatus_Server((ECartelStatus)status, resetTimer);
	}

	private static CartelStatus ConvertStatus(object status)
	{
		if (status == null)
		{
			return CartelStatus.Unknown;
		}
		int num = (int)status;
		if (1 == 0)
		{
		}
		CartelStatus result = num switch
		{
			0 => CartelStatus.Unknown, 
			1 => CartelStatus.Truced, 
			2 => CartelStatus.Hostile, 
			3 => CartelStatus.Defeated, 
			_ => CartelStatus.Unknown, 
		};
		if (1 == 0)
		{
		}
		return result;
	}
}
