public struct PlayableBinding // TypeDefIndex: 12304
{
	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Properties
	public Object sourceObject { get; }

	// Methods

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0
	public Object get_sourceObject() { }

	// RVA: 0x2CF2E20 Offset: 0x2CF1820 VA: 0x182CF2E20
	internal PlayableOutput CreateOutput(PlayableGraph graph) { }

	[VisibleToOtherModules]
	// RVA: 0x2CF2D80 Offset: 0x2CF1780 VA: 0x182CF2D80
	internal static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction) { }

	// RVA: 0x2CF2F10 Offset: 0x2CF1910 VA: 0x182CF2F10
	private static void .cctor() { }
}
