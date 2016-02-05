using UnityEngine;
using System.Collections;

public class usercontrol : MonoBehaviour {

	//the control box canvas
	public GameObject usercanvas;
	//the user cursor
	public GameObject usercursor;
	//
	private Vector3 cursorloc;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonUp(1))
		{
		//	cursorloc = usercursor.transform.position;
		//	usercanvas.transform.position = new Vector3(cursorloc.x,cursorloc.y,cursorloc.z+.5f);
		//	usercanvas.transform.rotation = usercursor.transform.rotation;
		//	usercanvas.transform.LookAt(new Vector3(cursorloc.x,cursorloc.y,cursorloc.z));
			if(usercanvas.activeSelf)
			{
				usercanvas.SetActive(false);
			}else
			{
				usercanvas.SetActive(true);
			}

		}
	}
}
