﻿using System.Collections;
using UnityEngine;
using TMPro;
using Febucci.UI;

public class InfoManagement : MonoBehaviour
{
    [SerializeField] private GameObject infoObject;

    /// <summary>
    /// This method will gonna execute specific coroutine for info tip when get called
    /// </summary>
    /// <param name="info">The</param>
    /// <param name="wait"></param>
    public void Info(string info , float wait)
    {
        StartCoroutine(InfoCo(info, wait));
    }

    public IEnumerator InfoCo(string words, float waitTime)
    {
        while (true)
        {
            infoObject.SetActive(true);
            infoObject.transform.Find("InfoText").GetComponent<TextAnimatorPlayer>().ShowText(words);
            yield return new WaitForSeconds(waitTime);
            infoObject.SetActive(false);
            break;
        }
    }
}
