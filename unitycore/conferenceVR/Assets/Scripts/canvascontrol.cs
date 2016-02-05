using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class canvascontrol : MonoBehaviour {

	public GameObject controlboxobj;
	public Button controlboxbutton;
	public GameObject filesharebuttonobj;
	public Button filesharebutton;

	void Awake()
	{
		controlboxobj = transform.GetChild(0).transform.gameObject;
		controlboxbutton = controlboxobj.GetComponent<Button>();
		controlboxbutton.onClick.AddListener(delegate {enablebutton();});
		filesharebuttonobj = transform.GetChild(1).transform.gameObject;
		filesharebutton = transform.GetChild(1).transform.GetComponent<Button>();
					
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void enablebutton()

	{
		filesharebuttonobj.SetActive(true);

		print("I am working");
	}
}
