using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static Vector2 lastCheckPointPos = new Vector2(-3, 0);

    public GameObject[] playerPrefabs;
    int characterIndex;
    private void Awake()
    {
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);


    }
}
