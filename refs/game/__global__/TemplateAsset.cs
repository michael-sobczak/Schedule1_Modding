internal class TemplateAsset : VisualElementAsset // TypeDefIndex: 6957
{
	// Fields
	[SerializeField]
	private string m_TemplateAlias; // 0x70
	[SerializeField]
	private List<TemplateAsset.AttributeOverride> m_AttributeOverrides; // 0x78
	[SerializeField]
	private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80

	// Properties
	public List<TemplateAsset.AttributeOverride> attributeOverrides { get; }
	internal List<VisualTreeAsset.SlotUsageEntry> slotUsages { get; }

	// Methods

	// RVA: 0x2DDE520 Offset: 0x2DDCF20 VA: 0x182DDE520
	public List<TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x2D0E240 Offset: 0x2D0CC40 VA: 0x182D0E240
	internal List<VisualTreeAsset.SlotUsageEntry> get_slotUsages() { }
}
