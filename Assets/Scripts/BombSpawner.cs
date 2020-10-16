using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject bombPrefab;
    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3Int cell = tilemap.WorldToCell(player.transform.position);
            Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);

            Instantiate(bombPrefab, cellCenterPos, Quaternion.identity);
        }
    }
}
