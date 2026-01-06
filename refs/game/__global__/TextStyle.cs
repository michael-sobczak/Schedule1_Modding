public class TextStyle // TypeDefIndex: 16761
{
	// Fields
	internal static TextStyle k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; // 0x38
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public int hashCode { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	public int get_hashCode() { }

	// RVA: 0x1E019C0 Offset: 0x1E003C0 VA: 0x181E019C0
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x2D89320 Offset: 0x2D87D20 VA: 0x182D89320
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x2D890A0 Offset: 0x2D87AA0 VA: 0x182D890A0
	public void RefreshStyle() { }
}
