using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float countDown = 2f;

    void Update()
    {
        countDown -= Time.deltaTime;

        if (countDown <= 0f)
        {
            FindObjectOfType<MapDestroyer>().Explode(transform.position);
            Destroy(gameObject);
        }
    }
}
