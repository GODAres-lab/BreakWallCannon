using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    public static GameMenager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public Transform wallOfBrick;
    public int fallenBrickAmount, fallenBrickNeeded;

    private void Start()
    {
        fallenBrickNeeded = wallOfBrick.childCount;
        BrickFall();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            RestartGame();
        }
    }

    public void BrickFall()
    {
        fallenBrickAmount++;
        if (fallenBrickAmount >= fallenBrickNeeded)
        {
            print("You Win");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
