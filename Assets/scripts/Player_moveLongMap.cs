using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.Tilemaps;
// using static System.Math;
using System;

public class Player_moveLongMap : MonoBehaviour
{
	// direction = 1 to up, -1 to down
	private int direction = 0;
	public Tilemap obstacles;
	private Vector3 moveToPosition;
	private Vector3Int obstacleMapTile;

	private uint personPosition;
	
	void Update()
    {
		personMove();
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

		if (obstacles.GetTile(obstacleMapTile) == null)
		{
			transform.position = moveToPosition;
		}
	}
}
