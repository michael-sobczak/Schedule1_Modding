public interface IVivoxTokenProviderInternal // TypeDefIndex: 17782
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task<string> GetTokenAsync(string issuer, Nullable<TimeSpan> expiration, string userUri, string action, string conferenceUri, string fromUserUri, string realm);
}
