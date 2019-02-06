package Geometries;

import Primitives.Point3D;
import Primitives.Ray;
import Primitives.Vector;

import java.util.Map;
import java.util.List;
import java.util.ArrayList;
/**
 * Created by HC on 30/04/2017.
 */
public class Triangle extends Geometry implements FlatGeometry {
    //******************Attributes**************************//
    private Point3D _p1;
    private Point3D _p2;
    private Point3D _p3;

    // ***************** Constructors ********************** //
    public Triangle(){
        this._p1=new Point3D();
        this._p2=new Point3D();
        this._p3=new Point3D();
    }
    public Triangle(Triangle triangle){
        this._p1=triangle.getP1();
        this._p2=triangle.getP2();
        this._p3=triangle.getP3();
    }
    public Triangle(Point3D p1, Point3D p2, Point3D p3){
        this._p1=new Point3D(p1);
        this._p2=new Point3D(p2);
        this._p3=new Point3D(p3);
    }

    // ***************** Getters/Setters ********************** //
    public Point3D getP1(){return new Point3D(_p1);}
    public Point3D getP2(){return new Point3D(_p2);}
    public Point3D getP3(){return new Point3D(_p3);}
    public void setP1(Point3D p1){this._p1=new Point3D(p1);}
    public void setP2(Point3D p2){this._p1=new Point3D(p2);}
    public void setP3(Point3D p3){this._p1=new Point3D(p3);}

    // ***************** Operations ******************** //
    public Vector getNormal(Point3D point){
        Vector V1=new Vector(_p1,_p2);
        Vector V2=new Vector(_p1,_p3);
        Vector N= new Vector(V1.crossProduct(V2));

        N.normalize();
        N.scale(-1);
        return N;
    }
    /*
    * P0= POO of the ray
    * V1,V2= vector from P0 to the two point of the bases of the triangle
    * N1= normal from the plan that create by V1,V2 and the bases of the triangle
    * P = intersection points with the triangle
    * P_P0=vector (P,P0)
    *
    * **/
    public List<Point3D> FindIntersections(Ray ray){
        List<Point3D>intersectionPoint= new ArrayList<Point3D>(1);

        Vector N=getNormal(null);
        Plane plane= new Plane(N,_p3);
        if(plane.FindIntersections(ray).isEmpty())
            return intersectionPoint;
        Point3D P0= ray.getPOO();
        Point3D P= plane.FindIntersections(ray).get(0);//pas claire
        //check if intersection is in the triangle or no
        Vector P_P0=new Vector(P0,P);

        /*//the three vector from P0 to the three point of the triangle
        Vector V1=new Vector(P0,_p1);
        Vector V2=new Vector(P0,_p2);
        Vector V3=new Vector(P0,_p3);

        //now we'll check the three side of the triangle
        //first side
        Vector N1=V1.crossProduct(V2);
        N1.normalize();
        double S1=-P_P0.dotProduct(N1);

        //second side
        Vector N2=V2.crossProduct(V3);
        N1.normalize();
        double S2=-P_P0.dotProduct(N2);

        //third side
        Vector N3=V1.crossProduct(V3);
        N3.normalize();
        double S3=-P_P0.dotProduct(N3);

        if ((S1>0&&S2>0&&S3>0)||(S1<0&&S2<0&&S3<0))
            intersectionPoint.add(P);

        return intersectionPoint;*/
        // Checking 1/3 triangular side
        Vector V1_1 = new Vector(P0, this._p1);
        Vector V2_1 = new Vector(P0, this._p2);
        Vector N1 = V1_1.crossProduct(V2_1);
        N1.normalize();
        double S1 = -P_P0.dotProduct(N1);

        // Checking 2/3 triangular side
        Vector V1_2 = new Vector(P0, this._p2);
        Vector V2_2 = new Vector(P0, this._p3);
        Vector N2 = V1_2.crossProduct(V2_2);
        N2.normalize();
        double S2 = -P_P0.dotProduct(N2);

        // Checking 1/3 triangular side
        Vector V1_3 = new Vector(P0, this._p3);
        Vector V2_3 = new Vector(P0, this._p1);
        Vector N3 = V1_3.crossProduct(V2_3);
        N3.normalize();
        double S3 = -P_P0.dotProduct(N3);

        if (((S1 > 0) && (S2 > 0) && (S3 > 0)) ||
                ((S1 < 0) && (S2 < 0) && (S3 < 0))){
            intersectionPoint.add(P);
        }

        return intersectionPoint;
    }
}
