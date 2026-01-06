public struct SteamIPAddress_t // TypeDefIndex: 14813
{
	// Fields
	private long m_ip0; // 0x0
	private long m_ip1; // 0x8
	private ESteamIPType m_eType; // 0x10

	// Methods

	// RVA: 0xCBE800 Offset: 0xCBD200 VA: 0x180CBE800
	public void .ctor(IPAddress iPAddress) { }

	// RVA: 0xCBE670 Offset: 0xCBD070 VA: 0x180CBE670
	public IPAddress ToIPAddress() { }

	// RVA: 0xCBE7C0 Offset: 0xCBD1C0 VA: 0x180CBE7C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public ESteamIPType GetIPType() { }

	// RVA: 0xCBE650 Offset: 0xCBD050 VA: 0x180CBE650
	public bool IsSet() { }
}
