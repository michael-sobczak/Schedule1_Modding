internal struct XGCValues // TypeDefIndex: 5789
{
	// Fields
	internal GXFunction function; // 0x0
	internal IntPtr plane_mask; // 0x8
	internal IntPtr foreground; // 0x10
	internal IntPtr background; // 0x18
	internal int line_width; // 0x20
	internal GCLineStyle line_style; // 0x24
	internal GCCapStyle cap_style; // 0x28
	internal GCJoinStyle join_style; // 0x2C
	internal GCFillStyle fill_style; // 0x30
	internal GCFillRule fill_rule; // 0x34
	internal GCArcMode arc_mode; // 0x38
	internal IntPtr tile; // 0x40
	internal IntPtr stipple; // 0x48
	internal int ts_x_origin; // 0x50
	internal int ts_y_origin; // 0x54
	internal IntPtr font; // 0x58
	internal GCSubwindowMode subwindow_mode; // 0x60
	internal bool graphics_exposures; // 0x64
	internal int clip_x_origin; // 0x68
	internal int clib_y_origin; // 0x6C
	internal IntPtr clip_mask; // 0x70
	internal int dash_offset; // 0x78
	internal byte dashes; // 0x7C
}
