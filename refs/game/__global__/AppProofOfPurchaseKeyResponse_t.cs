public struct AppProofOfPurchaseKeyResponse_t // TypeDefIndex: 14361
{
	// Fields
	public const int k_iCallback = 1021;
	public EResult m_eResult; // 0x0
	public uint m_nAppID; // 0x4
	public uint m_cchKeyLength; // 0x8
	private byte[] m_rgchKey_; // 0x10

	// Properties
	public string m_rgchKey { get; set; }

	// Methods

	// RVA: 0xC7BC10 Offset: 0xC7A610 VA: 0x180C7BC10
	public string get_m_rgchKey() { }

	// RVA: 0xC7BC90 Offset: 0xC7A690 VA: 0x180C7BC90
	public void set_m_rgchKey(string value) { }
}
