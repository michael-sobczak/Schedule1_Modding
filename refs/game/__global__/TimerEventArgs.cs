public class TimerEventArgs : EventArgs // TypeDefIndex: 17311
{
	// Fields
	private int _tickCount; // 0x10
	private bool _resetTickCount; // 0x14

	// Properties
	public bool ResetTickCount { get; set; }
	public int TickCount { get; }

	// Methods

	// RVA: 0x1E13C00 Offset: 0x1E12600 VA: 0x181E13C00
	public void .ctor(int tickCount) { }

	// RVA: 0x1667110 Offset: 0x1665B10 VA: 0x181667110
	public bool get_ResetTickCount() { }

	// RVA: 0x60D740 Offset: 0x60C140 VA: 0x18060D740
	public void set_ResetTickCount(bool value) { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public int get_TickCount() { }
}
