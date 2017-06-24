using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PgBar : MonoBehaviour {

	public Transform Loadingbar;
	public Transform TextIndicator;
	public Transform TextLoading;
	[SerializeField] private float currentAmount;
    [SerializeField] private float currentAmount2;
	[SerializeField] private float speed;
	[SerializeField] private int counter ;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	if (currentAmount < counter) {
			currentAmount = currentAmount + speed * Time.deltaTime;
            currentAmount2 = currentAmount2 - speed * Time.deltaTime;
			if ((int)currentAmount2 == 3 || (int)currentAmount2 == 2 || (int)currentAmount2 == 1) {
				
				GetComponent<Animation> ().Play ();
			}
			TextIndicator.GetComponent<Text> ().text = ((int)currentAmount2).ToString ();
			TextLoading.gameObject.SetActive (true);
		} else {
			//TextLoading.gameObject.SetActive(false);
		//	TextIndicator.GetComponent<Text> ().text = "Done";
			currentAmount =0;
            currentAmount2 = 11;
		}
		Loadingbar.GetComponent<Image> ().fillAmount  = currentAmount*10 /(counter*10);
	}
}
