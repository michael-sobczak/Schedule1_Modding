using System;
using ScheduleOne.Cartel;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace S1API.Cartel;

public sealed class Cartel
{
	private static Cartel? _cachedInstance;

	private static Cartel? _lastS1Cartel;

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
				Cartel s1Cartel = S1Cartel;
				s1Cartel.OnStatusChange = (Action<ECartelStatus, ECartelStatus>)Delegate.Combine(s1Cartel.OnStatusChange, (Action<ECartelStatus, ECartelStatus>)delegate(ECartelStatus oldStatus, ECartelStatus newStatus)
				{
					//IL_000d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0018: Unknown result type (might be due to invalid IL or missing references)
					value?.Invoke(ConvertStatus(oldStatus), ConvertStatus(newStatus));
				});
			}
		}
		remove
		{
			if (value != null)
			{
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
