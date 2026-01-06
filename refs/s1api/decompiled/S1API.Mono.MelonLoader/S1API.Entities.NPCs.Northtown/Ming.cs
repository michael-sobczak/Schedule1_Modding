using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class Ming : NPC
{
	public new static string NPCId => "ming";

	internal Ming()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "ming"))
	{
	}
}
