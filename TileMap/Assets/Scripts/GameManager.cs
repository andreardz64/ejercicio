using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform player;
    public string tempJson = "";


   public void Save()
    {
        PlayerData data = new PlayerData();
        data.position = player.position;
        data.life = 75;
        string dataString = JsonUtility.ToJson(data);
        tempJson = dataString;
        Debug.Log("Saved");
        Debug.Log("Data String: " + dataString);
    }

    public void Load()
    {
        string dataString = tempJson;
        PlayerData data = JsonUtility.FromJson<PlayerData>(dataString);
        player.position = data.position;

    }


}

public class PlayerData
{
    public Vector3 position;
    public int life;
}
