using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

public class MoveSets : MonoBehaviour
{
	/*
    public Image Idecor;
    public int speed;
    private bool tuchWall = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right);
    }

    void moveDecors()
    {

        
    }*/


	/*public enum PlatformState { moveLeftRight = 0, moveUpDown = 1, moveStop = 2 };
	public PlatformState platformState = PlatformState.moveLeftRight;
	public float moveSpeed = 20.0f;
	public bool changeMove;
	private Vector3 velocity = Vector3.zero;
	private Transform point;
	private bool stopMove;
	// Use this for initialization
	void Start()
	{
		//point = pointDroit;
		changeMove = false;
		velocity.x = moveSpeed * Time.deltaTime;
	}


	// Update is called once per frame


	void FixedUpdate()
	{
		//if (stopMove) rigidbody.MovePosition(rigidbody.position + velocity * Time.deltaTime);
	}

	void Update()
	{

		print(changeMove);

		switch (platformState)
		{
			case PlatformState.moveLeftRight:
				MoveLeftRight();
				break;

			case PlatformState.moveUpDown:
				MoveUpDown();
				break;

			case PlatformState.moveStop:
				MoveStop();
				break;
		}



	}


	void MoveLeftRight()
	{
		velocity.y = 0;
		stopMove = true;
	}

	void MoveUpDown()
	{
		velocity.x = 0;
	}

	void MoveStop()
	{
		stopMove = false;
	}

	void OnTriggerStay(Collider other)
	{

	}

	void OnCollisionEnter(Collision collision)
	{

		if (collision.gameObject.tag == "Detect1")
		{
			velocity.x = moveSpeed * Time.deltaTime;
		}
		if (collision.gameObject.tag == "Detect2")
		{
			velocity.x = -moveSpeed * Time.deltaTime;
		}

	}
	*/


	// Scroll the main texture based on time
	/*
			float scrollSpeed = 0.5f;
			Renderer rend;

			void Start()
			{
				rend = GetComponent<Renderer>();
			}

			void Update()
			{
			Debug.Log("quelsue se");
			float offset = Time.time * scrollSpeed;
				rend.material.mainTextureOffset = new Vector2(offset, 0);

			}*/

	//private void Start()
	//{
	//	SpriteRenderer spR = gameObject.GetComponent<SpriteRenderer>();
	//	Debug.Log(spR);

	//}

	//float scroolSpeedX = 0.4f;
	//float scroolSpeedY = 0.4f;
	//public Renderer render;

	//private void Update()
	//{
	//	float offsetX = Time.time * scroolSpeedX;
	//	float offsety = Time.time * scroolSpeedY;

	//	GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsety);
	//}
	/*public Transform player;
	float tempsScrol;
	public Renderer render;
	public float speed;
	private void Update()
	{
		tempsScrol += 0.1f;
		render.material.mainTextureOffset = new Vector2(tempsScrol, tempsScrol);	
		//avec le move du player
		//render.material.mainTextureOffset = new Vector2(player.position.x, player.position.z)* speed;
	}*/
	public float speed = 1f;
	Vector2 offset;
	private void Update()
	{
		offset = new Vector2(0, Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}

