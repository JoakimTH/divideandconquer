using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float speed = 3.0f;
    private Vector3 targetPos;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            float distance = transform.position.z - Camera.main.transform.position.z;
            targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            targetPos = Camera.main.ScreenToWorldPoint(targetPos);
        }
        gameObject.transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}

