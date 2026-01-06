internal struct Win32_MIB_IFROW // TypeDefIndex: 10159
{
	// Fields
	public char[] Name; // 0x0
	public int Index; // 0x8
	public NetworkInterfaceType Type; // 0xC
	public int Mtu; // 0x10
	public uint Speed; // 0x14
	public int PhysAddrLen; // 0x18
	public byte[] PhysAddr; // 0x20
	public uint AdminStatus; // 0x28
	public uint OperStatus; // 0x2C
	public uint LastChange; // 0x30
	public int InOctets; // 0x34
	public int InUcastPkts; // 0x38
	public int InNUcastPkts; // 0x3C
	public int InDiscards; // 0x40
	public int InErrors; // 0x44
	public int InUnknownProtos; // 0x48
	public int OutOctets; // 0x4C
	public int OutUcastPkts; // 0x50
	public int OutNUcastPkts; // 0x54
	public int OutDiscards; // 0x58
	public int OutErrors; // 0x5C
	public int OutQLen; // 0x60
	public int DescrLen; // 0x64
	public byte[] Descr; // 0x68
}
