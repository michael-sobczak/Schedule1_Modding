internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 11424
{
	// Properties
	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1DF57A0 Offset: 0x1DF41A0 VA: 0x181DF57A0
	private XProcessingInstruction get_ProcessingInstruction() { }

	[NullableContext(1)]
	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0x1DF5720 Offset: 0x1DF4120 VA: 0x181DF5720 Slot: 15
	public override string get_LocalName() { }

	// RVA: 0x1DF5810 Offset: 0x1DF4210 VA: 0x181DF5810 Slot: 19
	public override string get_Value() { }

	// RVA: 0x1DF5890 Offset: 0x1DF4290 VA: 0x181DF5890 Slot: 20
	public override void set_Value(string value) { }
}
