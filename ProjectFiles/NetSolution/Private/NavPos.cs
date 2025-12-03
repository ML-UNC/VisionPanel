using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "VisionTake3", Guid = "d832ea3f3b284274e2db1b2363436ce2")]
public class NavPos : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public string Name
    {
        get
        {
            return (string)Refs.GetVariable("Name").Value.Value;
        }
        set
        {
            Refs.GetVariable("Name").SetValue(value);
        }
    }
    public IUAVariable NameVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Name");
        }
    }
    public string Description
    {
        get
        {
            return (string)Refs.GetVariable("Description").Value.Value;
        }
        set
        {
            Refs.GetVariable("Description").SetValue(value);
        }
    }
    public IUAVariable DescriptionVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Description");
        }
    }
    public UAManagedCore.NodeId NodeId
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("NodeId").Value.Value;
        }
        set
        {
            Refs.GetVariable("NodeId").SetValue(value);
        }
    }
    public IUAVariable NodeIdVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("NodeId");
        }
    }
#endregion
}
