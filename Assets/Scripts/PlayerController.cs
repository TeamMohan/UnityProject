using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
	public float moveSpeed;
	public float runSpeed;
	public float rotationSpeed;
	public float jumpSpeed;
	CharacterController cc;

	void Start()
	{
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{
		Vector3 forward;
		Vector3 jump;
		Vector3 strafe;

		if(Input.GetKey(KeyCode.LeftShift))
		{
			forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * runSpeed;
			strafe = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * runSpeed;
		}
		else
		{
			forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * moveSpeed;
			strafe = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * moveSpeed;
		}

		jump = Input.GetAxis("Jump")*transform.TransformDirection(Vector3.up)* jumpSpeed;
		transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X")* rotationSpeed *Time.deltaTime,0));

		cc.Move(forward * Time.deltaTime);
		cc.Move(jump * Time.deltaTime);
		cc.Move(strafe * Time.deltaTime);
		cc.SimpleMove(Physics.gravity);

	}
}