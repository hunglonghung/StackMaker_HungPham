using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using static GameManager;
public class WinManager : MonoBehaviour
{
    [SerializeField] private GameObject winCanva;
    [SerializeField] private List<GameObject> levels;
    private bool isMuted = false; 
    void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerOnOnGameStateChanged;
    }

    private void GameManagerOnOnGameStateChanged(GameState state)
    {
        winCanva.SetActive(state == GameState.Win);
    }
    void Start()
    {

    }
    void Update()
    {

    }
    
    public void StartGame()
    {
        GameManager.Instance.UpdateGameState(GameState.Level);
    }
    public void BackToMainMenu()
    {
        GameManager.Instance.UpdateGameState(GameState.MainMenu);
    }
    
    
}