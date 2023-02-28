using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityCreator: MonoBehaviour
{
    public abstract GameObject CreateEntity(string name);
}
