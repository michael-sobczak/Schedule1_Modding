public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel> // TypeDefIndex: 122
{
	// Fields
	private Texture2D m_SpectrumLut; // 0x20

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x56E190 Offset: 0x56CB90 VA: 0x18056E190 Slot: 5
	public override bool get_active() { }

	// RVA: 0x56DE70 Offset: 0x56C870 VA: 0x18056DE70 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x56DEA0 Offset: 0x56C8A0 VA: 0x18056DEA0 Slot: 10
	public override void Prepare(Material uberMaterial) { }

	// RVA: 0x56E150 Offset: 0x56CB50 VA: 0x18056E150
	public void .ctor() { }
}
