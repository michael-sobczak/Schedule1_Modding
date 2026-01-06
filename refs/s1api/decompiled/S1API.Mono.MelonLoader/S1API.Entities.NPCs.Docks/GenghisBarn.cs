using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class GenghisBarn : NPC
{
	public new static string NPCId => "genghis_barn";

	internal GenghisBarn()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "genghis_barn"))
	{
	}
}
