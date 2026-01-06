using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class MelissaWood : NPC
{
	public new static string NPCId => "melissa_wood";

	internal MelissaWood()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "melissa_wood"))
	{
	}
}
