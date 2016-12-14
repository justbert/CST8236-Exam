using UnityEngine;
using System.Collections;
using System.Security.Policy;

public class ProjectileOnCollision : MonoBehaviour
{

    private AudioSource hitNoise;

	// Use this for initialization
	void Start ()
	{
	    hitNoise = GameObject.Find("WompWomp").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bat")
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            hitNoise.Play();
            Debug.Log("Womp womp");
        }

        Destroy(gameObject);
    }
}
