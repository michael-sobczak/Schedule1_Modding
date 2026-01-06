public class RawImage : MaskableGraphic // TypeDefIndex: 16459
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("m_Tex")]
	private Texture m_Texture; // 0xE0
	[SerializeField]
	private Rect m_UVRect; // 0xE8

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x2F2F960 Offset: 0x2F2E360 VA: 0x182F2F960
	protected void .ctor() { }

	// RVA: 0x2F2F990 Offset: 0x2F2E390 VA: 0x182F2F990 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	public Texture get_texture() { }

	// RVA: 0x2F2FB10 Offset: 0x2F2E510 VA: 0x182F2FB10
	public void set_texture(Texture value) { }

	// RVA: 0x5056E0 Offset: 0x5040E0 VA: 0x1805056E0
	public Rect get_uvRect() { }

	// RVA: 0x2F2FBD0 Offset: 0x2F2E5D0 VA: 0x182F2FBD0
	public void set_uvRect(Rect value) { }

	// RVA: 0x2F2F800 Offset: 0x2F2E200 VA: 0x182F2F800 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x2F2F3D0 Offset: 0x2F2DDD0 VA: 0x182F2F3D0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x2DA5030 Offset: 0x2DA3A30 VA: 0x182DA5030 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}
