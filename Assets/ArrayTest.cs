using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
//配列の各要素の値を順番に表示してください
//for文を使い、配列の各要素の値を逆順に表示してください

public class ArrayTest : MonoBehaviour {

	void Start () {
		// 配列を初期化する
		int[] array = {1, 2, 3, 4, 5};

		for (int i= 0; i<5; i++){
			
			Debug.Log(array [i]);

		}

		for (int i= 5-1; i>=0; i--){

			Debug.Log(array [i]);

		}
	}

	// Update is called once per frame
	void Update () {

	}
}