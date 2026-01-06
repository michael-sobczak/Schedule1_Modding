using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class BethPenn : NPC
{
	public new static string NPCId => "beth_penn";

	internal BethPenn()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "beth_penn"))
	{
	}
}
