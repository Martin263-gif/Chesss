using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject chesspiece;

    private GameObject[,] positions = new GameObject[8, 8];
    private GameObject[] playerBlack = new GameObject[16];
    private GameObject[] playerWhite = new GameObject[16];

    private string currentPlayer = "white";

    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerWhite = new GameObject[]
        {
            Create("white_rook", -2.32, -2.3), Create("white_knight", -1.65, -2.3), Create("white_bishop", -0.98, -2.3), Create("white_queen", -0.31, -2.3), Create("white_king", 0.36, -2.3), Create("white_bishop", 1.03, -2.3), Create("white_knight", 1.7, -2.3), Create("white_rook",2.37,-2.3), Create("white_pawn", -2.32, -1.65), Create("white_pawn", -1.65, -1.65), Create("white_pawn", -0.98, -1.65), Create("white_pawn", -0.31, -1.65), Create("white_pawn", 0.36, -1.65), Create("white_pawn", 1.03, -1.65), Create("white_pawn", 1.7, -1.65), Create("white_pawn",2.37,-1.65),
        }
    }

    // Update is called once per frame
    
}
