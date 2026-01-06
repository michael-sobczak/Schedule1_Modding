using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class CrankyFrank : NPC
{
	public new static string NPCId => "cranky_frank";

	internal CrankyFrank()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "cranky_frank"))
	{
	}
}
