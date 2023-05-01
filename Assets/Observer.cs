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
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(speed * new Vector3(1f, 0f, 0f));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-speed * new Vector3(1f, 0f, 0f));
		}	
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(-speed * new Vector3(0f, 0f, 1f));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(speed * new Vector3(0f, 0f, 1f));
		}
    }
}
