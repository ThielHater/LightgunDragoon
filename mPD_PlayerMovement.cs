using HarmonyLib;
using UnityEngine;

namespace LightgunDragoon
{
    class mPD_PlayerMovement
    {
        [HarmonyPatch(typeof(PD_PlayerMovement), "Start")]
        class Start
        {
            static void Postfix()
            {
                Cursor.lockState = CursorLockMode.None;
                PD_GameManager.Instance.CursorLocked = false;
            }
        }
    }
}
