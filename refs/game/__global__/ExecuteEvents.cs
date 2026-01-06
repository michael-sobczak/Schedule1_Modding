public static class ExecuteEvents // TypeDefIndex: 16549
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x80
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9B7D0 Offset: 0xE9A1D0 VA: 0x180E9B7D0
	|-ExecuteEvents.ValidateEventData<object>
	*/

	// RVA: 0x2F48B10 Offset: 0x2F47510 VA: 0x182F48B10
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48E30 Offset: 0x2F47830 VA: 0x182F48E30
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48C50 Offset: 0x2F47650 VA: 0x182F48C50
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48BB0 Offset: 0x2F475B0 VA: 0x182F48BB0
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F49260 Offset: 0x2F47C60 VA: 0x182F49260
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48D90 Offset: 0x2F47790 VA: 0x182F48D90
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F491C0 Offset: 0x2F47BC0 VA: 0x182F491C0
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48CF0 Offset: 0x2F476F0 VA: 0x182F48CF0
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F49120 Offset: 0x2F47B20 VA: 0x182F49120
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48A10 Offset: 0x2F47410 VA: 0x182F48A10
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48F30 Offset: 0x2F47930 VA: 0x182F48F30
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48970 Offset: 0x2F47370 VA: 0x182F48970
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F49300 Offset: 0x2F47D00 VA: 0x182F49300
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F490C0 Offset: 0x2F47AC0 VA: 0x182F490C0
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48910 Offset: 0x2F47310 VA: 0x182F48910
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48FD0 Offset: 0x2F479D0 VA: 0x182F48FD0
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48ED0 Offset: 0x2F478D0 VA: 0x182F48ED0
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F48AB0 Offset: 0x2F474B0 VA: 0x182F48AB0
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x2F4A080 Offset: 0x2F48A80 VA: 0x182F4A080
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x2F49FE0 Offset: 0x2F489E0 VA: 0x182F49FE0
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x2F4A030 Offset: 0x2F48A30 VA: 0x182F4A030
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x2F49F90 Offset: 0x2F48990 VA: 0x182F49F90
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x2F4A0D0 Offset: 0x2F48AD0 VA: 0x182F4A0D0
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x2F49F40 Offset: 0x2F48940 VA: 0x182F49F40
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x2F49EA0 Offset: 0x2F488A0 VA: 0x182F49EA0
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x2F49CB0 Offset: 0x2F486B0 VA: 0x182F49CB0
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x2F49DB0 Offset: 0x2F487B0 VA: 0x182F49DB0
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x2F49E50 Offset: 0x2F48850 VA: 0x182F49E50
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x2F49E00 Offset: 0x2F48800 VA: 0x182F49E00
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x2F4A120 Offset: 0x2F48B20 VA: 0x182F4A120
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x2F4A220 Offset: 0x2F48C20 VA: 0x182F4A220
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x2F4A170 Offset: 0x2F48B70 VA: 0x182F4A170
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x2F49D60 Offset: 0x2F48760 VA: 0x182F49D60
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x2F49EF0 Offset: 0x2F488F0 VA: 0x182F49EF0
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x2F4A1C0 Offset: 0x2F48BC0 VA: 0x182F4A1C0
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x2F49D00 Offset: 0x2F48700 VA: 0x182F49D00
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x2F49360 Offset: 0x2F47D60 VA: 0x182F49360
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9AA70 Offset: 0xE99470 VA: 0x180E9AA70
	|-ExecuteEvents.Execute<object>
	|
	|-RVA: 0xE9A640 Offset: 0xE99040 VA: 0x180E9A640
	|-ExecuteEvents.Execute<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9A4D0 Offset: 0xE98ED0 VA: 0x180E9A4D0
	|-ExecuteEvents.ExecuteHierarchy<object>
	|
	|-RVA: 0xE9A360 Offset: 0xE98D60 VA: 0x180E9A360
	|-ExecuteEvents.ExecuteHierarchy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9B6C0 Offset: 0xE9A0C0 VA: 0x180E9B6C0
	|-ExecuteEvents.ShouldSendToComponent<object>
	|-ExecuteEvents.ShouldSendToComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9B370 Offset: 0xE99D70 VA: 0x180E9B370
	|-ExecuteEvents.GetEventList<object>
	|
	|-RVA: 0xE9B110 Offset: 0xE99B10 VA: 0x180E9B110
	|-ExecuteEvents.GetEventList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9A270 Offset: 0xE98C70 VA: 0x180E9A270
	|-ExecuteEvents.CanHandleEvent<object>
	|
	|-RVA: 0xE9A180 Offset: 0xE98B80 VA: 0x180E9A180
	|-ExecuteEvents.CanHandleEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE9AF30 Offset: 0xE99930 VA: 0x180E9AF30
	|-ExecuteEvents.GetEventHandler<object>
	|
	|-RVA: 0xE9AE00 Offset: 0xE99800 VA: 0x180E9AE00
	|-ExecuteEvents.GetEventHandler<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F494D0 Offset: 0x2F47ED0 VA: 0x182F494D0
	private static void .cctor() { }
}
