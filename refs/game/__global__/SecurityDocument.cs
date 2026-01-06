internal sealed class SecurityDocument // TypeDefIndex: 4149
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x1AD7F00 Offset: 0x1AD6900 VA: 0x181AD7F00
	public void .ctor(int numData) { }

	// RVA: 0x1AD7BD0 Offset: 0x1AD65D0 VA: 0x181AD7BD0
	public void GuaranteeSize(int size) { }

	// RVA: 0x1AD74D0 Offset: 0x1AD5ED0 VA: 0x181AD74D0
	public void AddString(string str, ref int position) { }

	// RVA: 0x1AD7710 Offset: 0x1AD6110 VA: 0x181AD7710
	public void AppendString(string str, ref int position) { }

	// RVA: 0x1AD77B0 Offset: 0x1AD61B0 VA: 0x181AD77B0
	public static int EncodedStringSize(string str) { }

	// RVA: 0x1AD7820 Offset: 0x1AD6220 VA: 0x181AD7820
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x1AD7620 Offset: 0x1AD6020 VA: 0x181AD7620
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x1AD77F0 Offset: 0x1AD61F0 VA: 0x181AD77F0
	public SecurityElement GetRootElement() { }

	// RVA: 0x1AD77D0 Offset: 0x1AD61D0 VA: 0x181AD77D0
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x1AD7C80 Offset: 0x1AD6680 VA: 0x181AD7C80
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}
