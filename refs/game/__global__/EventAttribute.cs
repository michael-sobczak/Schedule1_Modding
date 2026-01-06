public sealed class EventAttribute : Attribute // TypeDefIndex: 4879
{
	// Fields
	[CompilerGenerated]
	private int <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private EventOpcode <Opcode>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28
	[CompilerGenerated]
	private EventTask <Task>k__BackingField; // 0x30

	// Properties
	private int EventId { set; }
	public EventLevel Level { set; }
	public EventKeywords Keywords { set; }
	public EventOpcode Opcode { set; }
	public string Message { set; }
	public EventTask Task { set; }

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	public void .ctor(int eventId) { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_EventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_Opcode(EventOpcode value) { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	public void set_Task(EventTask value) { }
}
