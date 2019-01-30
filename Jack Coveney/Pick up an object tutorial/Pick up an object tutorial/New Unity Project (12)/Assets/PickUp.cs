using UnityEngine;
using System.Collections;
public class PickUp : MonoBehaviour
{
    public GameObject children;
    public enum Item
    {
       
        cube
    }
    public Item item;
    void OnTriggerEnter()
    {
       
        Destroy(gameObject);
    }
}