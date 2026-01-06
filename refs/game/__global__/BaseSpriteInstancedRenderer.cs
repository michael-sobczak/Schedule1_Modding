public abstract class BaseSpriteInstancedRenderer : MonoBehaviour // TypeDefIndex: 481
{
	// Fields
	public const int kArrayMaxSprites = 1000;
	[CompilerGenerated]
	private int <maxSprites>k__BackingField; // 0x20
	[Tooltip("Mesh used to render the instances onto. If empty, a quad will be used.")]
	public Mesh modelMesh; // 0x28
	[Tooltip("Sky Studio sprite sheet animated shader material.")]
	public Material renderMaterial; // 0x30
	protected Queue<BaseSpriteItemData> m_Available; // 0x38
	protected HashSet<BaseSpriteItemData> m_Active; // 0x40
	private MaterialPropertyBlock m_PropertyBlock; // 0x48
	private Matrix4x4[] m_ModelMatrices; // 0x50
	private float[] m_StartTimes; // 0x58
	private float[] m_EndTimes; // 0x60
	protected SpriteSheetData m_SpriteSheetLayout; // 0x68
	protected Texture m_SpriteTexture; // 0x70
	protected Color m_TintColor; // 0x78
	[CompilerGenerated]
	private Camera <m_ViewerCamera>k__BackingField; // 0x88
	protected Mesh m_DefaltModelMesh; // 0x90

	// Properties
	public int maxSprites { get; set; }
	protected Camera m_ViewerCamera { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_maxSprites() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	protected void set_maxSprites(int value) { }

	[CompilerGenerated]
	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	protected Camera get_m_ViewerCamera() { }

	[CompilerGenerated]
	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	protected void set_m_ViewerCamera(Camera value) { }

	// RVA: 0xA7B8A0 Offset: 0xA7A2A0 VA: 0x180A7B8A0
	private void Start() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Bounds CalculateMeshBounds();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract BaseSpriteItemData CreateSpriteItemData();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool IsRenderingEnabled();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract int GetNextSpawnCount();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale);

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void ConfigureSpriteItemData(BaseSpriteItemData data);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock);

	// RVA: 0xA7A9E0 Offset: 0xA793E0 VA: 0x180A7A9E0
	private BaseSpriteItemData DequeueNextSpriteItemData() { }

	// RVA: 0xA7B800 Offset: 0xA7A200 VA: 0x180A7B800
	private void ReturnSpriteItemData(BaseSpriteItemData splash) { }

	// RVA: 0xA7B0B0 Offset: 0xA79AB0 VA: 0x180A7B0B0 Slot: 12
	protected virtual void LateUpdate() { }

	// RVA: 0xA7AD60 Offset: 0xA79760 VA: 0x180A7AD60
	private void GenerateNewSprites() { }

	// RVA: 0xA7A860 Offset: 0xA79260 VA: 0x180A7A860
	private void AdvanceAllSprites() { }

	// RVA: 0xA7B120 Offset: 0xA79B20 VA: 0x180A7B120
	private void RenderAllSprites() { }

	// RVA: 0xA7AFE0 Offset: 0xA799E0 VA: 0x180A7AFE0
	protected Mesh GetMesh() { }

	// RVA: 0xA7AA90 Offset: 0xA79490 VA: 0x180A7AA90 Slot: 13
	protected virtual Mesh GenerateMesh() { }

	// RVA: 0xA7B940 Offset: 0xA7A340 VA: 0x180A7B940
	protected void .ctor() { }
}
