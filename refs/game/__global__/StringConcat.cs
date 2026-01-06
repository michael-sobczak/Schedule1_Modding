public struct StringConcat // TypeDefIndex: 8232
{
	// Fields
	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x256ACC0 Offset: 0x25696C0 VA: 0x18256ACC0
	public void Clear() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	internal int get_Count() { }

	// RVA: 0x256AE80 Offset: 0x2569880 VA: 0x18256AE80
	public string GetResult() { }

	// RVA: 0x256ACE0 Offset: 0x25696E0 VA: 0x18256ACE0
	internal void ConcatNoDelimiter(string s) { }
}
