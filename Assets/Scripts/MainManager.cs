using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class MainManager : MonoBehaviour
{
    #region Singleton
    public static MainManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public string playerName;

    public void SetPlayerName(string inputField)
    {
        playerName = inputField;
        Debug.Log(playerName);
    }
}
