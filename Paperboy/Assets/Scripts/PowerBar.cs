using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
	public float maxHealth;
	public float health;
	public float power;
	private float chargeTime;
    public Image Red;
    public Image White;
	
	// Use this for initialization
	void Start ()
	{
		chargeTime = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButton (0)) {
			Red.enabled = true;
            White.enabled = true;
			chargeTime+= 0.05f;
			health = Mathf.Abs (Mathf.Sin (chargeTime));
			power = Red.transform.localScale.y;
		} else {
            Red.enabled = false;
            White.enabled = false;
            chargeTime = 0;
			health = 0;
		}
		Red.transform.localScale = new Vector3 (1,(health * 100) / maxHealth, 1);

	}
}
