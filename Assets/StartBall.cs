using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
	float passed;
	float total;
	float limit = 180f;
	float points = 0.0f;
	static string[] balls = new string[]{"DirtBall", "CopperBall", "MarbleBall", "WaterBall", "SoccerBall", "SunBall", "TennisBall", "VolleyBall"};
	static string[] trace = new string[balls.Length];
	static int index = 0;

    // Start is called before the first frame update
    void Start()
    {	
		passed = 0.0f;
		total = 0.0f;
		AddForce(500f);
    }

    void AddForce(float force){
		float angle = Random.Range(-1f, 1f);
		Vector3 direction = new Vector3(Mathf.Sin(angle*Mathf.PI), 0f, Mathf.Cos(angle*Mathf.PI));
        Rigidbody m_Rigidbody = GetComponent<Rigidbody>();
		m_Rigidbody.AddForce(force * direction);
//		Debug.Log(gameObject.name + ":" + force * direction);
	}

    // Update is called once per frame
    void Update()
    {
		passed = passed + Time.deltaTime;
		if(passed > 5f && total < limit){
			AddForce(200f);
			total = total + passed;
			passed = 0.0f;
		}
    }
    
    	public void AddToTrace(){
		string name = gameObject.name;
		if(Array.IndexOf(trace, name) == -1){
			trace[index] = name;
			index = index + 1;
			points = points + index;
//			Debug.Log(name + ":" + index);
		}
	}

	public void DirtBall(){
		if (total < limit){
			AddToTrace();
			AddForce(600f);
		}
	}

	public void CopperBall(){
		if (total < limit){
			AddToTrace();
			AddForce(700f);
		}
	}

	public void MarbleBall(){
		if (total < limit){
			AddToTrace();
			AddForce(100f);	
		}
	}

	public void SunBall(){
		if (total < limit){
			AddToTrace();
			points = points * 2;
			AudioSource audioData = GetComponent<AudioSource>();
			audioData.Play(0);
			Destroy(gameObject);
		}
	}

	public void TennisBall(){
		if (total < limit){
			AddToTrace();
			AddForce(200f);
		}
	}
	
	public void VolleyBall(){
		if (total < limit){
			AddToTrace();
			AddForce(300f);	
		}
	}

	public void WaterBall(){
		if (total < limit){
			AddToTrace();
			AddForce(400f);		
		}
	}

	public void SoccerBall(){
		if (total < limit){
			AddToTrace();
			AddForce(500f);
		}
	}
}
