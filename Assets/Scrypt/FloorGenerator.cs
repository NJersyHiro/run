using UnityEngine;
using System.Collections;

public class FloorGenerator : MonoBehaviour {

	public GameObject floorPrefab;
	//スタート地点
	private int startPos = 0;
	//ゴール地点
	private int goalPos = 120;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;

	// Use this for initialization
	void Start () {
		//一定の距離ごとにアイテムを生成
		for (int i = startPos; i < goalPos; i+=5) {
			for (float j = -1; j <= 1; j += 1.0f) {
					GameObject floor = Instantiate (floorPrefab) as GameObject;
					floor.transform.position = new Vector3 (4 * j, floor.transform.position.y, i);
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}
}