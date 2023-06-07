using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPlayerName : MonoBehaviour
{
    public TMP_Text displayPlayerName;

    public void Start()
    {
       displayPlayerName.text = MainManager.instance.playerName;
    }
}
