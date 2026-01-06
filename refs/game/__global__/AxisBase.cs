public struct AxisBase // TypeDefIndex: 16145
{
	// Fields
	[Tooltip("The current value of the axis.")]
	[NoSaveDuringPlay]
	public float m_Value; // 0x0
	[Tooltip("The minimum value for the axis")]
	public float m_MinValue; // 0x4
	[Tooltip("The maximum value for the axis")]
	public float m_MaxValue; // 0x8
	[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
	public bool m_Wrap; // 0xC

	// Methods

	// RVA: 0xC0D220 Offset: 0xC0BC20 VA: 0x180C0D220
	public void Validate() { }
}
