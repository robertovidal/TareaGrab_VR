using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ungrabbed : MonoBehaviour
{
    public GameObject arrow;



    public void deactivateArrow(){
        UnityEngine.Debug.Log("llegó");
        arrow.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
