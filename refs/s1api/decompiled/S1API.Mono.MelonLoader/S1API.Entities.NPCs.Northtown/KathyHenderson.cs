using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class KathyHenderson : NPC
{
	public new static string NPCId => "kathy_henderson";

	internal KathyHenderson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "kathy_henderson"))
	{
	}
}
