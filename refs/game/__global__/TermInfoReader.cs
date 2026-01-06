internal class TermInfoReader // TypeDefIndex: 3879
{
	// Fields
	private int boolSize; // 0x10
	private int numSize; // 0x14
	private int strOffsets; // 0x18
	private byte[] buffer; // 0x20
	private int booleansOffset; // 0x28
	private int intOffset; // 0x2C

	// Methods

	// RVA: 0x1CCF7E0 Offset: 0x1CCE1E0 VA: 0x181CCF7E0
	public void .ctor(string term, string filename) { }

	// RVA: 0x1CCF740 Offset: 0x1CCE140 VA: 0x181CCF740
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x1CCEE00 Offset: 0x1CCD800 VA: 0x181CCEE00
	private void DetermineVersion(short magic) { }

	// RVA: 0x1CCF410 Offset: 0x1CCDE10 VA: 0x181CCF410
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x1CCF690 Offset: 0x1CCE090 VA: 0x181CCF690
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x1CCF350 Offset: 0x1CCDD50 VA: 0x181CCF350
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x1CCF1F0 Offset: 0x1CCDBF0 VA: 0x181CCF1F0
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x1CCEFE0 Offset: 0x1CCD9E0 VA: 0x181CCEFE0
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x1CCEEC0 Offset: 0x1CCD8C0 VA: 0x181CCEEC0
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x1CCF150 Offset: 0x1CCDB50 VA: 0x181CCF150
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x1CCEF20 Offset: 0x1CCD920 VA: 0x181CCEF20
	private byte[] GetStringBytes(byte[] buffer, int offset) { }
}
