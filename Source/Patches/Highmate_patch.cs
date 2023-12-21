using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanillaRacesExpandedHighmate;
using Verse;

namespace RJW_VE_patches.Patches
{
    [HarmonyPatch]
    public static class Highmate_patch
    {
        [HarmonyPatch(typeof(rjw.AfterSexUtility), "FinalizeThought")]
        public static void Postfix(ThoughtDef thoughtgain, Pawn pawn) 
        {
            Need_Lovin need = pawn?.needs?.TryGetNeed<Need_Lovin>();
            if (need != null)
            {
                need.CurLevel = 1f;
            }
        }
    }
}
