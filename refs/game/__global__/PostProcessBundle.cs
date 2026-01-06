public sealed class PostProcessBundle // TypeDefIndex: 17028
{
	// Fields
	[CompilerGenerated]
	private PostProcessAttribute <attribute>k__BackingField; // 0x10
	[CompilerGenerated]
	private PostProcessEffectSettings <settings>k__BackingField; // 0x18
	private PostProcessEffectRenderer m_Renderer; // 0x20

	// Properties
	public PostProcessAttribute attribute { get; set; }
	public PostProcessEffectSettings settings { get; set; }
	internal PostProcessEffectRenderer renderer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public PostProcessAttribute get_attribute() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public PostProcessEffectSettings get_settings() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_settings(PostProcessEffectSettings value) { }

	// RVA: 0x29ACC50 Offset: 0x29AB650 VA: 0x1829ACC50
	internal PostProcessEffectRenderer get_renderer() { }

	// RVA: 0x29ACBA0 Offset: 0x29AB5A0 VA: 0x1829ACBA0
	internal void .ctor(PostProcessEffectSettings settings) { }

	// RVA: 0x29ACB10 Offset: 0x29AB510 VA: 0x1829ACB10
	internal void Release() { }

	// RVA: 0x29ACB80 Offset: 0x29AB580 VA: 0x1829ACB80
	internal void ResetHistory() { }

	// RVA: -1 Offset: -1
	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF25C20 Offset: 0xF24620 VA: 0x180F25C20
	|-PostProcessBundle.CastSettings<object>
	*/

	// RVA: -1 Offset: -1
	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF25BA0 Offset: 0xF245A0 VA: 0x180F25BA0
	|-PostProcessBundle.CastRenderer<object>
	*/
}
