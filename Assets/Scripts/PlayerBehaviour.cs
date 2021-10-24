using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;



public class PlayerBehaviour : MonoBehaviour
{
    public Tile testTile;
    public Tilemap playerTilemap;
    public GameObject turretPrefab;

    private Vector3Int tilemapPos;
    private Vector3 worldPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tilemapPos = playerTilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        

        if(Input.touchCount > 0)
        {
            
            
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                tilemapPos = playerTilemap.WorldToCell(Camera.main.ScreenToWorldPoint(touch.position));
                tilemapPos.z = 0;
                worldPos = playerTilemap.CellToWorld(tilemapPos);
                worldPos.z = playerTilemap.transform.position.z;

                //Check for player cash
                if (GameObject.FindObjectOfType<playerManager>().getCash() > 100f)
                {


                    //Prevent player from building in terrain
                    if (playerTilemap.HasTile(tilemapPos) != true)
                    {
                        Instantiate<GameObject>(turretPrefab, worldPos, new Quaternion(), transform);
                        playerTilemap.SetTile(tilemapPos, testTile);
                        GameObject.FindObjectOfType<playerManager>().builtTower();
                    }
                }
                
            }
        }
    }

    
}
