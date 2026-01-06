internal abstract class GaussianWindow1d<T> // TypeDefIndex: 16258
{
	// Fields
	protected T[] mData; // 0x0
	protected float[] mKernel; // 0x0
	protected int mCurrentPos; // 0x0
	[CompilerGenerated]
	private float <Sigma>k__BackingField; // 0x0

	// Properties
	public float Sigma { get; set; }
	public int KernelSize { get; }
	public int BufferLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public float get_Sigma() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	|-GaussianWindow1d<Quaternion>.get_Sigma
	|-GaussianWindow1d<Vector2>.get_Sigma
	|-GaussianWindow1d<Vector3>.get_Sigma
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.get_Sigma
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Sigma(float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	|-GaussianWindow1d<Quaternion>.set_Sigma
	|-GaussianWindow1d<Vector2>.set_Sigma
	|-GaussianWindow1d<Vector3>.set_Sigma
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.set_Sigma
	*/

	// RVA: -1 Offset: -1
	public int get_KernelSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AE000 Offset: 0x11ACA00 VA: 0x1811AE000
	|-GaussianWindow1d<Quaternion>.get_KernelSize
	|-GaussianWindow1d<Vector2>.get_KernelSize
	|-GaussianWindow1d<Vector3>.get_KernelSize
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.get_KernelSize
	*/

	// RVA: -1 Offset: -1
	private void GenerateKernel(float sigma, int maxKernelRadius) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180DCB0 Offset: 0x180C6B0 VA: 0x18180DCB0
	|-GaussianWindow1d<Quaternion>.GenerateKernel
	|
	|-RVA: 0x180E200 Offset: 0x180CC00 VA: 0x18180E200
	|-GaussianWindow1d<Vector2>.GenerateKernel
	|
	|-RVA: 0x180E490 Offset: 0x180CE90 VA: 0x18180E490
	|-GaussianWindow1d<Vector3>.GenerateKernel
	|
	|-RVA: 0x180DF40 Offset: 0x180C940 VA: 0x18180DF40
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.GenerateKernel
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract T Compute(int windowPos);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.Compute
	*/

	// RVA: -1 Offset: -1
	public void .ctor(float sigma, int maxKernelRadius = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180ECC0 Offset: 0x180D6C0 VA: 0x18180ECC0
	|-GaussianWindow1d<Quaternion>..ctor
	|
	|-RVA: 0x180EE40 Offset: 0x180D840 VA: 0x18180EE40
	|-GaussianWindow1d<Vector2>..ctor
	|
	|-RVA: 0x180EC00 Offset: 0x180D600 VA: 0x18180EC00
	|-GaussianWindow1d<Vector3>..ctor
	|
	|-RVA: 0x180ED80 Offset: 0x180D780 VA: 0x18180ED80
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663D60 Offset: 0x1662760 VA: 0x181663D60
	|-GaussianWindow1d<Quaternion>.Reset
	|-GaussianWindow1d<Vector2>.Reset
	|-GaussianWindow1d<Vector3>.Reset
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public bool IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180E8B0 Offset: 0x180D2B0 VA: 0x18180E8B0
	|-GaussianWindow1d<Quaternion>.IsEmpty
	|-GaussianWindow1d<Vector2>.IsEmpty
	|-GaussianWindow1d<Vector3>.IsEmpty
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.IsEmpty
	*/

	// RVA: -1 Offset: -1
	public void AddValue(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180D290 Offset: 0x180BC90 VA: 0x18180D290
	|-GaussianWindow1d<Quaternion>.AddValue
	|
	|-RVA: 0x180D6E0 Offset: 0x180C0E0 VA: 0x18180D6E0
	|-GaussianWindow1d<Vector2>.AddValue
	|
	|-RVA: 0x180D600 Offset: 0x180C000 VA: 0x18180D600
	|-GaussianWindow1d<Vector3>.AddValue
	|
	|-RVA: 0x180D360 Offset: 0x180BD60 VA: 0x18180D360
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.AddValue
	*/

	// RVA: -1 Offset: -1
	public T Filter(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180D910 Offset: 0x180C310 VA: 0x18180D910
	|-GaussianWindow1d<Quaternion>.Filter
	|
	|-RVA: 0x180DA30 Offset: 0x180C430 VA: 0x18180DA30
	|-GaussianWindow1d<Vector2>.Filter
	|
	|-RVA: 0x180D7C0 Offset: 0x180C1C0 VA: 0x18180D7C0
	|-GaussianWindow1d<Vector3>.Filter
	|
	|-RVA: 0x180DB40 Offset: 0x180C540 VA: 0x18180DB40
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.Filter
	*/

	// RVA: -1 Offset: -1
	public T Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180EB10 Offset: 0x180D510 VA: 0x18180EB10
	|-GaussianWindow1d<Quaternion>.Value
	|
	|-RVA: 0x180EAF0 Offset: 0x180D4F0 VA: 0x18180EAF0
	|-GaussianWindow1d<Vector2>.Value
	|
	|-RVA: 0x180EAB0 Offset: 0x180D4B0 VA: 0x18180EAB0
	|-GaussianWindow1d<Vector3>.Value
	|
	|-RVA: 0x180EB50 Offset: 0x180D550 VA: 0x18180EB50
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.Value
	*/

	// RVA: -1 Offset: -1
	public int get_BufferLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-GaussianWindow1d<Quaternion>.get_BufferLength
	|-GaussianWindow1d<Vector2>.get_BufferLength
	|-GaussianWindow1d<Vector3>.get_BufferLength
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.get_BufferLength
	*/

	// RVA: -1 Offset: -1
	public void SetBufferValue(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180E8C0 Offset: 0x180D2C0 VA: 0x18180E8C0
	|-GaussianWindow1d<Quaternion>.SetBufferValue
	|
	|-RVA: 0x180E940 Offset: 0x180D340 VA: 0x18180E940
	|-GaussianWindow1d<Vector2>.SetBufferValue
	|
	|-RVA: 0x180E900 Offset: 0x180D300 VA: 0x18180E900
	|-GaussianWindow1d<Vector3>.SetBufferValue
	|
	|-RVA: 0x180E990 Offset: 0x180D390 VA: 0x18180E990
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.SetBufferValue
	*/

	// RVA: -1 Offset: -1
	public T GetBufferValue(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x180E870 Offset: 0x180D270 VA: 0x18180E870
	|-GaussianWindow1d<Quaternion>.GetBufferValue
	|
	|-RVA: 0x180E720 Offset: 0x180D120 VA: 0x18180E720
	|-GaussianWindow1d<Vector2>.GetBufferValue
	|
	|-RVA: 0x180E760 Offset: 0x180D160 VA: 0x18180E760
	|-GaussianWindow1d<Vector3>.GetBufferValue
	|
	|-RVA: 0x180E7B0 Offset: 0x180D1B0 VA: 0x18180E7B0
	|-GaussianWindow1d<__Il2CppFullySharedGenericType>.GetBufferValue
	*/
}
