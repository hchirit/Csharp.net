package Geometries;

import Primitives.Point3D;
import Primitives.Ray;
import Primitives.Vector;


import java.util.List;
import java.util.ArrayList;
/**
 * Created by HC on 30/04/2017.
 */
public class Plane extends Geometry implements FlatGeometry {
    //******************Attributes************************//
    private Vector _normal;
    private Point3D _Q;

    // ***************** Constructors ********************** //
    public Plane(){
        this._normal=new Vector();
        this._Q=new Point3D();
    }
    public Plane (Plane plane){
        this._normal=plane.getNormal(null);
        this._Q=plane.getQ();

    }
    public Plane (Vector normal, Point3D q){
        this._normal=new Vector(normal);
        this._normal.normalize();
        this._Q=new Point3D(q);
    }
    // ***************** Getters/Setters ********************** //
    public Vector getNormal(Point3D point){return new Vector(this._normal);}
    public Point3D getQ(){return new Point3D(this._Q);}
    public void setNormal(Vector normal){this._normal=new Vector(normal);}
    public void setQ(Point3D d){this._Q=new Point3D(d);}

    // ***************** Operations ******************** //
    /*
    * P= intersection point with the plane
    * P0=POO of the ray
    * N = normal of the plane
    * V= direction ray
    * Q0= point on the plane
    * P0Q0= new vector
    * */
    public List<Point3D> FindIntersections(Ray ray){
        List<Point3D> intersectionPoint= new ArrayList<Point3D>(1) ;

        Point3D Q0=getQ();
        Point3D P0= ray.getPOO();
        Vector V=ray.getDirection();
        Vector N=getNormal(null);
        Vector P0Q0=new Vector(Q0,P0);

        double t=-N.dotProduct(P0Q0)/(N.dotProduct(V));

        if (t>=0){
            V.scale(t);
            P0.add(V);
            intersectionPoint.add(P0);
        }
        return intersectionPoint;
    }
}
