using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    float direct;
    public float oomph;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        direct = Input.GetAxis("Vertical");
	}

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0,0,direct * oomph));
    }

}
