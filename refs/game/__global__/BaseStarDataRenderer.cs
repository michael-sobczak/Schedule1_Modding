public abstract class BaseStarDataRenderer // TypeDefIndex: 39
{
	// Fields
	[CompilerGenerated]
	private BaseStarDataRenderer.StarDataProgress progressCallback; // 0x10
	[CompilerGenerated]
	private BaseStarDataRenderer.StarDataComplete completionCallback; // 0x18
	public float density; // 0x20
	public float imageSize; // 0x24
	public string layerId; // 0x28
	public float maxRadius; // 0x30
	protected float sphereRadius; // 0x34
	protected bool isCancelled; // 0x38

	// Methods

	[CompilerGenerated]
	// RVA: 0x555D90 Offset: 0x554790 VA: 0x180555D90
	public void add_progressCallback(BaseStarDataRenderer.StarDataProgress value) { }

	[CompilerGenerated]
	// RVA: 0x555ED0 Offset: 0x5548D0 VA: 0x180555ED0
	public void remove_progressCallback(BaseStarDataRenderer.StarDataProgress value) { }

	[CompilerGenerated]
	// RVA: 0x555CF0 Offset: 0x5546F0 VA: 0x180555CF0
	public void add_completionCallback(BaseStarDataRenderer.StarDataComplete value) { }

	[CompilerGenerated]
	// RVA: 0x555E30 Offset: 0x554830 VA: 0x180555E30
	public void remove_completionCallback(BaseStarDataRenderer.StarDataComplete value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator ComputeStarData();

	// RVA: 0x555C30 Offset: 0x554630 VA: 0x180555C30 Slot: 5
	public virtual void Cancel() { }

	// RVA: 0x555CB0 Offset: 0x5546B0 VA: 0x180555CB0
	protected void SendProgress(float progress) { }

	// RVA: 0x555C70 Offset: 0x554670 VA: 0x180555C70
	protected void SendCompletion(Texture2D texture, bool success) { }

	// RVA: 0x555CE0 Offset: 0x5546E0 VA: 0x180555CE0
	protected void .ctor() { }
}
