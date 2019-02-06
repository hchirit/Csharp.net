package Geometries;

import Primitives.Point3D;
import Primitives.Ray;
import Primitives.Vector;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by HC on 08-Jun-17.
 */
public class Rectangle extends Geometry implements FlatGeometry{

    Triangle _tri1;
    Triangle _tri2;

    public Rectangle(Point3D bottomLeft, Point3D topRight)
    {
        Point3D topLeft = new Point3D(bottomLeft.getX(), topRight.getY(), bottomLeft.getZ());
        Point3D bottomRight = new Point3D(topRight.getX(), bottomLeft.getY(), topRight.getZ()) ;
        _tri1 = new Triangle(bottomLeft, topLeft, bottomRight);
        _tri2 = new Triangle(topLeft, topRight, bottomRight);
    }




    // ***************** Operations ******************** //
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
