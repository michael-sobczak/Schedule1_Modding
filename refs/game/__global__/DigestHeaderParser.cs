internal class DigestHeaderParser // TypeDefIndex: 10052
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x25ADDF0 Offset: 0x25AC7F0 VA: 0x1825ADDF0
	public void .ctor(string header) { }

	// RVA: 0x1BA9EB0 Offset: 0x1BA88B0 VA: 0x181BA9EB0
	public string get_Realm() { }

	// RVA: 0x1BA9DC0 Offset: 0x1BA87C0 VA: 0x181BA9DC0
	public string get_Opaque() { }

	// RVA: 0x1BA9E20 Offset: 0x1BA8820 VA: 0x181BA9E20
	public string get_Nonce() { }

	// RVA: 0x1BA9E50 Offset: 0x1BA8850 VA: 0x181BA9E50
	public string get_Algorithm() { }

	// RVA: 0x1BA9E80 Offset: 0x1BA8880 VA: 0x181BA9E80
	public string get_QOP() { }

	// RVA: 0x25ADA70 Offset: 0x25AC470 VA: 0x1825ADA70
	public bool Parse() { }

	// RVA: 0x25ADC30 Offset: 0x25AC630 VA: 0x1825ADC30
	private void SkipWhitespace() { }

	// RVA: 0x25AD710 Offset: 0x25AC110 VA: 0x1825AD710
	private string GetKey() { }

	// RVA: 0x25AD7F0 Offset: 0x25AC1F0 VA: 0x1825AD7F0
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x25ADCA0 Offset: 0x25AC6A0 VA: 0x1825ADCA0
	private static void .cctor() { }
}
