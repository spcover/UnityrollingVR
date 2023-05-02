using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
	float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 view = Camera.main.transform.forward;
		Vector3 forward = new Vector3(view.x, 0, view.z);
		Vector3 right = new Vector3(forward.z, 0, -forward.x);
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(speed * right);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-speed * right);
		}	
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(-speed * forward);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(speed * forward);
		}
    }
}
