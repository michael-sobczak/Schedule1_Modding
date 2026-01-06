internal struct XWindowAttributes // TypeDefIndex: 5762
{
	// Fields
	internal int x; // 0x0
	internal int y; // 0x4
	internal int width; // 0x8
	internal int height; // 0xC
	internal int border_width; // 0x10
	internal int depth; // 0x14
	internal IntPtr visual; // 0x18
	internal IntPtr root; // 0x20
	internal int c_class; // 0x28
	internal Gravity bit_gravity; // 0x2C
	internal Gravity win_gravity; // 0x30
	internal int backing_store; // 0x34
	internal IntPtr backing_planes; // 0x38
	internal IntPtr backing_pixel; // 0x40
	internal bool save_under; // 0x48
	internal IntPtr colormap; // 0x50
	internal bool map_installed; // 0x58
	internal MapState map_state; // 0x5C
	internal IntPtr all_event_masks; // 0x60
	internal IntPtr your_event_mask; // 0x68
	internal IntPtr do_not_propagate_mask; // 0x70
	internal bool override_direct; // 0x78
	internal IntPtr screen; // 0x80

	// Methods

	// RVA: 0x227ED70 Offset: 0x227D770 VA: 0x18227ED70 Slot: 3
	public override string ToString() { }
}
