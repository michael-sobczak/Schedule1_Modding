using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class AlisonKnight : NPC
{
	public new static string NPCId => "alison_knight";

	internal AlisonKnight()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "alison_knight"))
	{
	}
}
