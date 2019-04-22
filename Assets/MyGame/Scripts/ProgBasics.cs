using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{
    // Public variables
    public int test1;
    public float test2;
    public string test3;
    public bool test4;
    public char test5;

	// Use this for initialization
	void Start ()
    {
        // Variables Test
        test1 = 1;
        test2 = 2.75f;
        test3 = "test3";
        test4 = true;
        test5 = 'C';
        Debug.Log("test1 in Start (int)" + test1);
        Debug.Log("test2 in Start (float)" + test2);
        Debug.Log("test3 in Start (string)" + test3);
        Debug.Log("test4 in Start (bool)" + test4);
        Debug.Log("test5 in Start (character)" + test5);

        // change data type using cast
        test1 = (int) test2;
        Debug.Log("new value for int: " + test1);

        // change data type using ToString Methode
        test3 = test5.ToString();
        Debug.Log("new value for string: " + test3);

        Operators();
        Bsp1();
        Bsp2();
        Bsp3();
        changeTest1();
        floatAdd();


        // Add values for parameters
        AddNumbers(4, 9);
        MultNumbers(2, 2, 2, 2);
        SubtractNumbers(2, 1);
        Infos("Kathrin", 18, 1.75f);

        // Return type
        Debug.Log(MyText("kkoenig"));
        string drama = MyText("kkoenig");
        Debug.Log("neu" + drama);
        Debug.Log(Menu("Salad", "Steak", "Cake"));
    }

    // Methode Operatoren
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

    // Verschachtelte Methode
    public void Bsp3()
    {
        XY();
    }

    public void XY()
    {
        Debug.Log("XY wird ausgeführt");
    }

    public void floatAdd()
    {
        float zwei;
        float drei;
        zwei = 2.222f;
        drei = 3.333f;

        Debug.Log("Addiere float: " + (zwei + drei));
    }

    // Parameters Methodes
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

    public void SubtractNumbers(int a, int b)
    {
        int c = a - b;
        Debug.Log("subtract numbers: " + c);
    }

    public void Infos(string name, int age, float height)
    {
        Debug.Log("Name: " + name + " " + "Alter: " +age + " " + "Größe: " + height);
    }

    // Change values
    public void changeTest1()
    {
        test1 = 2;
        Debug.Log("Changed test1= " + test1);
    }

    // Return String Methodes
    public string MyText(string myName)
    {
        return "Drama " + " " + myName;
    }

    public string Menu(string supper, string main, string dessert)
    {
        return "Supper: " + supper + " " + "Main: " + main + " " + "Dessert: " + dessert;
    }

    // Combine Methode
    public void Combine()
    {
        Operators();
        MultNumbers(4, 2, 1, 3);
        AddNumbers(100, 1000);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
