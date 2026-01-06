internal class ButtonPainter // TypeDefIndex: 5900
{
	// Properties
	protected SystemResPool ResPool { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x22CE4C0 Offset: 0x22CCEC0 VA: 0x1822CE4C0
	protected SystemResPool get_ResPool() { }

	// RVA: 0x22CDAF0 Offset: 0x22CC4F0 VA: 0x1822CDAF0 Slot: 4
	public virtual void Draw(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor) { }

	// RVA: 0x22CD080 Offset: 0x22CBA80 VA: 0x1822CD080 Slot: 5
	public virtual void DrawFlat(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor, FlatButtonAppearance appearance) { }

	// RVA: 0x22CD600 Offset: 0x22CC000 VA: 0x1822CD600 Slot: 6
	public virtual void DrawPopup(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor) { }

	// RVA: 0x22CCF50 Offset: 0x22CB950 VA: 0x1822CCF50
	private static Color ChangeIntensity(Color baseColor, float percent) { }
}
