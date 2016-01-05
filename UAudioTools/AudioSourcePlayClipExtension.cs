﻿//
// Copyright (C) Microsoft. All rights reserved.
//

using UnityEngine;

namespace UAudioTools
{
    /// <summary>
    /// A shortcut to assign a clip to an AudioSource component and play the source
    /// </summary>
    public static class AudioSourcePlayClipExtension
    {
        public static void PlayClip(this AudioSource source, UnityEngine.AudioClip clip)
        {
            source.clip = clip;
            source.Play();
        }
    }
}