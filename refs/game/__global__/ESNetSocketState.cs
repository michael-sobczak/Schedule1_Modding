public enum ESNetSocketState // TypeDefIndex: 14611
{
	// Fields
	public int value__; // 0x0
	public const ESNetSocketState k_ESNetSocketStateInvalid = 0;
	public const ESNetSocketState k_ESNetSocketStateConnected = 1;
	public const ESNetSocketState k_ESNetSocketStateInitiated = 10;
	public const ESNetSocketState k_ESNetSocketStateLocalCandidatesFound = 11;
	public const ESNetSocketState k_ESNetSocketStateReceivedRemoteCandidates = 12;
	public const ESNetSocketState k_ESNetSocketStateChallengeHandshake = 15;
	public const ESNetSocketState k_ESNetSocketStateDisconnecting = 21;
	public const ESNetSocketState k_ESNetSocketStateLocalDisconnect = 22;
	public const ESNetSocketState k_ESNetSocketStateTimeoutDuringConnect = 23;
	public const ESNetSocketState k_ESNetSocketStateRemoteEndDisconnected = 24;
	public const ESNetSocketState k_ESNetSocketStateConnectionBroken = 25;
}
