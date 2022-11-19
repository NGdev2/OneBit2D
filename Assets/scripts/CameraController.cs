using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
	private Vector3 target;
	private Vector3 offset;
	public float trackingSpeed = 2.5f;

	void Update()
	{
		Vector3 currentPosition = Vector3.Lerp(transform.position, target, trackingSpeed * Time.deltaTime);
		transform.position = currentPosition;
		offset = new Vector3(0f, 0f, -10f);
		target = new Vector3(playerTransform.transform.position.x, playerTransform.transform.position.y, playerTransform.transform.position.z + offset.z);
	}
}
