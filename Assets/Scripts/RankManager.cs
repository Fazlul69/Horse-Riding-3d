using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RankManager : MonoBehaviour
{
    public static RankManager instance;

    public Text[] txtRanks;

 

    Dictionary<string, PlayerController> players;
    Dictionary<string, PlayerController> sortedPlayers;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        players = new Dictionary<string, PlayerController>();
    }

    // Set player rank in UI text
    public void SetRank(PlayerController player)
    {
        players[player.name] = player;
        IOrderedEnumerable<KeyValuePair<string, PlayerController>> sortedPlayer = players.OrderBy(x => x.Value.distanceToWaypoint).OrderByDescending(x => x.Value.activeWaypointIndex);
        int i = 0;
        foreach (KeyValuePair<string, PlayerController> item in sortedPlayer)
        {
            // txtRanks[i].text = (i + 1) + " . Horse " + item.Value.name;
            txtRanks[i].text = item.Value.name;
            i++;
        }

    



         PlayerPrefs.SetString("1st", txtRanks[0].GetComponent<Text>().text);
         PlayerPrefs.SetString("2nd", txtRanks[1].GetComponent<Text>().text);

    }

  //  public

}
