package Geometries;

import Primitives.Point3D;
import Primitives.Ray;
import Primitives.Vector;

import java.util.Map;
import java.util.List;
import java.util.ArrayList;
/**
 * Created by HC on 21/06/2017.
 */
public class Quadrangle extends Geometry implements FlatGeometry  {

    Triangle _tri1;
    Triangle _tri2;



    /***********Constructor****************/
    public Quadrangle (Point3D P1, Point3D P2, Point3D P3, Point3D P4)
    {
        _tri1 = new Triangle(P1, P2, P4);
        _tri2 = new Triangle(P2, P3, P4);
    }

    /************Operation******************/
    @Override
    public List<Point3D> FindIntersections(Ray ray) {
        List<Point3D> intersectionPoint = new ArrayList<Point3D>();
        for( Point3D inter1 :_tri1.FindIntersections(ray))
            intersectionPoint.add(inter1);
        for (Point3D inter2 : _tri2.FindIntersections(ray))
            intersectionPoint.add(inter2);
        return intersectionPoint;
    }

    @Override
    public Vector getNormal(Point3D point) {
        return _tri1.getNormal(point);
    }

}
