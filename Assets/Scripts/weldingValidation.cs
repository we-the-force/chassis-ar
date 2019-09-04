using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weldingValidation : MonoBehaviour
{
    public GameObject Welds;
    public GameObject Interface;
    public GameObject PopUp;
    public Material Good;
    public Material Bad;
    public Material Normal;
    public Text ChildLenght;
    public class Global
    {
        public static int CurrentChild = 0;
    }




    // Start is called before the first frame update
    void Start()
    {
        ChildLenght.text = Welds.transform.childCount.ToString();
        Welds.transform.GetChild(Global.CurrentChild).gameObject.SetActive(true);

    }
    public void GoodWeld()
    {
        var maxChilds = Welds.transform.childCount - 1;
        if (Global.CurrentChild < maxChilds)
        {
            Welds.transform.GetChild(Global.CurrentChild).GetComponent<Renderer>().material = Good;
            Global.CurrentChild = Global.CurrentChild + 1;
            Welds.transform.GetChild(Global.CurrentChild).gameObject.SetActive(true);
        }

        else
        {
            Welds.transform.GetChild(Global.CurrentChild).GetComponent<Renderer>().material = Good;
           
            Interface.SetActive(false);
            PopUp.SetActive(true);

        }
        
    }
    public void BadWeld()
    {
        var maxChilds = Welds.transform.childCount - 1;
        if (Global.CurrentChild < maxChilds)
        {
            Welds.transform.GetChild(Global.CurrentChild).GetComponent<Renderer>().material = Bad;
            Global.CurrentChild = Global.CurrentChild + 1;
            Welds.transform.GetChild(Global.CurrentChild).gameObject.SetActive(true);
        }
        else
        {
            Welds.transform.GetChild(Global.CurrentChild).GetComponent<Renderer>().material = Bad;
            Interface.SetActive(false);
            PopUp.SetActive(true);

        }
    }

    public void Undo()
    {
        
        if (Global.CurrentChild > 0)
        {
            Welds.transform.GetChild(Global.CurrentChild).GetComponent<Renderer>().material = Normal;
            Welds.transform.GetChild(Global.CurrentChild).gameObject.SetActive(false);
            Global.CurrentChild = Global.CurrentChild - 1;
            Welds.transform.GetChild(Global.CurrentChild).GetComponent<Renderer>().material = Normal;

        }

    }

    public void Resetinterface()
    {
        
        foreach (Transform weld in Welds.transform)
        {
            weld.gameObject.SetActive(false);
            weld.GetComponent<Renderer>().material = Normal;
        }
        Welds.transform.GetChild(0).gameObject.SetActive(true);
        Global.CurrentChild = 0;
        Interface.SetActive(true);
        PopUp.SetActive(false);



    }

    public void Send()
    {


    }


    
}



