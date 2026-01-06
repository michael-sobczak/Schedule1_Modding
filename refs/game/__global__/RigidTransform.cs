public struct RigidTransform // TypeDefIndex: 10941
{
	// Fields
	public quaternion rot; // 0x0
	public float3 pos; // 0x10
	public static readonly RigidTransform identity; // 0x0

	// Methods

	// RVA: 0x298BEA0 Offset: 0x298A8A0 VA: 0x18298BEA0
	public void .ctor(quaternion rotation, float3 translation) { }

	// RVA: 0x298BEC0 Offset: 0x298A8C0 VA: 0x18298BEC0
	public void .ctor(float3x3 rotation, float3 translation) { }

	// RVA: 0x298BF30 Offset: 0x298A930 VA: 0x18298BF30
	public void .ctor(float4x4 transform) { }

	// RVA: 0x298A5D0 Offset: 0x2988FD0 VA: 0x18298A5D0
	public static RigidTransform AxisAngle(float3 axis, float angle) { }

	// RVA: 0x298A8F0 Offset: 0x29892F0 VA: 0x18298A8F0
	public static RigidTransform EulerXYZ(float3 xyz) { }

	// RVA: 0x298AAD0 Offset: 0x29894D0 VA: 0x18298AAD0
	public static RigidTransform EulerXZY(float3 xyz) { }

	// RVA: 0x298AB50 Offset: 0x2989550 VA: 0x18298AB50
	public static RigidTransform EulerYXZ(float3 xyz) { }

	// RVA: 0x298AD30 Offset: 0x2989730 VA: 0x18298AD30
	public static RigidTransform EulerYZX(float3 xyz) { }

	// RVA: 0x298ADB0 Offset: 0x29897B0 VA: 0x18298ADB0
	public static RigidTransform EulerZXY(float3 xyz) { }

	// RVA: 0x298AF90 Offset: 0x2989990 VA: 0x18298AF90
	public static RigidTransform EulerZYX(float3 xyz) { }

	// RVA: 0x298A970 Offset: 0x2989370 VA: 0x18298A970
	public static RigidTransform EulerXYZ(float x, float y, float z) { }

	// RVA: 0x298AA20 Offset: 0x2989420 VA: 0x18298AA20
	public static RigidTransform EulerXZY(float x, float y, float z) { }

	// RVA: 0x298ABD0 Offset: 0x29895D0 VA: 0x18298ABD0
	public static RigidTransform EulerYXZ(float x, float y, float z) { }

	// RVA: 0x298AC80 Offset: 0x2989680 VA: 0x18298AC80
	public static RigidTransform EulerYZX(float x, float y, float z) { }

	// RVA: 0x298AE30 Offset: 0x2989830 VA: 0x18298AE30
	public static RigidTransform EulerZXY(float x, float y, float z) { }

	// RVA: 0x298AEE0 Offset: 0x29898E0 VA: 0x18298AEE0
	public static RigidTransform EulerZYX(float x, float y, float z) { }

	// RVA: 0x298B010 Offset: 0x2989A10 VA: 0x18298B010
	public static RigidTransform Euler(float3 xyz, math.RotationOrder order = 4) { }

	// RVA: 0x298B300 Offset: 0x2989D00 VA: 0x18298B300
	public static RigidTransform Euler(float x, float y, float z, math.RotationOrder order = 4) { }

	// RVA: 0x298B400 Offset: 0x2989E00 VA: 0x18298B400
	public static RigidTransform RotateX(float angle) { }

	// RVA: 0x298B520 Offset: 0x2989F20 VA: 0x18298B520
	public static RigidTransform RotateY(float angle) { }

	// RVA: 0x298B640 Offset: 0x298A040 VA: 0x18298B640
	public static RigidTransform RotateZ(float angle) { }

	// RVA: 0x298BDE0 Offset: 0x298A7E0 VA: 0x18298BDE0
	public static RigidTransform Translate(float3 vector) { }

	// RVA: 0x298A860 Offset: 0x2989260 VA: 0x18298A860
	public bool Equals(RigidTransform x) { }

	// RVA: 0x298A750 Offset: 0x2989150 VA: 0x18298A750 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x298B360 Offset: 0x2989D60 VA: 0x18298B360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x298BA90 Offset: 0x298A490 VA: 0x18298BA90 Slot: 3
	public override string ToString() { }

	// RVA: 0x298B760 Offset: 0x298A160 VA: 0x18298B760
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x298BE40 Offset: 0x298A840 VA: 0x18298BE40
	private static void .cctor() { }
}
