public abstract class PlayableAsset : ScriptableObject, IPlayableAsset // TypeDefIndex: 12301
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x2CF2CD0 Offset: 0x2CF16D0 VA: 0x182CF2CD0 Slot: 7
	public virtual double get_duration() { }

	// RVA: 0x2CF2D20 Offset: 0x2CF1720 VA: 0x182CF2D20 Slot: 8
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCode]
	// RVA: 0x2CF2B60 Offset: 0x2CF1560 VA: 0x182CF2B60
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CF2C90 Offset: 0x2CF1690 VA: 0x182CF2C90
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
