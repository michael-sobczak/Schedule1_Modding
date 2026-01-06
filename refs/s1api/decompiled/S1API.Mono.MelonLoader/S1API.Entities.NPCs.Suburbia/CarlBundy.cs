using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class CarlBundy : NPC
{
	public new static string NPCId => "carl_bundy";

	internal CarlBundy()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "carl_bundy"))
	{
	}
}
