package Geometries;

/**
 * Created by HC on 30/04/2017.
 */
public abstract class RadialGeometry extends Geometry {
    //**********attributes*************//
    protected double _radius;

    // ***************** Constructors ********************** //
    public RadialGeometry(){this._radius=0.0;}
    public RadialGeometry(double radius){this._radius=radius;}

    // ***************** Getters/Setters ********************** //
    public double getRadius(){return this._radius;}
    public void setRadius(double radius){this._radius=radius;}
}
