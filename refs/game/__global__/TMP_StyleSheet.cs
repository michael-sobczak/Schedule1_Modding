public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 14968
{
	// Fields
	[SerializeField]
	private List<TMP_Style> m_StyleList; // 0x18
	private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TMP_Style> styles { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal List<TMP_Style> get_styles() { }

	// RVA: 0x2C2BDC0 Offset: 0x2C2A7C0 VA: 0x182C2BDC0
	private void Reset() { }

	// RVA: 0x2C2B9E0 Offset: 0x2C2A3E0 VA: 0x182C2B9E0
	public TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x2C2B920 Offset: 0x2C2A320 VA: 0x182C2B920
	public TMP_Style GetStyle(string name) { }

	// RVA: 0x2C2BDC0 Offset: 0x2C2A7C0 VA: 0x182C2BDC0
	public void RefreshStyles() { }

	// RVA: 0x2C2BA70 Offset: 0x2C2A470 VA: 0x182C2BA70
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x2C2BDD0 Offset: 0x2C2A7D0 VA: 0x182C2BDD0
	public void .ctor() { }
}
