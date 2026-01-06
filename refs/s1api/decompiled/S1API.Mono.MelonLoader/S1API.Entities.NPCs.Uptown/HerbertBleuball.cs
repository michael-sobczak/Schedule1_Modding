using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class HerbertBleuball : NPC
{
	public new static string NPCId => "herbert_bleuball";

	internal HerbertBleuball()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "herbert_bleuball"))
	{
	}
}
