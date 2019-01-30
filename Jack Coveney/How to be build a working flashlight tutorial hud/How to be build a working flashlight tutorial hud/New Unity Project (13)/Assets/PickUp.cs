using UnityEngine;
using System.Collections;
public class PickUp : MonoBehaviour
{
    public GameObject children;
    public enum Item
    {
        Flashlight,
        Battery
    }
    public Item item;
    void OnTriggerEnter()
    {
        if (item == Item.Flashlight)
        {

            Flashlight.HeadlightMount.SetActive(true);

            HUD.HasFlashlight = true;
        }
        else
            HUD.BatteryCount++;

        Destroy(gameObject);
    }
}