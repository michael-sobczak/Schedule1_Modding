public struct TransformAccess // TypeDefIndex: 11913
{
	// Fields
	private IntPtr hierarchy; // 0x0
	private int index; // 0x8

	// Properties
	public Vector3 position { get; }
	public Quaternion rotation { get; }
	public Vector3 localScale { get; }
	public Matrix4x4 localToWorldMatrix { get; }

	// Methods

	// RVA: 0x2CCC420 Offset: 0x2CCAE20 VA: 0x182CCC420
	public Vector3 get_position() { }

	// RVA: 0x2CCC490 Offset: 0x2CCAE90 VA: 0x182CCC490
	public Quaternion get_rotation() { }

	// RVA: 0x2CCC310 Offset: 0x2CCAD10 VA: 0x182CCC310
	public Vector3 get_localScale() { }

	// RVA: 0x2CCC380 Offset: 0x2CCAD80 VA: 0x182CCC380
	public Matrix4x4 get_localToWorldMatrix() { }

	[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCC270 Offset: 0x2CCAC70 VA: 0x182CCC270
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCC2C0 Offset: 0x2CCACC0 VA: 0x182CCC2C0
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethod(Name = "TransformAccessBindings::GetLocalScale", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCC1D0 Offset: 0x2CCABD0 VA: 0x182CCC1D0
	private static void GetLocalScale(ref TransformAccess access, out Vector3 r) { }

	[NativeMethod(Name = "TransformAccessBindings::GetLocalToWorldMatrix", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCC220 Offset: 0x2CCAC20 VA: 0x182CCC220
	private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m) { }
}
