public static class Buoyancy // TypeDefIndex: 18260
{
	// Fields
	private static WaveParameters waveParameters; // 0x0
	private static Material lastMaterial; // 0x8
	private static readonly int TimeParametersID; // 0x10
	private static float4 sine; // 0x14
	private static float4 cosine; // 0x24
	private static float4 dotABCD; // 0x34
	private static float4 AB; // 0x44
	private static float4 CD; // 0x54
	private static float4 direction1; // 0x64
	private static float4 direction2; // 0x74
	private static float4 TIME; // 0x84
	private static float2 planarPosition; // 0x94
	private static float4 amp; // 0x9C
	private static float4 freq; // 0xAC
	private static float4 speed; // 0xBC
	private static float4 dir1; // 0xCC
	private static float4 dir2; // 0xDC
	private static float4 steepness; // 0xEC
	private static float4 frequency; // 0xFC
	private static float3 offsets; // 0x10C
	private static RaycastHit hit; // 0x118
	private static Vector3 m_offset; // 0x144

	// Properties
	private static float _TimeParameters { get; }

	// Methods

	// RVA: 0x1F65FE0 Offset: 0x1F649E0 VA: 0x181F65FE0
	private static void GetMaterialParameters(Material mat) { }

	// RVA: 0x1F67BA0 Offset: 0x1F665A0 VA: 0x181F67BA0
	private static float get__TimeParameters() { }

	[Obsolete("Set the static 'WaterObject.CustomTime' parameter instead.", False)]
	// RVA: 0x1F67970 Offset: 0x1F66370 VA: 0x181F67970
	public static void SetCustomTime(float value) { }

	// RVA: 0x1F65E70 Offset: 0x1F64870 VA: 0x181F65E70
	public static float3 FindWaterLevelIntersection(float3 origin, float3 direction, float waterLevel) { }

	// RVA: 0x1F66500 Offset: 0x1F64F00 VA: 0x181F66500
	public static void Raycast(WaterObject waterObject, float3 origin, float3 direction, bool dynamicMaterial, out RaycastHit hit) { }

	// RVA: 0x1F661B0 Offset: 0x1F64BB0 VA: 0x181F661B0
	public static void Raycast(Material waterMat, float waterLevel, float3 origin, float3 direction, bool dynamicMaterial, out RaycastHit hit) { }

	// RVA: 0x1F67790 Offset: 0x1F66190 VA: 0x181F67790
	public static float SampleWaves(Vector3 position, WaterObject waterObject, float rollStrength, bool dynamicMaterial, out Vector3 normal) { }

	// RVA: 0x1F66620 Offset: 0x1F65020 VA: 0x181F66620
	private static void RecalculateParameters() { }

	// RVA: 0x1F66A10 Offset: 0x1F65410 VA: 0x181F66A10
	private static void SampleWaves(Vector3 position, Material waterMat, float waterLevel, float rollStrength, bool dynamicMaterial, out Vector3 offset, out Vector3 normal) { }

	// RVA: 0x1F67890 Offset: 0x1F66290 VA: 0x181F67890
	public static float SampleWaves(Vector3 position, Material waterMat, float waterLevel, float rollStrength, bool dynamicMaterial, out Vector3 normal) { }

	// RVA: 0x1F65D40 Offset: 0x1F64740 VA: 0x181F65D40
	public static bool CanTouchWater(float3 position, WaterObject waterObject) { }

	// RVA: 0x1F65C80 Offset: 0x1F64680 VA: 0x181F65C80
	public static bool CanTouchWater(float3 position, Material waterMaterial, float waterLevel) { }

	// RVA: 0x1F67A20 Offset: 0x1F66420 VA: 0x181F67A20
	private static void .cctor() { }
}
