using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weldingValidation : MonoBehaviour
{
    public GameObject Weld;
    public Material Good;
    public Material Bad;
    // Start is called before the first frame update
    public void goodWeld()
    {
        Weld.GetComponent<Renderer>().material = Good;
    }
    public void badWeld()
    {
        Weld.GetComponent<Renderer>().material = Bad;
    }
}
