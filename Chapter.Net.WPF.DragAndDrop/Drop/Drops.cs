﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="Drops.cs" company="dwndland">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.DragAndDrop;

/// <summary>
///     Items allowed to drop within <see cref="DropItem" />.
/// </summary>
public enum Drops
{
    /// <summary>
    ///     The user can drop single files.
    /// </summary>
    File,

    /// <summary>
    ///     The user can drop multiple files.
    /// </summary>
    Files,

    /// <summary>
    ///     The user can drop single folders.
    /// </summary>
    Folder,

    /// <summary>
    ///     The user can drop multiple folders.
    /// </summary>
    Folders,

    /// <summary>
    ///     The user can drop multiple files and folders.
    /// </summary>
    FilesAndFolders,

    /// <summary>
    ///     The user can drop custom data.
    /// </summary>
    Custom
}