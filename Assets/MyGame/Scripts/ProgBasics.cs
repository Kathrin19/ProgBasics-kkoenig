using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {

        

        Debug.Log("erste Tests mit Operatoren");

        Debug.Log("Multiplikative Operatoren: *"+(2 * 8));
        Debug.Log("Multiplikative Operatoren: /"+(12/2));
        Debug.Log("Multiplikative Operatoren: %"+(7%2));

        Debug.Log("Additive Operatoren: +"+(3+6));
        Debug.Log("Additive Operatoren: -" + (12-11));

        Debug.Log("Relationale Operatoren: <" + (3 < 6));
        Debug.Log("Relationale Operatoren: >" + (3 > 6));
        Debug.Log("Relationale Operatoren: <=" + (3 <= 3));
        Debug.Log("Relationale Operatoren: >=" + (3 >= 6));

        Debug.Log("Gleichheits Operatoren: =" + ( "Blau" == "blau"));
        Debug.Log("Gleichheits Operatoren: !=" + ("Blau" == "blau"));




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
