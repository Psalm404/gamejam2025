using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPieceCounter : MonoBehaviour

{
    // Start is called before the first frame update
    public static CharacterPieceCounter Instance;
    public int pieceCount = 0;
    public int totalCount = 15;
    void Start()
    {
        
    }

    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);  
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckSuccess();
    }

    public void CheckSuccess()
    {
        if (pieceCount == totalCount)
        {
            
            StartCoroutine(Pause());

        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(1.5f);
        MiniGameManager.GetInstance().FinishMinigame("CharacterJigsaw");
    }
}

