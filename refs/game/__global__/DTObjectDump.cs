public class DTObjectDump // TypeDefIndex: 10402
{
	// Fields
	private const int INDENTSPACES = 5;
	private string mIndent; // 0x10
	private StringBuilder mSB; // 0x18
	private object mObject; // 0x20

	// Methods

	// RVA: 0x48EBD0 Offset: 0x48D5D0 VA: 0x18048EBD0
	public void .ctor(object o, int indent = 0) { }

	// RVA: 0x48EBA0 Offset: 0x48D5A0 VA: 0x18048EBA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x48E220 Offset: 0x48CC20 VA: 0x18048E220
	private void AppendHeader(string name) { }

	// RVA: 0x48E2B0 Offset: 0x48CCB0 VA: 0x18048E2B0
	private void AppendMember(MemberInfo info) { }
}
