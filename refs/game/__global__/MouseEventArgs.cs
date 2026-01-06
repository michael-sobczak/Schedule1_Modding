public class MouseEventArgs : EventArgs // TypeDefIndex: 5519
{
	// Fields
	private MouseButtons buttons; // 0x10
	private int clicks; // 0x14
	private int delta; // 0x18
	private int x; // 0x1C
	private int y; // 0x20

	// Properties
	public MouseButtons Button { get; }
	public int Clicks { get; }
	public int Delta { get; }
	public int X { get; }
	public int Y { get; }
	public Point Location { get; }

	// Methods

	// RVA: 0x2398D30 Offset: 0x2397730 VA: 0x182398D30
	public void .ctor(MouseButtons button, int clicks, int x, int y, int delta) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public MouseButtons get_Button() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_Clicks() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Delta() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_X() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_Y() { }

	// RVA: 0x2398DC0 Offset: 0x23977C0 VA: 0x182398DC0
	public Point get_Location() { }
}
