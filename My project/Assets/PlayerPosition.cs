using UnityEngine;
using System.Collections.Generic;

public class PlayerPosition : MonoBehaviour
{
    float playerPosition;
    List<GameObject> minions;
    public float minionPosition;
    public GameObject minionPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minions = new List<GameObject>();
        minionPosition = 7;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = transform.position.x;
        if (playerPosition > minionPosition)
        {
            Spawn(minions.Count);
        }else
        {
            NotSpawn();
        }
    }

    void Spawn(int i)
    {
        if (minions.Count > 7)
        {
            return;
        }
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "MinonPrefab #" + (i + 1);
        minion.transform.position = transform.position;
        minions.Add(minion);
        
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }
}
