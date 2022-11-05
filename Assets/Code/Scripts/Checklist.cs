using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checklist : MonoBehaviour
{
    public Toggle the_bow;
    public Toggle calgary_tower;
    public Toggle telus_sky;
    public Toggle central_library;
    public Toggle prince_island_park;

    public void Update() {
        if (Input.GetButton("SG")) {
            the_bow.isOn = true;
        }
    }
    
}
