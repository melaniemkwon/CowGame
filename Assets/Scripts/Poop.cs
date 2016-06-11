using UnityEngine;
using System.Collections;

public class Poop : MonoBehaviour {

	public Rigidbody2D poo;		//prefab of the poop
	public float speed = 1f;	//speed of the poop

	private CowControl cowCtrl;
	private Animator anim;

	void Awake() {
		anim = transform.root.gameObject.GetComponent<Animator>();
		cowCtrl = transform.root.GetComponent<CowControl>();
	}

	void Update() {
		//if fire button is pressed
		if(Input.GetButtonDown("Fire1")){
			if(cowCtrl.facingRight) {
				Rigidbody2D poopInstance = Instantiate(poo, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				poopInstance.velocity = new Vector2(speed, 0);
			}
			else {
				Rigidbody2D poopInstance = Instantiate(poo, transform.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				poopInstance.velocity = new Vector2(-speed, 0);
			}
		}

	}
}
