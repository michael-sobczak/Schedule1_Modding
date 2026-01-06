public class VectorImage : ScriptableObject // TypeDefIndex: 7018
{
	// Fields
	[SerializeField]
	internal int version; // 0x18
	[SerializeField]
	internal Texture2D atlas; // 0x20
	[SerializeField]
	internal VectorImageVertex[] vertices; // 0x28
	[SerializeField]
	internal ushort[] indices; // 0x30
	[SerializeField]
	internal GradientSettings[] settings; // 0x38
	[SerializeField]
	internal Vector2 size; // 0x40

	// Properties
	public float width { get; }
	public float height { get; }

	// Methods

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_width() { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_height() { }

	// RVA: 0x2DEF9B0 Offset: 0x2DEE3B0 VA: 0x182DEF9B0
	public void .ctor() { }
}
