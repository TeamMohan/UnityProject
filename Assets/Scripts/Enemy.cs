using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform target;
	public Transform spawnOnePoint;
	public Transform spawnTwoPoint;
	public Transform spawnThreePoint;

	public int moveSpeed;
	public int rotationSpeed;
	public int maxDistance;
	public GameObject spawnPointOne;
	public GameObject spawnPointTwo;
	public GameObject spawnPointThree;

	int randomSelection;


	private Transform myTransform;

	void Awake(){
		myTransform = transform;
		}
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		GameObject sp1 = GameObject.FindGameObjectWithTag ("spawnOne");
		GameObject sp2 = GameObject.FindGameObjectWithTag ("spawnTwo");
		GameObject sp3 = GameObject.FindGameObjectWithTag ("spawnThree");

		target = go.transform;

		spawnOnePoint = sp1.transform;
		spawnTwoPoint = sp2.transform;
		spawnThreePoint = sp3.transform;

		maxDistance = 2;

		randomSelection = Random.Range (0, 3);


	
	}
	// Update is called once per frame
	void Update () {


		//look at player 
		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);

		if (Vector3.Distance (target.position, myTransform.position) > 5)
		{
			PathFinding();
		}

		if (Vector3.Distance (target.position, myTransform.position) > maxDistance) 
		{			
			//chasePlayer();
		}
	}
	void PathFinding()
	{
		if(randomSelection == 0)
		{
			myTransform.position = Vector3.MoveTowards (myTransform.position, spawnOnePoint.position, 5 * Time.deltaTime); 
		}
		if(randomSelection == 1)
		{
			myTransform.position = Vector3.MoveTowards (myTransform.position, spawnTwoPoint.position, 5 * Time.deltaTime);
		}
		if(randomSelection == 2)
		{
			myTransform.position = Vector3.MoveTowards (myTransform.position, spawnThreePoint.position, 5 * Time.deltaTime);
		}

	}
	void chasePlayer()
	{
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	}
	void NodeMovement()
	{

	}
}
