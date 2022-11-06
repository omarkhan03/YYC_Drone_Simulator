using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Transform coin;
    public Collider drone;
    public Toggle place;
    public Checklist checklist;
    private bool collected = false;
    private void OnTriggerEnter(Collider drone)
    {
        if (!collected) {
            checklist.checkPlace(place);
            coin.transform.localScale += new Vector3(-600f, -600f, -600f); 
            collected = true;
        }
    }

    void ShrinkCoin(Transform coin) {
        for (int i = 600; i >= 0; i--) {
            coin.transform.localScale += new Vector3(1f, 1f, 1f) * -1;
        }
    }
     
}
