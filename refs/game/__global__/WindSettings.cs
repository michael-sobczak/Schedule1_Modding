public struct WindSettings // TypeDefIndex: 18248
{
	// Fields
	[FormerlySerializedAs("GustDirection")]
	public Vector2 WindDirection; // 0x0
	[Range(0, 1)]
	[FormerlySerializedAs("GustStrength")]
	public float WindStrength; // 0x8
	[Range(0.5, 1)]
	[FormerlySerializedAs("GustSpeed")]
	public float WindSpeed; // 0xC
	[Range(0, 1)]
	[FormerlySerializedAs("ShiverStrength")]
	public float Turbulence; // 0x10

	// Properties
	public static WindSettings None { get; }
	public static WindSettings Calm { get; }
	public static WindSettings Breeze { get; }
	public static WindSettings StrongBreeze { get; }
	public static WindSettings Storm { get; }

	// Methods

	// RVA: 0x2F69E50 Offset: 0x2F68850 VA: 0x182F69E50
	public static WindSettings get_None() { }

	// RVA: 0x2F69E10 Offset: 0x2F68810 VA: 0x182F69E10
	public static WindSettings get_Calm() { }

	// RVA: 0x2F69DD0 Offset: 0x2F687D0 VA: 0x182F69DD0
	public static WindSettings get_Breeze() { }

	// RVA: 0x2F69ED0 Offset: 0x2F688D0 VA: 0x182F69ED0
	public static WindSettings get_StrongBreeze() { }

	// RVA: 0x2F69E90 Offset: 0x2F68890 VA: 0x182F69E90
	public static WindSettings get_Storm() { }

	// RVA: 0x2F69B30 Offset: 0x2F68530 VA: 0x182F69B30
	public static WindSettings FromWindZone(WindZone windZone) { }

	// RVA: 0x2F69C10 Offset: 0x2F68610 VA: 0x182F69C10
	public static Vector2 RotationToDirection(Quaternion quaternion) { }

	// RVA: 0x2F69D90 Offset: 0x2F68790 VA: 0x182F69D90
	public void .ctor(WindSettings other) { }

	// RVA: 0x2F69DB0 Offset: 0x2F687B0 VA: 0x182F69DB0
	public void .ctor(Vector2 gustDirection, float windStrength, float windSpeed, float turbulence) { }

	// RVA: 0x2F69AF0 Offset: 0x2F684F0 VA: 0x182F69AF0
	public void Apply(Texture2D gustNoise) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Apply() { }

	// RVA: 0x2F69A80 Offset: 0x2F68480 VA: 0x182F69A80
	public void ApplyToWindZone(WindZone zone) { }
}
