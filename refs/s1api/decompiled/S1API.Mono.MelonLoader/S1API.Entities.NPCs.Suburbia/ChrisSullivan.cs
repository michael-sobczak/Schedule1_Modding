using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class ChrisSullivan : NPC
{
	public new static string NPCId => "chris_sullivan";

	internal ChrisSullivan()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "chris_sullivan"))
	{
	}
}
