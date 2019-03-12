using UnityEngine;
using System.Collections;
using System.IO.Ports;
public class Arduino : MonoBehaviour
{
	public static SerialPort sp = new SerialPort ("COM6",9600,Parity.None,8,StopBits.One);
    // Start is called before the first frame update
    void Start()
    {
		OpenConnection ();   
    }

    // Update is called once per frame
    void Update()
    {
		if (sp.IsOpen)
		{
			Debug.Log ("Yes, Already is Open");
			try
			{
				float f=float.Parse(sp.ReadLine());
				if (f == 1)
				{
					Debug.Log("Yes, I can read to value");
					transform.Translate (Vector3.forward * Time.deltaTime*5);
				}

			}catch
			{
				
			}
		}
    }

	void OpenConnection()
	{
		if (sp != null)
		{
			if (sp.IsOpen) {
				sp.Close ();
				Debug.Log ("Port Closed, because it was already open");
			} else
			{
				sp.Open ();
				sp.ReadTimeout = 20;
				Debug.Log ("Port Opened");
			}
		}
		else
		{
			if(sp.IsOpen)
			{
				Debug.Log("Port is already open");
			}
			else
			{
				Debug.Log("Port is null");
			}
		}
	}
		

}
