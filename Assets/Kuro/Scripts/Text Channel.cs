﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChannel {
    private static Color defaultTextColor = new Color(148f / 255, 155f / 255, 164f / 255);
    private TextMesh textMesh;
    private GameObject highlight;

    private bool active;
    public bool Active { get { return active; } }

    public TextChannel(TextMesh textMesh, GameObject highlight)
    {
        this.textMesh = textMesh;
        this.highlight = highlight;
    }   

    /// <summary>
    /// Sets the color of the text to white and turns on the highlight
    /// </summary>
    public void Activate()
    {
        highlight.SetActive(true);
        active = true;
    }

    /// <summary>
    /// Sets the color of the text to gray and turns off the highlight
    /// </summary>
    public void Deactivate()
    {
        highlight.SetActive(false);
        active = false;
    }

}
