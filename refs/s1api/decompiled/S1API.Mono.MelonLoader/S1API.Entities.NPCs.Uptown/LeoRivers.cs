using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class LeoRivers : NPC
{
	public new static string NPCId => "leo_rivers";

	internal LeoRivers()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "leo_rivers"))
	{
	}
}
