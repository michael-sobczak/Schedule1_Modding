public class Timer : Component // TypeDefIndex: 5600
{
	// Fields
	private bool enabled; // 0x28
	private int interval; // 0x2C
	private DateTime expires; // 0x30
	internal Thread thread; // 0x38
	internal bool Busy; // 0x40
	internal IntPtr window; // 0x48
	internal static readonly int Minimum; // 0x0
	private EventHandler Tick; // 0x50

	// Properties
	[DefaultValue(False)]
	public virtual bool Enabled { get; set; }
	[DefaultValue(100)]
	public int Interval { get; set; }
	internal DateTime Expires { get; }

	// Methods

	// RVA: 0x22241F0 Offset: 0x2222BF0 VA: 0x1822241F0
	public void .ctor() { }

	// RVA: 0x22241B0 Offset: 0x2222BB0 VA: 0x1822241B0
	private static void .cctor() { }

	// RVA: 0x2224250 Offset: 0x2222C50 VA: 0x182224250
	public void add_Tick(EventHandler value) { }

	// RVA: 0x22242F0 Offset: 0x2222CF0 VA: 0x1822242F0
	public void remove_Tick(EventHandler value) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120 Slot: 14
	public virtual bool get_Enabled() { }

	// RVA: 0x2224390 Offset: 0x2222D90 VA: 0x182224390 Slot: 15
	public virtual void set_Enabled(bool value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_Interval() { }

	// RVA: 0x2224510 Offset: 0x2222F10 VA: 0x182224510
	public void set_Interval(int value) { }

	// RVA: 0x2224030 Offset: 0x2222A30 VA: 0x182224030
	public void Start() { }

	// RVA: 0x2224050 Offset: 0x2222A50 VA: 0x182224050
	public void Stop() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal DateTime get_Expires() { }

	// RVA: 0x2224070 Offset: 0x2222A70 VA: 0x182224070 Slot: 3
	public override string ToString() { }

	// RVA: 0x22240F0 Offset: 0x2222AF0 VA: 0x1822240F0
	internal void Update(DateTime update) { }

	// RVA: 0x2223F90 Offset: 0x2222990 VA: 0x182223F90
	internal void FireTick() { }

	// RVA: 0x2224000 Offset: 0x2222A00 VA: 0x182224000 Slot: 16
	protected virtual void OnTick(EventArgs e) { }

	// RVA: 0x2223F60 Offset: 0x2222960 VA: 0x182223F60 Slot: 12
	protected override void Dispose(bool disposing) { }
}
