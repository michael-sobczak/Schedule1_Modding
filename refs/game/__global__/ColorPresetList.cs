public class ColorPresetList // TypeDefIndex: 18751
{
	// Fields
	[CompilerGenerated]
	private string <ListId>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<Color> <Colors>k__BackingField; // 0x18
	[CompilerGenerated]
	private UnityAction<List<Color>> OnColorsUpdated; // 0x20

	// Properties
	public string ListId { get; set; }
	public List<Color> Colors { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_ListId() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_ListId(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<Color> get_Colors() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Colors(List<Color> value) { }

	[CompilerGenerated]
	// RVA: 0x1A4AAC0 Offset: 0x1A494C0 VA: 0x181A4AAC0
	public void add_OnColorsUpdated(UnityAction<List<Color>> value) { }

	[CompilerGenerated]
	// RVA: 0x1A4AB70 Offset: 0x1A49570 VA: 0x181A4AB70
	public void remove_OnColorsUpdated(UnityAction<List<Color>> value) { }

	// RVA: 0x1A4AA20 Offset: 0x1A49420 VA: 0x181A4AA20
	public void .ctor(string listId, List<Color> colors) { }

	// RVA: 0x1A4A8B0 Offset: 0x1A492B0 VA: 0x181A4A8B0
	public void AddColor(Color color) { }

	// RVA: 0x1A4A980 Offset: 0x1A49380 VA: 0x181A4A980
	public void UpdateList(IEnumerable<Color> colors) { }
}
