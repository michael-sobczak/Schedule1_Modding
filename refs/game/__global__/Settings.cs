public class Settings // TypeDefIndex: 12649
{
	// Fields
	public WritePermission WritePermission; // 0x10
	public ReadPermission ReadPermission; // 0x11
	public float SendRate; // 0x14
	public Channel Channel; // 0x18

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0xD3B880 Offset: 0xD3A280 VA: 0x180D3B880
	public void .ctor(WritePermission writePermission, ReadPermission readPermission, float sendRate, Channel channel) { }

	// RVA: 0xD3B800 Offset: 0xD3A200 VA: 0x180D3B800
	public void .ctor(float sendTickrate) { }

	// RVA: 0xD3B830 Offset: 0xD3A230 VA: 0x180D3B830
	public void .ctor(ReadPermission readPermission, float sendRate, Channel channel) { }
}
