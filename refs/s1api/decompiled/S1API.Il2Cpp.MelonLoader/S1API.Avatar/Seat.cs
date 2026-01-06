using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;

namespace S1API.Avatar;

public sealed class Seat
{
	internal static readonly List<Seat> All = new List<Seat>();

	private readonly WeakReference<AvatarSeat> seatReference;

	private readonly WeakReference<AvatarSeatSet> seatSetReference;

	private readonly Transform seatTransform;

	private readonly Transform sittingPoint;

	private readonly Transform accessPoint;

	private readonly string hierarchyPath;

	private readonly string seatSetName;

	private readonly int? seatIndex;

	public string Label
	{
		get
		{
			if (!string.IsNullOrEmpty(seatSetName))
			{
				return seatIndex.HasValue ? $"{seatSetName}[{seatIndex.Value}] ({HierarchyPath})" : (seatSetName + " (" + HierarchyPath + ")");
			}
			return HierarchyPath;
		}
	}

	public string HierarchyPath => hierarchyPath;

	public string SeatSetName => seatSetName;

	public int? IndexInSet => seatIndex;

	public Vector3 SittingPosition
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)sittingPoint != (Object)null)
			{
				return sittingPoint.position;
			}
			if ((Object)(object)seatTransform != (Object)null)
			{
				return seatTransform.position;
			}
			return Vector3.zero;
		}
	}

	public Quaternion SittingRotation
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)sittingPoint != (Object)null)
			{
				return sittingPoint.rotation;
			}
			if ((Object)(object)seatTransform != (Object)null)
			{
				return seatTransform.rotation;
			}
			return Quaternion.identity;
		}
	}

	public Vector3 AccessPosition
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)accessPoint != (Object)null)
			{
				return accessPoint.position;
			}
			return SittingPosition;
		}
	}

	public Quaternion AccessRotation
	{
		get
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)accessPoint != (Object)null)
			{
				return accessPoint.rotation;
			}
			return SittingRotation;
		}
	}

	public static int Count => All.Count;

	private Seat(AvatarSeat seat)
	{
		seatReference = new WeakReference<AvatarSeat>(seat);
		seatTransform = (((Object)(object)seat != (Object)null) ? ((Component)seat).transform : null);
		sittingPoint = ((seat != null) ? seat.SittingPoint : null);
		accessPoint = ((seat != null) ? seat.AccessPoint : null);
		hierarchyPath = BuildTransformPath(seatTransform);
		AvatarSeatSet val = (AvatarSeatSet)(((Object)(object)seat != (Object)null) ? /*isinst with value type is only supported in some contexts*/: null);
		if ((Object)(object)val != (Object)null)
		{
			seatSetReference = new WeakReference<AvatarSeatSet>(val);
			GameObject gameObject = ((Component)val).gameObject;
			seatSetName = (((Object)(object)gameObject != (Object)null) ? ((Object)gameObject).name : string.Empty);
			try
			{
				if (val.Seats == null)
				{
					return;
				}
				for (int i = 0; i < ((Il2CppArrayBase<AvatarSeat>)(object)val.Seats).Length; i++)
				{
					if (((Il2CppArrayBase<AvatarSeat>)(object)val.Seats)[i] == seat)
					{
						seatIndex = i;
						break;
					}
				}
				return;
			}
			catch
			{
				return;
			}
		}
		seatSetReference = new WeakReference<AvatarSeatSet>(null);
		seatSetName = string.Empty;
	}

	public AvatarSeat ResolveGameSeat()
	{
		seatReference.TryGetTarget(out AvatarSeat target);
		return target;
	}

	public AvatarSeatSet ResolveSeatSet()
	{
		seatSetReference.TryGetTarget(out AvatarSeatSet target);
		return target;
	}

	public GameObject ResolveSeatGameObject()
	{
		AvatarSeat val = ResolveGameSeat();
		return ((Object)(object)val != (Object)null) ? ((Component)val).gameObject : null;
	}

	public static Seat[] GetAll()
	{
		return All.ToArray();
	}

	public static Seat[] GetBySeatSet(string setName)
	{
		if (string.IsNullOrEmpty(setName))
		{
			return Array.Empty<Seat>();
		}
		return All.Where((Seat s) => !string.IsNullOrEmpty(s.seatSetName) && string.Equals(s.seatSetName, setName, StringComparison.OrdinalIgnoreCase)).ToArray();
	}

	public static Seat FindByPathSuffix(string pathSuffix)
	{
		if (string.IsNullOrEmpty(pathSuffix))
		{
			return null;
		}
		for (int i = 0; i < All.Count; i++)
		{
			Seat seat = All[i];
			if (seat != null && seat.HierarchyPath.EndsWith(pathSuffix, StringComparison.OrdinalIgnoreCase))
			{
				return seat;
			}
		}
		return null;
	}

	internal static void Register(AvatarSeat seat)
	{
		if ((Object)(object)seat == (Object)null)
		{
			return;
		}
		for (int i = 0; i < All.Count; i++)
		{
			if ((Object)(object)All[i]?.ResolveGameSeat() == (Object)(object)seat)
			{
				All[i] = new Seat(seat);
				return;
			}
		}
		All.Add(new Seat(seat));
	}

	internal static void Unregister(AvatarSeat seat)
	{
		if ((Object)(object)seat == (Object)null)
		{
			return;
		}
		for (int num = All.Count - 1; num >= 0; num--)
		{
			Seat seat2 = All[num];
			if (seat2 == null || (Object)(object)seat2.ResolveGameSeat() == (Object)(object)seat)
			{
				All.RemoveAt(num);
			}
		}
	}

	internal static void Clear()
	{
		All.Clear();
	}

	private static string BuildTransformPath(Transform transform)
	{
		if ((Object)(object)transform == (Object)null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(96);
		AppendRecursive(transform, stringBuilder);
		return stringBuilder.ToString();
	}

	private static void AppendRecursive(Transform current, StringBuilder builder)
	{
		if ((Object)(object)current == (Object)null)
		{
			return;
		}
		if ((Object)(object)current.parent != (Object)null)
		{
			AppendRecursive(current.parent, builder);
			if (builder.Length > 0)
			{
				builder.Append('/');
			}
		}
		builder.Append(((Object)current).name);
	}
}
