using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTwo : MonoBehaviour
{
    public Transform player;
    public Transform startLoc2;
    public Transform Loc2;

    public void TeleStartTwo()
    {
        player.transform.position = startLoc2.transform.position;
    }

    public void TeleLoc2()
    {
        player.transform.position = Loc2.transform.position;
    }
}
