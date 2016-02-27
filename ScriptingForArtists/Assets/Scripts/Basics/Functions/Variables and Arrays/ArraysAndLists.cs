using UnityEngine;//needed to my visible in the editor as a component;
using System.Collections;//needed to use monobehavior
using System.Collections.Generic;//needed for lists

public class ArraysAndLists : MonoBehaviour //needed to use Start();
{
	//visible in the editor;
	public int[] myNums;
	public List<int> myListNums;

	//to make the list dynamic in Unity
	void Start () {
		myListNums = new List<int> ();//use "new" infrequently
		//newing up the list, makes in changable
		//to a script, by creating an instance;
		myListNums.Add (9); //this adds to the list;
	}
}
