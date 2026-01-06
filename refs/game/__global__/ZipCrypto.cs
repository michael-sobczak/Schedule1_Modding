internal class ZipCrypto // TypeDefIndex: 16611
{
	// Fields
	private uint[] _Keys; // 0x10
	private CRC32 crc32; // 0x18

	// Properties
	private byte MagicByte { get; }

	// Methods

	// RVA: 0x1E387F0 Offset: 0x1E371F0 VA: 0x181E387F0
	private void .ctor() { }

	// RVA: 0x1E38540 Offset: 0x1E36F40 VA: 0x181E38540
	public static ZipCrypto ForWrite(string password) { }

	// RVA: 0x1E38300 Offset: 0x1E36D00 VA: 0x181E38300
	public static ZipCrypto ForRead(string password, ZipEntry e) { }

	// RVA: 0x1E388B0 Offset: 0x1E372B0 VA: 0x181E388B0
	private byte get_MagicByte() { }

	// RVA: 0x1E37EA0 Offset: 0x1E368A0 VA: 0x181E37EA0
	public byte[] DecryptMessage(byte[] cipherText, int length) { }

	// RVA: 0x1E38130 Offset: 0x1E36B30 VA: 0x181E38130
	public byte[] EncryptMessage(byte[] plainText, int length) { }

	// RVA: 0x1E38600 Offset: 0x1E37000 VA: 0x181E38600
	public void InitCipher(string passphrase) { }

	// RVA: 0x1E38710 Offset: 0x1E37110 VA: 0x181E38710
	private void UpdateKeys(byte byteValue) { }
}
