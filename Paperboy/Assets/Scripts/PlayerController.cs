using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    float direct;
    public float oomph;
    public float powerOfThrow;
    public GameObject newsPaper;
    public GameObject throwPoint;
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
            Paper = (GameObject) Instantiate(newsPaper,throwPoint.transform.position,this.rb.rotation);
            Paper.transform.SetParent(this.transform);
            print("Thrown");
            Paper.GetComponent<Rigidbody>().AddForce(new Vector3(powerOfThrow * this.rb.rotation.x,powerOfThrow* this.rb.rotation.y, powerOfThrow));
        }
	}

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0,0,direct * oomph));
    }

    public float getPower(float pow)
    {
        return this.powerOfThrow = pow;
    }

}
