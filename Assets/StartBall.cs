using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour
{
	float passed;
    // Start is called before the first frame update
    void Start()
    {	
		passed = 0.0f;
		AddForce(500f);
    }

	void AddForce(float force){
		float angle = Random.Range(-1f, 1f);
		Vector3 direction = new Vector3(Mathf.Sin(angle*Mathf.PI), 0f, Mathf.Cos(angle*Mathf.PI));
        Rigidbody m_Rigidbody = GetComponent<Rigidbody>();
		m_Rigidbody.AddForce(force * direction);
		Debug.Log(gameObject.name + ":" + force * direction);
	}

    // Update is called once per frame
    void Update()
    {
		passed = passed + Time.deltaTime;
		if(passed > 5f){
			AddForce(200f);
			passed = 0.0f;
		}
    }
	
	public void DirtBall(){
		AddForce(600f);
	}

	public void CopperBall(){
		AddForce(700f);
	}

	public void MarbleBall(){
		AddForce(100f);
	}

	public void SunBall(){
		Destroy(gameObject);
	}

	public void TennisBall(){
		AddForce(200f);
	}
	
	public void VolleyBall(){
		AddForce(300f);		
	}

	public void WaterBall(){
		AddForce(400f);		
	}

	public void SoccerBall(){
		AddForce(500f);		
	}

}
