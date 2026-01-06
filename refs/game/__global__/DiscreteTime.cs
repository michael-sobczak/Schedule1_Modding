internal struct DiscreteTime : IComparable // TypeDefIndex: 17403
{
	// Fields
	private const double k_Tick = 1E-12;
	public static readonly DiscreteTime kMaxTime; // 0x0
	private readonly long m_DiscreteTime; // 0x0

	// Properties
	public static double tickValue { get; }

	// Methods

	// RVA: 0x2C475B0 Offset: 0x2C45FB0 VA: 0x182C475B0
	public static double get_tickValue() { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(DiscreteTime time) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	private void .ctor(long time) { }

	// RVA: 0x2C47550 Offset: 0x2C45F50 VA: 0x182C47550
	public void .ctor(double time) { }

	// RVA: 0x2C47460 Offset: 0x2C45E60 VA: 0x182C47460
	public void .ctor(float time) { }

	// RVA: 0x2C474C0 Offset: 0x2C45EC0 VA: 0x182C474C0
	public void .ctor(int time) { }

	// RVA: 0x2C473F0 Offset: 0x2C45DF0 VA: 0x182C473F0
	public void .ctor(int frame, double fps) { }

	// RVA: 0x2C471F0 Offset: 0x2C45BF0 VA: 0x182C471F0
	public DiscreteTime OneTickBefore() { }

	// RVA: 0x2C471E0 Offset: 0x2C45BE0 VA: 0x182C471E0
	public DiscreteTime OneTickAfter() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public long GetTick() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static DiscreteTime FromTicks(long ticks) { }

	// RVA: 0x2C46E00 Offset: 0x2C45800 VA: 0x182C46E00 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0xC7BDF0 Offset: 0xC7A7F0 VA: 0x180C7BDF0
	public bool Equals(DiscreteTime other) { }

	// RVA: 0x2C46F30 Offset: 0x2C45930 VA: 0x182C46F30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2C46EA0 Offset: 0x2C458A0 VA: 0x182C46EA0
	private static long DoubleToDiscreteTime(double time) { }

	// RVA: 0x2C46FD0 Offset: 0x2C459D0 VA: 0x182C46FD0
	private static long FloatToDiscreteTime(float time) { }

	// RVA: 0x2C470D0 Offset: 0x2C45AD0 VA: 0x182C470D0
	private static long IntToDiscreteTime(int time) { }

	// RVA: 0x2C47310 Offset: 0x2C45D10 VA: 0x182C47310
	private static double ToDouble(long time) { }

	// RVA: 0x2C47330 Offset: 0x2C45D30 VA: 0x182C47330
	private static float ToFloat(long time) { }

	// RVA: 0x2C47650 Offset: 0x2C46050 VA: 0x182C47650
	public static double op_Explicit(DiscreteTime b) { }

	// RVA: 0x2C475C0 Offset: 0x2C45FC0 VA: 0x182C475C0
	public static float op_Explicit(DiscreteTime b) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static long op_Explicit(DiscreteTime b) { }

	// RVA: 0x2C476F0 Offset: 0x2C460F0 VA: 0x182C476F0
	public static DiscreteTime op_Explicit(double time) { }

	// RVA: 0x2C476A0 Offset: 0x2C460A0 VA: 0x182C476A0
	public static DiscreteTime op_Explicit(float time) { }

	// RVA: 0x2C47740 Offset: 0x2C46140 VA: 0x182C47740
	public static DiscreteTime op_Implicit(int time) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static DiscreteTime op_Explicit(long time) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x2C477C0 Offset: 0x2C461C0 VA: 0x182C477C0
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x1C8B8C0 Offset: 0x1C8A2C0 VA: 0x181C8B8C0
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x1C8B8E0 Offset: 0x1C8A2E0 VA: 0x181C8B8E0
	public static bool op_LessThan(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x1C8B8D0 Offset: 0x1C8A2D0 VA: 0x181C8B8D0
	public static bool op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x1C8B8B0 Offset: 0x1C8A2B0 VA: 0x181C8B8B0
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xF6CF60 Offset: 0xF6B960 VA: 0x180F6CF60
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xF6D430 Offset: 0xF6BE30 VA: 0x180F6D430
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x2C47390 Offset: 0x2C45D90 VA: 0x182C47390 Slot: 3
	public override string ToString() { }

	// RVA: 0x2C47060 Offset: 0x2C45A60 VA: 0x182C47060 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2C47180 Offset: 0x2C45B80 VA: 0x182C47180
	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x2C47120 Offset: 0x2C45B20 VA: 0x182C47120
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x2C472A0 Offset: 0x2C45CA0 VA: 0x182C472A0
	public static double SnapToNearestTick(double time) { }

	// RVA: 0x2C47200 Offset: 0x2C45C00 VA: 0x182C47200
	public static float SnapToNearestTick(float time) { }

	// RVA: 0x2C47080 Offset: 0x2C45A80 VA: 0x182C47080
	public static long GetNearestTick(double time) { }

	// RVA: 0x2C473B0 Offset: 0x2C45DB0 VA: 0x182C473B0
	private static void .cctor() { }
}
