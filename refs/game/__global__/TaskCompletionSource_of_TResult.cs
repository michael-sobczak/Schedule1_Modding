public class TaskCompletionSource<TResult> // TypeDefIndex: 4007
{
	// Fields
	private readonly Task<TResult> _task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12126C0 Offset: 0x12110C0 VA: 0x1812126C0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x1212860 Offset: 0x1211260 VA: 0x181212860
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x1212740 Offset: 0x1211140 VA: 0x181212740
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x12127C0 Offset: 0x12111C0 VA: 0x1812127C0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212500 Offset: 0x1210F00 VA: 0x181212500
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x1212840 Offset: 0x1211240 VA: 0x181212840
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x1212520 Offset: 0x1210F20 VA: 0x181212520
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x12124C0 Offset: 0x1210EC0 VA: 0x1812124C0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12124A0 Offset: 0x1210EA0 VA: 0x1812124A0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x1212680 Offset: 0x1211080 VA: 0x181212680
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x12126A0 Offset: 0x12110A0 VA: 0x1812126A0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x12124E0 Offset: 0x1210EE0 VA: 0x1812124E0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212540 Offset: 0x1210F40 VA: 0x181212540
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x12128E0 Offset: 0x12112E0 VA: 0x1812128E0
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x1212980 Offset: 0x1211380 VA: 0x181212980
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x12125E0 Offset: 0x1210FE0 VA: 0x1812125E0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-TaskCompletionSource<bool>.get_Task
	|-TaskCompletionSource<int>.get_Task
	|-TaskCompletionSource<object>.get_Task
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211BD0 Offset: 0x12105D0 VA: 0x181211BD0
	|-TaskCompletionSource<bool>.SpinUntilCompleted
	|
	|-RVA: 0x1211B50 Offset: 0x1210550 VA: 0x181211B50
	|-TaskCompletionSource<int>.SpinUntilCompleted
	|
	|-RVA: 0x1211AD0 Offset: 0x12104D0 VA: 0x181211AD0
	|-TaskCompletionSource<object>.SpinUntilCompleted
	|
	|-RVA: 0x1211C50 Offset: 0x1210650 VA: 0x181211C50
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12120C0 Offset: 0x1210AC0 VA: 0x1812120C0
	|-TaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0x12121E0 Offset: 0x1210BE0 VA: 0x1812121E0
	|-TaskCompletionSource<int>.TrySetException
	|
	|-RVA: 0x1212150 Offset: 0x1210B50 VA: 0x181212150
	|-TaskCompletionSource<object>.TrySetException
	|
	|-RVA: 0x1212030 Offset: 0x1210A30 VA: 0x181212030
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12115B0 Offset: 0x120FFB0 VA: 0x1812115B0
	|-TaskCompletionSource<bool>.SetException
	|
	|-RVA: 0x1211670 Offset: 0x1210070 VA: 0x181211670
	|-TaskCompletionSource<int>.SetException
	|
	|-RVA: 0x12117A0 Offset: 0x12101A0 VA: 0x1812117A0
	|-TaskCompletionSource<object>.SetException
	|
	|-RVA: 0x1211730 Offset: 0x1210130 VA: 0x181211730
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1212270 Offset: 0x1210C70 VA: 0x181212270
	|-TaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0x1212440 Offset: 0x1210E40 VA: 0x181212440
	|-TaskCompletionSource<int>.TrySetResult
	|
	|-RVA: 0x12123E0 Offset: 0x1210DE0 VA: 0x1812123E0
	|-TaskCompletionSource<object>.TrySetResult
	|
	|-RVA: 0x12122D0 Offset: 0x1210CD0 VA: 0x1812122D0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12119D0 Offset: 0x12103D0 VA: 0x1812119D0
	|-TaskCompletionSource<bool>.SetResult
	|
	|-RVA: 0x1211A50 Offset: 0x1210450 VA: 0x181211A50
	|-TaskCompletionSource<int>.SetResult
	|
	|-RVA: 0x1211950 Offset: 0x1210350 VA: 0x181211950
	|-TaskCompletionSource<object>.SetResult
	|
	|-RVA: 0x1211860 Offset: 0x1210260 VA: 0x181211860
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211EA0 Offset: 0x12108A0 VA: 0x181211EA0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x1211FB0 Offset: 0x12109B0 VA: 0x181211FB0
	|-TaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0x1211D40 Offset: 0x1210740 VA: 0x181211D40
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x1211F90 Offset: 0x1210990 VA: 0x181211F90
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211DC0 Offset: 0x12107C0 VA: 0x181211DC0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0x1211CD0 Offset: 0x12106D0 VA: 0x181211CD0
	|-TaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0x1211F20 Offset: 0x1210920 VA: 0x181211F20
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x1211E30 Offset: 0x1210830 VA: 0x181211E30
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211400 Offset: 0x120FE00 VA: 0x181211400
	|-TaskCompletionSource<bool>.SetCanceled
	|
	|-RVA: 0x1211520 Offset: 0x120FF20 VA: 0x181211520
	|-TaskCompletionSource<int>.SetCanceled
	|
	|-RVA: 0x1211490 Offset: 0x120FE90 VA: 0x181211490
	|-TaskCompletionSource<object>.SetCanceled
	|
	|-RVA: 0x12113C0 Offset: 0x120FDC0 VA: 0x1812113C0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetCanceled
	*/
}
