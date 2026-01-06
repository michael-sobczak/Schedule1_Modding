public class Avatar : Object // TypeDefIndex: 18299
{
	// Properties
	public bool isValid { get; }
	public bool isHuman { get; }
	public HumanDescription humanDescription { get; }

	// Methods

	// RVA: 0x2C798B0 Offset: 0x2C782B0 VA: 0x182C798B0
	private void .ctor() { }

	[NativeMethod("IsValid")]
	// RVA: 0x2C799F0 Offset: 0x2C783F0 VA: 0x182C799F0
	public bool get_isValid() { }

	[NativeMethod("IsHuman")]
	// RVA: 0x2C799B0 Offset: 0x2C783B0 VA: 0x182C799B0
	public bool get_isHuman() { }

	// RVA: 0x2C79950 Offset: 0x2C78350 VA: 0x182C79950
	public HumanDescription get_humanDescription() { }

	// RVA: 0x2C796B0 Offset: 0x2C780B0 VA: 0x182C796B0
	internal float GetAxisLength(int humanId) { }

	// RVA: 0x2C79720 Offset: 0x2C78120 VA: 0x182C79720
	internal Quaternion GetPostRotation(int humanId) { }

	[NativeMethod("GetAxisLength")]
	// RVA: 0x2C797C0 Offset: 0x2C781C0 VA: 0x182C797C0
	internal float Internal_GetAxisLength(int humanId) { }

	[NativeMethod("GetPostRotation")]
	// RVA: 0x2C79850 Offset: 0x2C78250 VA: 0x182C79850
	internal Quaternion Internal_GetPostRotation(int humanId) { }

	// RVA: 0x2C79900 Offset: 0x2C78300 VA: 0x182C79900
	private void get_humanDescription_Injected(out HumanDescription ret) { }

	// RVA: 0x2C79800 Offset: 0x2C78200 VA: 0x182C79800
	private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) { }
}
