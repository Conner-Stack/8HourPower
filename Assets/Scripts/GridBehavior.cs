using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GridBehavior : MonoBehaviour {
    [SerializeField]

    public GameObject[,] grid = new GameObject[10, 10];
    public List<GameObject> cells;
    public GameObject cellPrefab;
    void Start()
    {
        cells = new List<GameObject>();
        CreateGrid();
    }
    public void CreateGrid()
    {        
        for (int x = 0; x < 10; x++)
        {
            for (int z = 0; z < 10; z++)
            {
                var pos = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);
                var go = Instantiate(cellPrefab, pos, Quaternion.identity);
                cells.Add(go);


                //GameObject gridPlane = new GameObject(); 
                //gridPlane.transform.position = new Vector3(gridPlane.transform.position.x + x,
                //                                            gridPlane.transform.position.y,
                //                                            gridPlane.transform.position.z + z);

                //grid[x, z] = gridPlane;

            }
        }
    }

}
