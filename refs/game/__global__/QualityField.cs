public class QualityField : ConfigField // TypeDefIndex: 1219
{
	// Fields
	[CompilerGenerated]
	private EQuality <Value>k__BackingField; // 0x18
	public UnityEvent<EQuality> onValueChanged; // 0x20

	// Properties
	public EQuality Value { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public EQuality get_Value() { }

	[CompilerGenerated]
	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	protected void set_Value(EQuality value) { }

	// RVA: 0x620B80 Offset: 0x61F580 VA: 0x180620B80
	public void .ctor(EntityConfiguration parentConfig) { }

	// RVA: 0x620AF0 Offset: 0x61F4F0 VA: 0x180620AF0
	public void SetValue(EQuality value, bool network) { }

	// RVA: 0x620A60 Offset: 0x61F460 VA: 0x180620A60 Slot: 4
	public override bool IsValueDefault() { }

	// RVA: 0x620A00 Offset: 0x61F400 VA: 0x180620A00
	public QualityFieldData GetData() { }

	// RVA: 0x620A70 Offset: 0x61F470 VA: 0x180620A70
	public void Load(QualityFieldData data) { }
}
