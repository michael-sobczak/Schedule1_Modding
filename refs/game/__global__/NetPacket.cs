internal sealed class NetPacket // TypeDefIndex: 12412
{
	// Fields
	private static readonly int PropertiesCount; // 0x0
	private static readonly int[] HeaderSizes; // 0x8
	public byte[] RawData; // 0x10
	public int Size; // 0x18
	public object UserData; // 0x20
	public NetPacket Next; // 0x28

	// Properties
	public PacketProperty Property { get; set; }
	public byte ConnectionNumber { get; set; }
	public ushort Sequence { get; set; }
	public bool IsFragmented { get; }
	public byte ChannelId { get; set; }
	public ushort FragmentId { get; set; }
	public ushort FragmentPart { get; set; }
	public ushort FragmentsTotal { get; set; }

	// Methods

	// RVA: 0xD00AA0 Offset: 0xCFF4A0 VA: 0x180D00AA0
	private static void .cctor() { }

	// RVA: 0xD01000 Offset: 0xCFFA00 VA: 0x180D01000
	public PacketProperty get_Property() { }

	// RVA: 0xD01180 Offset: 0xCFFB80 VA: 0x180D01180
	public void set_Property(PacketProperty value) { }

	// RVA: 0xD00F40 Offset: 0xCFF940 VA: 0x180D00F40
	public byte get_ConnectionNumber() { }

	// RVA: 0xD01080 Offset: 0xCFFA80 VA: 0x180D01080
	public void set_ConnectionNumber(byte value) { }

	// RVA: 0xD01030 Offset: 0xCFFA30 VA: 0x180D01030
	public ushort get_Sequence() { }

	// RVA: 0xD011C0 Offset: 0xCFFBC0 VA: 0x180D011C0
	public void set_Sequence(ushort value) { }

	// RVA: 0xD00FD0 Offset: 0xCFF9D0 VA: 0x180D00FD0
	public bool get_IsFragmented() { }

	// RVA: 0xD00970 Offset: 0xCFF370 VA: 0x180D00970
	public void MarkFragmented() { }

	// RVA: 0xD00F10 Offset: 0xCFF910 VA: 0x180D00F10
	public byte get_ChannelId() { }

	// RVA: 0xD01050 Offset: 0xCFFA50 VA: 0x180D01050
	public void set_ChannelId(byte value) { }

	// RVA: 0xD00F70 Offset: 0xCFF970 VA: 0x180D00F70
	public ushort get_FragmentId() { }

	// RVA: 0xD010C0 Offset: 0xCFFAC0 VA: 0x180D010C0
	public void set_FragmentId(ushort value) { }

	// RVA: 0xD00F90 Offset: 0xCFF990 VA: 0x180D00F90
	public ushort get_FragmentPart() { }

	// RVA: 0xD01100 Offset: 0xCFFB00 VA: 0x180D01100
	public void set_FragmentPart(ushort value) { }

	// RVA: 0xD00FB0 Offset: 0xCFF9B0 VA: 0x180D00FB0
	public ushort get_FragmentsTotal() { }

	// RVA: 0xD01140 Offset: 0xCFFB40 VA: 0x180D01140
	public void set_FragmentsTotal(ushort value) { }

	// RVA: 0xD00D90 Offset: 0xCFF790 VA: 0x180D00D90
	public void .ctor(int size) { }

	// RVA: 0xD00E00 Offset: 0xCFF800 VA: 0x180D00E00
	public void .ctor(PacketProperty property, int size) { }

	// RVA: 0xD00870 Offset: 0xCFF270 VA: 0x180D00870
	public static int GetHeaderSize(PacketProperty property) { }

	// RVA: 0xD008E0 Offset: 0xCFF2E0 VA: 0x180D008E0
	public int GetHeaderSize() { }

	// RVA: 0xD009A0 Offset: 0xCFF3A0 VA: 0x180D009A0
	public bool Verify() { }
}
