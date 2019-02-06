package Geometries ;

import Primitives.Point3D;
import Primitives.Ray;
import Primitives.Vector;

import java.util.Map;
import java.util.List;
import java.util.ArrayList;
/**
 * Created by HC on 30/04/2017.
 */
public class Sphere extends RadialGeometry {
    //******************Attributes************************//
    private Point3D _center;
    // ***************** Constructors ********************** //
    public Sphere(){
        super(0.0);
        this._center=new Point3D();

    }
    public Sphere (Sphere sphere){
        super(sphere._radius);
        this._center=sphere.getCenter();

    }
    public Sphere(double radius, Point3D center){
        super(radius);
        this._center = new Point3D(center);

    }
    public Sphere(Map<String, String> attributes){

        String[] centerPoints = attributes
                .get("center" ).split("\\s+");

        _center = new Point3D(Double.valueOf(centerPoints[0]),
                Double.valueOf(centerPoints[1]),
                Double.valueOf(centerPoints[2]));

        _radius = Double.valueOf(attributes.get("radius"));
    }


    // ***************** Getters/Setters ********************** //
    public Point3D getCenter(){return new Point3D(_center);}
    public void setCenter(Point3D center){this._center=new Point3D(center);}

    // ***************** Operations ******************** //
    /*
    *  INTERSECTION BETWEEN RAY AND SPHERE
    * P0=POO of the ray
    * O=sphere center
    * L=vector between P0 and O
    * V=ray direction
    * tm=distance between P0 and the middle between P1 and P2
    * th=distance between P1 and the middle between P1 and P2 (((r^2)-(d^2)^)0.5)
    * t1=distance between P0 and P1
    * t2=distance between P0 and P2
    * P1,P2=intersections point with the sphere
    * d=distance between O and the middle between P1 and P2
    * r= radius
    *
    * */
    public List<Point3D> FindIntersections(Ray ray) {
        List<Point3D> intersectionPoints = new ArrayList<Point3D>();
        Vector L = new Vector(ray.getPOO(), this._center);
        double tm = L.dotProduct(ray.getDirection());
        double d = Math.sqrt(Math.pow(L.length(), 2) - Math.pow(tm, 2));
        if (d > this._radius) {
            return intersectionPoints;
        }
        double th = Math.sqrt(Math.pow(this._radius, 2) - Math.pow(d, 2));
        double t1 = tm - th;
        double t2 = tm + th;
        if (t1 >= 0) {
            Vector V = ray.getDirection();
            V.scale(t1);
            Point3D P1 = new Point3D(ray.getPOO());
            P1.add(V);
            Point3D P = new Point3D(P1);
            intersectionPoints.add(P);
        }
        if (t2 >= 0) {
            Vector V = ray.getDirection();
            V.scale(t2);
            Point3D P2 = new Point3D(ray.getPOO());
            P2.add(V);
            Point3D P = new Point3D(P2);
            intersectionPoints.add(P);
        }
        return intersectionPoints;
    }
    public Vector getNormal(Point3D point){
        Vector N=new Vector(this._center,point);
        N.normalize();
        return N;
    }
}
