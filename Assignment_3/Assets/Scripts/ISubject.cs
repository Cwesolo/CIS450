/*
 * Chandler Wesoloski
 * ISubject.cs
 * Assignment 3
 * All of the methods for subjects
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void UnregisterObserver(IObserver observer);
    void NotifyObservers();
}
