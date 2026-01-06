public sealed class LineRenderer : Renderer // TypeDefIndex: 11664
{
	// Properties
	public float startWidth { set; }
	public float endWidth { set; }
	public bool useWorldSpace { get; set; }
	[NativeProperty("PositionsCount")]
	public int positionCount { set; }
	public bool generateLightingData { set; }
	public LineTextureMode textureMode { set; }

	// Methods

	// RVA: 0x2C90E60 Offset: 0x2C8F860 VA: 0x182C90E60
	public void set_startWidth(float value) { }

	// RVA: 0x2C90D80 Offset: 0x2C8F780 VA: 0x182C90D80
	public void set_endWidth(float value) { }

	// RVA: 0x2C90D40 Offset: 0x2C8F740 VA: 0x182C90D40
	public bool get_useWorldSpace() { }

	// RVA: 0x2C90EF0 Offset: 0x2C8F8F0 VA: 0x182C90EF0
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x2C90E20 Offset: 0x2C8F820 VA: 0x182C90E20
	public void set_positionCount(int value) { }

	// RVA: 0x2C90CA0 Offset: 0x2C8F6A0 VA: 0x182C90CA0
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x2C90DD0 Offset: 0x2C8F7D0 VA: 0x182C90DD0
	public void set_generateLightingData(bool value) { }

	// RVA: 0x2C90EB0 Offset: 0x2C8F8B0 VA: 0x182C90EB0
	public void set_textureMode(LineTextureMode value) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
	// RVA: 0x2C90CF0 Offset: 0x2C8F6F0 VA: 0x182C90CF0
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C90C50 Offset: 0x2C8F650 VA: 0x182C90C50
	private void SetPosition_Injected(int index, ref Vector3 position) { }
}
