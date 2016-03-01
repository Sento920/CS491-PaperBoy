using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    float direct;
    public float oomph;
    public float powerOfThrow;
    public GameObject newsPaper;
    public GameObject throwPoint;
    public GameObject powerbar;
    GameObject Paper;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        throwPoint = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        direct = Input.GetAxis("Vertical");
        if (Input.GetMouseButtonUp(0) == true)
        {
            Paper = (GameObject) Instantiate(newsPaper,throwPoint.transform.position, throwPoint.transform.rotation);
            Paper.GetComponent<Rigidbody>().AddForce(throwPoint.transform.forward * powerOfThrow);
            Paper.transform.SetParent(Paper.transform);
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
