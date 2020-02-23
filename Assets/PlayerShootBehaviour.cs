using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehaviour : MonoBehaviour {
    public GameObject bullet;
    public float jeda;

    // Use this for initialization
    void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(shoot());
        }
    }
    IEnumerator shoot()
    {
        while (Input.GetKey(KeyCode.J))
        {
            Instantiate(bullet);
            yield return new WaitForSecondsRealtime(jeda);
        }
        yield return null;
    }

}
