using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

	void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
