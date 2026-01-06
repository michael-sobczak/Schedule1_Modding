public struct RenderQueueRange : IEquatable<RenderQueueRange> // TypeDefIndex: 12262
{
	// Fields
	private int m_LowerBound; // 0x0
	private int m_UpperBound; // 0x4
	private const int k_MinimumBound = 0;
	public static readonly int minimumBound; // 0x0
	private const int k_MaximumBound = 5000;
	public static readonly int maximumBound; // 0x4

	// Properties
	public static RenderQueueRange all { get; }
	public static RenderQueueRange opaque { get; }
	public static RenderQueueRange transparent { get; }

	// Methods

	// RVA: 0x2CF7A00 Offset: 0x2CF6400 VA: 0x182CF7A00
	public static RenderQueueRange get_all() { }

	// RVA: 0x2CF7A20 Offset: 0x2CF6420 VA: 0x182CF7A20
	public static RenderQueueRange get_opaque() { }

	// RVA: 0x2CF7A40 Offset: 0x2CF6440 VA: 0x182CF7A40
	public static RenderQueueRange get_transparent() { }

	// RVA: 0x2CF78C0 Offset: 0x2CF62C0 VA: 0x182CF78C0 Slot: 4
	public bool Equals(RenderQueueRange other) { }

	// RVA: 0x2CF78E0 Offset: 0x2CF62E0 VA: 0x182CF78E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CF79A0 Offset: 0x2CF63A0 VA: 0x182CF79A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CF7A60 Offset: 0x2CF6460 VA: 0x182CF7A60
	public static bool op_Equality(RenderQueueRange left, RenderQueueRange right) { }

	// RVA: 0x2CF79B0 Offset: 0x2CF63B0 VA: 0x182CF79B0
	private static void .cctor() { }
}
