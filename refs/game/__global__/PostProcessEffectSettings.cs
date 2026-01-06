public class PostProcessEffectSettings : ScriptableObject // TypeDefIndex: 17037
{
	// Fields
	public bool active; // 0x18
	public BoolParameter enabled; // 0x20
	internal ReadOnlyCollection<ParameterOverride> parameters; // 0x28

	// Methods

	// RVA: 0x29AECD0 Offset: 0x29AD6D0 VA: 0x1829AECD0
	private void OnEnable() { }

	// RVA: 0x29AEB10 Offset: 0x29AD510 VA: 0x1829AEB10
	private void OnDisable() { }

	// RVA: 0x29AF140 Offset: 0x29ADB40 VA: 0x1829AF140
	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	// RVA: 0x29AEAF0 Offset: 0x29AD4F0 VA: 0x1829AEAF0 Slot: 4
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x29AE910 Offset: 0x29AD310 VA: 0x1829AE910
	public int GetHash() { }

	// RVA: 0x29AF3C0 Offset: 0x29ADDC0 VA: 0x1829AF3C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x29AF320 Offset: 0x29ADD20 VA: 0x1829AF320
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }
}
