public class TextureCurve : IDisposable // TypeDefIndex: 13878
{
	// Fields
	private const int k_Precision = 128;
	private const float k_Step = 0.0078125;
	[CompilerGenerated]
	[SerializeField]
	private int <length>k__BackingField; // 0x10
	[SerializeField]
	private bool m_Loop; // 0x14
	[SerializeField]
	private float m_ZeroValue; // 0x18
	[SerializeField]
	private float m_Range; // 0x1C
	[SerializeField]
	private AnimationCurve m_Curve; // 0x20
	private AnimationCurve m_LoopingCurve; // 0x28
	private Texture2D m_Texture; // 0x30
	private bool m_IsCurveDirty; // 0x38
	private bool m_IsTextureDirty; // 0x39

	// Properties
	public int length { get; set; }
	public Keyframe Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_length() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	private void set_length(int value) { }

	// RVA: 0x2A590D0 Offset: 0x2A57AD0 VA: 0x182A590D0
	public Keyframe get_Item(int index) { }

	// RVA: 0x2A58E50 Offset: 0x2A57850 VA: 0x182A58E50
	public void .ctor(AnimationCurve baseCurve, float zeroValue, bool loop, in Vector2 bounds) { }

	// RVA: 0x2A58FA0 Offset: 0x2A579A0 VA: 0x182A58FA0
	public void .ctor(Keyframe[] keys, float zeroValue, bool loop, in Vector2 bounds) { }

	// RVA: 0x1B60510 Offset: 0x1B5EF10 VA: 0x181B60510 Slot: 1
	protected override void Finalize() { }

	[Obsolete("Please use Release() instead.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A58D70 Offset: 0x2A57770 VA: 0x182A58D70
	public void Release() { }

	// RVA: 0x2A58E10 Offset: 0x2A57810 VA: 0x182A58E10
	public void SetDirty() { }

	// RVA: 0x2A58A70 Offset: 0x2A57470 VA: 0x182A58A70
	private static GraphicsFormat GetTextureFormat() { }

	// RVA: 0x2A58AD0 Offset: 0x2A574D0 VA: 0x182A58AD0
	public Texture2D GetTexture() { }

	// RVA: 0x2A58800 Offset: 0x2A57200 VA: 0x182A58800
	public float Evaluate(float time) { }

	// RVA: 0x2A587C0 Offset: 0x2A571C0 VA: 0x182A587C0
	public int AddKey(float time, float value) { }

	// RVA: 0x2A58D20 Offset: 0x2A57720 VA: 0x182A58D20
	public int MoveKey(int index, in Keyframe key) { }

	// RVA: 0x2A58DE0 Offset: 0x2A577E0 VA: 0x182A58DE0
	public void RemoveKey(int index) { }

	// RVA: 0x2A58E20 Offset: 0x2A57820 VA: 0x182A58E20
	public void SmoothTangents(int index, float weight) { }
}
