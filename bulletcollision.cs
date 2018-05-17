using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcollision : MonoBehaviour {
    public GameObject bultry;
	public GameObject hole;
	public Transform bulrot;
	Transform instancebul;
    Transform tr;
    // Use this for initialization
    void Start () {
		tr = GetComponent<Transform>();
		instancebul = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
    private void OnCollisionEnter(Collision arg)
    {
        Destroy(gameObject);
		instancebul.rotation = new Quaternion (bulrot.rotation.x, bulrot.rotation.y,bulrot.rotation.z,bulrot.rotation.w);
		hole = Instantiate(bultry, tr.position, instancebul.rotation * Quaternion.Euler(270f,0,0));
    }
}
