internal interface IProgressDialog // TypeDefIndex: 17327
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartProgressDialog(IntPtr hwndParent, object punkEnableModless, ProgressDialogFlags dwFlags, IntPtr pvResevered);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopProgressDialog();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetTitle(string pwzTitle);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetAnimation(SafeModuleHandle hInstAnimation, ushort idAnimation);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool HasUserCancelled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetProgress(uint dwCompleted, uint dwTotal);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetProgress64(ulong ullCompleted, ulong ullTotal);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetLine(uint dwLineNum, string pwzString, bool fCompactPath, IntPtr pvResevered);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetCancelMsg(string pwzCancelMsg, object pvResevered);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Timer(uint dwTimerAction, object pvResevered);
}
