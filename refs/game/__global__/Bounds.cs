public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 11623
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeName("m_Extent")]
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x2C81250 Offset: 0x2C7FC50 VA: 0x182C81250
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x10950A0 Offset: 0x1093AA0 VA: 0x1810950A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2C80C70 Offset: 0x2C7F670 VA: 0x182C80C70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2C80BE0 Offset: 0x2C7F5E0 VA: 0x182C80BE0 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x2C63CF0 Offset: 0x2C626F0 VA: 0x182C63CF0
	public Vector3 get_center() { }

	// RVA: 0x281FE90 Offset: 0x281E890 VA: 0x18281FE90
	public void set_center(Vector3 value) { }

	// RVA: 0x2C81320 Offset: 0x2C7FD20 VA: 0x182C81320
	public Vector3 get_size() { }

	// RVA: 0x2C815F0 Offset: 0x2C7FFF0 VA: 0x182C815F0
	public void set_size(Vector3 value) { }

	// RVA: 0x2C80B20 Offset: 0x2C7F520 VA: 0x182C80B20
	public Vector3 get_extents() { }

	// RVA: 0x2C63D20 Offset: 0x2C62720 VA: 0x182C63D20
	public void set_extents(Vector3 value) { }

	// RVA: 0x2C812E0 Offset: 0x2C7FCE0 VA: 0x182C812E0
	public Vector3 get_min() { }

	// RVA: 0x2C81560 Offset: 0x2C7FF60 VA: 0x182C81560
	public void set_min(Vector3 value) { }

	// RVA: 0x2C812A0 Offset: 0x2C7FCA0 VA: 0x182C812A0
	public Vector3 get_max() { }

	// RVA: 0x2C814C0 Offset: 0x2C7FEC0 VA: 0x182C814C0
	public void set_max(Vector3 value) { }

	// RVA: 0x2C81360 Offset: 0x2C7FD60 VA: 0x182C81360
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x2C81400 Offset: 0x2C7FE00 VA: 0x182C81400
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x2C80F60 Offset: 0x2C7F960 VA: 0x182C80F60
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x44CA00 Offset: 0x44B400 VA: 0x18044CA00
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x44CB00 Offset: 0x44B500 VA: 0x18044CB00
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x2C80DF0 Offset: 0x2C7F7F0 VA: 0x182C80DF0
	public void Expand(float amount) { }

	// RVA: 0x2C80D90 Offset: 0x2C7F790 VA: 0x182C80D90
	public void Expand(Vector3 amount) { }

	// RVA: 0xB61780 Offset: 0xB60180 VA: 0x180B61780
	public bool Intersects(Bounds bounds) { }

	// RVA: 0x2C80EF0 Offset: 0x2C7F8F0 VA: 0x182C80EF0
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x2C81240 Offset: 0x2C7FC40 VA: 0x182C81240 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C81080 Offset: 0x2C7FA80 VA: 0x182C81080 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	[NativeMethod("IsInside", IsThreadSafe = True)]
	// RVA: 0x2C80B90 Offset: 0x2C7F590 VA: 0x182C80B90
	public bool Contains(Vector3 point) { }

	[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C81030 Offset: 0x2C7FA30 VA: 0x182C81030
	public float SqrDistance(Vector3 point) { }

	[FreeFunction("IntersectRayAABB", IsThreadSafe = True)]
	// RVA: 0x2C80E90 Offset: 0x2C7F890 VA: 0x182C80E90
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	// RVA: 0x2C80B40 Offset: 0x2C7F540 VA: 0x182C80B40
	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x2C80FE0 Offset: 0x2C7F9E0 VA: 0x182C80FE0
	private static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x2C80E30 Offset: 0x2C7F830 VA: 0x182C80E30
	private static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }
}
