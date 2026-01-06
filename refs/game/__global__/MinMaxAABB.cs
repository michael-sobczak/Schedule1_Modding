internal struct MinMaxAABB : IEquatable<MinMaxAABB> // TypeDefIndex: 10957
{
	// Fields
	public float3 Min; // 0x0
	public float3 Max; // 0xC

	// Properties
	public float3 Extents { get; }
	public float3 HalfExtents { get; }
	public float3 Center { get; }
	public bool IsValid { get; }
	public float SurfaceArea { get; }

	// Methods

	// RVA: 0x1435880 Offset: 0x1434280 VA: 0x181435880
	public void .ctor(float3 min, float3 max) { }

	// RVA: 0x28F9E20 Offset: 0x28F8820 VA: 0x1828F9E20
	public static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents) { }

	// RVA: 0x28F9EC0 Offset: 0x28F88C0 VA: 0x1828F9EC0
	public static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents) { }

	// RVA: 0x28FA3F0 Offset: 0x28F8DF0 VA: 0x1828FA3F0
	public float3 get_Extents() { }

	// RVA: 0x28FA430 Offset: 0x28F8E30 VA: 0x1828FA430
	public float3 get_HalfExtents() { }

	// RVA: 0x28FA390 Offset: 0x28F8D90 VA: 0x1828FA390
	public float3 get_Center() { }

	// RVA: 0x28FA490 Offset: 0x28F8E90 VA: 0x1828FA490
	public bool get_IsValid() { }

	// RVA: 0x28FA4D0 Offset: 0x28F8ED0 VA: 0x1828FA4D0
	public float get_SurfaceArea() { }

	// RVA: 0x28F9CF0 Offset: 0x28F86F0 VA: 0x1828F9CF0
	public bool Contains(float3 point) { }

	// RVA: 0x28F9D80 Offset: 0x28F8780 VA: 0x1828F9D80
	public bool Contains(MinMaxAABB aabb) { }

	// RVA: 0x28FA250 Offset: 0x28F8C50 VA: 0x1828FA250
	public bool Overlaps(MinMaxAABB aabb) { }

	// RVA: 0x28FA1F0 Offset: 0x28F8BF0 VA: 0x1828FA1F0
	public void Expand(float signedDistance) { }

	// RVA: 0x28F9F50 Offset: 0x28F8950 VA: 0x1828F9F50
	public void Encapsulate(MinMaxAABB aabb) { }

	// RVA: 0x28FA060 Offset: 0x28F8A60 VA: 0x1828FA060
	public void Encapsulate(float3 point) { }

	// RVA: 0x28FA170 Offset: 0x28F8B70 VA: 0x1828FA170 Slot: 4
	public bool Equals(MinMaxAABB other) { }

	// RVA: 0x28FA2F0 Offset: 0x28F8CF0 VA: 0x1828FA2F0 Slot: 3
	public override string ToString() { }
}
