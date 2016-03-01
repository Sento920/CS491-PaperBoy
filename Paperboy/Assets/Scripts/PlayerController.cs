using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    float direct;
    public float oomph;
    public float powerOfThrow;
    public GameObject newsPaper;
    GameObject throwPoint;
    public GameObject powerbar;
    public float Numpapers;
    public Text papertext;
    public Text Speedtext;
    ScoreController sc;
    GameObject Paper;
    float charge;
    float rof;
	// Use this for initialization
	void Start () {
        sc = GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreController>();
        rof = .5f;
        rb = GetComponent<Rigidbody>();
        throwPoint = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        direct = Input.GetAxis("Vertical");
        if (Input.GetMouseButtonUp(0) == true && Numpapers > 0 && Time.time > charge)
        {
            charge = Time.time + rof;
            Paper = (GameObject) Instantiate(newsPaper,throwPoint.transform.position, throwPoint.transform.rotation);
            Paper.GetComponent<Rigidbody>().AddForce(throwPoint.transform.forward * powerOfThrow * powerbar.GetComponent<PowerBar>().power);
            Paper.transform.SetParent(Paper.transform);
            Numpapers--;
            
        }
        int x = (int)rb.velocity.magnitude;
        papertext.text = "Papers: " + Numpapers;
        Speedtext.text = "Speed: " + x;
        if(x > 5)
        {
            sc.getSpeedMult(2);
        }else if (x < 10)
        {
            sc.getSpeedMult(3);
        }
        else
        {
            sc.getSpeedMult(1);
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
