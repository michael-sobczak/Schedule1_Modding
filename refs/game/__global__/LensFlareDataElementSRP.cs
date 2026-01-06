public sealed class LensFlareDataElementSRP // TypeDefIndex: 13786
{
	// Fields
	public bool visible; // 0x10
	public float position; // 0x14
	public Vector2 positionOffset; // 0x18
	public float angularOffset; // 0x20
	public Vector2 translationScale; // 0x24
	[FormerlySerializedAs("localIntensity")]
	[SerializeField]
	[Min(0)]
	private float m_LocalIntensity; // 0x2C
	public Texture lensFlareTexture; // 0x30
	public float uniformScale; // 0x38
	public Vector2 sizeXY; // 0x3C
	public bool allowMultipleElement; // 0x44
	[Min(1)]
	[SerializeField]
	[FormerlySerializedAs("count")]
	private int m_Count; // 0x48
	public bool preserveAspectRatio; // 0x4C
	public float rotation; // 0x50
	public Color tint; // 0x54
	public SRPLensFlareBlendMode blendMode; // 0x64
	public bool autoRotate; // 0x68
	public SRPLensFlareType flareType; // 0x6C
	public bool modulateByLightColor; // 0x70
	[SerializeField]
	private bool isFoldOpened; // 0x71
	public SRPLensFlareDistribution distribution; // 0x74
	public float lengthSpread; // 0x78
	public AnimationCurve positionCurve; // 0x80
	public AnimationCurve scaleCurve; // 0x88
	public int seed; // 0x90
	public Gradient colorGradient; // 0x98
	[FormerlySerializedAs("intensityVariation")]
	[SerializeField]
	[Range(0, 1)]
	private float m_IntensityVariation; // 0xA0
	public Vector2 positionVariation; // 0xA4
	public float scaleVariation; // 0xAC
	public float rotationVariation; // 0xB0
	public bool enableRadialDistortion; // 0xB4
	public Vector2 targetSizeDistortion; // 0xB8
	public AnimationCurve distortionCurve; // 0xC0
	public bool distortionRelativeToCenter; // 0xC8
	[Range(0, 1)]
	[FormerlySerializedAs("fallOff")]
	[SerializeField]
	private float m_FallOff; // 0xCC
	[Range(0, 1)]
	[SerializeField]
	[FormerlySerializedAs("edgeOffset")]
	private float m_EdgeOffset; // 0xD0
	[SerializeField]
	[Min(3)]
	[FormerlySerializedAs("sideCount")]
	private int m_SideCount; // 0xD4
	[Range(0, 1)]
	[SerializeField]
	[FormerlySerializedAs("sdfRoundness")]
	private float m_SdfRoundness; // 0xD8
	public bool inverseSDF; // 0xDC
	public float uniformAngle; // 0xE0
	public AnimationCurve uniformAngleCurve; // 0xE8

	// Properties
	public float localIntensity { get; set; }
	public int count { get; set; }
	public float intensityVariation { get; set; }
	public float fallOff { get; set; }
	public float edgeOffset { get; set; }
	public int sideCount { get; set; }
	public float sdfRoundness { get; set; }

	// Methods

	// RVA: 0x2A1ECE0 Offset: 0x2A1D6E0 VA: 0x182A1ECE0
	public void .ctor() { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_localIntensity() { }

	// RVA: 0x2A1F4E0 Offset: 0x2A1DEE0 VA: 0x182A1F4E0
	public void set_localIntensity(float value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_count() { }

	// RVA: 0x2A1F450 Offset: 0x2A1DE50 VA: 0x182A1F450
	public void set_count(int value) { }

	// RVA: 0x8B3450 Offset: 0x8B1E50 VA: 0x1808B3450
	public float get_intensityVariation() { }

	// RVA: 0x2A1F4C0 Offset: 0x2A1DEC0 VA: 0x182A1F4C0
	public void set_intensityVariation(float value) { }

	// RVA: 0x673C50 Offset: 0x672650 VA: 0x180673C50
	public float get_fallOff() { }

	// RVA: 0x2A1F490 Offset: 0x2A1DE90 VA: 0x182A1F490
	public void set_fallOff(float value) { }

	// RVA: 0x510840 Offset: 0x50F240 VA: 0x180510840
	public float get_edgeOffset() { }

	// RVA: 0x2A1F460 Offset: 0x2A1DE60 VA: 0x182A1F460
	public void set_edgeOffset(float value) { }

	// RVA: 0x1A3ADA0 Offset: 0x1A397A0 VA: 0x181A3ADA0
	public int get_sideCount() { }

	// RVA: 0x2A1F520 Offset: 0x2A1DF20 VA: 0x182A1F520
	public void set_sideCount(int value) { }

	// RVA: 0x537070 Offset: 0x535A70 VA: 0x180537070
	public float get_sdfRoundness() { }

	// RVA: 0x2A1F4F0 Offset: 0x2A1DEF0 VA: 0x182A1F4F0
	public void set_sdfRoundness(float value) { }
}
