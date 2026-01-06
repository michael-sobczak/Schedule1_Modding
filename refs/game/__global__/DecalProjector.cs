public class DecalProjector : MonoBehaviour // TypeDefIndex: 8835
{
	// Fields
	[CompilerGenerated]
	private static DecalProjector.DecalProjectorAction onDecalAdd; // 0x0
	[CompilerGenerated]
	private static DecalProjector.DecalProjectorAction onDecalRemove; // 0x8
	[CompilerGenerated]
	private static DecalProjector.DecalProjectorAction onDecalPropertyChange; // 0x10
	[CompilerGenerated]
	private static Action onAllDecalPropertyChange; // 0x18
	[CompilerGenerated]
	private static DecalProjector.DecalProjectorAction onDecalMaterialChange; // 0x20
	[CompilerGenerated]
	private static Material <defaultMaterial>k__BackingField; // 0x28
	[CompilerGenerated]
	private DecalEntity <decalEntity>k__BackingField; // 0x20
	[SerializeField]
	private Material m_Material; // 0x28
	[SerializeField]
	private float m_DrawDistance; // 0x30
	[SerializeField]
	[Range(0, 1)]
	private float m_FadeScale; // 0x34
	[SerializeField]
	[Range(0, 180)]
	private float m_StartAngleFade; // 0x38
	[SerializeField]
	[Range(0, 180)]
	private float m_EndAngleFade; // 0x3C
	[SerializeField]
	private Vector2 m_UVScale; // 0x40
	[SerializeField]
	private Vector2 m_UVBias; // 0x48
	[SerializeField]
	private uint m_DecalLayerMask; // 0x50
	[SerializeField]
	private DecalScaleMode m_ScaleMode; // 0x54
	[SerializeField]
	internal Vector3 m_Offset; // 0x58
	[SerializeField]
	internal Vector3 m_Size; // 0x64
	[SerializeField]
	[Range(0, 1)]
	private float m_FadeFactor; // 0x70
	private Material m_OldMaterial; // 0x78

	// Properties
	internal static Material defaultMaterial { get; set; }
	internal static bool isSupported { get; }
	internal DecalEntity decalEntity { get; set; }
	public Material material { get; set; }
	public float drawDistance { get; set; }
	public float fadeScale { get; set; }
	public float startAngleFade { get; set; }
	public float endAngleFade { get; set; }
	public Vector2 uvScale { get; set; }
	public Vector2 uvBias { get; set; }
	public uint renderingLayerMask { get; set; }
	public DecalScaleMode scaleMode { get; set; }
	public Vector3 pivot { get; set; }
	public Vector3 size { get; set; }
	public float fadeFactor { get; set; }
	internal Vector3 effectiveScale { get; }
	internal Vector3 decalSize { get; }
	internal Vector3 decalOffset { get; }
	internal Vector4 uvScaleBias { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2ACB380 Offset: 0x2AC9D80 VA: 0x182ACB380
	internal static void add_onDecalAdd(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB930 Offset: 0x2ACA330 VA: 0x182ACB930
	internal static void remove_onDecalAdd(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB5C0 Offset: 0x2AC9FC0 VA: 0x182ACB5C0
	internal static void add_onDecalRemove(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACBB70 Offset: 0x2ACA570 VA: 0x182ACBB70
	internal static void remove_onDecalRemove(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB500 Offset: 0x2AC9F00 VA: 0x182ACB500
	internal static void add_onDecalPropertyChange(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACBAB0 Offset: 0x2ACA4B0 VA: 0x182ACBAB0
	internal static void remove_onDecalPropertyChange(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB2C0 Offset: 0x2AC9CC0 VA: 0x182ACB2C0
	internal static void add_onAllDecalPropertyChange(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB870 Offset: 0x2ACA270 VA: 0x182ACB870
	internal static void remove_onAllDecalPropertyChange(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB440 Offset: 0x2AC9E40 VA: 0x182ACB440
	internal static void add_onDecalMaterialChange(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB9F0 Offset: 0x2ACA3F0 VA: 0x182ACB9F0
	internal static void remove_onDecalMaterialChange(DecalProjector.DecalProjectorAction value) { }

	[CompilerGenerated]
	// RVA: 0x2ACB6C0 Offset: 0x2ACA0C0 VA: 0x182ACB6C0
	internal static Material get_defaultMaterial() { }

	[CompilerGenerated]
	// RVA: 0x2ACBC30 Offset: 0x2ACA630 VA: 0x182ACBC30
	internal static void set_defaultMaterial(Material value) { }

	// RVA: 0x2ACB790 Offset: 0x2ACA190 VA: 0x182ACB790
	internal static bool get_isSupported() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal DecalEntity get_decalEntity() { }

	[CompilerGenerated]
	// RVA: 0x4F58D0 Offset: 0x4F42D0 VA: 0x1804F58D0
	internal void set_decalEntity(DecalEntity value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Material get_material() { }

	// RVA: 0x2ACBD60 Offset: 0x2ACA760 VA: 0x182ACBD60
	public void set_material(Material value) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_drawDistance() { }

	// RVA: 0x2ACBC90 Offset: 0x2ACA690 VA: 0x182ACBC90
	public void set_drawDistance(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_fadeScale() { }

	// RVA: 0x2ACBD20 Offset: 0x2ACA720 VA: 0x182ACBD20
	public void set_fadeScale(float value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_startAngleFade() { }

	// RVA: 0x2ACBDE0 Offset: 0x2ACA7E0 VA: 0x182ACBDE0
	public void set_startAngleFade(float value) { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_endAngleFade() { }

	// RVA: 0x2ACBCB0 Offset: 0x2ACA6B0 VA: 0x182ACBCB0
	public void set_endAngleFade(float value) { }

	// RVA: 0x2ACB850 Offset: 0x2ACA250 VA: 0x182ACB850
	public Vector2 get_uvScale() { }

	// RVA: 0x2ACBE30 Offset: 0x2ACA830 VA: 0x182ACBE30
	public void set_uvScale(Vector2 value) { }

	// RVA: 0x2ACB810 Offset: 0x2ACA210 VA: 0x182ACB810
	public Vector2 get_uvBias() { }

	// RVA: 0x2ACBE20 Offset: 0x2ACA820 VA: 0x182ACBE20
	public void set_uvBias(Vector2 value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public uint get_renderingLayerMask() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_renderingLayerMask(uint value) { }

	// RVA: 0x4C3B40 Offset: 0x4C2540 VA: 0x1804C3B40
	public DecalScaleMode get_scaleMode() { }

	// RVA: 0x2ACBDB0 Offset: 0x2ACA7B0 VA: 0x182ACBDB0
	public void set_scaleMode(DecalScaleMode value) { }

	// RVA: 0x2ACB7D0 Offset: 0x2ACA1D0 VA: 0x182ACB7D0
	public Vector3 get_pivot() { }

	// RVA: 0x2ACBD90 Offset: 0x2ACA790 VA: 0x182ACBD90
	public void set_pivot(Vector3 value) { }

	// RVA: 0x2ACB7F0 Offset: 0x2ACA1F0 VA: 0x182ACB7F0
	public Vector3 get_size() { }

	// RVA: 0x2ACBDC0 Offset: 0x2ACA7C0 VA: 0x182ACBDC0
	public void set_size(Vector3 value) { }

	// RVA: 0x4CD9D0 Offset: 0x4CC3D0 VA: 0x1804CD9D0
	public float get_fadeFactor() { }

	// RVA: 0x2ACBCE0 Offset: 0x2ACA6E0 VA: 0x182ACBCE0
	public void set_fadeFactor(float value) { }

	// RVA: 0x2ACB700 Offset: 0x2ACA100 VA: 0x182ACB700
	internal Vector3 get_effectiveScale() { }

	// RVA: 0x2ACB6A0 Offset: 0x2ACA0A0 VA: 0x182ACB6A0
	internal Vector3 get_decalSize() { }

	// RVA: 0x2ACB680 Offset: 0x2ACA080 VA: 0x182ACB680
	internal Vector3 get_decalOffset() { }

	// RVA: 0x2ACB830 Offset: 0x2ACA230 VA: 0x182ACB830
	internal Vector4 get_uvScaleBias() { }

	// RVA: 0x2ACAE80 Offset: 0x2AC9880 VA: 0x182ACAE80
	private void InitMaterial() { }

	// RVA: 0x2ACB050 Offset: 0x2AC9A50 VA: 0x182ACB050
	private void OnEnable() { }

	// RVA: 0x2ACAFF0 Offset: 0x2AC99F0 VA: 0x182ACAFF0
	private void OnDisable() { }

	// RVA: 0x2ACB100 Offset: 0x2AC9B00 VA: 0x182ACB100
	internal void OnValidate() { }

	// RVA: 0x2ACAED0 Offset: 0x2AC98D0 VA: 0x182ACAED0
	public bool IsValid() { }

	// RVA: 0x2ACB1F0 Offset: 0x2AC9BF0 VA: 0x182ACB1F0
	internal static void UpdateAllDecalProperties() { }

	// RVA: 0x2ACB240 Offset: 0x2AC9C40 VA: 0x182ACB240
	public void .ctor() { }
}
