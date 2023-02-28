using HarmonyLib;
using UnityEngine;

namespace LightgunDragoon
{
    class mPD_PauseMenuController
    {
        [HarmonyPatch(typeof(PD_PauseMenuController), "ResumeGame")]
        class ResumeGame
        {
            static void Postfix()
            {
                Cursor.lockState = CursorLockMode.None;
                PD_GameManager.Instance.CursorLocked = false;
            }
        }
    }
}
