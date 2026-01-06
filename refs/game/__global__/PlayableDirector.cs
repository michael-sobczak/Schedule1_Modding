public class PlayableDirector : Behaviour, IExposedPropertyTable // TypeDefIndex: 19199
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> played; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<PlayableDirector> paused; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<PlayableDirector> stopped; // 0x28

	// Properties
	public PlayState state { get; }
	public DirectorWrapMode extrapolationMode { get; }
	public PlayableAsset playableAsset { get; }
	public PlayableGraph playableGraph { get; }
	public double time { get; set; }
	public double duration { get; }

	// Methods

	// RVA: 0x2D00650 Offset: 0x2CFF050 VA: 0x182D00650
	public PlayState get_state() { }

	// RVA: 0x2D00740 Offset: 0x2CFF140 VA: 0x182D00740
	public DirectorWrapMode get_extrapolationMode() { }

	// RVA: 0x2D009F0 Offset: 0x2CFF3F0 VA: 0x182D009F0
	public PlayableAsset get_playableAsset() { }

	// RVA: 0x2D00A90 Offset: 0x2CFF490 VA: 0x182D00A90
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x2D00890 Offset: 0x2CFF290 VA: 0x182D00890
	internal void Play(FrameRate frameRate) { }

	// RVA: 0x2D00B30 Offset: 0x2CFF530 VA: 0x182D00B30
	public void set_time(double value) { }

	// RVA: 0x2D00AF0 Offset: 0x2CFF4F0 VA: 0x182D00AF0
	public double get_time() { }

	// RVA: 0x2D009B0 Offset: 0x2CFF3B0 VA: 0x182D009B0
	public double get_duration() { }

	[NativeThrows]
	// RVA: 0x2D00520 Offset: 0x2CFEF20 VA: 0x182D00520
	public void Evaluate() { }

	[NativeThrows]
	// RVA: 0x2D00850 Offset: 0x2CFF250 VA: 0x182D00850
	private void PlayOnFrame(FrameRate frameRate) { }

	[NativeThrows]
	// RVA: 0x2D008D0 Offset: 0x2CFF2D0 VA: 0x182D008D0
	public void Play() { }

	// RVA: 0x2D00970 Offset: 0x2CFF370 VA: 0x182D00970
	public void Stop() { }

	// RVA: 0x2D007C0 Offset: 0x2CFF1C0 VA: 0x182D007C0
	public void Pause() { }

	// RVA: 0x2D006F0 Offset: 0x2CFF0F0 VA: 0x182D006F0 Slot: 4
	public Object GetReferenceValue(PropertyName id, out bool idValid) { }

	[NativeMethod("GetBindingFor")]
	// RVA: 0x2D00560 Offset: 0x2CFEF60 VA: 0x182D00560
	public Object GetGenericBinding(Object key) { }

	// RVA: 0x2D00650 Offset: 0x2CFF050 VA: 0x182D00650
	private PlayState GetPlayState() { }

	// RVA: 0x2D00740 Offset: 0x2CFF140 VA: 0x182D00740
	private DirectorWrapMode GetWrapMode() { }

	// RVA: 0x2D00600 Offset: 0x2CFF000 VA: 0x182D00600
	private PlayableGraph GetGraphHandle() { }

	// RVA: 0x2D00780 Offset: 0x2CFF180 VA: 0x182D00780
	private ScriptableObject Internal_GetPlayableAsset() { }

	[RequiredByNativeCode]
	// RVA: 0x2D00930 Offset: 0x2CFF330 VA: 0x182D00930
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	// RVA: 0x2D00910 Offset: 0x2CFF310 VA: 0x182D00910
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	// RVA: 0x2D00950 Offset: 0x2CFF350 VA: 0x182D00950
	private void SendOnPlayableDirectorStop() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D00800 Offset: 0x2CFF200 VA: 0x182D00800
	private void PlayOnFrame_Injected(ref FrameRate frameRate) { }

	// RVA: 0x2D00690 Offset: 0x2CFF090 VA: 0x182D00690 Slot: 5
	private Object GetReferenceValue_Injected(ref PropertyName id, out bool idValid) { }

	// RVA: 0x2D005B0 Offset: 0x2CFEFB0 VA: 0x182D005B0
	private void GetGraphHandle_Injected(out PlayableGraph ret) { }
}
