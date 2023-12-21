using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VanillaRacesExpandedHighmate;
using Verse;

namespace RJW_VE_patches
{
    [StaticConstructorOnStartup]
    public class RJW_VE_main
    {
        static RJW_VE_main()
        {
            var harmony = new Harmony("com.rjw.ve_highmate_patch");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
