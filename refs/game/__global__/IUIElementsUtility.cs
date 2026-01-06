internal interface IUIElementsUtility // TypeDefIndex: 6929
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TakeCapture();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ReleaseCapture();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CleanupRoots();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool EndContainerGUIFromException(Exception exception);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool MakeCurrentIMGUIContainerDirty();
}
