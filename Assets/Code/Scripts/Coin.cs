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
            StartCoroutine(ShrinkCoin(coin));
            collected = true;
        }
    }

    IEnumerator ShrinkCoin(Transform coin) {
        for (float i = coin.transform.localScale.x ; i >= 0; i--) {
            coin.transform.localScale += new Vector3(-1f, -1f, -1f);
            yield return new WaitForSeconds(1/5);
        }
    }
     
}
