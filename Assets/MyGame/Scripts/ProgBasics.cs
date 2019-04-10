using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

    public int test1;
    public float test2;
    public string test3;

	// Use this for initialization
	void Start () {
        test1 = 1;
        Debug.Log("test1 in Start" + test1);
        Operators();
        Bsp1();
        Bsp2();
        AddNumbers(1,2);
        AddNumbers(4, 9);
        MultNumbers(2, 2, 2, 2);
        Debug.Log(MyText("kkoenig"));
        string drama = MyText("kkoenig");
        Debug.Log("neu" + drama);
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

    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers: " + c);
        test1 = 3;
        Debug.Log("test 1 in AddNumbers " + test1);
    }

    public void MultNumbers(int a, int b, int c, int d)
    {
        int e = a * b * c * d;
        Debug.Log("multiply numbers: " + e);
    }

    public void Combine()
    {
        MultNumbers(4, 2, 1, 3);
        Operators();
        AddNumbers(100, 1000);
    }

    public string MyText(string myName)
    {
        return "Drama " + " " + myName;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
