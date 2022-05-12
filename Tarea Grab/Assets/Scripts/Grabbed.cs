using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbed : MonoBehaviour
{


    public GameObject arrow;




    public void activateArrow(){
        UnityEngine.Debug.Log("llegó");
        arrow.SetActive(true);
    }

    public void deactivateArrow(){
        UnityEngine.Debug.Log("llegó");
        arrow.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
