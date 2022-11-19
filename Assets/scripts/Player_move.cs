using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.Tilemaps;
// using static System.Math;
using System;

public class Player_move : MonoBehaviour
{
	// direction = 1 to up, -1 to down
	private int direction = 0;
	public Tilemap obstacles;
	private Vector3 moveToPosition;
	private Vector3Int obstacleMapTile;

	private uint cameraPosition = 4;
	private uint personPosition;

	public Transform cameraTransform;
	
	void Update()
    {
		personMove();
		cameraMove();
    }


	void cameraMove()
	{
		if (transform.position.y > cameraPosition)
		{
			cameraTransform.position = cameraTransform.position + new Vector3(0, 1, 0);
			
			cameraPosition++;
		}
	}

	void personMove()
	{
		if (Input.GetKeyDown(KeyCode.W))
		{
			direction = 1;
			moveToPosition = new Vector3(transform.position.x, transform.position.y + 1f, 0);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			direction = -1;
			moveToPosition = new Vector3(transform.position.x, transform.position.y - 1f, 0);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			direction = 1;
			moveToPosition = new Vector3(transform.position.x - 1f, transform.position.y, 0);
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			direction = 1;
			moveToPosition = new Vector3(transform.position.x + 1f, transform.position.y, 0);
		}
		obstacleMapTile = obstacles.WorldToCell(moveToPosition);

		if (obstacles.GetTile(obstacleMapTile) == null && direction == 1 || (transform.position.y >= cameraTransform.position.y - 3.5f && direction == -1))
		{
			transform.position = moveToPosition;
		}
	}
}
