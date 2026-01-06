public sealed class CspParameters // TypeDefIndex: 4191
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public CspProviderFlags get_Flags() { }

	// RVA: 0x1AE2BB0 Offset: 0x1AE15B0 VA: 0x181AE2BB0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x1AE2A50 Offset: 0x1AE1450 VA: 0x181AE2A50
	public void .ctor() { }

	// RVA: 0x1AE29F0 Offset: 0x1AE13F0 VA: 0x181AE29F0
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x1AE2B30 Offset: 0x1AE1530 VA: 0x181AE2B30
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x1AE2AB0 Offset: 0x1AE14B0 VA: 0x181AE2AB0
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}
