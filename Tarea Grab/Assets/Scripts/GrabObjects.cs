using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{

    [SerializeField]
    private GameObject _jugador;
    private ParticleSystem _particulas;
    private GameObject _objetoGrabed; 

    private Rigidbody objectRigidbody;

    private Collider objectCollider;

    public Transform destination;

    void Start(){
      _objetoGrabed = null;
    }
    private void OnTriggerEnter(Collider other) {
        
        Debug.Log(other.gameObject.tag);
        if (((other.gameObject.tag == "Grab") || (other.gameObject.tag == "GrabGravity")) && (_objetoGrabed == null))
        {
            //cubeRigidbody = other.gameObject.GetComponent<Rigidbody> ();
            //cubeRigidbody.isKinematic = false;
            //cubeRigidbody.useGravity = false;
            other.gameObject.transform.SetParent(_jugador.transform, false);
            other.gameObject.transform.position = destination.position;
            _objetoGrabed = other.gameObject;
            _objetoGrabed.SendMessage("activateArrow");
        }
        else if (other.gameObject.tag == "UnGrab")
        {
          if(_objetoGrabed != null){
            objectCollider = _objetoGrabed.GetComponent<Collider>();
            objectCollider.isTrigger = false;
            _objetoGrabed.SendMessage("deactivateArrow");
            UnityEngine.Debug.Log("llegó2");
            _objetoGrabed.transform.SetParent(null, false);
            _objetoGrabed.transform.position = other.gameObject.transform.position + new Vector3(0, 2f, 0);
            if(_objetoGrabed.tag == "GrabGravity"){
              objectRigidbody = _objetoGrabed.gameObject.GetComponent<Rigidbody>();
              objectRigidbody.useGravity = true;
            }
            _objetoGrabed = null;
            objectCollider = other.gameObject.GetComponent<Collider>();
            objectCollider.isTrigger = false;
          }
        }
    }
}
