public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters> // TypeDefIndex: 12241
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private LODParameters m_LODParameters; // 0x4
	private const int k_MaximumCullingPlaneCount = 10;
	public static readonly int maximumCullingPlaneCount; // 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x20
	private int m_CullingPlaneCount; // 0xC0
	private uint m_CullingMask; // 0xC4
	private ulong m_SceneMask; // 0xC8
	private ulong m_ViewID; // 0xD0
	private const int k_LayerCount = 32;
	public static readonly int layerCount; // 0x4
	[FixedBuffer(typeof(float), 32)]
	internal ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xD8
	private int m_LayerCull; // 0x158
	private Matrix4x4 m_CullingMatrix; // 0x15C
	private Vector3 m_Origin; // 0x19C
	private float m_ShadowDistance; // 0x1A8
	private float m_ShadowNearPlaneOffset; // 0x1AC
	private CullingOptions m_CullingOptions; // 0x1B0
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1B4
	private CameraProperties m_CameraProperties; // 0x1B8
	private float m_AccurateOcclusionThreshold; // 0x598
	private int m_MaximumPortalCullingJobs; // 0x59C
	private const int k_CullingJobCountLowerLimit = 1;
	private const int k_CullingJobCountUpperLimit = 16;
	private Matrix4x4 m_StereoViewMatrix; // 0x5A0
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5E0
	private float m_StereoSeparationDistance; // 0x620
	private int m_maximumVisibleLights; // 0x624
	private bool m_ConservativeEnclosingSphere; // 0x628
	private int m_NumIterationsEnclosingSphere; // 0x62C

	// Properties
	public int maximumVisibleLights { set; }
	public bool conservativeEnclosingSphere { set; }
	public int numIterationsEnclosingSphere { set; }
	public int cullingPlaneCount { get; }
	public bool isOrthographic { set; }
	public float shadowDistance { set; }
	public CullingOptions cullingOptions { get; set; }
	public ReflectionProbeSortingCriteria reflectionProbeSortingCriteria { set; }
	public Matrix4x4 stereoViewMatrix { set; }
	public Matrix4x4 stereoProjectionMatrix { get; set; }
	public float stereoSeparationDistance { set; }

	// Methods

	// RVA: 0x2CEB6F0 Offset: 0x2CEA0F0 VA: 0x182CEB6F0
	public void set_maximumVisibleLights(int value) { }

	// RVA: 0x2CEB680 Offset: 0x2CEA080 VA: 0x182CEB680
	public void set_conservativeEnclosingSphere(bool value) { }

	// RVA: 0x2CEB700 Offset: 0x2CEA100 VA: 0x182CEB700
	public void set_numIterationsEnclosingSphere(int value) { }

	// RVA: 0x2CEB640 Offset: 0x2CEA040 VA: 0x182CEB640
	public int get_cullingPlaneCount() { }

	// RVA: 0x2CEB690 Offset: 0x2CEA090 VA: 0x182CEB690
	public void set_isOrthographic(bool value) { }

	// RVA: 0x2CEB720 Offset: 0x2CEA120 VA: 0x182CEB720
	public void set_shadowDistance(float value) { }

	// RVA: 0x2CEB630 Offset: 0x2CEA030 VA: 0x182CEB630
	public CullingOptions get_cullingOptions() { }

	// RVA: 0x1E44260 Offset: 0x1E42C60 VA: 0x181E44260
	public void set_cullingOptions(CullingOptions value) { }

	// RVA: 0x2CEB710 Offset: 0x2CEA110 VA: 0x182CEB710
	public void set_reflectionProbeSortingCriteria(ReflectionProbeSortingCriteria value) { }

	// RVA: 0x2CEB770 Offset: 0x2CEA170 VA: 0x182CEB770
	public void set_stereoViewMatrix(Matrix4x4 value) { }

	// RVA: 0x2CEB650 Offset: 0x2CEA050 VA: 0x182CEB650
	public Matrix4x4 get_stereoProjectionMatrix() { }

	// RVA: 0x2CEB730 Offset: 0x2CEA130 VA: 0x182CEB730
	public void set_stereoProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2CEB760 Offset: 0x2CEA160 VA: 0x182CEB760
	public void set_stereoSeparationDistance(float value) { }

	// RVA: 0x2CEB4E0 Offset: 0x2CE9EE0 VA: 0x182CEB4E0
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x2CEB140 Offset: 0x2CE9B40 VA: 0x182CEB140
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x2CEA9F0 Offset: 0x2CE93F0 VA: 0x182CEA9F0 Slot: 4
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x2CEB070 Offset: 0x2CE9A70 VA: 0x182CEB070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CEB290 Offset: 0x2CE9C90 VA: 0x182CEB290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CEB5E0 Offset: 0x2CE9FE0 VA: 0x182CEB5E0
	private static void .cctor() { }
}
