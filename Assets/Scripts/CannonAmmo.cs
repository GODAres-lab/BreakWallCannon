using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CannonAmmo : MonoBehaviour
{
    public TextMeshProUGUI ammoText;

    public int totalAmmo;

    public int currentAmmo;

    public int CurrentAmmo
    {
        get
        {
            return currentAmmo;
        }
        set
        {
            currentAmmo = value;
            ammoText.text = "Ammo: " + currentAmmo + "/" + totalAmmo;
            print("Current Ammo: " + currentAmmo);
            if (currentAmmo <= 0 && GameMenager.Instance.fallenBrickAmount < GameMenager.Instance.fallenBrickNeeded) 
            {
                print("You Lose");
            }
        }
    }

    void Start()
    {
        currentAmmo = totalAmmo;
        ammoText.text = "Ammo: " + currentAmmo + "/" + totalAmmo;
    }
}
