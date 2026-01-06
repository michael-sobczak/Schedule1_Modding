public abstract class BaseShaderDefinition : IProfileDefinition // TypeDefIndex: 460
{
	// Fields
	[CompilerGenerated]
	private string <shaderName>k__BackingField; // 0x10
	private ProfileGroupSection[] m_ProfileDefinitions; // 0x18
	[SerializeField]
	private ProfileFeatureSection[] m_ProfileFeatures; // 0x20
	private Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature; // 0x28

	// Properties
	public string shaderName { get; set; }
	public ProfileGroupSection[] groups { get; }
	public ProfileFeatureSection[] features { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 4
	public string get_shaderName() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_shaderName(string value) { }

	// RVA: 0x9DE2B0 Offset: 0x9DCCB0 VA: 0x1809DE2B0 Slot: 6
	public ProfileGroupSection[] get_groups() { }

	// RVA: 0x9DE260 Offset: 0x9DCC60 VA: 0x1809DE260 Slot: 5
	public ProfileFeatureSection[] get_features() { }

	// RVA: 0x9DDFB0 Offset: 0x9DC9B0 VA: 0x1809DDFB0 Slot: 7
	public ProfileFeatureDefinition GetFeatureDefinition(string featureKey) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract ProfileFeatureSection[] ProfileFeatureSection();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract ProfileGroupSection[] ProfileDefinitionTable();

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
