public abstract class Preset // TypeDefIndex: 1255
{
	// Fields
	public string PresetName; // 0x10
	public Color32 PresetColor; // 0x18
	public ManageableObjectType ObjectType; // 0x1C
	public Preset.NameChange onNameChanged; // 0x20
	public Preset.PresetDeletion onDeleted; // 0x28

	// Methods

	// RVA: 0x61FC60 Offset: 0x61E660 VA: 0x18061FC60
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Preset GetCopy();

	// RVA: 0x6208D0 Offset: 0x61F2D0 VA: 0x1806208D0 Slot: 5
	public virtual void CopyTo(Preset other) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void InitializeOptions();

	// RVA: 0x6209A0 Offset: 0x61F3A0 VA: 0x1806209A0
	public void SetName(string newName) { }

	// RVA: 0x620910 Offset: 0x61F310 VA: 0x180620910
	public void DeletePreset(Preset replacement) { }

	// RVA: 0x620930 Offset: 0x61F330 VA: 0x180620930
	public static Preset GetDefault(ManageableObjectType type) { }
}
