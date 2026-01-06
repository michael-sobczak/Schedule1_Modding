public struct ScriptPlayable<T> : IPlayable, IEquatable<ScriptPlayable<T>> // TypeDefIndex: 12313
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly ScriptPlayable<T> m_NullPlayable; // 0x0

	// Properties
	public static ScriptPlayable<T> Null { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> get_Null() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2FE0 Offset: 0x11B19E0 VA: 0x1811B2FE0
	|-ScriptPlayable<object>.get_Null
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2AA0 Offset: 0x11B14A0 VA: 0x1811B2AA0
	|-ScriptPlayable<object>.Create
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2970 Offset: 0x11B1370 VA: 0x1811B2970
	|-ScriptPlayable<object>.Create
	*/

	// RVA: -1 Offset: -1
	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B24E0 Offset: 0x11B0EE0 VA: 0x1811B24E0
	|-ScriptPlayable<object>.CreateHandle
	*/

	// RVA: -1 Offset: -1
	private static object CreateScriptInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2790 Offset: 0x11B1190 VA: 0x1811B2790
	|-ScriptPlayable<object>.CreateScriptInstance
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstance(IPlayableBehaviour source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B22A0 Offset: 0x11B0CA0 VA: 0x1811B22A0
	|-ScriptPlayable<object>.CloneScriptInstance
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstanceFromEngineObject(Object source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B21C0 Offset: 0x11B0BC0 VA: 0x1811B21C0
	|-ScriptPlayable<object>.CloneScriptInstanceFromEngineObject
	*/

	// RVA: -1 Offset: -1
	private static object CloneScriptInstanceFromIClonable(ICloneable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2250 Offset: 0x11B0C50 VA: 0x1811B2250
	|-ScriptPlayable<object>.CloneScriptInstanceFromIClonable
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(PlayableHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2E10 Offset: 0x11B1810 VA: 0x1811B2E10
	|-ScriptPlayable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public PlayableHandle GetHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2D20 Offset: 0x11B1720 VA: 0x1811B2D20
	|-ScriptPlayable<object>.GetHandle
	*/

	// RVA: -1 Offset: -1
	public T GetBehaviour() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2CA0 Offset: 0x11B16A0 VA: 0x1811B2CA0
	|-ScriptPlayable<object>.GetBehaviour
	*/

	// RVA: -1 Offset: -1
	public static Playable op_Implicit(ScriptPlayable<T> playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B3160 Offset: 0x11B1B60 VA: 0x1811B3160
	|-ScriptPlayable<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ScriptPlayable<T> op_Explicit(Playable playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B3090 Offset: 0x11B1A90 VA: 0x1811B3090
	|-ScriptPlayable<object>.op_Explicit
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Equals(ScriptPlayable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2BB0 Offset: 0x11B15B0 VA: 0x1811B2BB0
	|-ScriptPlayable<object>.Equals
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11B2D30 Offset: 0x11B1730 VA: 0x1811B2D30
	|-ScriptPlayable<object>..cctor
	*/
}
