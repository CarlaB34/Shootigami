using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSetsAuttre : MonoBehaviour
{
	public Transform player;
	float tempsScrol;
	public Renderer render;
	public float speed;
	private void Update()
	{
		//tempsScrol += 0.1f;
		//render.material.mainTextureOffset = new Vector2(tempsScrol, tempsScrol);
		//avec le move du player})
		render.material.mainTextureOffset = new Vector2(player.position.x, player.position.z)* speed;
	}
}
