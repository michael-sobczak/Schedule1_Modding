public class PaintEventArgs : EventArgs, IDisposable // TypeDefIndex: 5529
{
	// Fields
	private Graphics graphics; // 0x10
	private Rectangle clip_rectangle; // 0x18
	internal bool Handled; // 0x28
	private bool disposed; // 0x29

	// Properties
	public Rectangle ClipRectangle { get; }
	public Graphics Graphics { get; }

	// Methods

	// RVA: 0x239CDC0 Offset: 0x239B7C0 VA: 0x18239CDC0
	public void .ctor(Graphics graphics, Rectangle clipRect) { }

	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public Rectangle get_ClipRectangle() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Graphics get_Graphics() { }

	// RVA: 0x239CD30 Offset: 0x239B730 VA: 0x18239CD30 Slot: 4
	public void Dispose() { }

	// RVA: 0x239CDA0 Offset: 0x239B7A0 VA: 0x18239CDA0
	internal Graphics SetGraphics(Graphics g) { }

	// RVA: 0x691670 Offset: 0x690070 VA: 0x180691670
	internal void SetClip(Rectangle clip) { }

	// RVA: 0x4D8670 Offset: 0x4D7070 VA: 0x1804D8670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x239CD20 Offset: 0x239B720 VA: 0x18239CD20 Slot: 5
	protected virtual void Dispose(bool disposing) { }
}
