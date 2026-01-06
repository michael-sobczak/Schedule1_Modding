public class DragEventArgs : EventArgs // TypeDefIndex: 5317
{
	// Fields
	internal int x; // 0x10
	internal int y; // 0x14
	internal int keystate; // 0x18
	internal DragDropEffects allowed_effect; // 0x1C
	internal DragDropEffects current_effect; // 0x20
	internal IDataObject data_object; // 0x28

	// Properties
	public DragDropEffects AllowedEffect { get; }
	public IDataObject Data { get; }
	public DragDropEffects Effect { get; }

	// Methods

	// RVA: 0x2315C20 Offset: 0x2314620 VA: 0x182315C20
	public void .ctor(IDataObject data, int keyState, int x, int y, DragDropEffects allowedEffect, DragDropEffects effect) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public DragDropEffects get_AllowedEffect() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public IDataObject get_Data() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public DragDropEffects get_Effect() { }
}
