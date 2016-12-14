using UnityEngine;
using System.Collections;

public class OnGoal : MonoBehaviour
{

    private AudioSource goalNoise;

	// Use this for initialization
	void Start ()
	{

	    goalNoise = GetComponent<AudioSource>();

	}

    void OnTriggerStay(Collider collider)
    {
        goalNoise.Play();

        Destroy(collider.gameObject);
    }
}
