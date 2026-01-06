public class StyledCategory : PropertyAttribute // TypeDefIndex: 19272
{
	// Fields
	public string category; // 0x10
	public float top; // 0x18
	public float down; // 0x1C
	public bool colapsable; // 0x20

	// Methods

	// RVA: 0xBD9510 Offset: 0xBD7F10 VA: 0x180BD9510
	public void .ctor(string category) { }

	// RVA: 0xBD9560 Offset: 0xBD7F60 VA: 0x180BD9560
	public void .ctor(string category, bool colapsable) { }

	// RVA: 0xBD95C0 Offset: 0xBD7FC0 VA: 0x180BD95C0
	public void .ctor(string category, float top, float down) { }

	// RVA: 0xBD94A0 Offset: 0xBD7EA0 VA: 0x180BD94A0
	public void .ctor(string category, int top, int down, bool colapsable) { }
}
