internal class StyleProperty // TypeDefIndex: 6887
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_Line; // 0x18
	[SerializeField]
	private StyleValueHandle[] m_Values; // 0x20
	internal bool isCustomProperty; // 0x28
	internal bool requireVariableResolve; // 0x29

	// Properties
	public string name { get; }
	public StyleValueHandle[] values { get; }

	// Methods

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	public string get_name() { }

	// RVA: 0x1E09860 Offset: 0x1E08260 VA: 0x181E09860
	public StyleValueHandle[] get_values() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
