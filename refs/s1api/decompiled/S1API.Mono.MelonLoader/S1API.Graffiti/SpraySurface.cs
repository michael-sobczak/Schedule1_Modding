using System;
using S1API.Internal.Utils;
using ScheduleOne.Graffiti;
using UnityEngine;

namespace S1API.Graffiti;

public sealed class SpraySurface
{
	internal readonly SpraySurface S1SpraySurface;

	public Guid GUID => S1SpraySurface.GUID;

	public Vector3 Position
	{
		get
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			object obj = ReflectionUtils.TryGetFieldOrProperty(S1SpraySurface, "BottomLeftPoint");
			Transform val = (Transform)((obj is Transform) ? obj : null);
			if (val != null && (Object)(object)val != (Object)null)
			{
				return val.position;
			}
			return Vector3.zero;
		}
	}

	public int StrokeCount => S1SpraySurface.DrawingStrokeCount;

	public int PaintedPixelCount => S1SpraySurface.DrawingPaintedPixelCount;

	public bool HasDrawingBeenFinalized => S1SpraySurface.HasDrawingBeenFinalized;

	public Texture DrawingOutputTexture => S1SpraySurface.DrawingOutputTexture;

	public event Action OnDrawingChanged
	{
		add
		{
			SpraySurface s1SpraySurface = S1SpraySurface;
			s1SpraySurface.onDrawingChanged = (Action)Delegate.Combine(s1SpraySurface.onDrawingChanged, value);
		}
		remove
		{
			SpraySurface s1SpraySurface = S1SpraySurface;
			s1SpraySurface.onDrawingChanged = (Action)Delegate.Remove(s1SpraySurface.onDrawingChanged, value);
		}
	}

	internal SpraySurface(SpraySurface spraySurface)
	{
		S1SpraySurface = spraySurface;
	}
}
