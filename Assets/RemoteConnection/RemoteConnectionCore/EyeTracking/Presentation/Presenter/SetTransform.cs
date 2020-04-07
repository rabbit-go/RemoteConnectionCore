using System;
using UnityEngine;

[Serializable]
public class SetTransform
{
    public enum XYZ
    {
        X,
        XInverse,
        Y,
        YInverse,
        Z,
        ZInverse
    }
    public XYZ X = XYZ.X;
    public XYZ Y = XYZ.Y;
    public XYZ Z = XYZ.Z;
    public Vector3 translateTransform(Vector3 vector)
    {
        var result = new Vector3();
        switch (X)
        {
            case XYZ.X:
                result.x = vector.x;
                break;
            case XYZ.XInverse:
                result.x = -vector.x;
                break;
            case XYZ.Y:
                result.x = vector.y;
                break;
            case XYZ.YInverse:
                result.x = -vector.y;
                break;
            case XYZ.Z:
                result.x = vector.z;
                break;
            case XYZ.ZInverse:
                result.x = -vector.z;
                break;
        }
        switch (Y)
        {
            case XYZ.X:
                result.y = vector.x;
                break;
            case XYZ.XInverse:
                result.y = -vector.x;
                break;
            case XYZ.Y:
                result.y = vector.y;
                break;
            case XYZ.YInverse:
                result.y = -vector.y;
                break;
            case XYZ.Z:
                result.y = vector.z;
                break;
            case XYZ.ZInverse:
                result.y = -vector.z;
                break;
        }
        switch (Z)
        {
            case XYZ.X:
                result.z = vector.x;
                break;
            case XYZ.XInverse:
                result.z = -vector.x;
                break;
            case XYZ.Y:
                result.z = vector.y;
                break;
            case XYZ.YInverse:
                result.z = -vector.y;
                break;
            case XYZ.Z:
                result.z = vector.z;
                break;
            case XYZ.ZInverse:
                result.z = -vector.z;
                break;
        }
        return result;
    }
}