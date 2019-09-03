using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleModels : MonoBehaviour
{
    public GameObject Chassis;
    public GameObject Welding;
    // Start is called before the first frame update
    public void toggleChassis(bool toggleTarget) {
        Chassis.SetActive(toggleTarget);
    }
    public void toggleWelding(bool toggleTarget)
    {
        Welding.SetActive(toggleTarget);
    }

}
