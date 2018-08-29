﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    Animator animator;
    int levelToLoad;

    void Awake()
    {
        Debug.Log("Level Changer Started");
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            FadeToNextLevel();
        }
	}

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
