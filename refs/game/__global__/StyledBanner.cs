public class StyledBanner : PropertyAttribute // TypeDefIndex: 19270
{
	// Fields
	public float colorR; // 0x10
	public float colorG; // 0x14
	public float colorB; // 0x18
	public string title; // 0x20
	public string helpURL; // 0x28

	// Methods

	// RVA: 0xBD91F0 Offset: 0xBD7BF0 VA: 0x180BD91F0
	public void .ctor(string title) { }

	// RVA: 0xBD9270 Offset: 0xBD7C70 VA: 0x180BD9270
	public void .ctor(float colorR, float colorG, float colorB, string title) { }

	// RVA: 0xBD90B0 Offset: 0xBD7AB0 VA: 0x180BD90B0
	public void .ctor(string title, string helpURL) { }

	// RVA: 0xBD9110 Offset: 0xBD7B10 VA: 0x180BD9110
	public void .ctor(float colorR, float colorG, float colorB, string title, string helpURL) { }

	// RVA: 0xBD9190 Offset: 0xBD7B90 VA: 0x180BD9190
	public void .ctor(string title, string subtitle, string helpURL) { }

	// RVA: 0xBD9310 Offset: 0xBD7D10 VA: 0x180BD9310
	public void .ctor(float colorR, float colorG, float colorB, string title, string subtitle, string helpURL) { }
}
