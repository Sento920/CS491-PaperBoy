using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    float direct;
    public float oomph;
    public GameObject Throwable;
    GameObject Paper;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        direct = Input.GetAxis("Vertical");
        if (Input.GetMouseButtonDown(0) == true)
        {
            Paper = (GameObject) Instantiate(Throwable,new Vector3(rb.position.x, rb.position.y, rb.position.z),Quaternion.identity);
            Paper.transform.SetParent(this.transform);
            print("Thrown");
        }
	}

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0,0,direct * oomph));
    }

}
