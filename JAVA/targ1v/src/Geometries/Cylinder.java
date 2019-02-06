package Geometries;

import Primitives.Ray;
import Primitives.Point3D;
import Primitives.Vector;
import java.util.List;

/**
 * Created by HC on 30/04/2017.
 */
public class Cylinder extends RadialGeometry {
    //***************attributes********************//
    Point3D _axisPoint;
    Vector _axisDirection;

    // ***************** Constructors ********************** //
    public Cylinder(){
        super(0);
        this._axisDirection=new Vector();
        this._axisPoint=new Point3D();
    }
    public Cylinder(Cylinder cylinder){
        super(cylinder.getRadius());
        this._axisDirection=cylinder.getAxisDirection();
        this._axisPoint=cylinder.getAxisPoint();
    }
    public Cylinder(double radius, Point3D axisPoint, Vector axisDirection){
        super(radius);
        this._axisPoint=new Point3D(axisPoint);
        this._axisDirection=new Vector(axisDirection);
    }

    // ***************** Getters/Setters ********************** //
    public Point3D getAxisPoint(){return new Point3D(_axisPoint);}
    public Vector getAxisDirection(){return new Vector(_axisDirection);}
    public void setAxisPoint(Point3D axisPoint){this._axisPoint=new Point3D(axisPoint);}
    public void setAxisDirection(Vector axisDirection){this._axisDirection=new Vector(axisDirection);}

    // ***************** Operations ******************** //
    public List<Point3D> FindIntersections(Ray ray) {
        // To be implemented
        return null;
    }

    public Vector getNormal(Point3D point) {
        // To be implemented
        return null;
    }
}
