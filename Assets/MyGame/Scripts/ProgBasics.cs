using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Operators();
        Bsp1();
        Bsp2();
    }

    public void Operators()
    {
        Debug.Log("erste Tests mit Operatoren");

        // Multiplikative Operatoren
        Debug.Log("Multiplikative Operatoren: * " + (2 * 8));
        Debug.Log("Multiplikative Operatoren: / " + (12 / 2));
        Debug.Log("Multiplikative Operatoren: % " + (7 % 2));

        // Additive Operatoren
        Debug.Log("Additive Operatoren: + " + (3 + 6));
        Debug.Log("Additive Operatoren: - " + (12 - 11));

        // Relationale Operatoren
        Debug.Log("Relationale Operatoren: < " + (3 < 6));
        Debug.Log("Relationale Operatoren: > " + (3 > 6));
        Debug.Log("Relationale Operatoren: <= " + (3 <= 3));
        Debug.Log("Relationale Operatoren: >= " + (3 >= 6));

        // Gleichheits Operatoren
        Debug.Log("Gleichheits Operatoren: = " + ("Blau" == "blau"));
        Debug.Log("Gleichheits Operatoren: != " + ("Blau" != "blau"));

        // Logische Operatoren
        Debug.Log("Logische Operatoren: & " + (true && false));
        Debug.Log("Logische Operatoren: | " + (true || false));
    }

    public void Bsp1()
    {
        Debug.Log(4 + 6);
    }

    public void Bsp2()
    {
        Debug.Log("true" == "false");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
