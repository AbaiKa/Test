using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public void SwapBtn()
    {
        NPC._isSwap = true;

        NPC._isAttack = false;
        if (NPC.isSecond_NonePlayerCharacter == false) NPC.isSecond_NonePlayerCharacter = true;
        else NPC.isSecond_NonePlayerCharacter = false;
    }
}
