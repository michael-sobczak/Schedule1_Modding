public class TextStyleSheet : ScriptableObject // TypeDefIndex: 16762
{
	// Fields
	[SerializeField]
	private List<TextStyle> m_StyleList; // 0x18
	private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TextStyle> styles { get; }

	// Methods

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	internal List<TextStyle> get_styles() { }

	// RVA: 0x2D89010 Offset: 0x2D87A10 VA: 0x182D89010
	private void Reset() { }

	// RVA: 0x2D88B10 Offset: 0x2D87510 VA: 0x182D88B10
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x2D88BA0 Offset: 0x2D875A0 VA: 0x182D88BA0
	public TextStyle GetStyle(string name) { }

	// RVA: 0x2D89010 Offset: 0x2D87A10 VA: 0x182D89010
	public void RefreshStyles() { }

	// RVA: 0x2D88C40 Offset: 0x2D87640 VA: 0x182D88C40
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x2D89020 Offset: 0x2D87A20 VA: 0x182D89020
	public void .ctor() { }
}
