public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 4198
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	protected int get_BlockSizeValue() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x1AE6400 Offset: 0x1AE4E00 VA: 0x181AE6400
	private void UpdateIOPadBuffers() { }

	// RVA: 0x1AE6210 Offset: 0x1AE4C10 VA: 0x181AE6210
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x1AE6560 Offset: 0x1AE4F60 VA: 0x181AE6560 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x1AE65E0 Offset: 0x1AE4FE0 VA: 0x181AE65E0 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x1AE5CD0 Offset: 0x1AE46D0 VA: 0x181AE5CD0
	public static HMAC Create() { }

	// RVA: 0x1AE63A0 Offset: 0x1AE4DA0 VA: 0x181AE63A0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1AE5ED0 Offset: 0x1AE48D0 VA: 0x181AE5ED0 Slot: 16
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x1AE5FE0 Offset: 0x1AE49E0 VA: 0x181AE5FE0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1AE5DF0 Offset: 0x1AE47F0 VA: 0x181AE5DF0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AE6550 Offset: 0x1AE4F50 VA: 0x181AE6550
	protected void .ctor() { }
}
