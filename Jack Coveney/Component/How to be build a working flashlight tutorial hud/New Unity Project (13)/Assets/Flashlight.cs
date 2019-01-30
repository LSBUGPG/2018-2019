using UnityEngine;
using System.Collections;
public class Flashlight : MonoBehaviour
{
    public static float BatteryLife = 100;
    public static GameObject HeadlightMount;
    public Light HeadLight;
    public float BatteryReductionSpeed = 3.0f;

    void Awake()
    {

        HeadlightMount = GameObject.FindWithTag("Headlamp");

        HeadlightMount.SetActive(false);

        HeadLight.enabled = false;
    }
    void Update()
    {
        if (HeadLight.enabled)
        {
            BatteryLife = BatteryLife - (BatteryReductionSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.E) && HUD.HasFlashlight && !HeadLight.enabled && HUD.BatteryCount > 0)
        {
            if (BatteryLife <= 0 && HUD.BatteryCount > 0)
            {
                HUD.BatteryCount--;
                BatteryLife = 100;
            }
            HeadLight.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && HUD.HasFlashlight && HeadLight.enabled)
        {
            HeadLight.enabled = false;
        }
        if (BatteryLife <= 0)
        {
            BatteryLife = 0;
            HeadLight.enabled = false;
        }
    }
}