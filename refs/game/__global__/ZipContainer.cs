internal class ZipContainer // TypeDefIndex: 16630
{
	// Fields
	private ZipFile _zf; // 0x10
	private ZipOutputStream _zos; // 0x18
	private ZipInputStream _zis; // 0x20

	// Properties
	public ZipFile ZipFile { get; }
	public ZipOutputStream ZipOutputStream { get; }
	public string Name { get; }
	public string Password { get; }
	public Zip64Option Zip64 { get; }
	public int BufferSize { get; }
	public ParallelDeflateOutputStream ParallelDeflater { get; set; }
	public long ParallelDeflateThreshold { get; }
	public int ParallelDeflateMaxBufferPairs { get; }
	public int CodecBufferSize { get; }
	public CompressionStrategy Strategy { get; }
	public Zip64Option UseZip64WhenSaving { get; }
	public Encoding AlternateEncoding { get; }
	public Encoding DefaultEncoding { get; }
	public ZipOption AlternateEncodingUsage { get; }
	public Stream ReadStream { get; }

	// Methods

	// RVA: 0x1E4A320 Offset: 0x1E48D20 VA: 0x181E4A320
	public void .ctor(object o) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ZipFile get_ZipFile() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ZipOutputStream get_ZipOutputStream() { }

	// RVA: 0x1E4A720 Offset: 0x1E49120 VA: 0x181E4A720
	public string get_Name() { }

	// RVA: 0x1E4A880 Offset: 0x1E49280 VA: 0x181E4A880
	public string get_Password() { }

	// RVA: 0x1E4A990 Offset: 0x1E49390 VA: 0x181E4A990
	public Zip64Option get_Zip64() { }

	// RVA: 0x1E4A5A0 Offset: 0x1E48FA0 VA: 0x181E4A5A0
	public int get_BufferSize() { }

	// RVA: 0x1E4A830 Offset: 0x1E49230 VA: 0x181E4A830
	public ParallelDeflateOutputStream get_ParallelDeflater() { }

	// RVA: 0x1E4AA10 Offset: 0x1E49410 VA: 0x181E4AA10
	public void set_ParallelDeflater(ParallelDeflateOutputStream value) { }

	// RVA: 0x1E4A7F0 Offset: 0x1E491F0 VA: 0x181E4A7F0
	public long get_ParallelDeflateThreshold() { }

	// RVA: 0x1E4A7B0 Offset: 0x1E491B0 VA: 0x181E4A7B0
	public int get_ParallelDeflateMaxBufferPairs() { }

	// RVA: 0x1E4A620 Offset: 0x1E49020 VA: 0x181E4A620
	public int get_CodecBufferSize() { }

	// RVA: 0x1E4A910 Offset: 0x1E49310 VA: 0x181E4A910
	public CompressionStrategy get_Strategy() { }

	// RVA: 0x1E4A950 Offset: 0x1E49350 VA: 0x181E4A950
	public Zip64Option get_UseZip64WhenSaving() { }

	// RVA: 0x1E4A570 Offset: 0x1E48F70 VA: 0x181E4A570
	public Encoding get_AlternateEncoding() { }

	// RVA: 0x1E4A670 Offset: 0x1E49070 VA: 0x181E4A670
	public Encoding get_DefaultEncoding() { }

	// RVA: 0x1E4A540 Offset: 0x1E48F40 VA: 0x181E4A540
	public ZipOption get_AlternateEncodingUsage() { }

	// RVA: 0x1E4A8D0 Offset: 0x1E492D0 VA: 0x181E4A8D0
	public Stream get_ReadStream() { }
}
