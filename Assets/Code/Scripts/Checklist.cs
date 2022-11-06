using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checklist : MonoBehaviour
{
    public void checkPlace(Toggle place) {
        place.isOn = true;
    }
}
