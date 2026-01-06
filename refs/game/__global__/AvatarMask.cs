public sealed class AvatarMask : Object // TypeDefIndex: 18305
{
	// Properties
	public int transformCount { get; }

	// Methods

	// RVA: 0x2C79600 Offset: 0x2C78000 VA: 0x182C79600
	public void .ctor() { }

	[FreeFunction("AnimationBindings::CreateAvatarMask")]
	// RVA: 0x2C795C0 Offset: 0x2C77FC0 VA: 0x182C795C0
	private static void Internal_Create(AvatarMask self) { }

	[NativeMethod("GetBodyPart")]
	// RVA: 0x2C794B0 Offset: 0x2C77EB0 VA: 0x182C794B0
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	// RVA: 0x2C79670 Offset: 0x2C78070 VA: 0x182C79670
	public int get_transformCount() { }

	// RVA: 0x2C79540 Offset: 0x2C77F40 VA: 0x182C79540
	public string GetTransformPath(int index) { }

	// RVA: 0x2C79580 Offset: 0x2C77F80 VA: 0x182C79580
	private float GetTransformWeight(int index) { }

	// RVA: 0x2C794F0 Offset: 0x2C77EF0 VA: 0x182C794F0
	public bool GetTransformActive(int index) { }
}
